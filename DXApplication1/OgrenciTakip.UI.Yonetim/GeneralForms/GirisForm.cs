
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting.Native;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Common.Functions;
using OgrenciTakip.Data.Context;
using OgrenciTakip.UI.Win.Functions;
//using OgrenciTakip.UI.Yonetim.Functions;
using OgrenciTakip.UI.Win.Show;
using OgrenciTakip.UI.Yonetim.Functions;
using OgrenciTakip.UI.Yonetim.UserControls.Controls;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace OgrenciTakip.UI.Yonetim.GeneralForms
{
    public partial class GirisForm : XtraForm
    {
        private Point _mouseLocation;

        public GirisForm()
        {
            InitializeComponent();
            txtYetkilendirme.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<YetkilendirmeTuru>());
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
                        case MyComboBoxEdit edit:
                            edit.SelectedValueChanged += Control_SelectedValueChanged;
                            break;
                    }
                }
            }

            //Form Events
            Shown += GirisForm_Shown;
        }

        private void Yukle()
        {
            txtVersiyon.Text = $"Versiyon : {Assembly.GetExecutingAssembly().GetName().Version}";
            var connectionstringArray = BLL.Functions.GeneralFunctions.GetConnectionString().Split(';');
            var dictionary = new Dictionary<string, string>();
            connectionstringArray.ForEach(x =>
            {
                var row = x.Split('=');
                dictionary.Add(row[0], row[1]);
            });
            txtServer.Text = dictionary.GetValueOrDefault("Data Source", "");
            txtYetkilendirme.SelectedItem = dictionary.ContainsKey("Password") ? YetkilendirmeTuru.SqlServer.ToName() : YetkilendirmeTuru.Windows.ToName();
            if (txtYetkilendirme.Text.GetEnum<YetkilendirmeTuru>() == YetkilendirmeTuru.SqlServer)
                txtKullaniciAdi.Focus();
            else
                txtSifre.Focus();
        }

        private void Giris()
        {
           if (!YonetimGeneralFunctions.BaglantiKontrolu(txtServer.Text, txtKullaniciAdi.Text.ConvertToSecureString(), txtSifre.Text.ConvertToSecureString(), txtYetkilendirme.Text.GetEnum<YetkilendirmeTuru>())) return;

            YonetimGeneralFunctions.CreateConnectionString("OgrenciTakip2018_Yonetim", txtServer.Text, txtKullaniciAdi.Text.ConvertToSecureString(), txtSifre.Text.ConvertToSecureString(), txtYetkilendirme.Text.GetEnum<YetkilendirmeTuru>());

            if (!YonetimGeneralFunctions.CreateDatabase<OgrenciTakipYonetimContext>("Lütfen Bekleyiniz", "Program İlk Kurulum İçin Hazırlanıyor...", "Program İlk Kurulum İşlemi Yapılacaktır. Onaylıyor Musunuz?", "İlk Kurulum İşlemi Başarılı Bir Şekilde Tamamlandı.")) return;
            Hide();

            ShowRibbonForms<AnaForm>.ShowForm(false, txtServer.Text, txtKullaniciAdi.Text.ConvertToSecureString(), txtSifre.Text.ConvertToSecureString(), txtYetkilendirme.Text.GetEnum<YetkilendirmeTuru>());
            txtKullaniciAdi.Text = "";
            txtSifre.Text = "";
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
            if (!(sender is MySimpleButton button)) return;

            if (button == btnGiris)
                Giris();
            else if (button == btnVazgec)
                Close();
        }

        private void Control_SelectedValueChanged(object sender, System.EventArgs e)
        {
            if (!(sender is ComboBoxEdit edit)) return;
            var yetkilendirmeTuru = edit.Text.GetEnum<YetkilendirmeTuru>();

            txtKullaniciAdi.Enabled = yetkilendirmeTuru == YetkilendirmeTuru.SqlServer;
            txtSifre.Enabled = yetkilendirmeTuru == YetkilendirmeTuru.SqlServer;
            txtKullaniciAdi.Focus();

            if (yetkilendirmeTuru != YetkilendirmeTuru.Windows) return;
            txtKullaniciAdi.Text = "";
            txtSifre.Text = "";
        }

        private void GirisForm_Shown(object sender, System.EventArgs e)
        {
            Yukle();
        }

    }
}