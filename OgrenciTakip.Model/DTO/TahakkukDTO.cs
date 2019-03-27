using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.Model.Entities.Base;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace OgrenciTakip.Model.DTO
{
    [NotMapped]
    public class TahakkukS : Tahakkuk
    {
        public string TcKimlikNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string BabaAdi { get; set; }
        public string AnaAdi { get; set; }
        public string OgrenciAdi { get; set; }
        public string SinifAdi { get; set; }
        public string GeldigiOkulAdi { get; set; }
        public string KontenjanAdi { get; set; }
        public string YabanciDilAdi { get; set; }
        public string RehberAdi { get; set; }
        public string TesvikAdi { get; set; }
        public string OzelKod1Adi { get; set; }
        public string OzelKod2Adi { get; set; }
        public string OzelKod3Adi { get; set; }
        public string OzelKod4Adi { get; set; }
        public string OzelKod5Adi { get; set; }

    }
    public class TahakkukL : BaseEntity
    {
        public long OgrenciId { get; set; }
        public string TcKimlikNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string BabaAdi { get; set; }
        public string AnaAdi { get; set; }
        public string OkulNo { get; set; }
        public DateTime KayitTarihi { get; set; }
        public KayitSekli KayitSekli { get; set; }
        public KayitDurumu KayitDurumu { get; set; }
        public string SinifAdi { get; set; }
        public string GeldigiOkulAdi { get; set; }
        public string KontenjanAdi { get; set; }
        public string YabanciDilAdi { get; set; }
        public string RehberAdi { get; set; }
        public string TesvikAdi { get; set; }
        public SonrakiDonemKayitDurumu SonrakiDonemKayitDurumu { get; set; }
        public string SonrakiDonemKayitDurumuAciklama { get; set; }
        public string OzelKod1Adi { get; set; }
        public string OzelKod2Adi { get; set; }
        public string OzelKod3Adi { get; set; }
        public string OzelKod4Adi { get; set; }
        public string OzelKod5Adi { get; set; }
        public string SubeAdi { get; set; }
        public bool Durum { get; set; }
    }

    public class OgrenciTahakkukL
    {
        public long TahakkukId { get; set; }
        public long SubeId { get; set; }
        public string SubeAdi { get; set; }
        public long DonemId { get; set; }
        public string DonemAdi { get; set; }
        public decimal BrutHizmet { get; set; }
        public decimal KistDonemDusulenHizmet { get; set; }
        public decimal NetHizmet { get; set; }
        public decimal BrutIndirim { get; set; }
        public decimal KistDonemDusulenIndirim { get; set; }
        public decimal NetIndirim { get; set; }
        public decimal NetUcret { get; set; }
        public decimal IndirimOrani { get; set; }

    }
}

