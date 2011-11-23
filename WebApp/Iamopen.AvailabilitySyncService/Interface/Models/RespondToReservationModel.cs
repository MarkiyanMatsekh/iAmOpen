using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Iamopen.AvailabilitySyncService.Interface.Models
{
    [DataContract]
    public class ReservationResponseInfo
    {
        [DataMember]
        public int ReservationID;
        [DataMember]
        public ReservationResponse Response;
        [DataMember]
        public int? WaiterID;
    }

    [DataContract]
    public enum ReservationResponse
    {
        [EnumMember]
        Confirmed = 0,
        [EnumMember]
        Declined = 1
    }
}