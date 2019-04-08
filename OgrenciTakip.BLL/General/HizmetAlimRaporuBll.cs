
using OgrenciTakip.BLL.Base;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Data.Context;
using OgrenciTakip.Model.DTO;
using OgrenciTakip.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace OgrenciTakip.BLL.General
{
    public class HizmetAlimRaporuBll : BaseBll<Tahakkuk, OgrenciTakipContext>
    {
        public IEnumerable<HizmetAlimRaporuL> List(Expression<Func<Tahakkuk, bool>> filter, IEnumerable<long> hizmetTurleri, HizmetAlimDurumu hizmetAlimDurumu)
        {
            return BaseList(filter, x => new
            {
                Tahakkuk = x,

                VeliBilgileri = x.IletisimBilgileri.Where(y => y.Veli).Select(y => new
                {
                    y.Iletisim,
                    y.Yakinlik
                }).FirstOrDefault(),
                HizmetAlimDurumu = x.HizmetBilgileri.Where(y => hizmetTurleri.Contains(y.HizmetId) && !y.IptalEdildi).GroupBy(y => y.TahakkukId).Any()

            }).Where(x => hizmetAlimDurumu == HizmetAlimDurumu.HizmetiAlanlar ? x.HizmetAlimDurumu : !x.HizmetAlimDurumu).Select(x => new HizmetAlimRaporuL
            {
                OgrenciId = x.Tahakkuk.OgrenciId,
                TahakkukId = x.Tahakkuk.Id,
                OgrenciNo = x.Tahakkuk.Kod,
                OkulNo = x.Tahakkuk.OkulNo,
                TcKimlikNo = x.Tahakkuk.Ogrenci.TcKimlikNo,
                Adi = x.Tahakkuk.Ogrenci.Adi,
                Soyadi = x.Tahakkuk.Ogrenci.Soyadi,
                Cinsiyet = x.Tahakkuk.Ogrenci.Cinsiyet,
                Telefon = x.Tahakkuk.Ogrenci.Telefon,
                KayitTarihi = x.Tahakkuk.KayitTarihi,
                KayitSekli = x.Tahakkuk.KayitSekli,
                KayitDurumu = x.Tahakkuk.KayitDurumu,
                IptalDurumu = x.Tahakkuk.Durum ? IptalDurumu.DevamEdiyor : IptalDurumu.IptalEdildi,
                SinifAdi = x.Tahakkuk.Sinif.SinifAdi,
                GeldigiOkulAdi = x.Tahakkuk.GeldigiOkul.OkulAdi,
                KontenjanAdi = x.Tahakkuk.Kontenjan.KontenjanAdi,
                YabanciDilAdi = x.Tahakkuk.YabanciDil.DilAdi,
                RehberAdi = x.Tahakkuk.Rehber.AdiSoyadi,
                TesvikAdi = x.Tahakkuk.Tesvik.TesvikAdi,
                SubeId = x.Tahakkuk.SubeId,
                SubeAdi = x.Tahakkuk.Sube.SubeAdi,
                DonemId = x.Tahakkuk.DonemId,
                OzelKod1 = x.Tahakkuk.OzelKod1.OzelKodAdi,
                OzelKod2 = x.Tahakkuk.OzelKod2.OzelKodAdi,
                OzelKod3 = x.Tahakkuk.OzelKod3.OzelKodAdi,
                OzelKod4 = x.Tahakkuk.OzelKod4.OzelKodAdi,
                OzelKod5 = x.Tahakkuk.OzelKod5.OzelKodAdi,
                VeliAdi = x.VeliBilgileri.Iletisim.Adi,
                VeliSoyadi = x.VeliBilgileri.Iletisim.Soyadi,
                VeliYakinlikAdi = x.VeliBilgileri.Yakinlik.YakinlikAdi,
                VeliMeslekAdi = x.VeliBilgileri.Iletisim.Meslek.MeslekAdi,
                VeliIsyeriAdi = x.VeliBilgileri.Iletisim.Isyeri.IsyeriAdi,
                VeliGorevAdi = x.VeliBilgileri.Iletisim.Gorev.GorevAdi
            }).OrderBy(x => x.OgrenciNo).ToList();
        }
    }
}
