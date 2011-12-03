using System;
using System.Collections.Generic;

namespace Iamopen.Common.DB.StoredProcedures.SpResult
{
    public class SpTupleResult<T> : SpResultBase<T>
    {
        public List<T> ResultSet;

        public SpTupleResult(List<T> resultSet)
        {
            SpResultCode resultCode = SpResultCode.OK;
            if (resultSet.Count == 0)
                resultCode = SpResultCode.EmptyResult;
            Initializer(resultCode, String.Empty, resultSet);
        }

        public SpTupleResult(string errorMessage)
        {
            Initializer(SpResultCode.UnexpectedError, errorMessage, null);
        }

        private void Initializer(SpResultCode resultCode, string errorMessage, List<T> resultSet)
        {
            this.ResultCode = resultCode;
            this.ErrorMessage = errorMessage;
            this.ResultSet = resultSet;
        }
    }
}
