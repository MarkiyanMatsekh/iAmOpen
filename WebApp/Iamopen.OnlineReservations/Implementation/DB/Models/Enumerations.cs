namespace Iamopen.OnlineReservations.Implementation.DB.Models
{
    internal abstract class Enumeration
    {
        internal int ID;
        internal int Name;
    }

    internal class TableStatus : Enumeration { }

    internal class ReservationStatus : Enumeration { }

    internal class AreaType : Enumeration { }

    internal class InstitutionReservationType : Enumeration { }

    internal class InstitutionResponseType : Enumeration { }
}
