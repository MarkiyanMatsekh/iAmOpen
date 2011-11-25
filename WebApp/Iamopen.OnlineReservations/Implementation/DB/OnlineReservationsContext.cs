using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using Iamopen.OnlineReservations.Implementation.DB.Models;

namespace Iamopen.OnlineReservations.Implementation.DB
{
    internal class OnlineReservationsContext : DbContext
    {
        internal DbSet<Institution> Institutions;
        internal DbSet<Reservation> Reservations;
        internal DbSet<Table> Tables;
        internal DbSet<Hall> Halls;

        internal DbSet<InstitutionReservationType> InstitutionReservationTypes;
        internal DbSet<InstitutionResponseType> InstitutionResponseTypes;
        internal DbSet<ReservationStatus> ReservationStatuses;
        internal DbSet<TableStatus> TableStatuses;
        internal DbSet<AreaType> AreaTypes;
    }

}
