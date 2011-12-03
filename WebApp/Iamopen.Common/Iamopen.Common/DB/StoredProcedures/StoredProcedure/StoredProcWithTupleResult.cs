using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using Iamopen.Common.DB.StoredProcedures.SpResult;

namespace Iamopen.Common.DB.StoredProcedures.StoredProcedure
{
    public class StoredProcWithTupleResult<T> : StoredProcBase<SpTupleResult<T>,T> 
    {
        public StoredProcWithTupleResult(DbContext context, string name, List<SqlParameter> parameters)
            : base(context, name, parameters)
        {
        }

        protected override SpTupleResult<T> ReturnFailedResult(string errorMessage)
        {
            return new SpTupleResult<T>(errorMessage);
        }

        protected override SpTupleResult<T> ReturnSuccessfulResult(List<T> resultSet)
        {
            return new SpTupleResult<T>(resultSet);
        }
    }
}