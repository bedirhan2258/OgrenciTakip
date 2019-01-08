
using OgrenciTakip.BLL.Functions;
using OgrenciTakip.BLL.Interfaces;
using OgrenciTakip.DAL.Interfaces;
using OgrenciTakip.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace OgrenciTakip.BLL.Base
{
    public class BaseHareketBll<T, TContext> : IBaseBll, IBaseHareketGenelBll where T : BaseHareketEntity where TContext : DbContext
    {
        #region Variables
        private IUnitOfWork<T> _uow;
        #endregion

        protected IQueryable<TResult> List<TResult>(Expression<Func<T, bool>> filter, Expression<Func<T, TResult>> selector)
        {
            GeneralFunctions.CreateOfUnitOfWork<T, TContext>(ref _uow);
            return _uow.Rep.Select(filter, selector);
        }

        public virtual bool Insert(IList<BaseHareketEntity> entities)
        {
            GeneralFunctions.CreateOfUnitOfWork<T, TContext>(ref _uow);
            _uow.Rep.Insert(entities.EntityListConvert<T>());
            return _uow.Save();
        }

        public virtual bool Update(IList<BaseHareketEntity> entities)
        {
            GeneralFunctions.CreateOfUnitOfWork<T, TContext>(ref _uow);

            _uow.Rep.Update(entities.EntityListConvert<T>());
            return _uow.Save();
        }

        public bool Delete(IList<BaseHareketEntity> entitites)
        {
            GeneralFunctions.CreateOfUnitOfWork<T, TContext>(ref _uow);

            _uow.Rep.Delete(entitites.EntityListConvert<T>());
            return _uow.Save();
        }

        #region Dispose

        public void Dispose()
        {
            _uow?.Dispose();
        }
        #endregion
    }
}
