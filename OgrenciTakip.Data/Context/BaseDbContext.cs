
using System.Data.Entity;
using System.Data.Entity.Migrations;

namespace OgrenciTakip.Data.Context
{
    public class BaseDbContext<TContext, TConfiguration> : DbContext where TContext : DbContext where TConfiguration : DbMigrationsConfiguration<TContext>, new()
    {
        private static string _nameOrConnectionString = typeof(TContext).Name;
        public BaseDbContext() : base(_nameOrConnectionString) { }
        public BaseDbContext(string connectionString) : base(connectionString)
        {
            //Tablo alanlarında değişiklik olursa bunu otomatik olarak algılar ve update işlemi gerçekleştirir.
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<TContext, TConfiguration>());
            _nameOrConnectionString = connectionString;
        }
    }
}
