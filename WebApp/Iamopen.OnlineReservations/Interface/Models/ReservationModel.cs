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
    }

    public class UserInfo
    {
        public string FirstName;
        public string LastName;
        public string PhoneNumber;
        public int UserSID;
    }

    public class ReservationResult : OperationResult
    {}

}
