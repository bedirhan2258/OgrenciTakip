using OgrenciTakip.BLL.Base;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Common.Functions;
using OgrenciTakip.Data.Context;
using OgrenciTakip.Model.DTO;
using OgrenciTakip.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace OgrenciTakip.BLL.General
{
    public class GelirDagilimRaporuBll : BaseHareketBll<OdemeBilgileri, OgrenciTakipContext>
    {
        public IEnumerable<GelirDagilimRaporuL> List(Expression<Func<OdemeBilgileri, bool>> filter, GruplamaTuru hesaplamaSekli)
        {
            return List(filter, x => new
            {
                Odeme = x,
                Tahsil = x.MakbuzHareketleri.Where(c => c.BelgeDurumu == BelgeDurumu.AvukatYoluylaTahsilEtme || c.BelgeDurumu == BelgeDurumu.BankaYoluylaTahsilEtme || c.BelgeDurumu == BelgeDurumu.BlokeCozumu || c.BelgeDurumu == BelgeDurumu.KismiAvukatYoluylaTahsilEtme || c.BelgeDurumu == BelgeDurumu.KismiTahsilEdildi || c.BelgeDurumu == BelgeDurumu.MahsupEtme || c.BelgeDurumu == BelgeDurumu.OdenmisOlarakIsaretleme || c.BelgeDurumu == BelgeDurumu.TahsilEtmeKasa || c.BelgeDurumu == BelgeDurumu.TahsilEtmeBanka).Select(c => c.IslemTutari).DefaultIfEmpty(0).Sum(),

                Iade = x.MakbuzHareketleri.Where(c => c.BelgeDurumu == BelgeDurumu.MusteriyeGeriIade).Select(c => c.IslemTutari).DefaultIfEmpty(0).Sum(),

                Tahsilde = x.MakbuzHareketleri.Where(c => c.BelgeDurumu == BelgeDurumu.AvukataGonderme || c.BelgeDurumu == BelgeDurumu.BankayaTahsileGonderme || c.BelgeDurumu == BelgeDurumu.CiroEtme || c.BelgeDurumu == BelgeDurumu.BlokeyeAlma).Select(c => c.IslemTutari).DefaultIfEmpty(0).Sum() - x.MakbuzHareketleri.Where(c => c.BelgeDurumu == BelgeDurumu.KismiAvukatYoluylaTahsilEtme || c.BelgeDurumu == BelgeDurumu.AvukatYoluylaTahsilEtme ||
                 c.BelgeDurumu == BelgeDurumu.BankaYoluylaTahsilEtme || c.BelgeDurumu == BelgeDurumu.BlokeCozumu || c.BelgeDurumu == BelgeDurumu.OdenmisOlarakIsaretleme || c.BelgeDurumu == BelgeDurumu.PortfoyeGeriIade || c.BelgeDurumu == BelgeDurumu.PortfoyeKarsiliksizIade).Select(c => c.IslemTutari).DefaultIfEmpty(0).Sum(),

            }).GroupBy(x => hesaplamaSekli == GruplamaTuru.GirisTarihineGore ? new
            {
                x.Odeme.GirisTarihi.Year,
                x.Odeme.GirisTarihi.Month
            } : hesaplamaSekli == GruplamaTuru.HesabaGecisTarihineGore ? new
            {
                x.Odeme.HesabaGecisTarihi.Year,
                x.Odeme.HesabaGecisTarihi.Month
            } : new { x.Odeme.Vade.Year, x.Odeme.Vade.Month }).Select(x => new GelirDagilimRaporuL
            {
                Yil = x.Select(y => hesaplamaSekli == GruplamaTuru.GirisTarihineGore ? y.Odeme.GirisTarihi.Year : hesaplamaSekli == GruplamaTuru.HesabaGecisTarihineGore ? y.Odeme.HesabaGecisTarihi.Year : y.Odeme.Vade.Year).FirstOrDefault(),

                Ay = (Aylar)x.Select(y => hesaplamaSekli == GruplamaTuru.GirisTarihineGore ? y.Odeme.GirisTarihi.Month : hesaplamaSekli == GruplamaTuru.HesabaGecisTarihineGore ? y.Odeme.HesabaGecisTarihi.Month : y.Odeme.Vade.Month).FirstOrDefault(),
                TaksitSayisi = x.Count(),
                Acik = x.Where(y => y.Odeme.OdemeTipi == OdemeTipi.Acik).Select(y => y.Odeme.Tutar).DefaultIfEmpty(0).Sum(),
                Cek = x.Where(y => y.Odeme.OdemeTipi == OdemeTipi.Cek).Select(y => y.Odeme.Tutar).DefaultIfEmpty(0).Sum(),
                Elden = x.Where(y => y.Odeme.OdemeTipi == OdemeTipi.Elden).Select(y => y.Odeme.Tutar).DefaultIfEmpty(0).Sum(),
                Epos = x.Where(y => y.Odeme.OdemeTipi == OdemeTipi.Epos).Select(y => y.Odeme.Tutar).DefaultIfEmpty(0).Sum(),
                Ots = x.Where(y => y.Odeme.OdemeTipi == OdemeTipi.Ots).Select(y => y.Odeme.Tutar).DefaultIfEmpty(0).Sum(),
                Pos = x.Where(y => y.Odeme.OdemeTipi == OdemeTipi.Pos).Select(y => y.Odeme.Tutar).DefaultIfEmpty(0).Sum(),
                Senet = x.Where(y => y.Odeme.OdemeTipi == OdemeTipi.Senet).Select(y => y.Odeme.Tutar).DefaultIfEmpty(0).Sum(),
                ToplamOdeme = x.Select(y => y.Odeme.Tutar).DefaultIfEmpty(0).Sum(),
                Tahsil = x.Select(y => y.Tahsil).DefaultIfEmpty(0).Sum(),
                Iade = x.Select(y => y.Iade).DefaultIfEmpty(0).Sum(),
                Tahsilde = x.Select(y => y.Tahsilde).DefaultIfEmpty(0).Sum(),
            }).ToList();
        }
    }
}
