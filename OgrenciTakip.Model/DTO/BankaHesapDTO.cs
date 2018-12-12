
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Attributes;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.Model.Entities.Base;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OgrenciTakip.Model.DTO
{
    [NotMapped]
    public class BankaHesapS : BankaHesap
    {
        public string BankaAdi { get; set; }
        public string BankaSubeAdi { get; set; }
        public string OzelKod1Adi { get; set; }
        public string OzelKod2Adi { get; set; }
    }
    public class BankaHesapL:BaseEntity
    {
        public string HesapAdi { get; set; }
        public string BankaAdi { get; set; }
        public string BankaSubeAdi { get; set; }
        public BankaHesapTuru HesapTuru { get; set; }
        public DateTime HesapAcilisTarihi { get; set; }
        public string HesapNo { get; set; }
        public string IbanNo { get; set; }
        public byte BlokeGunSayisi { get; set; }
        public string IsyeriNo { get; set; }
        public string TerminalNo { get; set; }
        public string Aciklama { get; set; }
        public string OzelKod1Adi { get; set; }
        public string OzelKod2Adi { get; set; }
    }
}
