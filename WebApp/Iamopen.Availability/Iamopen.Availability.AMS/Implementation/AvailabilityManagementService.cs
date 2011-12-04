using System;
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

        public UpdateStatusResult UpdateStatus(UpdateStatusInfo tableStatusInfo)
        {
            throw new NotImplementedException();
        }
    }
}