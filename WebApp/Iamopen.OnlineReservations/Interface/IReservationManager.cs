using System;
using System.Collections.Generic;
using Iamopen.Common.ServiceModels;
using Iamopen.OnlineReservations.Interface.Models;

namespace Iamopen.OnlineReservations.Interface
{
    public interface IReservationManager
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
