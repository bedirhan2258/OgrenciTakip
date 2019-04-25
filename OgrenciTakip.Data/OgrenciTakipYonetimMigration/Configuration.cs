
using OgrenciTakip.Data.Context;
using System.Data.Entity.Migrations;

namespace OgrenciTakip.Data.OgrenciTakipYonetimMigration
{
    public class Configuration : DbMigrationsConfiguration<OgrenciTakipYonetimContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }
    }
}
