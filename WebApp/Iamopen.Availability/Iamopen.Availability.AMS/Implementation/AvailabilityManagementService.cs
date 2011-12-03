using System;
using Iamopen.Availability.AMS.Interface;
using Iamopen.Availability.AMS.Interface.Models;
using Iamopen.Common.ServiceModels;

namespace Iamopen.Availability.AMS.Implementation
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