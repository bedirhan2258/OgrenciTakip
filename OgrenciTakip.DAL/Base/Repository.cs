
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using OgrenciTakip.DAL.Interfaces;
using System.Data.Entity;
using System.Linq;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Common.Functions;

namespace OgrenciTakip.DAL.Base
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly DbContext _context;
        private readonly DbSet<T> _dbSet;
        public Repository(DbContext context)
        {
            if (context == null) return;
            _context = context;
            _dbSet = _context.Set<T>();

        }
        public void Insert(T entity)
        {
            _context.Entry(entity).State = EntityState.Added;
        }
        public void Insert(IEnumerable<T> entities)
        {
            foreach (var entity in entities)
            {
                _context.Entry(entity).State = EntityState.Added;
            }
        }
        public void Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }
        public void Update(IEnumerable<T> entities)
        {
            foreach (var entity in entities)
            {
                _context.Entry(entity).State = EntityState.Modified;
            }
        }

        public void Update(T entity, IEnumerable<string> fields)
        {
            _dbSet.Attach(entity);
            var entry = _context.Entry(entity);
            foreach (var field in fields)
            {
                entry.Property(field).IsModified = true;
            }
        }

        public void Delete(T entity)
        {
            _context.Entry(entity).State = EntityState.Deleted;
        }
        public void Delete(IEnumerable<T> entities)
        {
            foreach (var entity in entities)
            {
                _context.Entry(entity).State = EntityState.Deleted;
            }
        }
        public TResult Find<TResult>(Expression<Func<T, bool>> filter, Expression<Func<T, TResult>> selector)
        {
            return filter == null ? _dbSet.Select(selector).FirstOrDefault() : _dbSet.Where(filter).Select(selector).FirstOrDefault();
        }

        public IQueryable<TResult> Select<TResult>(Expression<Func<T, bool>> filter, Expression<Func<T, TResult>> selector)
        {
            return filter == null ? _dbSet.Select(selector) : _dbSet.Where(filter).Select(selector);
        }
        public int Count(Expression<Func<T, bool>> filter = null)
        {
            return filter == null ? _dbSet.Count() : _dbSet.Count(filter); 
        }
        public string YeniKodVer(KartTuru kartTuru, Expression<Func<T, string>> filter, Expression<Func<T, bool>> where = null)
        {
            string Kod()
            {
                string kod = null;
                var kodDizi = kartTuru.ToName().Split(' ');
                for (int i = 0; i < kodDizi.Length - 1; i++)
                {
                    kod += kodDizi[i];
                    if (i + 1 < kodDizi.Length - 1)
                        kod += "";

                }
                return kod += "-0001";
            }
            string YeniKodVer(string kod)
            {
                var sayisalDegerler = "";
                foreach (var karakter in kod)
                {
                    if (char.IsDigit(karakter))
                        sayisalDegerler += karakter;
                    else
                        sayisalDegerler = "";

                }
                var artisSonrasiDeger = (int.Parse(sayisalDegerler) + 1).ToString();
                var fark = kod.Length - artisSonrasiDeger.Length;

                if (fark < 0)
                    fark = 0;

                var yeniDeger = kod.Substring(0, fark);
                yeniDeger += artisSonrasiDeger;

                return yeniDeger;
            }
            //Eğer kodda bir where ifadesi varsa

            var maxKod = where == null ? _dbSet.Max(filter) : _dbSet.Where(where).Max(filter);
            //Eğer databasede daha once kayıt yoksa 0001 ile başlayan bir kod gelecek daha once varsa 1 arttırarak bize yeni bir kod verecek
            return maxKod == null ? Kod() : YeniKodVer(maxKod);

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
