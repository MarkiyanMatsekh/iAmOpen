using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using Iamopen.Common.DB.StoredProcedures.StoredProcedure;
using Iamopen.Common.Exceptions;
using Iamopen.OnlineReservations.Implementation.DomainModels;

namespace Iamopen.OnlineReservations.Implementation.DB.StoredProcedures
{
    public/*internal*/ class SpReserveTable : StoredProcWithSingleRecordResult<SpReserveTableResult>
    {
        private const string SpName = "spReserveTable";
        private const string TableIDParam = "TableID";
        private const string UserIDParam = "UserID";
        private const string ReservationTimeParam = "ReservationTime";

        public/*internal*/ SpReserveTable(DbContext context, int tableID, int userID, DateTime reservationTime)
            : base(context, SpName, new List<SqlParameter>
            {
               new SqlParameter(TableIDParam, tableID),
               new SqlParameter(UserIDParam, userID),
               new SqlParameter(ReservationTimeParam, reservationTime),
            })
        { }
    }

    public/*internal*/ class SpReserveTableResult
    {
        public/*internal*/ int NewReservationID;
        public/*internal*/ InstitutionResponseType InstitutionResponseType;
        public/*internal*/ string InstitutionListenerAddress;
        public/*internal*/ int DbResponseCode;
        public/*internal*/ SpReserveTableError Error
        {
            get
            {
                if (Enum.IsDefined(typeof(SpReserveTableError), DbResponseCode))
                    return (SpReserveTableError)DbResponseCode;
                throw new DBIncompatibilityException("Couldn't cast db response code to SpReserveTableError enum");
            }
        }
    }

    // TODO MM: consider if such information is really needed outside of DB
    public/*internal*/ enum SpReserveTableError
    {
        None = 0,
        TableDoesntExist = 1,
        TableIsBusy = 2,
        UserDoesntExist = 3,
        UserDoestHavePermission = 4,
        InstitutionDoesntSupportReservation = 5
    }

}
