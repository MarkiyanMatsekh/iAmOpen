using System;
using System.Collections.Generic;
using Iamopen.Common.ServiceModels;

namespace Iamopen.OnlineReservations.Interface.Models
{
    public class InstitutionOnlineStatusRequestInfo
    {
        public int InstitutionID;
        public int? HallID;
        public TimeSpan RecentActivityTimeSpan;
    }

    public class InstitutionOnlineStatusRequestResult : OperationResult
    {
        public IEnumerable<HallInfo> Halls;
        public InstitutionServiceType InstitutionServiceType;
        public InstitutionActivity RecentActivity;
    }

    public class HallInfo
    {
        public int HallID;
        public string Name;
        public IEnumerable<TableInfo> Tables;
    }

    public class TableInfo
    {
        /// <summary>
        /// Global ID
        /// </summary>
        public int TableID;
        /// <summary>
        /// Institution's enumeration
        /// </summary>
        public short TableNo;
        public TableStatus TableStatus;
        /// <summary>
        /// Valid only if (TableStatus == Reserved) and (Reservarion's PublicityType == Public)
        /// </summary>
        public int? ReservationHolder;
    }

    public enum InstitutionServiceType
    {
        FirstPayThenEat = 0,
        FirstEatThenPay = 1
    }

    // note MM: it may make sense to watch recent activity of each hall, but it may be impossible for limited institutions
    public class InstitutionActivity
    {
        public int OrdersMade;
        public TimeSpan TimeSpan;
    }









}
