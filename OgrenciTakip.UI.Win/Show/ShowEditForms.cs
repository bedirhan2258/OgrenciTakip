
using OgrenciTakip.Common.Enums;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Show.Interfaces;
using System;
using System.Windows.Forms;

namespace OgrenciTakip.UI.Win.Show
{
    public class ShowEditForms<TForm> : IBaseFormShow where TForm : BaseEditForm //Interfaces gelecek
    {
        public long ShowDialogEditForms(KartTuru kartTuru, long id)
        {
            //Yetki kontrolü yapılacak
            using (var frm = (TForm)Activator.CreateInstance(typeof(TForm)))
            {
                frm.islemTuru = id > 0 ? IslemTuru.EntityUpdate : IslemTuru.EntityInsert;
                frm.id = id;
                frm.Yukle();
                frm.ShowDialog();
                return frm.refreshYapilacak ? frm.id : 0;
            }
        }

        public long ShowDialogEditForms(KartTuru kartTuru, long id, params object[] prm)
        {
            //Yetki kontrolü yapılacak
            using (var frm = (TForm)Activator.CreateInstance(typeof(TForm), prm))
            {
                frm.islemTuru = id > 0 ? IslemTuru.EntityUpdate : IslemTuru.EntityInsert;
                frm.id = id;
                frm.Yukle();
                frm.ShowDialog();
                return frm.refreshYapilacak ? frm.id : 0;
            }
        }
    }
}
