
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
        OgrenciKartiRaporu = 40,
        [Description("Banka Ödeme Planı Raporu")]
        BankaOdemePlaniRaporu = 41,
        [Description("Meb Kayıt Sözleşmesi Raporu")]
        MebKayitSozlesmesiRaporu = 42,
        [Description("İndirim Dilekçesi Raporu")]
        IndirimDilekcesiRaporu = 43,
        [Description("Kayıt Sozleşmesi Raporu")]
        KayitSozlesmesiRaporu = 44,
        [Description("Kredi Kartlı Ödeme Talimatı Raporu")]
        KrediKartliOdemeTalimatiRaporu = 45,
        [Description("Ödeme Senedi Raporu")]
        OdemeSenediRaporu = 46,
        [Description("Kullanıcı Tanımlı Rapor")]
        KullaniciTanimliRapor = 47,
        [Description("Tahsilat Makbuzu")]
        TahsilatMakbuzu = 48,
        [Description("Teslimat Makbuzu")]
        TeslimatMakbuzu = 49,
        [Description("İade Makbuzu")]
        IadeMakbuzu = 50,
        [Description("Genel Makbuz")]
        GenelMakbuz = 51,
        [Description("Şube Kartı")]
        Sube = 52,
        [Description("Fatura Kartı")]
        Fatura = 53,
        [Description("Fatura Raporu")]
        FaturaRaporu = 54,
        [Description("Fatura Dönem İcmal Raporu")]
        FaturaDonemIcmalRaporu = 55,
        [Description("Fatura Öğrenci İcmal Raporu")]
        FaturaOgrenciIcmalRaporu = 56,
        [Description("Genel Amaçlı Rapor")]
        GenelAmacliRapor = 57,
        [Description("Sinif Raporları")]
        SinifRaporlari = 58,
        [Description("Hizmet Alım Raporu")]
        HizmetAlimRaporu = 59,
        [Description("Net Ücret Raporu")]
        NetUcretRaporu = 60,
        [Description("Ücret ve Ödeme Raporu")]
        UcretveOdemeRaporu = 61,
        [Description("İndirim Dağılım Raporu")]
        IndirimDagilimRaporu = 62,
        [Description("Mesleklere Göre Kayıt Raporu")]
        MesleklereGoreKayitRaporu = 63,
        [Description("Aylık Kayıt Raporu")]
        AylikKayitRaporu = 64,
        [Description("Gelir Dağılım Raporu")]
        GelirDagilimRaporu = 65,
        [Description("Ücret Ortalamaları Raporu")]
        UcretOrtalamalariRaporu = 66,
        [Description("Ödeme Belgeleri Raporu")]
        OdemeBelgeleriRaporu = 67,
        [Description("Tahsilat Raporu")]
        TahsilatRaporu = 68,
        [Description("Ödemesi Geciken Alacaklar Raporu")]
        OdemesiGecikenAlacaklarRaporu = 69
    }
}
