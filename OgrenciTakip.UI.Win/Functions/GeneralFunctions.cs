
using DevExpress.XtraBars;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraLayout;
using DevExpress.XtraPrinting.Native;
using DevExpress.XtraReports.UI;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Common.Message;
using OgrenciTakip.Model.Entities.Base;
using OgrenciTakip.Model.Entities.Base.Interfaces;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Properties;
using OgrenciTakip.UI.Win.UserControls.Controls;
using OgrenciTakip.UI.Win.UserControls.UserControl.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
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

        public static long GetRowCellId(this GridView tablo, GridColumn idColumn)
        {
            var value = tablo.GetRowCellValue(tablo.FocusedRowHandle, idColumn);
            return (long?)value ?? -1;
        }

        public static T GetRow<T>(this GridView tablo, bool mesajVer = true)
        {
            if (tablo.FocusedRowHandle > -1) return (T)tablo.GetRow(tablo.FocusedRowHandle);

            if (mesajVer)
                Messages.KartSecmemeUyariMesaji();

            return default(T);
        }

        public static T GetRow<T>(this GridView tablo, int rowHandle)
        {
            if (tablo.FocusedRowHandle > -1) return (T)tablo.GetRow(rowHandle);
            Messages.KartSecmemeUyariMesaji();
            return default(T);
        }

        //oldEntity ile current entity arasında bir fark varsa alan olarak geri gönderiyoruz.
        private static VeriDegisimYeri VeriDegisimYeriGetir<T>(T oldEntity, T currentEntity)
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
            var veriDegisimYeri = VeriDegisimYeriGetir(oldEntity, currentEntity);
            var butonEnabledDurumu = veriDegisimYeri == VeriDegisimYeri.Alan; //veridegisimyeri alan gelirse otomatik olarak true olucak
            btnKaydet.Enabled = butonEnabledDurumu;
            btnGeriAl.Enabled = butonEnabledDurumu;
            btnSil.Enabled = !butonEnabledDurumu;
            btnYeni.Enabled = !butonEnabledDurumu;
        }

        public static void ButtonEnabledDurumu(BarButtonItem btnYeni, BarButtonItem btnKaydet, BarButtonItem btnGeriAl, BarButtonItem btnSil)
        {

            btnKaydet.Enabled = false;
            btnGeriAl.Enabled = false;
            btnSil.Enabled = false;
            btnYeni.Enabled = false;
        }

        public static void ButtonEnabledDurumu<T>(BarButtonItem btnYeni, BarButtonItem btnKaydet, BarButtonItem btnGeriAl, BarButtonItem btnSil, T oldEntity, T currentEntity, bool tableValueChanged)
        {
            var veriDegisimYeri = tableValueChanged ? VeriDegisimYeri.Tablo : VeriDegisimYeriGetir(oldEntity, currentEntity);
            var butonEnabledDurumu = veriDegisimYeri == VeriDegisimYeri.Alan || veriDegisimYeri == VeriDegisimYeri.Tablo; //veridegisimyeri alan gelirse otomatik olarak true olucak
            btnKaydet.Enabled = butonEnabledDurumu;
            btnGeriAl.Enabled = butonEnabledDurumu;
            btnSil.Enabled = !butonEnabledDurumu;
            btnYeni.Enabled = !butonEnabledDurumu;
        }

        public static void ButtonEnabledDurumu<T>(BarButtonItem btnKaydet, BarButtonItem btnFarkliKaydet, BarButtonItem btnSil, IslemTuru islemTuru, T oldEntity, T currentEntity)
        {
            var veriDegisimYeri = VeriDegisimYeriGetir(oldEntity, currentEntity);
            var butonEnabledDurumu = veriDegisimYeri == VeriDegisimYeri.Alan; //veridegisimyeri alan gelirse otomatik olarak true olucak

            btnKaydet.Enabled = butonEnabledDurumu;
            btnFarkliKaydet.Enabled = islemTuru != IslemTuru.EntityInsert;
            btnSil.Enabled = !butonEnabledDurumu;
        }

        public static void ButtonEnabledDurumu(BarButtonItem btnKaydet, BarButtonItem btnGeriAl, bool tableValueChanged)
        {
            var butonEnabledDurumu = tableValueChanged;
            btnKaydet.Enabled = butonEnabledDurumu;
            btnGeriAl.Enabled = butonEnabledDurumu;
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
            tablo.Focus();
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

        public static void RefleshDataSource(this GridView tablo)
        {
            var source = tablo.DataController.ListSource.Cast<IBaseHareketEntity>().ToList();
            if (!source.Any(x => x.Delete)) return;

            var rowHandle = tablo.FocusedRowHandle;
            tablo.CustomRowFilter += Tablo_CustomRowFilter;
            tablo.RefreshData();
            tablo.CustomRowFilter -= Tablo_CustomRowFilter;


            tablo.RowFocus(rowHandle);
            void Tablo_CustomRowFilter(object sender, RowFilterEventArgs e)
            {
                var entity = source[e.ListSourceRow];
                if (entity == null) return;

                if (!entity.Delete) return;

                e.Visible = false;
                e.Handled = true;
            }
        }

        public static BindingList<T> ToBindingList<T>(this IEnumerable<BaseHareketEntity> list)
        {
            return new BindingList<T>((IList<T>)list);
        }

        public static BaseTablo AddTable(this BaseTablo tablo, BaseEditForm frm)
        {
            tablo.Dock = DockStyle.Fill;
            tablo.OwnerForm = frm;
            return tablo;
        }

        public static void LayoutControlInsert(this LayoutGroup grup, Control control, int columnIndex, int rowIndex, int columnSpan, int rowSpan)
        {
            var item = new LayoutControlItem
            {
                Control = control,
                Parent = grup
            };
            item.OptionsTableLayoutItem.ColumnIndex = columnIndex;
            item.OptionsTableLayoutItem.RowIndex = rowIndex;
            item.OptionsTableLayoutItem.ColumnSpan = columnSpan;
            item.OptionsTableLayoutItem.RowSpan = rowSpan;
        }

        public static void RowCellEnabled(this GridView tablo)
        {
            var rowHandle = tablo.FocusedRowHandle;

            tablo.FocusedRowHandle = 0;
            tablo.ClearSelection();

            tablo.FocusedRowHandle = rowHandle;
        }

        public static void CreateDropDownMenu(this BarButtonItem baseButton, BarItem[] buttonItems)
        {
            baseButton.ButtonStyle = BarButtonStyle.CheckDropDown;
            var popUpMenu = new PopupMenu();
            buttonItems.ForEach(x => x.Visibility = BarItemVisibility.Always);
            popUpMenu.ItemLinks.AddRange(buttonItems);
            baseButton.DropDownControl = popUpMenu;
        }

        public static MyXtraReport StreamToReport(this MemoryStream stream)
        {
            return (MyXtraReport)XtraReport.FromStream(stream, true);
        }

        public static MemoryStream ByteToStream(this byte[] report)
        {
            return new MemoryStream(report);
        }

        public static MemoryStream ReportToStream(this XtraReport rapor)
        {
            var stream = new MemoryStream();
            rapor.SaveLayout(stream);
            return stream;
        }

        public static IEnumerable<T> CheckedComboBoxList<T>(this MyCheckedComboBoxEdit comboBox)
        {
            return comboBox.Properties.Items.Where(x => x.CheckState == CheckState.Checked).Select(x => (T)x.Value);
        }

        public static void AppSettingsWrite(string key, string value)
        {
            var configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            configuration.AppSettings.Settings[key].Value = value;
            configuration.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }

        public static void CreateConnectionString(string initialCatalog, string server, SecureString kullaniciAdi, SecureString sifre, YetkilendirmeTuru yetkilendirmeTuru)
        {
            SqlConnectionStringBuilder builder = null;
            switch (yetkilendirmeTuru)
            {
                case YetkilendirmeTuru.SqlServer:
                    builder = new SqlConnectionStringBuilder
                    {
                        DataSource = server,
                        UserID = kullaniciAdi.ConvertToUnSecureString(),
                        Password = sifre.ConvertToUnSecureString(),
                        InitialCatalog = initialCatalog,
                        MultipleActiveResultSets = true,
                    };
                    break;
                case YetkilendirmeTuru.Windows:
                    builder = new SqlConnectionStringBuilder
                    {
                        DataSource = server,
                        InitialCatalog = initialCatalog,
                        MultipleActiveResultSets = true,
                        IntegratedSecurity = true
                    };
                    break;
            }
            var configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            configuration.ConnectionStrings.ConnectionStrings["OgrenciTakipContext"].ConnectionString = builder?.ConnectionString;
            configuration.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.GetSection("connectionStrings");
            Settings.Default.Reset();
            Settings.Default.Save();
        }

        public static string ConvertToUnSecureString(this SecureString value)
        {
            var result = Marshal.SecureStringToBSTR(value);
            return Marshal.PtrToStringAuto(result);
        }

        public static SecureString ConvertToSecureString(this string value)
        {
            var secureString = new SecureString();
            if (value.Length > 0)
            {
                value.ToCharArray().ForEach(x => secureString.AppendChar(x));
            }
            secureString.MakeReadOnly();
            return secureString;    
        }

        public static bool BaglantiKontrolu(string server, SecureString kullaniciAdi, SecureString sifre, YetkilendirmeTuru yetkilendirmeTuru, bool genelMesajVer = false)
        {
            CreateConnectionString("", server, kullaniciAdi, sifre, yetkilendirmeTuru);

            using (var con = new SqlConnection(BLL.Functions.GeneralFunctions.GetConnectionString()))
            {
                try
                {
                    if (con.ConnectionString == "") return false;
                    con.Open();
                    return true;
                }
                catch (SqlException ex)
                {
                    if (genelMesajVer)
                    {
                        Messages.HataMesaji("Server Bağlantı Ayarları Hatalıdır. Lütfen Kontrol Ediniz.");
                        return false;
                    }
                    switch (ex.Number)
                    {
                        case 18456:
                            Messages.HataMesaji("Server Kullanıcı Adı veya Şifresi Hatalıdır.");
                            break;
                        default:
                            Messages.HataMesaji(ex.Message);
                            break;
                    }
                }
                return false;
               
            }

        }
    }
}

