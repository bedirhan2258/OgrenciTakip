﻿
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities.Base;
using OgrenciTakip.Model.Entities.Base.Interfaces;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OgrenciTakip.UI.Win.Show
{
    public class ShowListForms<TForm> where TForm : BaseListForm
    {
        public static void ShowListForm(KartTuru kartTuru)
        {
            if (!kartTuru.YetkiKontrolu(YetkiTuru.Gorebilir)) return;

            var frm = (TForm)Activator.CreateInstance(typeof(TForm));
            frm.MdiParent = Form.ActiveForm;

            frm.Yukle();
            frm.Show();
        }
        public static void ShowListForm(KartTuru kartTuru, params object[] prm)
        {
            if (!kartTuru.YetkiKontrolu(YetkiTuru.Gorebilir)) return;

            var frm = (TForm)Activator.CreateInstance(typeof(TForm), prm);
            frm.MdiParent = Form.ActiveForm;

            frm.Yukle();
            frm.Show();
        }

        public static BaseEntity ShowDialogListForm(KartTuru kartTuru, long? seciliGelecekId, params object[] prm)
        {
            if (!kartTuru.YetkiKontrolu(YetkiTuru.Gorebilir)) return null;

            using (var frm = (TForm)Activator.CreateInstance(typeof(TForm), prm))
            {
                frm.seciliGelecekId = seciliGelecekId;
                frm.Yukle();

                if (!frm.IsDisposed)
                    frm.ShowDialog();

                return frm.DialogResult == DialogResult.OK ? frm.selectedEntity : null;
            }
        }

        public static void ShowDialogListForm()
        {
            using (var frm = (TForm)Activator.CreateInstance(typeof(TForm)))
            {
                frm.AktifPasifButtonGoster = true;
                frm.Yukle();
                frm.ShowDialog();

            }
        }

        public static IEnumerable<IBaseEntity> ShowDialogListForm(KartTuru kartTuru, IList<long> listeDisiTutulacakKayitlar, bool multiSelect, params object[] prm)
        {
            if (!kartTuru.YetkiKontrolu(YetkiTuru.Gorebilir)) return null;

            using (var frm = (TForm)Activator.CreateInstance(typeof(TForm), prm))
            {
                frm.ListeDisiTutulacakKayitlar = listeDisiTutulacakKayitlar;
                frm.multiSelect = multiSelect;
                frm.Yukle();
                frm.RowSelect = new SelectRowFunctions(frm.Tablo);

                if (frm.EklenebilecekEntityVar)
                    frm.ShowDialog();


                return frm.DialogResult == DialogResult.OK ? frm.SelectedEntities : null;
            }
        }

        public static IEnumerable<IBaseEntity> ShowDialogListForm(IList<long> listeDisiTutulacakKayitlar, bool multiSelect, params object[] prm)
        {
            using (var frm = (TForm)Activator.CreateInstance(typeof(TForm), prm))
            {
                frm.ListeDisiTutulacakKayitlar = listeDisiTutulacakKayitlar;
                frm.multiSelect = multiSelect;
                frm.Yukle();
                frm.RowSelect = new SelectRowFunctions(frm.Tablo);

                if (frm.EklenebilecekEntityVar)
                    frm.ShowDialog();


                return frm.DialogResult == DialogResult.OK ? frm.SelectedEntities : null;
            }
        }

        public static IEnumerable<IBaseEntity> ShowDialogListForm(KartTuru kartTuru, bool multiSelect, params object[] prm)
        {
            if (!kartTuru.YetkiKontrolu(YetkiTuru.Gorebilir)) return null;
            using (var frm = (TForm)Activator.CreateInstance(typeof(TForm), prm))
            {
                frm.multiSelect = multiSelect;
                frm.Yukle();
                frm.RowSelect = new SelectRowFunctions(frm.Tablo);
                frm.ShowDialog();

                return frm.DialogResult == DialogResult.OK ? frm.SelectedEntities : null;
            }
        }
    }
}
