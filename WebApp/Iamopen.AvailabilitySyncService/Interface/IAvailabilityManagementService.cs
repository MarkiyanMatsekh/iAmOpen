using System.ServiceModel;
using Iamopen.AMS.Interface.Models;
using Iamopen.Common.ServiceModels;

namespace Iamopen.AMS.Interface
{
    [ServiceContract]
    public interface IAvailabilityManagementService
    {
        [OperationContract]
        OperationResult ChangeTableStatus(ChangeTableStatusInfo tableStatusInfo);
        [OperationContract]
        OperationResult RespondToReservation(ReservationResponseInfo confirmReservationInfo);
        [OperationContract]
        OperationResult ReportReservationResult(ActualReservationResult reservationResult);
        [OperationContract]
        UpdateStatusResult UpdateStatus(UpdateStatusInfo tableStatusInfo);
    }
}
