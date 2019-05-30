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
using OgrenciTakip.UI.Win.Forms.FaturaForms;
using System.Collections.Generic;
using OgrenciTakip.UI.Win.Reports.FormReports;
using DevExpress.XtraBars.Ribbon;
using OgrenciTakip.UI.Win.Reports;
using OgrenciTakip.Model.Entities;
using DevExpress.XtraBars.Ribbon.Gallery;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.Model.DTO;
using DevExpress.XtraTabbedMdi;
using OgrenciTakip.Common.Message;
using System.Windows.Forms;
using System.Diagnostics;
using OgrenciTakip.BLL.General;
using OgrenciTakip.BLL.Functions;
using OgrenciTakip.UI.Win.Forms.KullaniciForms;

namespace OgrenciTakip.UI.Win.GeneralForms
{
    public partial class AnaForm : RibbonForm
    {
        public static string KurumAdi;
        public static long KullaniciId;
        public static string KullaniciAdi;
        public static long KullaniciRolId;
        public static string KullaniciRolAdi;

        public static long DonemId;
        public static string DonemAdi = "Dönem Bilgisi Bekleniyor...";
        public static long SubeId;
        public static string SubeAdi = "Şube Bilgisi Bekleniyor...";
        public static List<long> YetkiliOlunanSubeler;
        public static DonemParametre DonemParametreleri;
        public static KullaniciParametreS KullaniciParametreleri = new KullaniciParametreS();
        public static IEnumerable<RolYetkileri> RolYetkileri;

        public AnaForm()
        {
            InitializeComponent();
            EventsLoad();

            imgArkaPlanResim.EditValue = KullaniciParametreleri.ArkaPlanResim;
        }
        private void EventsLoad()
        {
            Load += AnaForm_Load;
            FormClosing += AnaForm_FormClosing;
            KeyDown += Control_KeyDown;

            foreach (var item in ribbonControl.Items)
            {
                switch (item)
                {

                    case SkinRibbonGalleryBarItem btn:
                        btn.GalleryItemClick += GalleryItem_GalleryItemClick;
                        break;

                    case SkinPaletteRibbonGalleryBarItem btn:
                        btn.GalleryItemClick += GalleryItem_GalleryItemClick;
                        break;
                    case BarButtonItem btn:
                        btn.ItemClick += Butonlar_ItemClick;
                        break;
                }
            }

            foreach (Control control in Controls)
            {
                control.KeyDown += Control_KeyDown;
            }

            xtraTabbedMdiManager.PageAdded += XtraTabbedMdiManager_PageAdded;
            xtraTabbedMdiManager.PageRemoved += XtraTabbedMdiManager_PageRemoved;
        }

        private void SubeDonemSecimi(bool subeSecimButonunaBasildi)
        {
            ShowEditForms<SubeDonemSecimiEditForm>.ShowDialogEditForms(null, KullaniciId, subeSecimButonunaBasildi, SubeId, DonemId);
            barDonem.Caption = DonemAdi;
            btnSube.Caption = SubeAdi;
        }

        private void Control_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }

        private void AnaForm_Load(object sender, System.EventArgs e)
        {
            barKullanici.Caption = $"{KullaniciAdi} ( {KullaniciRolAdi} )";
            barKurum.Caption = KurumAdi;
            SubeDonemSecimi(false);

            if (DonemParametreleri == null)
            {
                Messages.HataMesaji("Dönem Parametreleri Girilmemiş. Lütfen Sistem Yöneticinize Başvurunuz.");
                Application.ExitThread();
                return;
            }

            if (!DonemParametreleri.YetkiKontroluAnlikYapilacak)
                using (var bll = new RolYetkileriBll())
                {
                    RolYetkileri = bll.List(x => x.RolId == KullaniciRolId).EntityListConvert<RolYetkileriL>();
                }
        }

        private void AnaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Messages.HayirSeciliEvetHayir("Programdan Çıkmak İstiyor Musunuz?", "Çıkış Onay") == DialogResult.Yes)
                Application.ExitThread();
            else
                e.Cancel = true;

        }

        private void GalleryItem_GalleryItemClick(object sender, GalleryItemClickEventArgs e)
        {
            var gallery = sender as InRibbonGallery;
            var key = "";

            if (gallery.OwnerItem.GetType() == typeof(SkinRibbonGalleryBarItem))
                key = "Skin";
            else if (gallery.OwnerItem.GetType() == typeof(SkinPaletteRibbonGalleryBarItem))
                key = "Palette";

            UI.Win.Functions.GeneralFunctions.AppSettingsWrite(key, e.Item.Caption);
        }

        private void Butonlar_ItemClick(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

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

            else if (e.Item == btnAylikKayitRaporu)
            {
                ShowEditReports<AylikKayitRaporu>.ShowEditReport(KartTuru.AylikKayitRaporu);
            }

            else if (e.Item == btnGelirDagilimRaporu)
            {
                ShowEditReports<GelirDagilimRaporu>.ShowEditReport(KartTuru.GelirDagilimRaporu);
            }

            else if (e.Item == btnUcretOrtalamalariRaporu)
            {
                ShowEditReports<UcretOrtalamalariRaporu>.ShowEditReport(KartTuru.UcretOrtalamalariRaporu);
            }

            else if (e.Item == btnOdemeBelgeleriRaporu)
            {
                ShowEditReports<OdemeBelgeleriRaporu>.ShowEditReport(KartTuru.OdemeBelgeleriRaporu);
            }

            else if (e.Item == btnTahsilatRaporu)
            {
                ShowEditReports<TahsilatRaporu>.ShowEditReport(KartTuru.TahsilatRaporu);
            }

            else if (e.Item == btnGecikenAlacaklarRaporu)
            {
                ShowEditReports<OdemesiGecikenAlacaklarRaporu>.ShowEditReport(KartTuru.OdemesiGecikenAlacaklarRaporu);
            }

            else if (e.Item == btnKullaniciParametreleri)
            {
                var entity = ShowEditForms<KullaniciParametreEditForm>.ShowDialogEditForms<KullaniciParametreS>(KullaniciId);
                if (entity == null) return;
                KullaniciParametreleri = entity;
                imgArkaPlanResim.EditValue = entity.ArkaPlanResim;
            }

            else if (e.Item == btnHesapMakinesi)
            {
                try
                {
                    Process.Start("calc.exe");
                }
                catch
                {
                    Messages.HataMesaji("Hesap Makinesi Bulunamadı.");
                }
            }

            else if (e.Item == btnSube)
            {
                for (int i = 0; i < Application.OpenForms.Count; i++)
                {
                    if (Application.OpenForms[i] is GirisForm || Application.OpenForms[i] is AnaForm) continue;
                    Application.OpenForms[i].Close();
                    i--;
                }
                SubeDonemSecimi(true);
            }

            else if (e.Item == btnSifreDegistir)
                ShowEditForms<SifreDegistirEditForm>.ShowDialogEditForms(IslemTuru.EntityUpdate);

            Cursor.Current = Cursors.Default;

        }

        private void XtraTabbedMdiManager_PageAdded(object sender, MdiTabPageEventArgs e)
        {
            imgArkaPlanResim.SendToBack();
        }

        private void XtraTabbedMdiManager_PageRemoved(object sender, MdiTabPageEventArgs e)
        {
            if (((XtraTabbedMdiManager)sender).Pages.Count == 0)
                imgArkaPlanResim.BringToFront();
        }

    }
}