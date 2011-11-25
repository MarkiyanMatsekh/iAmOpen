using System;
using Iamopen.Common.ServiceModels;

namespace Iamopen.OnlineReservations.Interface.Models
{
    public class CancelReservationInfo
    {
        public int ReservationID;
        public int UserID;
        public string CancellationNote;
    }

    public class CancelReservationResult : OperationResult
    { }



}
