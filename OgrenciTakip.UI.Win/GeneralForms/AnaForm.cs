using DevExpress.XtraBars;
using OgrenciTakip.UI.Win.Forms.SchoolForms;
using OgrenciTakip.UI.Win.Show;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.UI.Win.Forms.IlForms;
using OgrenciTakip.UI.Win.Forms;
using OgrenciTakip.UI.Win.IptalNedeniForms;
using OgrenciTakip.UI.Win.Forms.YabanciDilForms;
using OgrenciTakip.UI.Win.Forms.TesvikForms;
using OgrenciTakip.UI.Win.Forms.KontenjanForms;
using OgrenciTakip.UI.Win.Forms.RehberForms;
using OgrenciTakip.UI.Win.Forms.SinifGrupForms;
using OgrenciTakip.UI.Win.Forms.MeslekForms;
using OgrenciTakip.UI.Win.Forms.YakinlikForms;
using OgrenciTakip.UI.Win.Forms.IsyeriForms;
using OgrenciTakip.UI.Win.Forms.GorevForms;
using OgrenciTakip.UI.Win.Forms.IndirimTuruForms;
using OgrenciTakip.UI.Win.Forms.EvrakForms;
using OgrenciTakip.UI.Win.Forms.PromosyonForms;
using OgrenciTakip.UI.Win.Forms.ServisForms;
using OgrenciTakip.UI.Win.Forms.SinifForms;
using OgrenciTakip.UI.Win.Forms.HizmetTuruForms;
using System;
using OgrenciTakip.UI.Win.Forms.HizmetForms;
using OgrenciTakip.UI.Win.Forms.KasaForms;
using OgrenciTakip.UI.Win.Forms.BankaForms;
using OgrenciTakip.UI.Win.Forms.AvukatForms;
using OgrenciTakip.UI.Win.Forms.CariForms;
using OgrenciTakip.UI.Win.Forms.OdemeTuruForms;
using OgrenciTakip.UI.Win.Forms.BankaHesapForms;
using OgrenciTakip.UI.Win.Forms.IletisimForms;
using OgrenciTakip.UI.Win.Forms.OgrenciForms;
using OgrenciTakip.UI.Win.Forms.IndirimForms;
using OgrenciTakip.UI.Win.Forms.TahakkukForms;
using OgrenciTakip.UI.Win.Forms.MakbuzForms;
using OgrenciTakip.UI.Win.Forms.SubeForms;
using OgrenciTakip.UI.Win.Forms.FaturaForms;
using System.Collections.Generic;
using OgrenciTakip.UI.Win.Reports.FormReports;
using DevExpress.XtraBars.Ribbon;

namespace OgrenciTakip.UI.Win.GeneralForms
{
    public partial class AnaForm : RibbonForm
    {
        public static long DonemId = 1;
        public static string DonemAdi = "Dönem Bilgisi Bekleniyor...";

        public static long SubeId = 1;
        public static string SubeAdi = "Şube Bilgisi Bekleniyor...";

        public static DateTime EgitimBaslamaTarihi = new DateTime(2017, 09, 15);
        public static DateTime DonemBaslamaTarihi = new DateTime(2017, 07, 01);
        public static DateTime DonemBitisTarihi = new DateTime(2018, 06, 30);
        public static bool GunTarihininOncesineHizmetBaslamaTarihiGirilebilir = true;
        public static bool GunTarihininSonrasinaHizmetBaslamaTarihiGirilebilir = true;
        public static bool GunTarihininOncesineIptalTarihiGirilebilir = true;
        public static bool GunTarihininSonrasinaIptalTarihiGirilebilir = true;
        public static bool GunTarihininOncesineMakbuzTarihiGirilebilir = true;
        public static bool GunTarihininSonrasinaMakbuzTarihiGirilebilir = true;
        public static bool HizmetTahakkukKurusKullan;
        public static bool IndirimTahakkukKurusKullan;
        public static bool OdemePlaniKurusKullan;
        public static bool FaturaTahakkukKurusKullan;
        public static bool GittigiOkulZorunlu = true;
        public static DateTime MaksimumTaksitTarihi = new DateTime(2018, 06, 30);
        public static byte MaksimumTaksitSayisi = 12;
        public static long? DefaultKasaHesapId;
        public static string DefaultKasaHesapAdi;
        public static long? DefaultBankaHesapId;
        public static string DefaultBankaHesapAdi;
        public static long? DefaultAvukatHesapId;
        public static string DefaultAvukatHesapAdi;
        public static long KullaniciId = 1;
        public static bool RaporlariOnayAlmadanKapat = false;
        public static List<long> YetkiliOlunanSubeler = new List<long> { 1, 2019031701050868106 };

