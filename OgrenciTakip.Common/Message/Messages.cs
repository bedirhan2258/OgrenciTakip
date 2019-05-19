﻿

using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace OgrenciTakip.Common.Message
{
    public class Messages
    {
        public static void HataMesaji(string hataMesaji)
        {
            XtraMessageBox.Show(hataMesaji, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void UyariMesaji(string uyariMesaji)
        {
            XtraMessageBox.Show(uyariMesaji, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void BilgiMesaji(string bilgiMesaji)
        {
            XtraMessageBox.Show(bilgiMesaji, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static DialogResult EvetSeciliEvetHayir(string mesaj, string baslik)
        {
            return XtraMessageBox.Show(mesaj, baslik, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
        }
        public static DialogResult HayirSeciliEvetHayir(string mesaj, string baslik)
        {
            return XtraMessageBox.Show(mesaj, baslik, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
        }
        public static DialogResult SilMesaj(string kartAdi)
        {
            return HayirSeciliEvetHayir($"Seçtiğiniz {kartAdi}. Silinecektir.Onaylıyor musunuz?", "Silme Onayı");
        }

        public static DialogResult EvetSeciliEvetHayirIptal(string mesaj, string baslik)
        {
            return XtraMessageBox.Show(mesaj, baslik, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
        }
        public static DialogResult KapanisMesaj()
        {
            return EvetSeciliEvetHayirIptal("Yapılan Değişiklikler Kayıt Edilsin mi?", "Çıkış Onay");
        }

        public static DialogResult KayitMesaj()
        {
            return EvetSeciliEvetHayir("Yapılan Değişiklikler Kayıt Edilsin mi?", "Kayıt Onay");
        }

        public static void KartSecmemeUyariMesaji()
        {
            UyariMesaji("Lütfen Bir Kart Seçiniz.");
        }
        public static void MukerrerKayitHataMesajı(string alanAdi)
        {
            HataMesaji($"Girmiş Olduğunuz {alanAdi} Daha Önce Kullanılmıştır.");
        }

        public static void HataliVeriMesaji(string alanAdi)
        {
            HataMesaji($"{alanAdi} Alanına Geçerli Bir Veri Giriniz.");
        }

        public static DialogResult TabloExportMessage(string dosyaFormati)
        {
            return EvetSeciliEvetHayir($"İlgili Tablo, {dosyaFormati} Formati Olarak Dışarı Aktarılacaktır.Onaylıyor Musunuz?", "Aktarım Onay");
        }

        public static void KartBulunamadiMesaji(string kartTuru)
        {
            UyariMesaji($"İşlem Yapılabilecek {kartTuru} Bulunamadı.");
        }

        public static void TabloEksikBilgiMesaji(string tabloAdi)
        {
            UyariMesaji($"{tabloAdi}nda Eksik Bilgi Girişi Var. Lütfen Kontrol Ediniz.");
        }

        public static void IptalHareketSilinemezMesaji()
        {
            HataMesaji("İptal Edilen Hareketler Silinemez.");
        }

        public static DialogResult IptalMesaj(string kartAdi)
        {
            return HayirSeciliEvetHayir($"Seçtiğiniz {kartAdi} İptal Edilecektir.Onaylıyor musunuz?", "İptal Onayı");
        }

        public static DialogResult IptalGeriAlMesaj(string kartAdi)
        {
            return HayirSeciliEvetHayir($"Seçtiğiniz {kartAdi} Kartına Uygulanan İptal İşlemi Geri Alınacaktır.Onaylıyor musunuz?", "İptal Gerial Onayı");
        }

        public static void SecimHataMesaji(string alanAdi)
        {
            HataMesaji($"{alanAdi} Seçimi Yapmalısınız.");
        }

        public static void OdemeBelgesiSilinemezMesaj(bool dahaSonra)
        {
            UyariMesaji(dahaSonra ? "Ödeme Belgesinin Daha Sonra İşlem Görmüş Hareketleri Var. Ödeme Belgesi Silinemez" : "Ödeme Belgesinin İşlem Görmüş Harektleri Var.Ödeme Belgesi Silinemez");
        }

        public static DialogResult RaporuTasarimaGonderMesaj()
        {
            return HayirSeciliEvetHayir("Rapor Tasarım Görünümde Açılacaktır.Onaylıyor musunuz?", "Onay");
        }

        public static DialogResult RaporKapatMesaj()
        {
            return HayirSeciliEvetHayir("Rapor Kapatılacaktır Onaylıyor Musunuz?", "Onay");
        }

        public static DialogResult EmailGonderimOnayı()
        {
            return HayirSeciliEvetHayir("Kullanıcı Şifresi Sıfırlanarak , Kullanıcı Bilgilerini İçeren Yeni Bir Email Gönderilecektir. Onaylıyor Musunuz?", "Onay");
        }

    }
}
