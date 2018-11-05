
using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Grid;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Common.Message;
using OgrenciTakip.Model.Entities.Base;
using System;

namespace OgrenciTakip.UI.Win.Functions
{
    public static class GeneralFunctions
    {
        public static long GetRowId(this GridView tablo)
        {
            if (tablo.FocusedRowHandle > -1) return (long)tablo.GetFocusedRowCellValue("Id");
            Messages.KartSecmemeUyariMesaji();
            return (-1);
        }
        public static T GetRow<T>(this GridView tablo, bool mesajVer = true)
        {
            if (tablo.FocusedRowHandle > -1) return (T)tablo.GetRow(tablo.FocusedRowHandle);

            if (mesajVer)
                Messages.KartSecmemeUyariMesaji();

            return default(T);
        }
        //oldEntity ile current entity arasında bir fark varsa alan olarak geri gönderiyoruz.
        private static VeriDegisimYeri veriDegisimYeriGetir<T>(T oldEntity, T currentEntity)
        {

            foreach (var prop in currentEntity.GetType().GetProperties())
            {
                if (prop.PropertyType.Namespace == "System.Collections.Generic") continue;
                var oldValue = prop.GetValue(oldEntity) ?? string.Empty;
                //?? kullanarak eğer getvalu(oldEnttiy) ile gelen değer null ise string.Empty atayarak gelen değerin değerini değiştirmiş olduk.
                var currentvalue = prop.GetValue(currentEntity) ?? string.Empty;

                if (prop.PropertyType == typeof(byte[]))
                {
                    if (string.IsNullOrEmpty(oldValue.ToString()))
                    {
                        oldValue = new byte[] { 0 };
                    }

                    if (string.IsNullOrEmpty(currentvalue.ToString()))
                    {
                        currentvalue = new byte[] { 0 };
                    }
                    if (((byte[])oldValue).Length != ((byte[])currentvalue).Length)
                    {
                        return VeriDegisimYeri.Alan;
                    }
                }
                else if (!currentvalue.Equals(oldValue))
                {
                    return VeriDegisimYeri.Alan;
                }
            }
            return VeriDegisimYeri.VeriDegisimiYok;
        }
        public static void ButtonEnabledDurumu<T>(BarButtonItem btnYeni, BarButtonItem btnKaydet, BarButtonItem btnGeriAl, BarButtonItem btnSil, T oldEntity, T currentEntity)
        {
            var veriDegisimYeri = veriDegisimYeriGetir(oldEntity, currentEntity);
            var butonEnabledDurumu = veriDegisimYeri == VeriDegisimYeri.Alan; //veridegisimyeri alan gelirse otomatik olarak true olucak
            btnKaydet.Enabled = butonEnabledDurumu;
            btnGeriAl.Enabled = butonEnabledDurumu;
            btnSil.Enabled = !butonEnabledDurumu;
            btnYeni.Enabled = !butonEnabledDurumu;
        }
        public static long IdOlustur(this IslemTuru islemTuru, BaseEntity selectedEnttiy)
        {
            string SifirEkle(string deger)
            {
                if (deger.Length == 1)
                {
                    return "0" + deger;
                }
                return deger;
            }
            string UcBasamakYap(string deger)
            {
                switch (deger.Length)
                {
                    case 1:
                        return "00" + deger;
                    case 2:
                        return "0" + deger;
                }
                return deger;
            }
            string Id()
            {
                var yil = DateTime.Now.Date.Year.ToString();
                var ay = SifirEkle(DateTime.Now.Date.Month.ToString());
                var gun = SifirEkle(DateTime.Now.Date.Day.ToString());
                var saat = SifirEkle(DateTime.Now.Hour.ToString());
                var dakika = SifirEkle(DateTime.Now.Minute.ToString());
                var saniye = SifirEkle(DateTime.Now.Second.ToString());
                var milisaniye = UcBasamakYap(DateTime.Now.Millisecond.ToString());
                var random = SifirEkle(new Random().Next(0, 99).ToString());

                return yil + ay + gun + saat + dakika + saniye + milisaniye + random;
            }
            return islemTuru == IslemTuru.EntityUpdate ? selectedEnttiy.Id : long.Parse(Id());
        }
    }
}