        public AnaForm()
        {
            InitializeComponent();
            EventsLoad();
        }
        private void EventsLoad()
        {
            foreach (var item in ribbonControl.Items)
            {
                switch (item)
                {
                    case BarButtonItem btn:
                        btn.ItemClick += Butonlar_ItemClick;
                        break;

                }
            }
        }

        private void Butonlar_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (e.Item == btnOkulKartlari)
            {
                ShowListForms<OkulListForm>.ShowListForm(KartTuru.Okul);
            }
            else if (e.Item == btnIlKartlari)
            {
                ShowListForms<IlListForm>.ShowListForm(KartTuru.Il);
            }
            else if (e.Item == btnAileBilgiKartlari)
            {
                ShowListForms<AileBilgiListForm>.ShowListForm(KartTuru.AileBilgi);
            }
            else if (e.Item == btnIptalNedeniKartlari)
            {
                ShowListForms<IptalNedeniListForm>.ShowListForm(KartTuru.IptalNedeni);
            }
            else if (e.Item == btnYabanciDilKartlari)
            {
                ShowListForms<YabanciDilListForm>.ShowListForm(KartTuru.YabanciDil);
            }
            else if (e.Item == btnTesvikKartlari)
            {
                ShowListForms<TesvikListForm>.ShowListForm(KartTuru.Tesvik);
            }
            else if (e.Item == btnKontenjanKartlari)
            {
                ShowListForms<KontenjanListForm>.ShowListForm(KartTuru.Kontenjan);
            }
            else if (e.Item == btnRehberKartlari)
            {
                ShowListForms<RehberListForm>.ShowListForm(KartTuru.Rehber);
            }
            else if (e.Item == btnSinifGrupKartlari)
            {
                ShowListForms<SinifGrupListForm>.ShowListForm(KartTuru.SinifGrup);
            }
            else if (e.Item == btnMeslekKartlari)
            {
                ShowListForms<MeslekListForm>.ShowListForm(KartTuru.Meslek);
            }
            else if (e.Item == btnYakinlikKarti)
            {
                ShowListForms<YakinlikListForm>.ShowListForm(KartTuru.Yakinlik);
            }
            else if (e.Item == btnIsyeriKarti)
            {
                ShowListForms<IsyeriListForm>.ShowListForm(KartTuru.Isyeri);
            }
            else if (e.Item == btnGorevKarti)
            {
                ShowListForms<GorevListForm>.ShowListForm(KartTuru.Gorev);
            }
            else if (e.Item == btnIndirimTuruKarti)
            {
                ShowListForms<IndirimTuruListForm>.ShowListForm(KartTuru.IndirimTuru);
            }
            else if (e.Item == btnEvrakKarti)
            {
                ShowListForms<EvrakListForm>.ShowListForm(KartTuru.Evrak);
            }
            else if (e.Item == btnPromosyonKarti)
            {
                ShowListForms<PromosyonListForm>.ShowListForm(KartTuru.Promosyon);
            }
            else if (e.Item == btnServisKarti)
            {
                ShowListForms<ServisListForm>.ShowListForm(KartTuru.Servis);
            }
            else if (e.Item == btnSinifKarti)
            {
                ShowListForms<SinifListForm>.ShowListForm(KartTuru.Sinif);
            }
            else if (e.Item == btnHizmetTuruKarti)
            {
                ShowListForms<HizmetTuruListForm>.ShowListForm(KartTuru.HizmetTuru);
            }
            else if (e.Item == btnHizmetKarti)
            {
                ShowListForms<HizmetListForm>.ShowListForm(KartTuru.Hizmet);
            }
            else if (e.Item == btnKasaKarti)
            {
                ShowListForms<KasaListForm>.ShowListForm(KartTuru.Kasa);
            }
            else if (e.Item == btnBankaKarti)
            {
                ShowListForms<BankaListForm>.ShowListForm(KartTuru.Banka);
            }
            else if (e.Item == btnAvukatKarti)
            {
                ShowListForms<AvukatListForm>.ShowListForm(KartTuru.Avukat);
            }
            else if (e.Item == btnCariKart)
            {
                ShowListForms<CariListForm>.ShowListForm(KartTuru.Cari);
            }
            else if (e.Item == btnOdemeTuruKarti)
            {
                ShowListForms<OdemeTuruListForm>.ShowListForm(KartTuru.OdemeTuru);
            }
            else if (e.Item == btnBankaHesapKarti)
            {
                ShowListForms<BankaHesapListForm>.ShowListForm(KartTuru.BankaHesap);
            }
            else if (e.Item == btnIletisimKarti)
            {
                ShowListForms<IletisimListForm>.ShowListForm(KartTuru.Iletisim);
            }
            else if (e.Item == btnOgrenciKarti)
            {
                ShowListForms<OgrenciListForm>.ShowListForm(KartTuru.Ogrenci);
            }
            else if (e.Item == btnIndirimKarti)
            {
                ShowListForms<IndirimListForm>.ShowListForm(KartTuru.Indirim);
            }
            else if (e.Item == btnTahakkukKarti)
            {
                ShowListForms<TahakkukListForm>.ShowListForm(KartTuru.Tahakkuk);
            }
            else if (e.Item == btnMakbuzKarti)
            {
                ShowListForms<MakbuzListForm>.ShowListForm(KartTuru.Makbuz);
            }
            else if (e.Item == btnSubeKartlari)
            {
                ShowListForms<SubeListForm>.ShowListForm(KartTuru.Sube);
            }
            else if (e.Item == btnFaturaKartlari)
            {
                ShowListForms<FaturaPlaniListForm>.ShowListForm(KartTuru.Fatura);
            }
            else if (e.Item == btnFaturaTahakkukKarti)
            {
                ShowEditForms<FaturaTahakkukEditForm>.ShowDialogEditForms(KartTuru.Fatura);
            }

