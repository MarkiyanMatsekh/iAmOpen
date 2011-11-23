using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using Iamopen.Common.ServiceModels;

namespace Iamopen.AvailabilitySyncService.Interface.Models
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