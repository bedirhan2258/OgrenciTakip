
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.Model.Entities.Base.Interfaces;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace OgrenciTakip.Model.DTO
{
    [NotMapped]
    public class MakbuzHareketleriL : MakbuzHareketleri, IBaseHareketEntity
    {
        public string OgrenciNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string SinifAdi { get; set; }
        public string OgrenciSubeAdi { get; set; }
        public string BelgeSubeAdi { get; set; }
        public string OdemeTuruAdi { get; set; }
        public OdemeTipi OdemeTipi { get; set; }
        public string TakipNo { get; set; }
        public DateTime GirisTarihi { get; set; }
        public DateTime Vade { get; set; }
        public DateTime HesabaGecisTarihi { get; set; }
        public decimal Tutar { get; set; }
        public string BankaHesapAdi { get; set; }
        public string BankaAdi { get; set; }
        public string BankaSubeAdi { get; set; }
        public string BelgeNo { get; set; }
        public string HesapNo { get; set; }
        public string AsilBorclu { get; set; }
        public string Ciranta { get; set; }
        public long? SonHareketId { get; set; }
        public DateTime? SonHareketTarihi { get; set; }
        public string SonIslemYeri { get; set; }

        public bool Insert { get; set; }
        public bool Update { get; set; }
        public bool Delete { get; set; }
    }
}
