using System.Collections.Generic;
using Iamopen.Common.ServiceModels;

namespace Iamopen.OnlineReservations.Interface.Models
{
    public class InstitutionStatusRequestInfo
    {
        public int InstitutionID;

        public int? HallID;
    }

    public class InstitutionStatusRequestResult : OperationResult
    {
        public IEnumerable<HallInfo> Halls;
    }

    public class HallInfo
    {
        public int HallNo;
        public string Name;
        public IEnumerable<TableInfo> Tables;
    }

    public class TableInfo
    {
        public int TableID;
        public TableStatus TableStatus;
        public short TableNo;
    }









}
