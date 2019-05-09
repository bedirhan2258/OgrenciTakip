using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using OgrenciTakip.Common.Enums;
using System.Windows.Forms;
using System.Security;
using OgrenciTakip.BLL.General;
using OgrenciTakip.Common.Message;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.Model.Entities.Base;
using OgrenciTakip.Data.Context;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.GeneralForms;
using OgrenciTakip.UI.Yonetim.Show;

namespace OgrenciTakip.UI.Yonetim.GeneralForms
{
    public partial class AnaForm : RibbonForm
    {
        #region Variables
        private readonly string _server;
        private readonly SecureString _kullaniciAdi;
        private readonly SecureString _sifre;
        private readonly YetkilendirmeTuru _yetkilendirmeTuru;
        private readonly KurumBll _bll;

        #endregion

        public AnaForm(params object[] prm)
        {
            InitializeComponent();
            longNavigator.Navigator.NavigatableControl = tablo.GridControl;
            EventsLoad();
            ButtonEnabledDurumu();

            _server = prm[0].ToString();
            _kullaniciAdi = (SecureString)prm[1];
            _sifre = (SecureString)prm[2];
            _yetkilendirmeTuru = (YetkilendirmeTuru)prm[3];
            _bll = new KurumBll();
        }

        private void EventsLoad()
        {
            //Button Events
            foreach (BarItem button in ribbonControl.Items)
            {
                button.ItemClick += Button_ItemClick;
            }

            //Table Events
            tablo.DoubleClick += Tablo_DoubleClick;
            tablo.KeyDown += Tablo_KeyDown;
            tablo.MouseUp += Tablo_MouseUp;
            tablo.RowCountChanged += Tablo_RowCountChanged;

            //Forms Evnts
            FormClosing += AnaForm_FormClosing;
            Load += AnaForm_Load;
        }

        protected internal void Listele()
        {
            tablo.GridControl.DataSource = _bll.List(null);
        }

        protected virtual void ShowEditForm(long id)
        {
            Functions.GeneralFunctions.CreateConnectionString("OgrenciTakip2018_Yonetim", _server, _kullaniciAdi, _sifre, _yetkilendirmeTuru);
            var result = ShowEditForms<KurumEditForm>.ShowDialogEditForms(id, _server, _kullaniciAdi, _sifre, _yetkilendirmeTuru);
            if (result <= 0) return;
            Listele();
            tablo.RowFocus("Id", result);
        }

        private void ButtonEnabledDurumu()
        {
            foreach (BarItem button in ribbonControl.Items)
            {
                if (!(button is BarButtonItem item)) continue;
                if (item != btnYeni)
                    item.Enabled = tablo.DataRowCount > 0;
            }
        }

        private void EntityDelete(BaseEntity entity)
        {
            Functions.GeneralFunctions.CreateConnectionString(entity.Kod, _server, _kullaniciAdi, _sifre, _yetkilendirmeTuru);
            if (!Functions.GeneralFunctions.DeleteDatabase<OgrenciTakipYonetimContext>()) return;

            Functions.GeneralFunctions.CreateConnectionString("OgrenciTakip2018_Yonetim", _server, _kullaniciAdi, _sifre, _yetkilendirmeTuru);
            _bll.Delete(entity);
            tablo.DeleteSelectedRows();
            tablo.RowFocus(tablo.FocusedRowHandle);
        }

        private void Button_ItemClick(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (e.Item == btnYeni || e.Item == btnDuzelt)
            {
                if (e.Item == btnYeni)
                {
                    ShowEditForm(-1);
                }

                else if (e.Item == btnDuzelt)
                {
                    ShowEditForm(tablo.GetRowId());
                }
            }

            else
            {
                var entity = tablo.GetRow<Kurum>();
                if (entity == null) return;
                Functions.GeneralFunctions.CreateConnectionString(entity.Kod, _server, _kullaniciAdi, _sifre, _yetkilendirmeTuru);

                if (e.Item == btnSil)
                {
                    EntityDelete(entity);
                }
                else if (e.Item == btnEmailParametreleri)
                {
                    Win.Show.ShowEditForms<EmailParametreEditForm>.ShowDialogEditForms();
                }
            }

            Cursor.Current = DefaultCursor;
        }

        private void Tablo_DoubleClick(object sender, System.EventArgs e)
        {
            if (tablo.FocusedRowHandle < 0) return;
            ShowEditForm(tablo.GetRowId());
        }

        private void Tablo_KeyDown(object sender, KeyEventArgs e)
        {
            if (tablo.FocusedRowHandle < 0) return;

            switch (e.KeyCode)
            {
                case Keys.Enter:
                    ShowEditForm(tablo.GetRowId());
                    break;
                case Keys.Escape:
                    Close();
                    break;
            }
        }

        private void Tablo_MouseUp(object sender, MouseEventArgs e)
        {
            e.SagMenuGoster(sagMenu);
        }

        private void Tablo_RowCountChanged(object sender, System.EventArgs e)
        {
            ButtonEnabledDurumu();
        }

        private void AnaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Messages.HayirSeciliEvetHayir("Programdan Çıkmak İstiyor Musunuz?", "Çıkış Onay") == DialogResult.Yes)
                Application.ExitThread();
            else
                e.Cancel = true;
        }

        private void AnaForm_Load(object sender, System.EventArgs e)
        {
            Listele();
            tablo.Focus();
        }

    }
}