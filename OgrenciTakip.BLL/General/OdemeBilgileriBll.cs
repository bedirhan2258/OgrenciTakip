
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
    public class OdemeBilgileriBll : BaseHareketBll<OdemeBilgileri, OgrenciTakipContext>, IBaseHareketSelectBll<OdemeBilgileri>
    {
        public IEnumerable<BaseHareketEntity> List(Expression<Func<OdemeBilgileri, bool>> filter)
        {
            return List(filter, x => new
            {
                Toplamlar = x.MakbuzHareketleri.GroupBy(y => y.OdemeBilgileriId).DefaultIfEmpty().Select(y => new
                {
                    Tahsil = y.Where(z => z.BelgeDurumu == BelgeDurumu.AvukatYoluylaTahsilEtme || z.BelgeDurumu == BelgeDurumu.BankaYoluylaTahsilEtme || z.BelgeDurumu == BelgeDurumu.BlokeCozumu || z.BelgeDurumu == BelgeDurumu.KismiAvukatYoluylaTahsilEtme || z.BelgeDurumu == BelgeDurumu.KismiTahsilEdildi || z.BelgeDurumu == BelgeDurumu.OdenmisOlarakIsaretleme || z.BelgeDurumu == BelgeDurumu.MahsupEtme || z.BelgeDurumu == BelgeDurumu.TahsilEtmeBanka || z.BelgeDurumu == BelgeDurumu.TahsilEtmeKasa).Select(z => z.IslemTutari).DefaultIfEmpty(0).Sum(),
                    Iade = y.Where(z => z.BelgeDurumu == BelgeDurumu.MusteriyeGeriIade).Select(z => z.IslemTutari).DefaultIfEmpty(0).Sum(),
                    Tahsilde = y.Where(z => z.BelgeDurumu == BelgeDurumu.AvukataGonderme || z.BelgeDurumu == BelgeDurumu.BankayaTahsileGonderme || z.BelgeDurumu == BelgeDurumu.CiroEtme || z.BelgeDurumu == BelgeDurumu.BlokeyeAlma).Select(z => z.IslemTutari).DefaultIfEmpty(0).Sum() - y.Where(z => z.BelgeDurumu == BelgeDurumu.AvukatYoluylaTahsilEtme || z.BelgeDurumu == BelgeDurumu.BankaYoluylaTahsilEtme || z.BelgeDurumu == BelgeDurumu.BlokeCozumu || z.BelgeDurumu == BelgeDurumu.KismiAvukatYoluylaTahsilEtme || z.BelgeDurumu == BelgeDurumu.OdenmisOlarakIsaretleme || z.BelgeDurumu == BelgeDurumu.PortfoyeGeriIade || z.BelgeDurumu == BelgeDurumu.PortfoyeKarsiliksizIade).Select(z => z.IslemTutari).DefaultIfEmpty(0).Sum(),
                    BelgeDurumu = y.Any() ? y.OrderByDescending(z => z.Id).FirstOrDefault().BelgeDurumu : BelgeDurumu.Portfoyde,
                    SonHareketId = (int?)y.Max(z => z.Id),
                    SonHareketTarih = (DateTime?)y.OrderByDescending(z => z.Id).FirstOrDefault().Makbuz.Tarih,
                    SonIslemYeri = y.OrderByDescending(z => z.Id).Select(z => z.Makbuz.AvukatHesapId != null ? z.Makbuz.AvukatHesap.AdiSoyadi : z.Makbuz.BankaHesapId != null ? z.Makbuz.BankaHesap.HesapAdi : z.Makbuz.CariHesapId != null ? z.Makbuz.CariHesap.CariAdi : z.Makbuz.KasaHesapId != null ? z.Makbuz.KasaHesap.KasaAdi : z.Makbuz.SubeHesapId != null ? z.Makbuz.SubeHesap.SubeAdi : null).FirstOrDefault(),
                }).FirstOrDefault(),

                OdemeBelgesi = x,
            }).Select(x => new OdemeBilgileriL
            {
                Id = x.OdemeBelgesi.Id,
                TahakkukId = x.OdemeBelgesi.TahakkukId,
                OdemeTuruId = x.OdemeBelgesi.OdemeTuruId,
                OdemeTuruAdi = x.OdemeBelgesi.OdemeTuru.OdemeTuruAdi,
                OdemeTipi = x.OdemeBelgesi.OdemeTipi,
                BankaHesapId = x.OdemeBelgesi.BankaHesapId,
                BankaHesapAdi = x.OdemeBelgesi.BankaHesap.HesapAdi,
                BlokeGunSayisi = x.OdemeBelgesi.BlokeGunSayisi,
                GirisTarihi = x.OdemeBelgesi.GirisTarihi,
                Vade = x.OdemeBelgesi.Vade,
                HesabaGecisTarihi = x.OdemeBelgesi.HesabaGecisTarihi,
                Tutar = x.OdemeBelgesi.Tutar,
                TakipNo = x.OdemeBelgesi.TakipNo,
                BankaId = x.OdemeBelgesi.BankaId,
                BankaAdi = x.OdemeBelgesi.Banka.BankaAdi,
                BankaSubeId = x.OdemeBelgesi.BankaSubeId,
                BankaSubeAdi = x.OdemeBelgesi.BankaSube.SubeAdi,
                BelgeNo = x.OdemeBelgesi.BelgeNo,
                HesapNo = x.OdemeBelgesi.HesapNo,
                AsilBorclu = x.OdemeBelgesi.AsilBorclu,
                Ciranta = x.OdemeBelgesi.Ciranta,
                TutarYazi = x.OdemeBelgesi.TutarYazi,
                VadeYazi = x.OdemeBelgesi.VadeYazi,
                Aciklama = x.OdemeBelgesi.Aciklama,
                SubeAdi = x.OdemeBelgesi.Tahakkuk.Sube.SubeAdi,
                SubeIlAdi = x.OdemeBelgesi.Tahakkuk.Sube.AdresIl.IlAdi,
                Tahsil = x.Toplamlar.Tahsil,
                Tahsilde = x.Toplamlar.Tahsilde,
                Iade = x.Toplamlar.Iade,
                Kalan = x.OdemeBelgesi.Tutar - (x.Toplamlar.Tahsil + x.Toplamlar.Iade),
                BelgeDurumu = x.Toplamlar.BelgeDurumu,
                SonHareketId = x.Toplamlar.SonHareketId,
                SonHareketTarih = x.Toplamlar.SonHareketTarih,
                SonIslemYeri = x.Toplamlar.SonIslemYeri,
            }).ToList();
        }
    }


}

