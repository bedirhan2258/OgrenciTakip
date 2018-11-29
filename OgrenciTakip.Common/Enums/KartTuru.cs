
using System.ComponentModel;

namespace OgrenciTakip.Common.Enums

{
    //Enumlar varsayılan olarak int olarak kayıt edilir.
    public enum KartTuru : byte
    {
        [Description("Okul Kartı")]
        Okul = 1,
        [Description("İl Kartı")]
        Il = 2,
        [Description("İlçe Kartı")]
        Ilce = 3,
        [Description("Filtre Kartı")]
        Filtre = 4,
        [Description("Aile Bilgi Kartı")]
        AileBilgi = 5,
        [Description("İptal Nedeni Kartı")]
        IptalNedeni = 6,
        [Description("Yabancı Dil Kartı")]
        YabanciDil = 7,
        [Description("Teşvik Kartı")]
        Tesvik = 8,
        [Description("Kontenjan Kartı")]
        Kontenjan = 9,
        [Description("Rehber Kartı")]
        Rehber = 10,
        [Description("Sinif Grup Kartı")]
        SinifGrup = 11,
        [Description("Meslek Kartı")]
        Meslek = 12,
        [Description("Yakınlık Kartı")]
        Yakinlik = 13,
        [Description("Isyeri Kartı")]
        Isyeri = 14
    }
}
