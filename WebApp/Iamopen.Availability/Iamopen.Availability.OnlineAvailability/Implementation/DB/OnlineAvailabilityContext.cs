using System;
using System.Data.Entity;
using Iamopen.Availability.OnlineAvailability.Implementation.DB.StoredProcedures;
using Iamopen.Availability.OnlineAvailability.Implementation.DomainModels;
using Iamopen.Common.DB.StoredProcedures.SpResult;

namespace Iamopen.Availability.OnlineAvailability.Implementation.DB
{
    public class OnlineAvailabilityContext : DbContext
    {
        public/*internal*/ DbSet<Institution> Institutions { get; set; }
        public/*internal*/ DbSet<Reservation> Reservations { get; set; }
        public/*internal*/ DbSet<Table> Tables { get; set; }
        public/*internal*/ DbSet<Hall> Halls { get; set; }

        public/*internal*/ DbSet<InstitutionResponseType> ResponseTypes { get; set; }
        public/*internal*/ DbSet<ReservationStatus> ReservationStatuses { get; set; }
        public/*internal*/ DbSet<InstitutionServiceType> ServiceTypes { get; set; }
        public/*internal*/ DbSet<TableStatus> TableStatuses { get; set; }
        public/*internal*/ DbSet<AreaType> AreaTypes { get; set; }

        public/*internal*/ SpSingleRecordResult<SpReserveTableResult> ReserveTable(int tableID, int userID, DateTime reservationTime)
        {
            var spReserveTable = new SpReserveTable(this, tableID, userID, reservationTime);
            return spReserveTable.Execute();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Institution>().HasMany(i => i.Halls).WithRequired(h => h.Institution);
            modelBuilder.Entity<Institution>().HasMany(i => i.Tables).WithRequired(t => t.Institution);

            modelBuilder.Entity<Hall>().HasMany(h => h.Tables).WithRequired(t => t.Hall);

            modelBuilder.Entity<Hall>().HasRequired(h => h.Institution)
                                       .WithMany(i => i.Halls)
                                       .WillCascadeOnDelete(true);
            modelBuilder.Entity<Table>().HasRequired(t => t.Hall)
                                       .WithMany(h => h.Tables)
                                       .WillCascadeOnDelete(false);
            modelBuilder.Entity<Table>().HasRequired(t => t.Institution)
                                       .WithMany(i => i.Tables)
                                       .WillCascadeOnDelete(true);
        }
    }



}
