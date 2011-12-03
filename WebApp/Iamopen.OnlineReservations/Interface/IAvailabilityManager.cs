using Iamopen.OnlineAvailability.Interface.Models;

namespace Iamopen.OnlineAvailability.Interface
{
    public interface IAvailabilityManager
    {
        ReservationResult ReserveTable(ReservationInfo reservationInfo);
        CancelReservationResult CancelReservation(CancelReservationInfo cancelReservationInfo);
        InstitutionsQueryResult QueryInstitutions(InstitutionsQueryInfo institutionsQueryInfo);
        InstitutionOnlineStatusRequestResult GetInstitutionOnlineStatus(InstitutionOnlineStatusRequestInfo institutionInfoRequest);
        /// <summary>
        /// This method is not used straight by user - it's purpose is to update cached results
        /// </summary>
        InstitutionsStatisticsResult GetInstitutionsStatistics(InstitutionsStatisticsInfo institutionsStatisticsInfo);
    }
}
