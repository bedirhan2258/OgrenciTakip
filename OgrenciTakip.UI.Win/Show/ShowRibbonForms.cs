using DevExpress.XtraBars.Ribbon;
using System;

namespace OgrenciTakip.UI.Win.Show
{
    public class ShowRibbonForms<TFrom> where TFrom : RibbonForm
    {
        public static void ShowForm(bool dialog, params object[] prm)
        {
            var frm = (TFrom)Activator.CreateInstance(typeof(TFrom), prm);
            if (dialog)
                using (frm)
                    frm.ShowDialog();
            else
                frm.Show();
        }

    }
}
