
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
        Isyeri = 14,
        [Description("Gorev Kartı")]
        Gorev = 15,
        [Description("İndirim Türü Kartı")]
        IndirimTuru = 16,
        [Description("Evrak Kartı")]
        Evrak = 17,
        [Description("Promosyon Kartı")]
        Promosyon = 18,
        [Description("Servis Yeri Kartı")]
        Servis = 19,
        [Description("Sınıf Kartı")]
        Sinif = 20,
        [Description("Hizmet Türü Kartı")]
        HizmetTuru = 21,
        [Description("Hizmet Kartı")]
        Hizmet = 22,
        [Description("Özel Kod Kartı")]
        OzelKod = 23,
        [Description("Kasa Kartı")]
        Kasa = 24,
        [Description("Banka Kartı")]
        Banka = 25,
        [Description("Banka Şube Kartı")]
        BankaSube = 26,
        [Description("Avukat Kartı")]
        Avukat = 27,
        [Description("Cari Kartı")]
        Cari = 28,
        [Description("Odeme Türü Kartı")]
        OdemeTuru = 29,
        [Description("Banka Hesap Kartı")]
        BankaHesap = 30,
        [Description("İletişim Kartı")]
        Iletisim = 31,
        [Description("Öğrenci Kartı")]
        Ogrenci = 32,
        [Description("İndirim Kartı")]
        Indirim = 33,
        [Description("Tahakkuk Kartı")]
        Tahakkuk = 34,
        [Description("Makbuz Kartı")]
        Makbuz = 35,
        [Description("Belge Seçim Kartı")]
        BelgeSecim = 36,
        [Description("Belge Hareketleri")]
        BelgeHareketleri = 37,
        [Description("Rapor Kartı")]
        Rapor = 38,
        [Description("Rapor Tasarım")]
        RaporTasarim = 39,
        [Description("Öğrenci Kartı Raporu")]
        OgrenciKartiRaporu=40
    }
}
