
using DevExpress.XtraBars;
using OgrenciTakip.BLL.Functions;
using OgrenciTakip.BLL.General;
using OgrenciTakip.Common.Message;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.GeneralForms;
using System.Windows.Forms;

namespace OgrenciTakip.UI.Win.Forms.KullaniciForms
{
    public partial class SifreDegistirEditForm : BaseEditForm
    {
        public SifreDegistirEditForm()
        {
            InitializeComponent();

            dataLayoutControl = myDataLayoutControl;
            bll = new KullaniciBll(myDataLayoutControl);
            HideItems = new BarItem[] { btnYeni, btnGeriAl, btnSil, };
            EventsLoad();
        }

        private void SifreDegistir()
        {
            if (Messages.KayitMesaj() != DialogResult.Yes) return;
            var entity = ((KullaniciBll)bll).SingleDetail(x => x.Id == AnaForm.KullaniciId).EntityConvert<Kullanici>();
            if (entity == null) return;

            if (HataliGiris()) return;

            if (entity.Sifre == txtEskiSifre.Text.Md5Sifrele())
            {
                var currentEntity = new Kullanici
                {
                    Id = entity.Id,
                    Kod = entity.Kod,
                    Adi = entity.Adi,
                    Soyadi = entity.Soyadi,
                    Email = entity.Email,
                    RolId = entity.RolId,
                    Sifre = txtYeniSifre.Text.Md5Sifrele(),
                    GizliKelime = string.IsNullOrEmpty(txtGizliKelime.Text) ? entity.GizliKelime : txtGizliKelime.Text.Md5Sifrele(),
                    Aciklama = entity.Aciklama,
                    Durum = entity.Durum
                };

                if (!((KullaniciBll)bll).Update(entity, currentEntity)) return;
                Messages.BilgiMesaji("Şifreniz Başarılı Bir Şekilde Değiştirilmiştir.");
                Close();
            }

            else
            {
                Messages.HataMesaji("Girilen Eski Şifre Bilgisi Hatalıdır. Lütfen Kontrol Edip Tekrar Deneyiniz.");
                txtEskiSifre.Focus();
            }

        }

        private bool HataliGiris()
        {
            if (txtYeniSifre.Text != txtYeniSifreTekrar.Text)
            {
                Messages.HataMesaji("Girilen Yeni Şifre, Yeni Şifre Tekrarıyla Uyuşmamaktadır.");
                txtYeniSifre.Focus();
                return true;
            }

            if (txtYeniSifre.Text.Length < 6)
            {
                Messages.HataMesaji("Girilen Yeni Şifrenin Uzunluğu En Az 6 Karakter Olmalıdır.");
                txtYeniSifre.Focus();
                return true;
            }

            if (string.IsNullOrEmpty(txtGizliKelime.Text) && txtGizliKelime.Text.Length < 10)
            {
                Messages.HataMesaji("Girilen Gizli Kelimenin Uzunluğu En Az 10 Karakter Olmalıdır.");
                txtGizliKelime.Focus();
                return true;
            }
            return false;
        }

        protected override void Button_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (e.Item == btnKaydet)
            {
                SifreDegistir();
            }

            else if (e.Item == btnCikis)
            {
                Close();
            }
        }

        //Kaydet Butonunun Enable Durumunun Pasif Olması  İçin Yazıldı.
        protected override void BaseEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SablonKaydet();
        }
    }
}