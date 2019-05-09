
using DevExpress.Utils.Extensions;
using DevExpress.XtraSplashScreen;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Common.Message;
using OgrenciTakip.UI.Yonetim.GeneralForms;
using OgrenciTakip.UI.Yonetim.Properties;
using System.Configuration;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Security;
using System.Windows.Forms;

namespace OgrenciTakip.UI.Yonetim.Functions
{
    public static class GeneralFunctions
    {
        public static string GetConnectionString()
        {

            return ConfigurationManager.ConnectionStrings["OgrenciTakipContext"].ConnectionString;
        }

        public static bool CreateDatabase<TContext>(string splashCaption, string splashDescription, string onayMesaj, string bilgiMesaj) where TContext : DbContext, new()
        {
            using (var con = new TContext())
            {
                con.Database.Connection.ConnectionString = GetConnectionString();
                if (con.Database.Exists()) return true;
                if (Messages.EvetSeciliEvetHayir(onayMesaj, "Onay") != DialogResult.Yes) return false;
                var splashForm = new SplashScreenManager(Form.ActiveForm, typeof(BekleForm), true, true);
                SplashBaslat(splashForm);

                splashForm.SetWaitFormCaption(splashCaption);
                splashForm.SetWaitFormDescription(splashDescription);

                try
                {
                    if (con.Database.CreateIfNotExists())
                    {
                        SplashDurdur(splashForm);
                        Messages.BilgiMesaji(bilgiMesaj);
                        return true;
                    }
                }
                catch (SqlException ex)
                {
                    SplashDurdur(splashForm);

                    switch (ex.ErrorCode)
                    {
                        case 5170:
                            Messages.HataMesaji("Veritabanı Dosyalarının Yükleneceği Klasorder Aynı İsimde Zaten Bir Dosya Var. Lütfen Kontrol Ediniz.\n\n" + ex.Message);
                            break;
                        default:
                            Messages.HataMesaji(ex.Message);
                            break;
                    }
                    throw;
                }
                return false;
            }
        }

        public static bool DeleteDatabase<TContext>() where TContext : DbContext, new()
        {
            using (var con = new TContext())
            {
                con.Database.Connection.ConnectionString = GetConnectionString();
                if (Messages.HayirSeciliEvetHayir("Seçtiğiniz Kurum ve Kurum İşlemlerinin Tamamını İçeren Kurum Veritabanı (Veri Tabanı Dosyaları Dahil) Tamamen Silinecektir. Onaylıyor Musununuz?", "Silme Onay") != DialogResult.Yes) return false;

                if (Messages.HayirSeciliEvetHayir("Seçtiğiniz Kurum ve Kurum İşlemlerinin Tamamını İçeren Kurum Veritabanı (Veri Tabanı Dosyaları Dahil) Tamamen Silinecektir. Tekrar Onaylıyor Musununuz?", "Silme Onay") != DialogResult.Yes) return false;

                try
                {
                    if (con.Database.Delete())
                    {
                        Messages.BilgiMesaji("Kurum Silme İşlemi Başarılı Bir Şekilde Tamamlanmıştır.");
                        return true;
                    }
                }
                catch (SqlException ex)
                {
                    switch (ex.Number)
                    {
                        case 3702:
                            Messages.HataMesaji("Veri Tabanı Kullanımda Olduğu İçin Silinemedi. Lütfen Veritabanına Yapılan Tüm Bağlantıları Sonlandırdıktan Sonra Tekrar Deneyiniz.");
                            break;
                        default:
                            Messages.HataMesaji(ex.Message);
                            break;
                    }

                }
                return true;

            }
        }

        private static void SplashBaslat(SplashScreenManager manager)
        {
            if (manager.IsSplashFormVisible)
            {
                manager.CloseWaitForm();
                manager.ShowWaitForm();
            }
            else
                manager.ShowWaitForm();
        }

        private static void SplashDurdur(SplashScreenManager manager)
        {
            if (manager.IsSplashFormVisible)
                manager.CloseWaitForm();
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
            configuration.ConnectionStrings.ConnectionStrings["OgrenciTakipContext"].ConnectionString = builder.ConnectionString;
            configuration.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.GetSection("connectionStrings");
            ConfigurationManager.RefreshSection("connectionStrings");
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

            using (var con = new SqlConnection(GetConnectionString()))
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
