using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Iamopen.AMS.Interface;
using Iamopen.AMS.Interface.Models;
using Iamopen.Common.ServiceModels;

namespace Iamopen.AMS.Implementation
{
    public class AvailabilityManagementService : IAvailabilityManagementService 
    {
        public OperationResult ChangeTableStatus(ChangeTableStatusInfo tableStatusInfo)
        {
            throw new NotImplementedException();
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