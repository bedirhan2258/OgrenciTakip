

using OgrenciTakip.BLL.Base;
using OgrenciTakip.BLL.Interfaces;
using OgrenciTakip.Data.Context;
using OgrenciTakip.Model.DTO;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace OgrenciTakip.BLL.General
{
    public class BilgiNotlariBll : BaseHareketBll<BilgiNotlari, OgrenciTakipContext>, IBaseHareketSelectBll<BilgiNotlari>
    {
        public IEnumerable<BaseHareketEntity> List(Expression<Func<BilgiNotlari, bool>> filter)
        {
            return List(filter, x => new BilgiNotlariL
            {
                Id = x.Id,
                TahakkukId = x.TahakkukId,
                Tarih = x.Tarih,
                BilgiNotu = x.BilgiNotu
            }).ToList();
        }
    }
}
