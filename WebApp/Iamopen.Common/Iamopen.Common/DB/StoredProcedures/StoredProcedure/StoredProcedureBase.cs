using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Iamopen.Common.DB.StoredProcedures.SpResult;

namespace Iamopen.Common.DB.StoredProcedures.StoredProcedure
{
    public abstract class StoredProcBase<TResult, TRecord>
        where TResult : SpResultBase<TRecord>
    {
        private readonly DbContext _context;
        private readonly string _name;
        private readonly List<SqlParameter> _params;
        private readonly string _spInvokationString;

        protected StoredProcBase(DbContext context, string name, List<SqlParameter> parameters)
        {
            _context = context;
            _name = name;
            _params = parameters;
            _spInvokationString = BuildInvokationTemplate(_name, _params);
        }

        public TResult Execute()
        {
            List<TRecord> result = null;
            try
            {
                var r =  CoreBuildQuery();
                result = r.ToList();
            }
            // TODO MM: consider catching more concrete exceptions
            catch (Exception ex)
            {
                // note MM: can't use 'return new TResult( ex.Message )' only due to C# limitations
                return ReturnFailedResult(ex.Message);
            }
            return ReturnSuccessfulResult(result);
        }

        public IEnumerable<TRecord> BuildQuery()
        {
            return CoreBuildQuery();
        }

        protected virtual IEnumerable<TRecord> CoreBuildQuery()
        {
            // TODO MM CRITICAL: find out how to use _params as an array
            // TODO MM: find out how to receive data in type TRecord( currently all non-db-table entities are returned as default valued objects)
            return _context.Database.SqlQuery<TRecord>(_spInvokationString, _params[0], _params[1], _params[2]);
        }

        protected abstract TResult ReturnFailedResult(string errorMessage);

        protected abstract TResult ReturnSuccessfulResult(List<TRecord> resultSet);

        private static string BuildInvokationTemplate(string name, IEnumerable<SqlParameter> parameters)
        {
            var sb = new StringBuilder();
            sb.Append(name);
            foreach (SqlParameter t in parameters)
            {
                sb.Append(String.Format(" @{0},", t.ParameterName));
            }
            sb.Remove(sb.Length - 1, 1); // remove last comma
            return sb.ToString();
        }
    }
}