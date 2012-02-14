using System.Data.Entity;

namespace Iamopen.Availability.Common.DB
{
    public/*internal*/ class AvailabilityInitializer : DropCreateDatabaseIfModelChanges<AvailabilityContext>
    {

        protected override void Seed(AvailabilityContext context)
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
