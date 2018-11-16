using OgrenciTakip.BLL.Base;
using OgrenciTakip.BLL.Interfaces;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Data.Context;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace OgrenciTakip.BLL.General
{
    public class IlceBLL : BaseBll<Ilce, OgrenciTakipContext>, IBaseCommonBll
    {
        public IlceBLL() { }
        public IlceBLL(Control ctrl) : base(ctrl) { }

        public BaseEntity Single(Expression<Func<Ilce, bool>> filter)
        {
            //Bütün alanlarıyla geri getir demek x=>x
            return BaseSingle(filter, x => x);
        }
        public IEnumerable<BaseEntity> List(Expression<Func<Ilce, bool>> filter)
        {
            return BaseList(filter, x => x).OrderBy(x => x.Kod).ToList();
        }
        public bool Insert(BaseEntity entity, Expression<Func<Ilce, bool>> filter)
        {
            return BaseInsert(entity, filter);
        }
        public bool Update(BaseEntity oldEntity, BaseEntity currentEntity, Expression<Func<Ilce, bool>> filter)
        {
            return BaseUpdate(oldEntity, currentEntity, filter);
        }
        public bool Delete(BaseEntity entity)
        {
            return BaseDelete(entity, KartTuru.Ilce);
        }

        public string YeniKodVer(Expression<Func<Ilce, bool>> filter)
        {
            return BaseYeniKodVer(KartTuru.Ilce, x => x.Kod, filter);
        }
    }
}
