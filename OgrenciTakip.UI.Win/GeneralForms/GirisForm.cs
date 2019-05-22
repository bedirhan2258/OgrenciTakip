
using DevExpress.XtraEditors;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Common.Functions;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.UserControls.Controls;
using System.Configuration;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace OgrenciTakip.UI.Win.GeneralForms
{
    public partial class GirisForm : XtraForm
    {

        #region Variables
        private Point _mouseLocation;
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

            if (!GeneralFunctions.BaglantiKontrolu(server, kullaniciAdi, sifre, yetkilendirmeTuru, true))
            {
                txtKurum.Properties.DataSource = null; //devredışı bırakılarak çalıştırılacak.
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
                    break;
            }

        }

        private void GirisForm_Shown(object sender, System.EventArgs e)
        {
            txtKullaniciAdi.Focus();
        }

        private void GirisForm_Load(object sender, System.EventArgs e)
        {
            //splash yazılcak
            Yukle();
        }

    }
}