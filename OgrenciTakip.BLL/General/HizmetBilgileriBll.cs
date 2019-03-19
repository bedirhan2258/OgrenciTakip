

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
                HizmetAdi = x.IptalEdildi ? x.Hizmet.HizmetAdi + " - ( *** İptal Edildi *** )" : x.Hizmet.HizmetAdi,
                HizmetTuruId = x.HizmetTuruId,
                HizmetTipi = x.HizmetTuru.HizmetTipi,
                ServisId = x.ServisId,
                ServisYeriAdi = x.Servis.ServisYeri,
                IslemTarihi = x.IslemTarihi,
                BaslamaTarihi = x.BaslamaTarihi,
                BrutUcret = x.BrutUcret,
                KistDonemDusulenUcret = x.KistDonemDusulenUcret,
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

        public IEnumerable<FaturaAlinanHizmetlerL> FaturaPlaniList(Expression<Func<HizmetBilgileri, bool>> filter)
        {
            return List(filter, x => new
            {
                HizmetBilgi = x,
                VeliBilgileri = x.Tahakkuk.IletisimBilgileri.Where(y => y.Veli).Select(y => new
                {
                    y.Iletisim,
                    y.Yakinlik
                }).FirstOrDefault(),

                HizmetBilgileri = x.Tahakkuk.HizmetBilgileri.Where(y => y.HizmetId == x.HizmetId).GroupBy(y => y.HizmetId).DefaultIfEmpty().Select(y => new
                {
                    HizmetAdi = y.Select(z => z.Hizmet.HizmetAdi).FirstOrDefault(),
                    BrutUcret = y.Select(z => z.BrutUcret).DefaultIfEmpty(0).Sum(),
                    KistDonemDusulenHizmet = y.Select(z => z.KistDonemDusulenUcret).DefaultIfEmpty(0).Sum(),
                    NetHizmet = y.Select(z => z.NetUcret).DefaultIfEmpty(0).Sum(),
                }).FirstOrDefault(),

                IndirimBilgileri = x.Tahakkuk.IndirimBilgileri.Where(y => y.HizmetId == x.HizmetId).GroupBy(y => y.HizmetId).DefaultIfEmpty().Select(y => new
                {
                    BrutIndirim = y.Select(z => z.BrutIndirim).DefaultIfEmpty(0).Sum(),
                    KistDonemDusulenIndirim = y.Select(z => z.KistDonemDusulenIndirim).DefaultIfEmpty(0).Sum(),
                    NetIndirim = y.Select(z => z.NetIndirim).DefaultIfEmpty(0).Sum(),
                }).FirstOrDefault()

            }).Select(x => new FaturaAlinanHizmetlerL
            {
                HizmetId = x.HizmetBilgi.HizmetId,
                TahakkukId = x.HizmetBilgi.TahakkukId,
                OkulNo = x.HizmetBilgi.Tahakkuk.Kod,
                Adi = x.HizmetBilgi.Tahakkuk.Ogrenci.Adi,
                Soyadi = x.HizmetBilgi.Tahakkuk.Ogrenci.Soyadi,
                SinifAdi = x.HizmetBilgi.Tahakkuk.Sinif.SinifAdi,
                VeliAdi = x.VeliBilgileri.Iletisim.Adi,
                VeliSoyadi = x.VeliBilgileri.Iletisim.Soyadi,
                VeliYakinlikAdi = x.VeliBilgileri.Yakinlik.YakinlikAdi,
                VeliMeslekAdi = x.VeliBilgileri.Iletisim.Meslek.MeslekAdi,
                HizmetAdi = x.HizmetBilgileri.HizmetAdi,
                BrutUcret = x.HizmetBilgileri.NetHizmet,
                Indirim = x.IndirimBilgileri.NetIndirim,
                NetUcret = x.HizmetBilgileri.NetHizmet - x.IndirimBilgileri.NetIndirim
            }).OrderBy(x => x.HizmetAdi).Distinct().ToList();
        }
    }
}
