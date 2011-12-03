using System;
using System.Runtime.Serialization;
using Iamopen.Common.ServiceModels;

namespace Iamopen.AMS.Interface.Models
{
    [DataContract]
    public class ChangeTableStatusInfo
    {
        [DataMember]
        public TableStatus TableStatus;
        [DataMember]
        public int TableID;
        [DataMember]
        public DateTime? DueDate;
    }
}