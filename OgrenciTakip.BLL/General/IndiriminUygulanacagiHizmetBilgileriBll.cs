
using OgrenciTakip.BLL.Base;
using OgrenciTakip.BLL.Interfaces;
using OgrenciTakip.Data.Context;
using OgrenciTakip.Model.DTO;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace OgrenciTakip.BLL.General
{
    public class IndiriminUygulanacagiHizmetBilgileriBll : BaseHareketBll<IndiriminUygulanacagiHizmetBilgileri, OgrenciTakipContext>,IBaseHareketSelectBll<IndiriminUygulanacagiHizmetBilgileri>
    {
        public IEnumerable<BaseHareketEntity> List(Expression<Func<IndiriminUygulanacagiHizmetBilgileri, bool>> filter)
        {
            return List(filter, x => new IndiriminUygulanacagiHizmetBilgileriL
            {
                Id = x.Id,
                IndirimId = x.IndirimId,
                HizmetId = x.HizmetId,
                HizmetAdi = x.Hizmet.HizmetAdi,
                IndirimTutari = x.IndirimTutari,
                IndirimOrani = x.IndirimOrani,
                SubeId = x.SubeId,
                DonemId = x.DonemId,
            });
        }
    }
}
