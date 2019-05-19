
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using OgrenciTakip.BLL.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Common.Message;
using OgrenciTakip.Model.DTO;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;
using System.Windows.Forms;
using System.Security;

namespace OgrenciTakip.UI.Win.Forms.KullaniciForms
{
    public partial class KullaniciEditForm : BaseEditForm
    {
        #region Variables
        private string _sifre;
        private string _gizliKelime;
        private SecureString _secureSifre;
        private SecureString _secureGizliKelime;
        private bool _tekrarGonder;
        #endregion

        public KullaniciEditForm()
        {
            InitializeComponent();

            dataLayoutControl = myDataLayoutControl;
            bll = new KullaniciBll(myDataLayoutControl);
            kartTuru = KartTuru.Kullanici;
            ShowItems = new BarItem[] { btnSifreSifirla };

            EventsLoad();
        }

        protected internal override void Yukle()
        {
            oldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new KullaniciS() : ((KullaniciBll)bll).Single(FilterFunctions.Filter<Kullanici>(id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            id = BaseIslemTuru.IdOlustur(oldEntity);
            txtKullaniciAdi.Text = "Yeni Kullanıcı";
            btnSifreSifirla.Enabled = false;
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (KullaniciS)oldEntity;
            txtKullaniciAdi.Text = entity.Kod;
            txtAdi.Text = entity.Adi;
            txtSoyadi.Text = entity.Soyadi;
            txtEmail.Text = entity.Email;
            txtRol.Id = entity.RolId;
            txtRol.Text = entity.RolAdi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            currentEnttiy = new Kullanici
            {
                Id = id,
                Kod = txtKullaniciAdi.Text,
                Adi = txtAdi.Text,
                Soyadi = txtSoyadi.Text,
                Email = txtEmail.Text,
                Sifre = _sifre,
                GizliKelime = _gizliKelime,
                RolId = (long)txtRol.Id,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn
            };

            ButonEnabledDurumu();
        }

        protected override bool EntityInsert()
        {
            SifreUret();
            var result = base.EntityInsert();

            if (result)
                txtKullaniciAdi.Text.SifreMailiGonder(txtRol.Text, txtEmail.Text, _secureSifre, _secureGizliKelime);
            return result;
        }

        protected override bool EntityUpdate()
        {
            var result = base.EntityUpdate();

            if (_tekrarGonder)
                txtKullaniciAdi.Text.SifreMailiGonder(txtRol.Text, txtEmail.Text, _secureSifre, _secureGizliKelime);
            return result;
        }

        private void SifreUret()
        {
            var result = GeneralFunctions.SifreUret();

            _sifre = result.sifre;
            _gizliKelime = result.gizliKelime;
            _secureSifre = result.secureSifre;
            _secureGizliKelime = result.secureGizliKelime;

            GuncelNesneOlustur();
        }

        protected override void SifreSifirla()
        {
            if (Messages.EmailGonderimOnayı() != DialogResult.Yes) return;
            _tekrarGonder = true;
            SifreUret();
            btnKaydet.PerformClick();
        }

        protected override void SecimYap(object sender)
        {
            if (!(sender is ButtonEdit)) return;
            using (var sec = new SelectFunctions())
            {
                if (sender == txtRol)
                    sec.Sec(txtRol);
            }
        }
    }
}