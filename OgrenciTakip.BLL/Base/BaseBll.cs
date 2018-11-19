
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
using OgrenciTakip.Model.Attributes;

namespace OgrenciTakip.BLL.Base
{
    public class BaseBll<T, TContext> : IBaseBll where T : BaseEntity where TContext : DbContext
    {
        private readonly Control _ctrl;
        private IUnitOfWork<T> _unitOfWork;

        private bool Validation(IslemTuru islemTuru, BaseEntity oldEntity, BaseEntity currentEntity, Expression<Func<T, bool>> filter)
        {
            var errorControl = GetValidationErrorKontrol();
            if (errorControl == null) return true;

            _ctrl.Controls[errorControl].Focus();
            return false;

            string GetValidationErrorKontrol()
            {
                string MukerrerKod()
                {
                    foreach (var property in typeof(T).GetPropertyAttributesFromType<Kod>())
                    {
                        if (property.Attribute == null) continue;
                        if ((islemTuru == IslemTuru.EntityInsert || oldEntity.Kod == currentEntity.Kod) && islemTuru == IslemTuru.EntityUpdate) continue;
                        if (_unitOfWork.Rep.Count(filter) < 1) continue;
                        Messages.MukerrerKayitHataMesajı(property.Attribute.Description);
                        return property.Attribute.ControlName;
                    }
                    return null;
                }
                string HataliGiris()
                {
                    foreach (var property in typeof(T).GetPropertyAttributesFromType<ZorunluAlan>())
                    {
                        if (property.Attribute == null) continue;
                        var value = property.Property.GetValue(currentEntity);
                        if (property.Property.PropertyType == typeof(long))
                            if ((long)value == 0) value = null;

                        if (!string.IsNullOrEmpty(value?.ToString())) continue;
                        Messages.HataliVeriMesajı(property.Attribute.Description);
                        return property.Attribute.ControlName;
                    }
                    return null;
                }
                return HataliGiris() ?? MukerrerKod();
            }
        }
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
            //validation işlemi
            if (!Validation(IslemTuru.EntityInsert, null, entity, filter)) return false;
            //
            _unitOfWork.Rep.Insert(entity.EntityConvert<T>());
            return _unitOfWork.Save();
        }

        protected bool BaseUpdate(BaseEntity oldEntity, BaseEntity currentEntity, Expression<Func<T, bool>> filter)
        {
            GeneralFunctions.CreateOfUnitOfWork<T, TContext>(ref _unitOfWork);
            //Validation işlemş
            if (!Validation(IslemTuru.EntityUpdate, oldEntity, currentEntity, filter)) return false;
            //
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
        protected string BaseYeniKodVer(KartTuru kartTuru, Expression<Func<T, string>> filter, Expression<Func<T, bool>> where = null)
        {

            GeneralFunctions.CreateOfUnitOfWork<T, TContext>(ref _unitOfWork);
            return _unitOfWork.Rep.YeniKodVer(kartTuru, filter, where);
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
