using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Attributes;
using OgrenciTakip.Model.Entities.Base;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace OgrenciTakip.Model.Entities
{
    public class Makbuz : BaseEntity
    {
        [Index("IX_kod", IsUnique = false), Kod("Makbuz No", "txtMakbuzNo"), ZorunluAlan("Makbuz No", "txtMakbuzNo")]
        public override string Kod { get; set; }

        [Column(TypeName = "date")]
        public DateTime Tarih { get; set; }

        public MakbuzTuru MakbuzTuru { get; set; } = MakbuzTuru.TahsilEtmeBanka;
        public MakbuzHesapTuru HesapTuru { get; set; } = MakbuzHesapTuru.Kasa;

        public long? AvukatHesapId { get; set; }
        public long? BankaHesapId { get; set; }
        public long? CariHesapId { get; set; }
        public long? KasaHesapId { get; set; }
        public long? SubeHesapId { get; set; }

        [Column(TypeName = "money")]
        public decimal MakbuzToplami { get; set; }
        public int HareketSayisi { get; set; }
        public long DonemId { get; set; }
        public long SubeId { get; set; }

        public Avukat AvukatHesap { get; set; }
        public BankaHesap BankaHesap { get; set; }
        public Cari CariHesap { get; set; }
        public Kasa KasaHesap { get; set; }
        public Sube SubeHesap { get; set; }
        public Donem Donem { get; set; }
        public Sube Sube { get; set; }
    }
}