            else if (e.Item == btnGenelAmacliRapor)
            {
                ShowEditReports<GenelAmacliRapor>.ShowEditReport(KartTuru.GenelAmacliRapor);
            }

            else if (e.Item == btnSinifRaporlari)
            {
                ShowEditReports<SinifRaporlari>.ShowEditReport(KartTuru.SinifRaporlari);
            }

            else if (e.Item == btnHizmetAlimRaporu)
            {
                ShowEditReports<HizmetAlimRaporu>.ShowEditReport(KartTuru.HizmetAlimRaporu);
            }

            else if (e.Item == btnNetUcretRaporu)
            {
                ShowEditReports<NetUcretRaporu>.ShowEditReport(KartTuru.NetUcretRaporu);
            }

            else if (e.Item == btnUcretVeOdemeRaporu)
            {
                ShowEditReports<NetUcretRaporu>.ShowEditReport(KartTuru.UcretveOdemeRaporu);
            }

            else if (e.Item == btnIndirimDagilimRaporu)
            {
                ShowEditReports<IndirimDagilimRaporu>.ShowEditReport(KartTuru.IndirimDagilimRaporu);
            }

            else if (e.Item == btnMesleklereGoreKayitRaporu)
            {
                ShowEditReports<MesleklereGoreKayitRaporu>.ShowEditReport(KartTuru.MesleklereGoreKayitRaporu);
            }
        }
    }
}