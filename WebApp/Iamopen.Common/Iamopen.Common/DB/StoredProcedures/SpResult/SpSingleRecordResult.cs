using System.Collections.Generic;
using Iamopen.Common.Exceptions;

namespace Iamopen.Common.DB.StoredProcedures.SpResult
{
    public class SpSingleRecordResult<T> : SpResultBase<T>
    {
        public T Record;

        public SpSingleRecordResult(List<T> resultSet)
        {
            int count = resultSet.Count;
            switch (count)
            {
                case 0:
                  ResultCode = SpResultCode.EmptyResult;
                    Record = default(T);
                    break;
                case 1:
                    ResultCode = SpResultCode.OK;
                    Record = resultSet[0];
                    break;
                default:
                    throw new DBIncompatibilityException("SpSingleRecordResult should contain exactly 0 or 1 records");
            }
        }

        public SpSingleRecordResult(string errorMessage)
        {
            Initializer(SpResultCode.UnexpectedError, errorMessage, default(T));
        }

        private void Initializer(SpResultCode resultCode, string errorMessage, T resultSet)
        {
            this.ResultCode = resultCode;
            this.ErrorMessage = errorMessage;
            this.Record = resultSet;
        }
    }
}
