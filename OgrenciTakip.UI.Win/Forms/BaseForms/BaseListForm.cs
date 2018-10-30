
using System;
using DevExpress.XtraBars;


namespace OgrenciTakip.UI.Win.Forms.BaseForms
{
    public partial class BaseListForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public BaseListForm()
        {
            InitializeComponent();
        }

        private void EventsLoad()
        {
            foreach (var item in ribbonControl.Items)
            {
                switch (item)
                {
                    case BarItem button:
                        button.ItemClick += Button_ItemClick;
                        break;
                }
            }
        }

        private void ShowEditForm(long id)
        {
            var result =
        }

        private void Button_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (e.Item == btnGonder)
            {
                var link = (BarSubItemLink)e.Item.Links[0];
                link.Focus();
                link.OpenMenu();
                link.Item.ItemLinks[0].Focus();
            }
            else if (e.Item == btnStandarExcelDosyasi)
            {

            }
            else if (e.Item == btnFormatliExcelDosyasi)
            {

            }
            else if (e.Item == btnExcelDosyasiFormatsiz)
            {

            }
            else if (e.Item == btnWordDosyasi)
            {

            }
            else if (e.Item == btnPdfDosyasi)
            {

            }
            else if (e.Item == btnTxtDosyası)
            {

            }
            else if (e.Item == btnYeni)
            {
                //Burada yetki kontrolü yapılacak.
                ShowEditForm();
            }
        }


    }
}