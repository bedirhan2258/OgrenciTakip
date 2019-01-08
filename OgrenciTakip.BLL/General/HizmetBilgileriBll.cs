

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
    public class HizmetBilgileriBll : BaseHareketBll<HizmetBilgileri, OgrenciTakipContext>, IBaseHareketSelectBll<HizmetBilgileri>
    {
        public IEnumerable<BaseHareketEntity> List(Expression<Func<HizmetBilgileri, bool>> filter)
        {
            return List(filter, x => new HizmetBilgileriL
            {
                Id = x.Id,
                TahakkukId = x.TahakkukId,
                HizmetId = x.HizmetId,
                HizmetAdi = x.IptalEdildi ? $"{x.Hizmet.HizmetAdi} - ( *** İptal Edildi *** )" : x.Hizmet.HizmetAdi,
                HizmetTuruId = x.HizmetTuruId,
                HizmetTipi = x.HizmetTuru.HizmetTipi,
                ServisId = x.ServisId,
                ServisYeriAdi = x.Servis.ServisYeri,
                IslemTarihi = x.IslemTarihi,
                BaslamaTarihi = x.BaslamaTarihi,
                BrutUcret = x.BrutUcret,
                KistDusulenUcret = x.KistDusulenUcret,
                NetUcret = x.NetUcret,
                IptalEdildi = x.IptalEdildi,
                EgitimDonemiGunSayisi = x.EgitimDonemiGunSayisi,
                AlinanHizmetGunSayisi = x.AlinanHizmetGunSayisi,
                GunlukUcret = x.GunlukUcret,
                IptalTarihi = x.IptalTarihi,
                IptalNedeniId = x.IptalNedeniId,
                IptalNedeniAdi = x.IptalNedeni.IptalNedeniAdi,
                GittigiOkulId = x.GittigiOkulId,
                GittigiOkulAdi = x.GittigiOkul.OkulAdi,
                IptalAciklama = x.IptalAciklama

            }).OrderByDescending(x => x.IptalEdildi).ThenBy(x => x.IptalTarihi).ThenBy(x => x.Id).ToList();
        }
    }
}
