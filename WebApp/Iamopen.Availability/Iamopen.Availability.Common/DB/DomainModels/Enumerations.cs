namespace Iamopen.Availability.Common.DB.DomainModels
{
    public/*internal*/ abstract class Enumeration
    {
        public/*internal*/ int ID { get; set; }
        public/*internal*/ string Name { get; set; }
    }

    public/*internal*/ class TableStatus : Enumeration
    {
        public static explicit operator Iamopen.Common.ServiceModels.TableStatus(TableStatus status)
        {
            return EntitiesMapping.MapTableStatus(status);
        }

        public static explicit operator TableStatus(Iamopen.Common.ServiceModels.TableStatus status)
        {
            return EntitiesMapping.MapTableStatus(status);
        }
    }

    public/*internal*/ class ReservationStatus : Enumeration
    {
        public static explicit operator Iamopen.Common.ServiceModels.ReservationStatus(ReservationStatus status)
        {
            return EntitiesMapping.MapReservationStatus(status);
        }

        public static explicit operator ReservationStatus(Iamopen.Common.ServiceModels.ReservationStatus status)
        {
            return EntitiesMapping.MapReservationStatus(status);
        }

    }

    public/*internal*/ class AreaType : Enumeration { }

    public/*internal*/ class InstitutionServiceType : Enumeration { }

    public/*internal*/ class InstitutionResponseType : Enumeration { }
}
