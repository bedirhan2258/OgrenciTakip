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
    public class FiltreBLL : BaseBll<Filtre, OgrenciTakipContext>, IBaseCommonBll
    {
        public FiltreBLL() { }
        public FiltreBLL(Control ctrl) : base(ctrl) { }

        public BaseEntity Single(Expression<Func<Filtre, bool>> filter)
        {
            //Bütün alanlarıyla geri getir demek x=>x
            return BaseSingle(filter, x => x);
        }
        public IEnumerable<BaseEntity> List(Expression<Func<Filtre, bool>> filter)
        {
            return BaseList(filter, x => x).OrderBy(x => x.Kod).ToList();
        }
        public bool Insert(BaseEntity entity, Expression<Func<Filtre, bool>> filter)
        {
            return BaseInsert(entity, filter);
        }
        public bool Update(BaseEntity oldEntity, BaseEntity currentEntity, Expression<Func<Filtre, bool>> filter)
        {
            return BaseUpdate(oldEntity, currentEntity, filter);
        }
        public bool Delete(BaseEntity entity)
        {
            return BaseDelete(entity, KartTuru.Filtre);
        }

        public string YeniKodVer(Expression<Func<Filtre, bool>> filter)
        {
            return BaseYeniKodVer(KartTuru.Filtre, x => x.Kod, filter);
        }
    }
}
