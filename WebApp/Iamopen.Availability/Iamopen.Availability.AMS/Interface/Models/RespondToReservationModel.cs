using System.Runtime.Serialization;

namespace Iamopen.Availability.AMS.Interface.Models
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