using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Iamopen.OnlineReservations.Implementation.DB.Models;

namespace Iamopen.OnlineReservations.Implementation.DB
{
    internal class Institution
    {
        internal int IAmOpenID;

        internal int ReservationTypeID;
        internal InstitutionReservationType ReservationType;

        internal int TablesCount;

    }
}
