using DevExpress.XtraBars.Ribbon;
using OgrenciTakip.Common.Enums;
using System;
using System.Windows.Forms;

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

        public static long ShowDialogForm(KartTuru kartTuru, params object[] prm)
        {
            var frm = (TFrom)Activator.CreateInstance(typeof(TFrom), prm);
            using (frm)
            {
                frm.ShowDialog();
                return frm.DialogResult == DialogResult.OK ? (long)frm.Tag : 0;
            }
        }

    }
}
