namespace Iamopen.OnlineReservations.Implementation.DomainModels
{
    public/*internal*/ abstract class Enumeration
    {
        public/*internal*/ int ID { get; set; }
        public/*internal*/ string Name { get; set; }
    }

    public/*internal*/ class TableStatus : Enumeration { }

    public/*internal*/ class ReservationStatus : Enumeration { }

    public/*internal*/ class AreaType : Enumeration { }

    public/*internal*/ class InstitutionServiceType : Enumeration { }

    public/*internal*/ class InstitutionResponseType : Enumeration { }
}
