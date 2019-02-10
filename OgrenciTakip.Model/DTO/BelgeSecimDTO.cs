
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities.Base;
using System;

namespace OgrenciTakip.Model.DTO
{
    public class BelgeSecimL : BaseEntity
    {
        public string OgrenciNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string SinifAdi { get; set; }
        public string OgrenciSubeAdi { get; set; }
        public long OdemeBilgileriId { get; set; }
        public string BelgeSubeAdi { get; set; }
        public string OdemeTuruAdi { get; set; }
        public OdemeTipi OdemeTipi { get; set; }
        public string TakipNo { get; set; }
        public DateTime GirisTarihi { get; set; }
        public DateTime Vade { get; set; }
        public DateTime HesabaGecisTarihi { get; set; }
        public decimal Tutar { get; set; }
        public decimal Tahsil { get; set; }
        public decimal Iade { get; set; }
        public decimal Kalan { get; set; }
        public string BankaHesapAdi { get; set; }
        public string BankaAdi { get; set; }
        public string BankaSubeAdi { get; set; }
        public string BelgeNo { get; set; }
        public string HesapNo { get; set; }
        public string AsilBorclu { get; set; }
        public string Ciranta { get; set; }
        public string Aciklama { get; set; }
        public long? SonHareketId { get; set; }
        public DateTime? SonHareketTarihi { get; set; }
        public string SonIslemYeri { get; set; }
        public BelgeDurumu BelgeDurumu { get; set; }
        public MakbuzHesapTuru HesapTuru { get; set; }
        public long? SubeId { get; set; }
    }
}
