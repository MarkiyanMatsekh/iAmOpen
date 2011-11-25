using System;

namespace Iamopen.OnlineReservations.Implementation.DB.Models
{
    internal class Table
    {
        internal int ID;
        internal int No;

        internal int HallID;
        internal Hall Hall;

        internal int InstitutionID;  // From Iamopen site

        internal int StatusID;
        internal TableStatus Status;

        internal DateTime LastUpdateTime;

        internal double Left;
        internal double Top;
        internal double Width;
        internal double Height;

        internal int AreaTypeID;
        internal AreaType AreaType;
    }
}
