
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using OgrenciTakip.BLL.Base;
using OgrenciTakip.BLL.Interfaces;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Data.Context;
using OgrenciTakip.Model.DTO;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.Model.Entities.Base;

namespace OgrenciTakip.BLL.General
{
    public class GeriOdemeBilgileriBll : BaseHareketBll<GeriOdemeBilgileri, OgrenciTakipContext>, IBaseHareketSelectBll<GeriOdemeBilgileri>
    {
        public IEnumerable<BaseHareketEntity> List(Expression<Func<GeriOdemeBilgileri, bool>> filter)
        {
            return List(filter, x => new GeriOdemeBilgileriL
            {
                Id = x.Id,
                TahakkukId = x.TahakkukId,
                Tarih = x.Tarih,
                HesapTuru = x.HesapTuru,
                HesapId = x.HesapTuru == GeriOdemeHesapTuru.Kasa ? x.KasaId : x.BankaHesapId,
                HesapAdi = x.HesapTuru == GeriOdemeHesapTuru.Kasa ? x.Kasa.KasaAdi : x.BankaHesap.HesapAdi,
                Tutar = x.Tutar,
                BankaHesapId = x.BankaHesapId,
                KasaId = x.KasaId,
                Aciklama = x.Aciklama
            }).ToList();
        }
    }
}
