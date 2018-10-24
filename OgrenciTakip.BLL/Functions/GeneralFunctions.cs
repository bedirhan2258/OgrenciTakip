
using OgrenciTakip.DAL.Base;
using OgrenciTakip.DAL.Interfaces;
using OgrenciTakip.Model.Entities.Base.Interfaces;
using System;
using System.Configuration;
using System.Data.Entity;

namespace OgrenciTakip.BLL.Functions
{
    public class GeneralFunctions
    {
        public static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["OgrenciTakipXontext"].ConnectionString;
        }

        private static TContext CreateContext<TContext>() where TContext : DbContext
        {
            return (TContext)Activator.CreateInstance(typeof(TContext), GetConnectionString());
        }
        public static void CreateOfUnitOfWork<T, TContext>(ref IUnitOfWork<T> unitOfWork) where T : class, IBaseEntity where TContext : DbContext
        {
            unitOfWork?.Dispose();
            unitOfWork = new UnitOfWork<T>(CreateContext<TContext>());
        }
    }
}
