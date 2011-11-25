using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Iamopen.OnlineReservations.Implementation.DB;
using Iamopen.OnlineReservations.Interface;
using Iamopen.OnlineReservations.Interface.Models;

namespace Iamopen.OnlineReservations.Implementation
{
    public class OnlineReservationManager: IReservationManager, IDisposable
    {
        // todo MM: maybe abstract this entity a bit
        private readonly OnlineReservationsContext _context;

        public OnlineReservationManager()
        {
            _context = new OnlineReservationsContext();
        }


        public ReservationResult ReserveTable(ReservationInfo reservationInfo)
        {
            throw new NotImplementedException();
        }

        public CancelReservationResult CancelReservation(CancelReservationInfo cancelReservationInfo)
        {
            throw new NotImplementedException();
        }

        public InstitutionsQueryResult QueryInstitutions(InstitutionsQueryInfo institutionsQueryInfo)
        {
            throw new NotImplementedException();
        }

        public InstitutionOnlineStatusRequestResult GetInstitutionOnlineStatus(InstitutionOnlineStatusRequestInfo institutionInfoRequest)
        {
            throw new NotImplementedException();
        }

        public InstitutionsStatisticsResult GetInstitutionsStatistics(InstitutionsStatisticsInfo institutionsStatisticsInfo)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
