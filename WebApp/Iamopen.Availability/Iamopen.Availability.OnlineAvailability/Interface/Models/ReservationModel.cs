using System;
using Iamopen.Common.ServiceModels;

namespace Iamopen.Availability.OnlineAvailability.Interface.Models
{
    public class ReservationInfo
    {
        public int TableID;
        public DateTime ReservationTime;
        //public int InstitutionID;  // this is accessed in db by TableID
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
        public InstitutionResponseType InstitutionResponseType;
    }

    // if Instant - user will receive confirmation almost immediatly
    public enum InstitutionResponseType
    {
        Instant = 0, // i.e. has access point in internet, where we can post information about reservation
        Delayed = 1 // i.e. doesn't have any listener, so it needs to ping our service to check for updates
    }

}
