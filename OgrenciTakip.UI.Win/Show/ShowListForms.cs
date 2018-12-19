
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities.Base;
using OgrenciTakip.Model.Entities.Base.Interfaces;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using System;
using System.Collections.Generic;
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
        public static void ShowListForm(KartTuru kartTuru, params object[] prm)
        {
            //Yetki kontrolü yapılacak
            var frm = (TForm)Activator.CreateInstance(typeof(TForm), prm);
            frm.MdiParent = Form.ActiveForm;

            frm.Yukle();
            frm.Show();
        }
        public static BaseEntity ShowDialogListForm(KartTuru kartTuru, long? seciliGelecekId, params object[] prm)
        {
            //Burada yetki kontrolü yapılacak
            using (var frm = (TForm)Activator.CreateInstance(typeof(TForm), prm))
            {
                frm.seciliGelecekId = seciliGelecekId;
                frm.Yukle();
                frm.ShowDialog();

                return frm.DialogResult == DialogResult.OK ? frm.selectedEntity : null;
            }
        }
        public static IEnumerable<IBaseEntity> ShowDialogListForm(KartTuru kartTuru, IList<long> listeDisiTutulacakKayitlar, bool multiSelect, params object[] prm)
        {
            //Yetki kontrolü Yap.
            using (var frm = (TForm)Activator.CreateInstance(typeof(TForm), prm))
            {
                frm.ListeDisiTutulacakKayitlar = listeDisiTutulacakKayitlar;
                frm.multiSelect = multiSelect;
                frm.Yukle();
                frm.ShowDialog();

                return frm.DialogResult == DialogResult.OK ? frm.selectedEntity : null;
            }
        }
    }
}
