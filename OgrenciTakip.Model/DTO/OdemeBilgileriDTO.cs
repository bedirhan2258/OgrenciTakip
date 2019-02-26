

using DevExpress.DataAccess.ObjectBinding;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.Model.Entities.Base.Interfaces;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace OgrenciTakip.Model.DTO
{
    [NotMapped]
    public class OdemeBilgileriL : OdemeBilgileri, IBaseHareketEntity
    {
        public string OdemeTuruAdi { get; set; }
        public string BankaHesapAdi { get; set; }
        public string BankaAdi { get; set; }
        public string BankaSubeAdi { get; set; }
        public string SubeAdi { get; set; }
        public string SubeIlAdi { get; set; }
        public decimal Tahsil { get; set; }
        public decimal Tahsilde { get; set; }
        public decimal Iade { get; set; }
        public decimal Kalan { get; set; }
        public long? SonHareketId { get; set; }
        public DateTime? SonHareketTarih { get; set; }
        public string SonIslemYeri { get; set; }
        public BelgeDurumu BelgeDurumu { get; set; }
        public bool Insert { get; set; }
        public bool Update { get; set; }
        public bool Delete { get; set; }
    }

    [HighlightedClass]
    public class OdemeBilgileriR
    {
        public OdemeTipi OdemeTipi { get; set; }
        public int PorftfoyNo { get; set; }
        public string OdemeTuruAdi { get; set; }
        public DateTime GirisTarihi { get; set; }
        public DateTime Vade { get; set; }
        public DateTime HesabaGecisTarihi { get; set; }
        public string BankaHesapAdi { get; set; }
        public string TakipNo { get; set; }
        public byte BlokeGunSayisi { get; set; }
        public string BankaAdi { get; set; }
        public string BankaSubeAdi { get; set; }
        public string BelgeNo { get; set; }
        public string HesapNo { get; set; }
        public string AsilBorclu { get; set; }
        public string Ciranta { get; set; }
        public string Aciklama { get; set; }
        public decimal Tutar { get; set; }
        public decimal Tahsil { get; set; }
        public decimal Tahsilde { get; set; }
        public decimal Iade { get; set; }
        public decimal Kalan { get; set; }
        public string TutarYazi { get; set; }
        public string VadeYazi { get; set; }
        public string SubeAdi { get; set; }
        public string SubeIlAdi { get; set; }
        public BelgeDurumu BelgeDurumu { get; set; }
    }
}
