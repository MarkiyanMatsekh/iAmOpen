using System;
using System.Collections.Generic;
using Iamopen.Common.ServiceModels;

namespace Iamopen.OnlineAvailability.Interface.Models
{
    public class InstitutionsQueryInfo
    {
        public int MinimalFreeTablesCount;
        public DateTime SearchTime;
    }

    public class InstitutionsQueryResult : OperationResult
    {
        public IEnumerable<InstitutionInfo> Institutions;
    }

    public class InstitutionInfo
    {
        public IEnumerable<HallInfo> Halls;
    }









}
