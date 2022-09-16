using System.Data.Entity.Migrations;
using TolgaESoftware.StudentTracking.Data.Contexts;

namespace TolgaESoftware.StudentTracking.Data.StudentTrackingAdminMigration
{
    public class Configuration:DbMigrationsConfiguration<StudentTrackingAdminContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }
    }
}