using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using OgrenciTakip.Common.Enums;
using System.Windows.Forms;
using System.Security;
using OgrenciTakip.UI.Win.Show;
using OgrenciTakip.UI.Win.Functions;

namespace OgrenciTakip.UI.Yonetim.GeneralForms
{
    public partial class AnaForm : RibbonForm
    {
        private readonly string _server;
        private readonly SecureString _kullaniciAdi;
        private readonly SecureString _sifre;
        private YetkilendirmeTuru _yetkilendirmeTuru;

        public AnaForm(params object[] prm)
        {
            InitializeComponent();
            _server = prm[0].ToString();
            _kullaniciAdi = (SecureString)prm[1];
            _sifre = (SecureString)prm[2];
            _yetkilendirmeTuru = (YetkilendirmeTuru)prm[3];

            longNavigator.Navigator.NavigatableControl = tablo.GridControl;
            EventsLoad();
            ButtonEnabledDurumu();
        }

        private void EventsLoad()
        {
            foreach (BarItem button in ribbonControl.Items)
            {
                button.ItemClick += Button_ItemClick;
            }
        }
        protected virtual void ShowEditForm(long id)
        {
            GeneralFunctions.CreateConnectionString("OgrenciTakip2018_Yonetim", _server, _kullaniciAdi, _sifre, _yetkilendirmeTuru);
            var result = ShowEditForms<KurumEditForm>.ShowDialogEditForms(id, _server, _kullaniciAdi, _sifre);
            if (result <= 0) return;
            Listele();
            tablo.RowFocus("Id", result);
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

                }
            }
            else
            {

            }


            Cursor.Current = DefaultCursor;
        }

        private void ButtonEnabledDurumu()
        {

        }
    }
}