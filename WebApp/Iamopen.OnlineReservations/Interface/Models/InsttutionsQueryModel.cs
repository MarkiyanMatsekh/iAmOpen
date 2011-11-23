using System;
using System.Collections.Generic;
using Iamopen.Common.ServiceModels;

namespace Iamopen.OnlineReservations.Interface.Models
{
    public class InstitutionsQueryResult : OperationResult
    {
        public IEnumerable<InstitutionInfo> Institutions;
    }

    public class InstitutionsQueryInfo
    {
        public int MinimalFreeTablesCount;
        public DateTime SearchTime;
    }

    public class InstitutionInfo
    {
        public IEnumerable<HallInfo> Halls;
    }









}
