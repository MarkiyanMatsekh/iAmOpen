using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using Iamopen.Common.DB.StoredProcedures.SpResult;
using Iamopen.Common.ServiceModels;
using Iamopen.OnlineReservations.Implementation.DB;
using Iamopen.OnlineReservations.Interface;
using Iamopen.OnlineReservations.Interface.Models;

namespace Iamopen.OnlineReservations.Implementation
{
    public class OnlineReservationManager : IReservationManager, IDisposable
    {
        // todo MM: maybe abstract this entity a bit
        private readonly OnlineReservationsContext context;

        public OnlineReservationManager()
        {
            context = new OnlineReservationsContext();
        }


        public ReservationResult ReserveTable(ReservationInfo reservationInfo)
        {
            var spResult = context.ReserveTable(
                reservationInfo.TableID,
                reservationInfo.UserInfo.UserSID,
                reservationInfo.ReservationTime);
            if (spResult.ResultCode == SpResultCode.OK)
            {
                var result = spResult.Record;
                // todo: process this info
            }
            return null;
        }

        public CancelReservationResult CancelReservation(CancelReservationInfo cancelReservationInfo)
        {
            throw new NotImplementedException();
        }

        public InstitutionsQueryResult QueryInstitutions(InstitutionsQueryInfo institutionsQueryInfo)
        {
            throw new NotImplementedException();
        }

        public InstitutionOnlineStatusRequestResult GetInstitutionOnlineStatus(InstitutionOnlineStatusRequestInfo info)
        {
            var ts = new Iamopen.OnlineReservations.Implementation.DomainModels.TableStatus() { ID = 1 };




            List<HallInfo> halls;
            try
            {
                halls = (from h in context.Halls
                         where (h.InstitutionID == info.InstitutionID) && 
                               (!info.HallID.HasValue || h.ID == info.HallID.Value)
                         select new HallInfo
                         {
                             HallID = h.ID,
                             Name = h.Name,
                             Tables =
                                 from t in context.Tables
                                 where t.HallID == h.ID
                                 select new TableInfo
                                 {
                                     TableID = t.TableID,
                                     //TableStatus = EntitiesMapping.MapTableStatus(t.Status),
                                     TableStatus = (TableStatus)t.StatusID,
                                     //TableStatus = (TableStatus)t.Status,
                                     TableNo = t.No
                                 }
                         }).ToList();
            }
            finally
            {
                //todo MM: make up a good connection strategy
                context.Dispose();
            }
                
            
            return new InstitutionOnlineStatusRequestResult()
            {
                ExecutionResult = new ExecutionResult { ResultCode = ResultCode.OK },
                Halls = halls
            };
        }

        public InstitutionsStatisticsResult GetInstitutionsStatistics(InstitutionsStatisticsInfo institutionsStatisticsInfo)
        {
            throw new NotImplementedException();
        }

        public/*internal*/ void SaveChanges()
        {
            context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
        }


        public static void Init()
        {
            Database.SetInitializer(new OnlineReservationsInitializer());
        }
    }
}
