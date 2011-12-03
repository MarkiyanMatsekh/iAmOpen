using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using Iamopen.Common.DB.StoredProcedures.SpResult;

namespace Iamopen.Common.DB.StoredProcedures.StoredProcedure
{
    public class StoredProcWithSingleRecordResult<T> : StoredProcBase<SpSingleRecordResult<T>,T> 
    {
        public StoredProcWithSingleRecordResult(DbContext context, string name, List<SqlParameter> parameters) : base(context, name, parameters)
        {
        }

        protected override SpSingleRecordResult<T> ReturnFailedResult(string errorMessage)
        {
            return new SpSingleRecordResult<T>(errorMessage);
        }

        protected override SpSingleRecordResult<T> ReturnSuccessfulResult(List<T> resultSet)
        {
            return new SpSingleRecordResult<T>(resultSet);
        }
    }
}