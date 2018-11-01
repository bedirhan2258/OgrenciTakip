
using OgrenciTakip.Common.Enums;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using System;
using System.Windows.Forms;

namespace OgrenciTakip.UI.Win.Show
{
    public class ShowListForms<TForm> where TForm : BaseListForm
    {
        public static void ShowListForm(KartTuru kartTuru)
        {
            //Yetki kontrolü yapılacak
            var frm = (TForm)Activator.CreateInstance(typeof(TForm));
            frm.MdiParent = Form.ActiveForm;

            frm.Yukle();
            frm.Show();
        }
    }
}
