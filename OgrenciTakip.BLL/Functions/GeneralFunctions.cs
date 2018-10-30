
using OgrenciTakip.DAL.Base;
using OgrenciTakip.DAL.Interfaces;
using OgrenciTakip.Model.Entities.Base.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;

namespace OgrenciTakip.BLL.Functions
{
    public static class GeneralFunctions
    {
        public static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["OgrenciTakipContext"].ConnectionString;
        }

        public static List<string> DegisenAlanlariGetir<T>(this T oldEntity, T currentEntity)
        {
            List<string> alanlar = new List<string>();

            foreach (var prop in currentEntity.GetType().GetProperties())
            {
                if (prop.PropertyType.Namespace == "System.Collections.Generic") continue;
                var oldValue = prop.GetValue(oldEntity) ?? string.Empty;
                //?? kullanarak eğer getvalu(oldEnttiy) ile gelen değer null ise string.Empty atayarak gelen değerin değerini değiştirmiş olduk.
                var currentvalue = prop.GetValue(currentEntity) ?? string.Empty;

                if (prop.PropertyType == typeof(byte[]))
                {
                    if (string.IsNullOrEmpty(oldValue.ToString()))
                    {
                        oldValue = new byte[] { 0 };
                    }

                    if (string.IsNullOrEmpty(currentvalue.ToString()))
                    {
                        currentvalue = new byte[] { 0 };
                    }
                    if (((byte[])oldValue).Length != ((byte[])currentvalue).Length)
                    {
                        alanlar.Add(prop.Name);
                    }
                }
                else if (!currentvalue.Equals(oldValue))
                {
                    alanlar.Add(prop.Name);
                }
            }
            return alanlar;
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
