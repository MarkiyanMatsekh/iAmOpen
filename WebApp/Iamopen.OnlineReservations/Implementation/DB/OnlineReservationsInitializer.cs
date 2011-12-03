﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Iamopen.Common.DB.StoredProcedures.SpResult;
using Iamopen.OnlineReservations.Implementation.DB.StoredProcedures;
using Iamopen.OnlineReservations.Implementation.DomainModels;

namespace Iamopen.OnlineReservations.Implementation.DB
{
    // todo MM: change strategy to DropCreateDatabaseIfModelChanged
    public/*internal*/ class OnlineReservationsInitializer : DropCreateDatabaseIfModelChanges<OnlineReservationsContext>
    {

        protected override void Seed(OnlineReservationsContext context)
        {
            InitialData.ResponseTypes.ForEach(rt => context.ResponseTypes.Add(rt));
            InitialData.InstitutionServiceTypes.ForEach(st => context.ServiceTypes.Add(st));
            InitialData.ReservationStatuses.ForEach(rs => context.ReservationStatuses.Add(rs));
            InitialData.TableStatuses.ForEach(ts => context.TableStatuses.Add(ts));
            InitialData.AreaTypes.ForEach(at => context.AreaTypes.Add(at));
            InitialData.Institutions.ForEach(i => context.Institutions.Add(i));
            InitialData.Halls.ForEach(h => context.Halls.Add(h));
            InitialData.Tables.ForEach(t => context.Tables.Add(t));
            InitialData.Reservations.ForEach(r => context.Reservations.Add(r));

            base.Seed(context);
        }
    }


}
