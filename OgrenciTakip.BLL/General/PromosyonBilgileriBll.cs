
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
    public class PromosyonBilgileriBll : BaseHareketBll<PromosyonBilgileri, OgrenciTakipContext>, IBaseHareketSelectBll<PromosyonBilgileri>
    {
        public IEnumerable<BaseHareketEntity> List(Expression<Func<PromosyonBilgileri, bool>> filter)
        {
            return List(filter, x => new PromosyonBilgileriL
            {
                Id = x.Id,
                TahakkukId = x.TahakkukId,
                PromosyonId = x.PromosyonId,
                Kod = x.Promosyon.Kod,
                PromosyonAdi = x.Promosyon.PromosyonAdi,
            }).ToList();
        }
    }
}
