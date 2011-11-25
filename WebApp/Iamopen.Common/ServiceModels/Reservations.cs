using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Iamopen.Common.ServiceModels
{

    [DataContract]
    public enum TableStatus
    {
        [EnumMember]
        Free = 0,
        [EnumMember]
        Busy = 1,
        [EnumMember]
        Reserved = 2
    }
}
