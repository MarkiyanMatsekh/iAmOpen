using System.Data.Entity;

namespace Iamopen.OnlineAvailability.Implementation.DB
{
    // todo MM: change strategy to DropCreateDatabaseIfModelChanged
    public/*internal*/ class OnlineAvailabilityInitializer : DropCreateDatabaseIfModelChanges<OnlineAvailabilityContext>
    {

        protected override void Seed(OnlineAvailabilityContext context)
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
