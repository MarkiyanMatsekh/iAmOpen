using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Iamopen.Availability.Common.DB;
using Iamopen.Availability.OnlineAvailability.Implementation.DB.StoredProcedures;
using Iamopen.Common.DB.StoredProcedures.SpResult;

namespace Iamopen.Availability.OnlineAvailability.Implementation.DB
{
    class OnlineAvailabilityContext  : AvailabilityContext
    {
        public/*internal*/ SpSingleRecordResult<SpReserveTableResult> ReserveTable(int tableID, int userID, DateTime reservationTime)
        {
            var spReserveTable = new SpReserveTable(this, tableID, userID, reservationTime);
            return spReserveTable.Execute();
        }
    }
}
