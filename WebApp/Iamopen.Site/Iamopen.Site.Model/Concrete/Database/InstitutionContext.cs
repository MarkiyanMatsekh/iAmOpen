#region

using System.Data.Entity;
using IAmOpen.Site.Model.Models;

#endregion

namespace IAmOpen.Site.Model.Concrete.Database
{
    public class InstitutionContext : DbContext
    {
        public DbSet<Institution> Institutions { get; set; }
        public DbSet<InstitutionType> Types { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Chain> Chains { get; set; }
        public DbSet<ExternalAccount> ExternalAccounts { get; set; }
        public DbSet<WorkTime> WorkingHours { get; set; }
        public DbSet<Vote> Votes { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<UserExternalAccountToken> ExternalAccountTokens { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<Role> Roles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Institution>()
                .HasMany(i => i.Types)
                .WithMany(it => it.Institutions)
                .Map(t => t.MapLeftKey("ID").MapRightKey("InstitutionTypeID").ToTable("InstitutionWithInstitutionTypes"));

            modelBuilder.Entity<Institution>().HasMany(i => i.Reviews).WithRequired(r => r.ReferredInstitution);
            modelBuilder.Entity<Institution>().HasMany(i => i.WorkHours).WithRequired(wh => wh.Institution);

            modelBuilder.Entity<Chain>().HasMany(c => c.Reviews).WithOptional(r => r.ReferredChain);
            modelBuilder.Entity<Chain>().HasMany(c => c.Institutions).WithOptional(i => i.Chain);

            modelBuilder.Entity<Status>().HasMany(s => s.Institutions).WithRequired(i => i.Status);
            modelBuilder.Entity<Status>().HasMany(s => s.Chains).WithRequired(c => c.Status);

            modelBuilder.Entity<State>().HasMany(st => st.Institutions).WithRequired(i => i.State);

            modelBuilder.Entity<User>().HasMany(u => u.Reviews).WithOptional(r => r.Author);
            modelBuilder.Entity<User>().HasMany(u => u.MyInstitutions).WithRequired(i => i.CreatedByUser);

            modelBuilder.Entity<User>()
                .HasMany(u => u.Roles)
                .WithMany(r => r.Users)
                .Map(t => t.MapLeftKey("UserID").MapRightKey("RoleID").ToTable("UserRoles"));

            modelBuilder.Entity<User>()
                .HasMany(u => u.MyInstitutions)
                .WithMany(i => i.Visiters)
                .Map(t => t.MapLeftKey("UserID").MapRightKey("ID").ToTable("UserPlaces"));
            
            modelBuilder.Entity<User>().HasMany(u => u.UserExternalAccounts).WithRequired(uea => uea.User);

            modelBuilder.Entity<ExternalAccount>().HasMany(ea => ea.UserExternalAccounts).WithRequired(uea => uea.Account);
        }
    }
}
