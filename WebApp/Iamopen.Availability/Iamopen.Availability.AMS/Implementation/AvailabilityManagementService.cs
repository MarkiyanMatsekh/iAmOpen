using System;
using System.Configuration;
using System.Linq;
using Iamopen.Availability.AMS.Implementation.DB;
using Iamopen.Availability.AMS.Interface;
using Iamopen.Availability.AMS.Interface.Models;
using Iamopen.Availability.Common.DB;
using Iamopen.Common.Exceptions;
using Iamopen.Common.ServiceModels;

namespace Iamopen.Availability.AMS.Implementation
{
    public class AvailabilityManagementService : IAvailabilityManagementService
    {
        private readonly TimeSpan allowUpdatePeriod;

        // TODO MM: this field should be set before any calls to service, 
        // i.e. on connection establishment and instance creation phase.
        // Best way to implement this would be filters and custom Service Behaviors.
        // this information should be received from database, but later kept in cach, 
        // shared and synchronized between all instances of service
        public int ClientInstitutionID { get; set; }

        public AvailabilityManagementService()
        {
            var allowUpdatePeriodStr = ConfigurationManager.AppSettings["AllowUpdatePeriod"];
            if (String.IsNullOrEmpty(allowUpdatePeriodStr))
            {
                throw new IAmOpenException("AllowUpdatePeriod key wasn't present in appsettings");
            }
            if (!TimeSpan.TryParse(allowUpdatePeriodStr, out allowUpdatePeriod))
                throw new IAmOpenException("Couldn't parse allowUpdatePeriod from appsettings");

            ClientInstitutionID = 1;

        }

        public OperationResult ChangeTableStatus(ChangeTableStatusInfo info)
        {
            using (AvailabilityManagementContext ctx = new AvailabilityManagementContext())
            {
                OperationResult result;
                var tables = ctx.Tables.Where(table => table.TableID == info.TableID).ToList();
                //note MM: db is hit 2 times - might be a performance problem - possible solution is to turn off check for "no table exists"
                if (tables.Count == 0)
                    result = new OperationResult(ResultCode.Fail, "Table doesn't exist");
                else
                {
                    if (tables.Count > 1)
                        throw new DBIncompatibilityException("Table ID should be unique");
                    tables[0].StatusID = (int)info.TableStatus;
                    ctx.SaveChanges();
                    result = new OperationResult(ResultCode.OK);
                }
                return result;
            }
        }

        public OperationResult RespondToReservation(ReservationResponseInfo confirmReservationInfo)
        {
            throw new NotImplementedException();
        }

        public OperationResult ReportReservationResult(ActualReservationResult reservationResult)
        {
            throw new NotImplementedException();
        }

        public UpdateStatusResult UpdateStatus(UpdateStatusInfo info)
        {
            UpdateStatusResult result;
            if (DateTime.Now - info.LastUpdateTime < allowUpdatePeriod)
            {
                result = new UpdateStatusResult(ResultCode.NotChanged);
            }

            using (var ctx = new AvailabilityManagementContext())
            {

                var currentReservationsQuery =
                    from res in ctx.Reservations
                    // note MM: res.Table.InstitutionID == extra JOIN. may be optimized by db denormalization
                    where (res.CreationTime > info.LastUpdateTime) && (res.Table.InstitutionID == this.ClientInstitutionID)
                    select new
                               {
                                   res.CancellationNote,
                                   res.StatusID,
                                   res.ReservationTime,
                                   res.TableID,
                                   res.CustomerID,  // TODO MM: make a solution of a problem how the cafe has to get more info about the user
                                   res.ID
                               };
                var currentReservations = currentReservationsQuery.ToList(); // make the query and process everything else in memory
                
                var dbStatusRequestSent = EntitiesMapping.MapReservationStatus(ReservationStatus.RequestSentByIAmOpenUser);
                var dbStatusCanceled = EntitiesMapping.MapReservationStatus(ReservationStatus.ReservationCanceledByUser);
                
                var newReservations = currentReservations
                    .Where(r => r.StatusID == dbStatusRequestSent.ID)
                    .Select(r => new ReservationInfo
                            {
                                ReservationID = r.ID, 
                                TableID = r.TableID, 
                                ReservationTime = r.ReservationTime,
                                UserInfo = new UserInfo {UserSID = r.CustomerID},
                            })
                    .ToList();
                var canceledReservations = currentReservations
                    .Where(r => r.StatusID == dbStatusCanceled.ID)
                    .Select(r => new ReservationCancellationInfo
                                     {
                                         ReservationID = r.ID,
                                         CancellationNote = r.CancellationNote
                                     })
                    .ToList();

                return new UpdateStatusResult(ResultCode.OK)
                           {
                               NewReservations = newReservations,
                               CanceledReservations = canceledReservations
                           };

            }

            



        }
    }
}