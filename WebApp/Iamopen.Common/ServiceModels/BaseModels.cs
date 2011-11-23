using System.Runtime.Serialization;

namespace Iamopen.Common.ServiceModels
{
    [DataContract]
    public class OperationResult
    {
        [DataMember]
        public ExecutionResult ExecutionResult;
    }

    /// <summary>
    /// Used for Post operation, so contains only technical information about success of operation
    /// </summary>
    [DataContract]
    public sealed class PostOperationResult : OperationResult {}

    [DataContract]
    public class ExecutionResult
    {
        [DataMember]
        public ResultCode ResultCode;
        [DataMember]
        public string EndUserErrorMessage;
        [DataMember]
        public string LogErrorMessage;
    }

    [DataContract]
    public enum ResultCode
    {
        [EnumMember]
        OK = 0, 
        [EnumMember]
        Fail = 1
    }
}
