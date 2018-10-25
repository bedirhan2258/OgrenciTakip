
using System;
using OgrenciTakip.BLL.Interfaces;
using OgrenciTakip.Model.Entities.Base;
using System.Data.Entity;
using System.Windows.Forms;
using OgrenciTakip.DAL.Interfaces;
using System.Linq.Expressions;
using OgrenciTakip.BLL.Functions;
using System.Linq;
using OgrenciTakip.Common.Message;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Common.Functions;

namespace OgrenciTakip.BLL.Base
{
    public class BaseBll<T, TContext> : IBaseBll where T : BaseEntity where TContext : DbContext
    {
        private readonly Control _ctrl;
        private IUnitOfWork<T> _unitOfWork;

        protected BaseBll() { }
        protected BaseBll(Control ctrl)
        {
            _ctrl = ctrl;
        }
        protected TResult BaseSingle<TResult>(Expression<Func<T, bool>> filter, Expression<Func<T, TResult>> selector)
        {
            GeneralFunctions.CreateOfUnitOfWork<T, TContext>(ref _unitOfWork);
            return _unitOfWork.Rep.Find(filter, selector);
        }

        protected IQueryable<TResult> BaseList<TResult>(Expression<Func<T, bool>> filter, Expression<Func<T, TResult>> selector)
        {
            GeneralFunctions.CreateOfUnitOfWork<T, TContext>(ref _unitOfWork);
            return _unitOfWork.Rep.Select(filter, selector);
        }

        protected bool BaseInsert(BaseEntity entity, Expression<Func<T, bool>> filter)
        {
            GeneralFunctions.CreateOfUnitOfWork<T, TContext>(ref _unitOfWork);
            //Insert işlemlerinden geçtiği için validation işlerim yapılmalı bu aşamada daha sonra tekrar dönülüp yazılacak.
            _unitOfWork.Rep.Insert(entity.EntityConvert<T>());
            return _unitOfWork.Save();
        }

        protected bool BaseUpdate(BaseEntity oldEntity, BaseEntity currentEntity, Expression<Func<T, bool>> filter)
        {
            GeneralFunctions.CreateOfUnitOfWork<T, TContext>(ref _unitOfWork);
            //Validation
            var degisenAlanlar = oldEntity.DegisenAlanlariGetir(currentEntity);
            if (degisenAlanlar.Count == 0) return true;
            _unitOfWork.Rep.Update(currentEntity.EntityConvert<T>(), degisenAlanlar);
            return _unitOfWork.Save();
        }

        protected bool BaseDelete(BaseEntity entity, KartTuru kartTuru, bool messageVer = true)
        {
            GeneralFunctions.CreateOfUnitOfWork<T, TContext>(ref _unitOfWork);
            if (messageVer)
                if (Messages.SilMesaj(kartTuru.ToName()) != DialogResult.Yes) return false;

            _unitOfWork.Rep.Delete(entity.EntityConvert<T>());
            return _unitOfWork.Save();
        }

        #region Dispose

        public void Dispose()
        {
            _ctrl?.Dispose();
            _unitOfWork?.Dispose();
        }
        #endregion
    }
}
