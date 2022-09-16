using System.Data.Entity.Migrations;
using TolgaESoftware.StudentTracking.Data.Contexts;

namespace TolgaESoftware.StudentTracking.Data.StudentTrackingMigration
{
    public class Configuration:DbMigrationsConfiguration<StudentTrackingContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }
    }
}
