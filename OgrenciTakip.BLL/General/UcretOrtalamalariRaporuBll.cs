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
    public class UcretOrtalamalariRaporuBll : BaseBll<Tahakkuk, OgrenciTakipContext>
    {
        public IEnumerable<UcretOrtalamalariRaporuL> List(Expression<Func<Tahakkuk, bool>> filter)
        {
            return BaseList(filter, x => new
            {
                Tahakkuk = x,
                x.Sinif,
                x.Sinif.Grup,
                x.Sube,

                HizmetBilgileri = x.HizmetBilgileri.GroupBy(y => new { y.Tahakkuk.SubeId, y.Tahakkuk.SinifId }).DefaultIfEmpty().Select(y => new
                {
                    BrutHizmet = y.Select(z => z.BrutUcret).DefaultIfEmpty(0).Sum(),
                    KistDonemDusulenHizmet = y.Select(z => z.KistDonemDusulenUcret).DefaultIfEmpty(0).Sum(),
                    NetHizmet = y.Select(z => z.NetUcret).DefaultIfEmpty(0).Sum(),
                }).FirstOrDefault(),

                IndirimBilgileri = x.IndirimBilgileri.GroupBy(y => new { y.Tahakkuk.SubeId, y.Tahakkuk.SinifId }).DefaultIfEmpty().Select(y => new
                {
                    BrutIndirim = y.Select(z => z.BrutIndirim).DefaultIfEmpty(0).Sum(),
                    KistDonemDusulenIndirim = y.Select(z => z.KistDonemDusulenIndirim).DefaultIfEmpty(0).Sum(),
                    NetIndirim = y.Select(z => z.NetIndirim).DefaultIfEmpty(0).Sum(),
                }).FirstOrDefault(),

            }).AsEnumerable().GroupBy(x => new { x.Tahakkuk.SubeId, x.Tahakkuk.SinifId }).Select(x => new UcretOrtalamalariRaporuL
            {
                SinifAdi = x.Select(y => y.Tahakkuk.Sinif.SinifAdi).FirstOrDefault(),
                SinifGrupAdi = x.Select(y => y.Tahakkuk.Sinif.Grup.GrupAdi).FirstOrDefault(),
                SubeAdi = x.Select(y => y.Tahakkuk.Sube.SubeAdi).FirstOrDefault(),
                SubeGrupAdi = x.Select(y => y.Tahakkuk.Sube.GrupAdi).FirstOrDefault(),
                SubeSiraNo = x.Select(y => y.Tahakkuk.Sube.SiraNo).FirstOrDefault(),
                UcretliOgrenci = x.Where(y => y.Tahakkuk.KontenjanId == null && y.Tahakkuk.Durum).Select(y => y.Tahakkuk.Id).Count(),
                UcretsizOgrenci = x.Where(y => y.Tahakkuk.KontenjanId != null && y.Tahakkuk.Durum).Select(y => y.Tahakkuk.Id).Count(),
                BrutHizmet = x.Select(y => y.HizmetBilgileri.BrutHizmet).DefaultIfEmpty(0).Sum(),
                KistDonemDusulenHizmet = x.Select(y => y.HizmetBilgileri.KistDonemDusulenHizmet).DefaultIfEmpty(0).Sum(),
                NetHizmet = x.Select(y => y.HizmetBilgileri.NetHizmet).DefaultIfEmpty(0).Sum(),
                BrutIndirim = x.Select(y => y.IndirimBilgileri.BrutIndirim).DefaultIfEmpty(0).Sum(),
                KistDonemDusulenIndirim = x.Select(y => y.IndirimBilgileri.KistDonemDusulenIndirim).DefaultIfEmpty(0).Sum(),
                NetIndirim = x.Select(y => y.IndirimBilgileri.NetIndirim).DefaultIfEmpty(0).Sum(),
                SinifSayisi = 1
            }).Where(x => x.UcretliOgrenci + x.UcretsizOgrenci > 0).OrderBy(x => x.SinifAdi).ToList();
        }

    }
}
