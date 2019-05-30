
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using OgrenciTakip.BLL.Functions;
using OgrenciTakip.BLL.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Common.Functions;
using OgrenciTakip.Common.Message;
using OgrenciTakip.Model.DTO;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.KullaniciForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.Show;
using OgrenciTakip.UI.Win.UserControls.Controls;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace OgrenciTakip.UI.Win.GeneralForms
{
    public partial class GirisForm : XtraForm
    {

        #region Variables
        private Point _mouseLocation;
        private List<Kurum> _source;
        #endregion

        public GirisForm()
        {
            InitializeComponent();
            EventsLoad();
        }

        private void EventsLoad()
        {
            //Control Events
            foreach (Control control in Controls)
            {
                if (!(control is MyDataLayoutControl)) continue;
                control.MouseDown += Control_MouseDown;
                control.MouseMove += Control_MouseMove;

                foreach (Control ctrl in control.Controls)
                {
                    ctrl.KeyDown += Control_KeyDown;

                    switch (ctrl)
                    {
                        case MySimpleButton btn:
                            btn.Click += Control_Click;
                            break;

                        case MyHyperLinkLabelControl hyp:
                            hyp.Click += Control_Click;
                            break;
                    }
                }
            }

            //Form Events
            Shown += GirisForm_Shown;
            Load += GirisForm_Load;
        }

        private void Yukle()
        {
            txtVersion.Text = $"Versiyon : {Assembly.GetExecutingAssembly().GetName().Version}";

            var server = ConfigurationManager.AppSettings["Server"];
            var yetkilendirmeTuru = ConfigurationManager.AppSettings["YetkilendirmeTuru"].GetEnum<YetkilendirmeTuru>();
            var kullaniciAdi = ConfigurationManager.AppSettings["KullaniciAdi"].ConvertToSecureString();
            var sifre = ConfigurationManager.AppSettings["Sifre"].ConvertToSecureString();

            if (!Functions.GeneralFunctions.BaglantiKontrolu(server, kullaniciAdi, sifre, yetkilendirmeTuru, true))
            {
                txtKurum.Properties.DataSource = null; //devredışı bırakılarak çalıştırılacak.
                if (ShowEditForms<BaglantiAyarlariEditForm>.ShowDialogEditForms(IslemTuru.EntityUpdate))
                    Yukle();
                return;
            }

            Functions.GeneralFunctions.CreateConnectionString("OgrenciTakip2018_Yonetim", server, kullaniciAdi, sifre, yetkilendirmeTuru);

            using (var bll = new KurumBll())
            {
                _source = bll.List(null).Cast<Kurum>().ToList();
                txtKurum.Properties.DataSource = _source;
                txtKurum.Properties.ValueMember = "Kod";
                txtKurum.Properties.DisplayMember = "KurumAdi";
                txtKurum.ItemIndex = 0;
            }
        }

        private void CreateConnection()
        {
            if (txtKurum.Text == "")
            {
                Messages.HataMesaji("Kurum Seçimi Yapmalısınız.");
                txtKurum.Focus();
                return;
            }
            var kurum = _source[txtKurum.ItemIndex];

            var kod = kurum.Kod;
            var server = kurum.Server;
            var yetkilendirmeTuru = kurum.YetkilendirmeTuru;
            var kullaniciAdi = kurum.KullaniciAdi.Decrypt(kurum.Id + kurum.Kod).ConvertToSecureString();
            var sifre = kurum.Sifre.Decrypt(kurum.Id + kurum.Kod).ConvertToSecureString();

            if (!Functions.GeneralFunctions.BaglantiKontrolu(server, kullaniciAdi, sifre, yetkilendirmeTuru)) return;
            Functions.GeneralFunctions.CreateConnectionString(kod, server, kullaniciAdi, sifre, yetkilendirmeTuru);
        }

        private void Giris()
        {
            CreateConnection();

            using (var kullaniciBll = new KullaniciBll())
            {
                var kullanici = (KullaniciS)kullaniciBll.SingleDetail(x => x.Kod == txtKullaniciAdi.Text);

                if (kullanici == null || txtSifre.Text.Md5Sifrele() != kullanici.Sifre)
                {
                    Messages.HataMesaji("Kullanıcı Adı veya Şifre Hatalıdır Lütfen Kontrol Edip Tekrar Deneyiniz.");
                    txtKullaniciAdi.Focus();
                    return;
                }

                if (!kullanici.Durum)

                {
                    Messages.HataMesaji("Pasif Durumdaki Kullanıcı İle Giriş Yapamazsınız.");
                    txtKullaniciAdi.Focus();
                    return;
                }

                using (var parametreBll = new KullaniciParametreBll())
                {
                    var entity = (KullaniciParametreS)parametreBll.Single(x => x.KullaniciId == kullanici.Id);
                    AnaForm.KullaniciParametreleri = entity ?? new KullaniciParametreS();

                    AnaForm.KurumAdi = txtKurum.Text;
                    AnaForm.KullaniciId = kullanici.Id;
                    AnaForm.KullaniciAdi = kullanici.Adi;
                    AnaForm.KullaniciRolId = kullanici.RolId;
                    AnaForm.KullaniciRolAdi = kullanici.RolAdi;
                    Hide();

                    ShowRibbonForms<AnaForm>.ShowForm(false);
                }
            }
        }

        private void Control_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseLocation = new Point(-e.X, -e.Y);
        }

        private void Control_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;

            var position = MousePosition;
            position.Offset(_mouseLocation.X, _mouseLocation.Y);
            Location = position;
        }

        private void Control_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) Close();
        }

        private void Control_Click(object sender, System.EventArgs e)
        {
            switch (sender)
            {
                case MySimpleButton btn:
                    if (btn == btnGiris)
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        Giris();
                        Cursor.Current = Cursors.Default;
                    }

                    else if (btn == btnVazgec)
                        Close();
                    break;

                case MyHyperLinkLabelControl hyp:
                    if (hyp == btnBaglantiAyarlari)
                    {
                        if (ShowEditForms<BaglantiAyarlariEditForm>.ShowDialogEditForms(IslemTuru.EntityUpdate))
                            Yukle();
                    }
                    else if (hyp == btnSifremiUnuttum)
                    {
                        CreateConnection();
                        ShowEditForms<SifremiUnuttumEditForm>.ShowDialogEditForms(IslemTuru.EntityUpdate, txtKullaniciAdi.Text);
                    }
                    break;
            }   

        }

        private void GirisForm_Shown(object sender, System.EventArgs e)
        {
            txtKullaniciAdi.Focus();
        }

        private void GirisForm_Load(object sender, System.EventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Baslatiliyor));
            Yukle();
            SplashScreenManager.CloseForm();
        }

    }
}