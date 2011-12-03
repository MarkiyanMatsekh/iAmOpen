using System.Runtime.Serialization;

namespace Iamopen.Availability.AMS.Interface.Models
{
    [DataContract]
    public class ActualReservationResult
    {
        [DataMember]
        public int ReservationID;
        [DataMember]
        public ReservationResult Result;
    }

    [DataContract]
    public enum ReservationResult
    {
        [EnumMember]
        ClientHasCome = 0,
        [EnumMember]
        ClientWasLate = 1,
        [EnumMember]
        ClientDidntCome = 2,
        [EnumMember]
        ClientCanceledReservation = 3
    }
}