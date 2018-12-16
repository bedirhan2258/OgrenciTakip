
using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Grid;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Common.Message;
using OgrenciTakip.Model.Entities.Base;
using OgrenciTakip.UI.Win.UserControls.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

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

                var currentvalue = prop.GetValue(currentEntity) ?? string.Empty;
                var oldValue = prop.GetValue(oldEntity) ?? string.Empty;


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
        public static void ButtonEnabledDurumu<T>(BarButtonItem btnKaydet, BarButtonItem btnFarkliKaydet, BarButtonItem btnSil, IslemTuru islemTuru, T oldEntity, T currentEntity)
        {
            var veriDegisimYeri = veriDegisimYeriGetir(oldEntity, currentEntity);
            var butonEnabledDurumu = veriDegisimYeri == VeriDegisimYeri.Alan; //veridegisimyeri alan gelirse otomatik olarak true olucak

            btnKaydet.Enabled = butonEnabledDurumu;
            btnFarkliKaydet.Enabled = islemTuru != IslemTuru.EntityInsert;
            btnSil.Enabled = !butonEnabledDurumu;
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
        public static void ControlEnabledChange(this MyButtonEdit baseEdit, Control prmEdit)
        {
            switch (prmEdit)
            {
                case MyButtonEdit edt:
                    edt.Enabled = baseEdit.Id.HasValue && baseEdit.Id > 0;
                    edt.Id = null;
                    edt.EditValue = null;
                    break;
            }
        }
        public static void RowFocus(this GridView tablo, string aranacakKolon, object aranacakDeger)
        {
            var rowHandle = 0;
            for (int i = 0; i < tablo.RowCount; i++)
            {
                var bulunanDeger = tablo.GetRowCellValue(i, aranacakKolon);
                if (aranacakDeger.Equals(bulunanDeger))
                    rowHandle = i;
            }
            tablo.FocusedRowHandle = rowHandle;

        }
        public static void RowFocus(this GridView tablo, int rowHandle)
        {
            if (rowHandle <= 0) return;
            if (rowHandle == tablo.RowCount - 1)
                tablo.FocusedRowHandle = rowHandle;
            else
                tablo.FocusedRowHandle = rowHandle - 1;
        }
        public static void SagMenuGoster(this MouseEventArgs e, PopupMenu sagMenu)
        {
            if (e.Button != MouseButtons.Right) return;
            sagMenu.ShowPopup(Control.MousePosition);
        }
        //Bu fonsiyon bilgisayarda kuruu olan printerların ismini yazici adi alınaına yükler
        public static List<string> YazicilariListele()
        {
            return PrinterSettings.InstalledPrinters.Cast<string>().ToList();
        }
        public static string DefaultYazici()
        {
            var settings = new PrinterSettings();
            return settings.PrinterName;
        }

        public static void ShowPopUpMenu(this MouseEventArgs e, PopupMenu popUpMenu)
        {
            if (e.Button != MouseButtons.Right) return;
            //Açılacak menüyü mouse'ın pozisyonuna göre aç demektir.
            popUpMenu.ShowPopup(Control.MousePosition);
        }

        public static byte[] ResimYukle()
        {
            var dialog = new OpenFileDialog
            {
                Title = "Resim Seç",
                Filter = "Resim Dosyaları (*.bmp,*.gif,*.jpg,*.png)|*.bmp; *.gif; *.jpg; *.png|Bmp Dosyaları|*.bmp|Gif Dosyaları|*.gif|Jpg Dosyaları|*.jpg|Png Dosyaları|*.png",
                InitialDirectory = @"C:\"
            };
            byte[] Resim()
            {
                using (var stream = new MemoryStream())
                {
                    Image.FromFile(dialog.FileName).Save(stream, ImageFormat.Png);
                    return stream.ToArray();
                }

            }
            return dialog.ShowDialog() != DialogResult.OK ? null : Resim();

        }
    }
}

