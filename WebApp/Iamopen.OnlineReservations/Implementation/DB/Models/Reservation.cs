using System;

namespace Iamopen.OnlineReservations.Implementation.DB.Models
{
    internal class Reservation
    {
        internal int ID;
        internal DateTime Time;

        internal int StatusID;
        internal ReservationStatus Status;

        internal int TableID;
        internal Table Table;

        internal int CustomerID;

        internal bool Public;
    }
}
