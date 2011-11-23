using System.ServiceModel;
using Iamopen.AvailabilitySyncService.Interface.Models;
using Iamopen.Common.ServiceModels;

namespace Iamopen.AvailabilitySyncService.Interface
{
    [ServiceContract]
    public interface IAvailabilitySyncService
    {
        [OperationContract]
        OperationResult ChangeTableStatus(ChangeTableStatusInfo tableStatusInfo);
        [OperationContract]
        OperationResult RespondToReservation(ReservationResponseInfo confirmReservationInfo);
        [OperationContract]
        OperationResult ReportReservationResult(ActualReservationResult reservationResult);
    }
}
