
using OgrenciTakip.Data.Context;
using System.Data.Entity.Migrations;

namespace OgrenciTakip.Data.OgrenciTakipMigration
{
    public class Configuration : DbMigrationsConfiguration<OgrenciTakipContext>
    {
        public Configuration()
        {
            //Migration işlemlerini otomatik olarak yap
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;

            //Veri Kaybı olup olmamasını soruyor. Evet dedik veri kayıpları bizim için önemli değil dedik.
        }
    }
}
