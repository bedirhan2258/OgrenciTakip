

using System;
using OgrenciTakip.DAL.Base;
using OgrenciTakip.DAL.Interfaces;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using OgrenciTakip.Common.Message;
using System.Data.Entity.Validation;
using System.Text;

namespace OgrenciTakip.DAL.Base
{
    public class UnitOfWork<T> : IUnitOfWork<T> where T : class
    {
        private readonly DbContext _context;

        public UnitOfWork(DbContext context)
        {
            if (context == null) return;
            _context = context;
        }
        public IRepository<T> Rep => new Repository<T>(_context);

        public bool Save()
        {
            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                var sqlEx = (SqlException)ex.InnerException?.InnerException;
                if (sqlEx == null)
                {
                    Messages.HataMesaji(ex.Message);
                    return false;
                }
                else
                {
                    switch (sqlEx.Number)
                    {
                        case 208:
                            Messages.HataMesaji("İşlem Yapmak İstediğiniz Tablo Veri Tabanında Bulunamadı.");
                            break;
                        case 548:
                            Messages.HataMesaji("Seçilen Kartın İşlem Görmüş Kartları Var Kart Silinemez");
                            break;
                        case 2601:
                        case 2627:
                            Messages.HataMesaji("Girmiş Olduğunuz Id Daha Önce Kullanılmıştır.");
                            break;
                        case 4060:
                            Messages.HataMesaji("İşlem Yapmak İstediğiniz Veritabanı Sunucuda Bulunamadı.");
                            break;
                        case 18456:
                            Messages.HataMesaji("Server'a Bağlanılmak İstenilen Kullanıcı Adı veya Şifre Hatalıdır.");
                            break;
                        default:
                            Messages.HataMesaji(sqlEx.Message);
                            break;
                    }
                    return false;
                }
                //Messages.HataMesaji(ex.Message);
                //return false;
            }
            catch (DbEntityValidationException dbValEx)
            {
                var outputLines = new StringBuilder();
                foreach (var eve in dbValEx.EntityValidationErrors)
                {
                    outputLines.AppendFormat("{0}:Entity of type {1} in state {2} has the following validatin errors:", DateTime.Now, eve.Entry.Entity.GetType().Name, eve.Entry);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        outputLines.AppendFormat("-Property {0},Error:1{1}", ve.PropertyName, ve.ErrorMessage);
                    }
                }

                //Tools.Notify(this, outputLines.ToString(),"error");
                throw new DbEntityValidationException(string.Format("Validation errorsrn{0}"
                 , outputLines.ToString()), dbValEx);
            }
            return true;
        }

        #region Dispose

        private bool _disposedValue = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposedValue)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
                _disposedValue = true;
            }
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        #endregion
    }
}
