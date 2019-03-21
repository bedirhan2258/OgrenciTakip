
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities.Base.Interfaces;
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
                frm.BaseIslemTuru = id > 0 ? IslemTuru.EntityUpdate : IslemTuru.EntityInsert;
                frm.id = id;
                frm.Yukle();
                frm.ShowDialog();
                return frm.refreshYapilacak ? frm.id : 0;
            }
        }

        public static long ShowDialogEditForms(KartTuru kartTuru, long id, params object[] prm)
        {
            //Yetki kontrolü yapılacak
            using (var frm = (TForm)Activator.CreateInstance(typeof(TForm), prm))
            {
                frm.BaseIslemTuru = id > 0 ? IslemTuru.EntityUpdate : IslemTuru.EntityInsert;
                frm.id = id;
                frm.Yukle();
                frm.ShowDialog();
                return frm.refreshYapilacak ? frm.id : 0;
            }
        }

        public static bool ShowDialogEditForms(params object[] prm)
        {
            //Yetki kontrolü yapılacak
            using (var frm = (TForm)Activator.CreateInstance(typeof(TForm), prm))
            {
                frm.Yukle();
                return frm.DialogResult == DialogResult.OK;
            }
        }

        public static bool ShowDialogEditForms(KartTuru kartTuru,params object[] prm)
        {
            //Yetki kontrolü yapılacak
            using (var frm = (TForm)Activator.CreateInstance(typeof(TForm), prm))
            {
                frm.Yukle();
                frm.ShowDialog();
                return frm.DialogResult == DialogResult.OK;
            }
        }

        public static T ShowDialogEditForms<T>(params object[] prm) where T : IBaseEntity
        {
            using (var frm = (TForm)Activator.CreateInstance(typeof(TForm), prm))
            {

                frm.Yukle();
                frm.ShowDialog();
                return (T)frm.ReturnEntity();
            }
        }

    }
}
