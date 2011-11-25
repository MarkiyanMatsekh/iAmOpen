using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using Iamopen.Common.ServiceModels;

namespace Iamopen.AvailabilitySyncService.Interface.Models
{
    [DataContract]
    public class UpdateStatusInfo
    {
        [DataMember]
        public DateTime LastUpdateTime;
    }

    [DataContract]
    public class UpdateStatusResult : OperationResult
    {
        [DataMember]
        public List<ReservationInfo> NewReservations;
        [DataMember]
        public List<ReservationCancellationInfo> CanceledReservations;
    }

    [DataContract]
    public class ReservationCancellationInfo
    {
        [DataMember]
        public int ReservationID;
        [DataMember]
        public string CancellationNote;
    }

    [DataContract]
    public class ReservationInfo
    {
        [DataMember]
        public int ReservationID;
        [DataMember]
        public int TableID;
        [DataMember]
        public DateTime ReservationTime;
        [DataMember]
        public UserInfo UserInfo;
    }

    [DataContract]
    public class UserInfo
    {
        [DataMember]
        public int UserSID;
        [DataMember]
        public string FirstName;
        [DataMember]
        public string LastName;
        [DataMember]
        public string PhoneNumber;
        [DataMember]
        // note MM : the best choice here would be dictionary, but it may be not supported on client side
        public List<SocialNetworkUserInfo> SocialNetworkIDs;
    }

    [DataContract]
    public class SocialNetworkUserInfo
    {
        [DataMember]
        public string SocialNetworkName;
        [DataMember]
        public string UserID;
    }
}