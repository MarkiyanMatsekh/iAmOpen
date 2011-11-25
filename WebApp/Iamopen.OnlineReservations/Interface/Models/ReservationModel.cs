using System;
using Iamopen.Common.ServiceModels;

namespace Iamopen.OnlineReservations.Interface.Models
{
    public class ReservationInfo
    {
        public int TableID;
        public DateTime ReservationTime;
        public int InstitutionID;
        public UserInfo UserInfo;
        public ReservationPublicityType PublicityType;
    }

    public enum ReservationPublicityType
    {
        Private = 0,
        Public = 1
    }

    public class UserInfo
    {
        public string FirstName;
        public string LastName;
        public string PhoneNumber;
        public int UserSID;
    }

    public class ReservationResult : OperationResult
    {
        public int ReservationID;
        public InstitutionOnlineReservationType InstitutionType;
    }

    // if Instant - user will receive confirmation almost immediatly
    public enum InstitutionOnlineReservationType
    {
        Instant = 0, // i.e. has access point in internet, where we can post information about reservation
        Delayed = 1 // i.e. doesn't have any listener, so it needs to ping our service to check for updates
    }

}
