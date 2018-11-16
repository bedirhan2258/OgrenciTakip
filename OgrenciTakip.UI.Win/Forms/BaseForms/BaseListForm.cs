
using System;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting.Native;
using OgrenciTakip.BLL.Interfaces;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities.Base;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.Show.Interfaces;

namespace OgrenciTakip.UI.Win.Forms.BaseForms
{
    public partial class BaseListForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        protected IBaseFormShow formShow;
        protected KartTuru kartTuru;
        protected internal GridView Tablo;
        protected bool aktifKartlariGoster = true;
        protected internal bool AktifPasifButtonGoster = false;
        protected internal bool multiSelect;
        protected internal BaseEntity selectedEntity;
        protected IBaseBll bll;
        protected ControlNavigator navigator;
        protected internal long? seciliGelecekId;
        protected BarItem[] ShowItems;
        protected BarItem[] HideItems;

        public BaseListForm()
        {
            InitializeComponent();
        }

        private void EventsLoad()
        {
            //Button Events
            foreach (BarItem button in ribbonControl.Items)
            {
                button.ItemClick += Button_ItemClick;
            }

            //Table Events
            Tablo.DoubleClick += Tablo_DoubleClick;
            Tablo.KeyDown += Tablo_KeyDown;
            Tablo.MouseUp += Tablo_MouseUp;
            //Form Events
            Shown += BaseListForm_Shown;

        }

        private void Tablo_MouseUp(object sender, MouseEventArgs e)
        {
            e.SagMenuGoster(sagMenu);
        }

        private void BaseListForm_Shown(object sender, EventArgs e)
        {
            Tablo.Focus();
            ButonGizleGoster();
            //  SutunGizleGoster();
            //.HasValu özelliği gelen değerin null olup olmadığınıda kontrol eder.
            if (IsMdiChild || !seciliGelecekId.HasValue) return;
            Tablo.RowFocus("Id", seciliGelecekId);
        }

        private void SutunGizleGoster()
        {
            throw new NotImplementedException();
        }

        private void ButonGizleGoster()
        {
            btnSec.Visibility = AktifPasifButtonGoster ? BarItemVisibility.Never : IsMdiChild ? BarItemVisibility.Never : BarItemVisibility.Always;
            barEnter.Visibility = IsMdiChild ? BarItemVisibility.Never : BarItemVisibility.Always;
            barEnterAciklama.Visibility = IsMdiChild ? BarItemVisibility.Never : BarItemVisibility.Always;
            btnAktifPasifKartlar.Visibility = AktifPasifButtonGoster ? BarItemVisibility.Always : !IsMdiChild ? BarItemVisibility.Never : BarItemVisibility.Always;

            ShowItems?.ForEach(x => x.Visibility = BarItemVisibility.Always);
            HideItems?.ForEach(x => x.Visibility = BarItemVisibility.Never);
            //Güncellenecek
        }

        protected internal void Yukle()
        {
            DegiskenleriDoldur();
            EventsLoad();

            Tablo.OptionsSelection.MultiSelect = multiSelect;
            navigator.NavigatableControl = Tablo.GridControl;

            Cursor.Current = Cursors.WaitCursor;
            Listele();
            Cursor.Current = DefaultCursor;

            //Güncellenecek
        }

        protected virtual void DegiskenleriDoldur()
        {

        }

        protected virtual void ShowEditForm(long id)
        {
            var result = formShow.ShowDialogEditForms(kartTuru, id);
            ShowEditFormDefault(result);

        }
        protected virtual void ShowEditFormDefault(long id)
        {
            if (id <= 0) return;
            aktifKartlariGoster = true;
            FormCaptionAyarla();
            Tablo.RowFocus("Id", id);
        }
        protected virtual void EntityDelete()
        {
            var entity = Tablo.GetRow<BaseEntity>();
            if (entity == null) return;
            if (!((IBaseCommonBll)bll).Delete(entity)) return;
            Tablo.DeleteSelectedRows();
            Tablo.RowFocus(Tablo.FocusedRowHandle);
        }
        private void SelectEntity()
        {
            if (multiSelect)
            {
                //Güncellenecek
            }
            else
            {
                selectedEntity = Tablo.GetRow<BaseEntity>();
            }
            DialogResult = DialogResult.OK;
            Close();
        }
        protected virtual void Listele() { }
        private void FiltreSec()
        {
            throw new NotImplementedException();
        }
        private void Yazdir()
        {
            throw new NotImplementedException();
        }
        private void FormCaptionAyarla()
        {
            if (btnAktifPasifKartlar == null)
            {
                Listele();
                return;
            }
            if (aktifKartlariGoster)
            {
                btnAktifPasifKartlar.Caption = "Pasif Kartlar";
                Tablo.ViewCaption = Text;
            }
            else
            {
                btnAktifPasifKartlar.Caption = "Aktif Kartlar";
                Tablo.ViewCaption = Text + " -Pasif Kartlar";

            }
            Listele();
        }
        private void IslemTuruSec()
        {
            if (!IsMdiChild)
            {
                //Güncellenecek
                SelectEntity();
            }
            else
            {
                //PerformClick MdiChild değilsen btnDüzenle butonuna basılmış gibi işlem yapılmaını sağlar.
                btnDuzenle.PerformClick();
            }
        }

        private void Button_ItemClick(object sender, ItemClickEventArgs e)
        {
            //İmlecin tıklananın üstünde olmasını sağlar.

            Cursor.Current = Cursors.WaitCursor;

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
                ShowEditForm(-1);
            }
            else if (e.Item == btnDuzenle)
            {
                ShowEditForm(Tablo.GetRowId());
            }
            else if (e.Item == btnSil)
            {
                //Yetki kontrolü yapılacak
                EntityDelete();
            }
            else if (e.Item == btnSec)
            {
                SelectEntity();
            }
            else if (e.Item == btnYenile)
            {
                Listele();
            }
            else if (e.Item == btnFiltrele)
            {
                FiltreSec();
            }
            else if (e.Item == btnKolonlar)
            {
                if (Tablo.CustomizationForm == null)
                {
                    Tablo.ShowCustomization();
                }
                else
                {
                    Tablo.HideCustomization();
                }
            }
            else if (e.Item == btnBagliKartlar)
            {
                BagliKartAc();
            }
            else if (e.Item == btnYazdir)
            {
                Yazdir();
            }
            else if (e.Item == btnCikis)
            {
                Close();
            }
            else if (e.Item == btnAktifPasifKartlar)
            {
                aktifKartlariGoster = !aktifKartlariGoster;
                FormCaptionAyarla();
            }
            Cursor.Current = DefaultCursor;
        }

        protected virtual void BagliKartAc() { }

        private void Tablo_DoubleClick(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            IslemTuruSec();
            Cursor.Current = DefaultCursor;
        }
        private void Tablo_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    IslemTuruSec();
                    break;
                case Keys.Escape:
                    Close();
                    break;
            }
        }

    }
}