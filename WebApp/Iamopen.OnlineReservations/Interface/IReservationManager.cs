using Iamopen.OnlineReservations.Interface.Models;

namespace Iamopen.OnlineReservations.Interface
{
    public interface IReservationManager
    {
        ReservationResult ReserveTable(ReservationInfo reservationInfo);
        InstitutionStatusRequestResult GetInstitutionStatus(InstitutionStatusRequestInfo institutionInfoRequest);
        InstitutionsQueryResult QueryInstitutions(InstitutionsQueryInfo institutionsQueryInfo);
    }
}
