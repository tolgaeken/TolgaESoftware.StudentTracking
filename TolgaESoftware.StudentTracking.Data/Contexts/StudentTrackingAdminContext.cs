using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using TolgaESoftware.StudentTracking.Data.StudentTrackingAdminMigration;
using TolgaESoftware.StudentTracking.Model.Entities;

namespace TolgaESoftware.StudentTracking.Data.Contexts
{
    public class StudentTrackingAdminContext : BaseDbContext<StudentTrackingAdminContext,Configuration>
    {
        public StudentTrackingAdminContext()
        {
            Configuration.LazyLoadingEnabled = false;
        }

        public StudentTrackingAdminContext(string connectionString) : base(connectionString)
        {
            Configuration.LazyLoadingEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
        }

        public DbSet<Institution> Institution { get; set; }
    }
}