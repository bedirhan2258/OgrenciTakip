
using System;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;
using OgrenciTakip.Common.Message;

namespace OgrenciTakip.UI.Win.UserControls.UserControl.Base
{
    public partial class BaseTablo : XtraUserControl
    {
        protected GridView Tablo;

        public BaseTablo()
        {
            InitializeComponent();
        }
        protected void EventsLoad()
        {
            //Button Events
            foreach (BarItem button in barManager.Items)
                button.ItemClick += Button_ItemClick;

            //Navigator Events
            insUptNavigator.Navigator.ButtonClick += Navigator_ButtonClick;

            //Table Events
        }

        protected virtual void HareketEkle() { }

        protected virtual void HareketSil()
        {
            if (Tablo.DataRowCount == 0) return;
            if (Messages.SilMesaj("İşlem Satırı") != DialogResult.Yes) return;

        }

        private void Button_ItemClick(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            if (e.Item == btnHareketEkle)
                HareketEkle();
            else if (e.Item == btnHareketSil)
                HareketSil();

            Cursor.Current = DefaultCursor;
        }

        private void Navigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            //Hareket ekleme butonuna basıldığı zaman yapılacak işlemlerin yapıldığı alandır.
            if (e.Button == insUptNavigator.Navigator.Buttons.Append)
                HareketEkle();
            else if (e.Button == insUptNavigator.Navigator.Buttons.Remove)
                HareketSil();

            //e.Handled =true diyerek default olarak yapılan işlemi iptal etmiş olduk.
            //Normelde append tuşuna basıldığında yeni bir satır eklenir. Fakat biz + tuşuna basıldıgında başka bir ekranın açılmasını sağlıcaz.
            if (e.Button == insUptNavigator.Navigator.Buttons.Append || e.Button == insUptNavigator.Navigator.Buttons.Remove)
                e.Handled = true;
        }
    }
}
