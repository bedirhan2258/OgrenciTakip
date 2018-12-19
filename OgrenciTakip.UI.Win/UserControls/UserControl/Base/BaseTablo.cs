
using OgrenciTakip.UI.Win.Functions;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;
using OgrenciTakip.Common.Message;
using OgrenciTakip.Model.Entities.Base.Interfaces;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using System;
using DevExpress.XtraPrinting.Native;
using DevExpress.XtraGrid.Views.Base;
using OgrenciTakip.UI.Win.Interfaces;
using System.Linq;
using OgrenciTakip.BLL.Interfaces;
using OgrenciTakip.Model.Entities.Base;

namespace OgrenciTakip.UI.Win.UserControls.UserControl.Base
{
    public partial class BaseTablo : XtraUserControl
    {
        private bool _isLoaded;
        private bool _tabloSablonKayitEdilecek;
        protected GridView Tablo;
        protected internal bool TableValueChanged;
        protected internal BaseEditForm OwnerForm;
        protected BarItem[] ShowItems;
        protected BarItem[] HideItems;
        protected IBaseBll Bll;

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
            Tablo.CellValueChanged += Tablo_CellValueChanged;
            Tablo.MouseUp += Tablo_MouseUp;
            Tablo.GotFocus += Tablo_GotFocus;
            Tablo.LostFocus += Tablo_LostFocus;
            Tablo.KeyDown += Tablo_KeyDown;
            Tablo.FocusedColumnChanged += Tablo_FocusedColumnChanged;
            Tablo.ColumnPositionChanged += Tablo_SablonChanged;
            Tablo.ColumnWidthChanged += Tablo_SablonChanged;
            Tablo.EndSorting += Tablo_SablonChanged;
        }

        protected internal void Yukle()
        {
            _isLoaded = true;
            TableValueChanged = false;
            OwnerForm.ButonEnabledDurumu();
            insUptNavigator.Navigator.NavigatableControl = Tablo.GridControl;
            SablonYukle();
            Listele();
            ButtonGizleGoster();
            //Tablo_LostFocus(Tablo, EventArgs.Empty);
        }

        private void SablonKaydet()
        {
            if (_tabloSablonKayitEdilecek)
                Tablo.TabloSablonKaydet(Tablo.ViewCaption);
        }

        private void SablonYukle()
        {
            Tablo.TabloSablonYukle(Tablo.ViewCaption);
        }

        protected virtual void Listele() { }

        private void ButtonGizleGoster()
        {
            ShowItems?.ForEach(x => x.Visibility = BarItemVisibility.Always);
            HideItems?.ForEach(x => x.Visibility = BarItemVisibility.Never);
        }

        protected virtual void HareketEkle() { }

        protected virtual void HareketSil()
        {
            if (Tablo.DataRowCount == 0) return;
            if (Messages.SilMesaj("İşlem Satırı") != DialogResult.Yes) return;

            Tablo.GetRow<IBaseHareketEntity>().Delete = true;
            Tablo.RefleshDataSource();
            ButtonEnabledDurumu(true);
        }

        protected void ButtonEnabledDurumu(bool durum)
        {
            TableValueChanged = durum;
            OwnerForm.ButonEnabledDurumu();
        }
        protected internal bool Kaydet()
        {
            var source = Tablo.DataController.ListSource;

            var insert = source.Cast<IBaseHareketEntity>().Where(x => x.Insert && !x.Delete).Cast<BaseHareketEntity>().ToList();
            var update = source.Cast<IBaseHareketEntity>().Where(x => x.Update && !x.Delete).Cast<BaseHareketEntity>().ToList();
            var delete = source.Cast<IBaseHareketEntity>().Where(x => x.Delete && !x.Insert).Cast<BaseHareketEntity>().ToList();

            if (insert.Any())
                if (!((IBaseHareketGenelBll)Bll).Insert(insert))
                {
                    Messages.HataMesaji($"{Tablo.ViewCaption} Tablosundaki Hareketler Eklenemedi.");
                    return false;
                }
            if (update.Any())
                if (!((IBaseHareketGenelBll)Bll).Insert(update))
                {
                    Messages.HataMesaji($"{Tablo.ViewCaption} Tablosundaki Hareketler Güncellenemedi.");
                    return false;
                }
            if (delete.Any())
                if (!((IBaseHareketGenelBll)Bll).Insert(delete))
                {
                    Messages.HataMesaji($"{Tablo.ViewCaption} Tablosundaki Hareketler Silinemedi.");
                    return false;
                }
            ButtonEnabledDurumu(false);
            return true;

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
        private void Tablo_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            if (!_isLoaded) return;

            var entity = Tablo.GetRow<IBaseHareketEntity>();
            if (!entity.Insert)
                entity.Update = true;

            ButtonEnabledDurumu(true);
        }
        private void Tablo_MouseUp(object sender, MouseEventArgs e)
        {
            if (popupMenu == null) return;
            //Sağ tıklayıp sil dediğimiz de tablo üzerinde bir eleman yok sa sil Enable Durumu false gelmes için yaptım.
            btnHareketSil.Enabled = Tablo.RowCount > 0;
            e.SagMenuGoster(popupMenu);
        }

        private void Tablo_GotFocus(object sender, EventArgs e)
        {
            OwnerForm.statusBarKisayol.Visibility = BarItemVisibility.Always;
            OwnerForm.statusBarKisayolAciklama.Visibility = BarItemVisibility.Always;

            OwnerForm.statusBarAciklama.Caption = ((IStatusBarKisayol)sender).StatusBarAciklama;
            OwnerForm.statusBarKisayolAciklama.Caption = ((IStatusBarKisayol)sender).StatusBarKisayolAciklama;
            OwnerForm.statusBarKisayol.Caption = ((IStatusBarKisayol)sender).StatusBarKisayol;
        }

        private void Tablo_LostFocus(object sender, EventArgs e)
        {
            OwnerForm.statusBarKisayol.Visibility = BarItemVisibility.Never;
            OwnerForm.statusBarKisayolAciklama.Visibility = BarItemVisibility.Never;

        }
        private void Tablo_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    if (Tablo.IsEditorFocused)
                        insUptNavigator.Navigator.Buttons.DoClick(insUptNavigator.Navigator.Buttons.CancelEdit);
                    else
                        OwnerForm.Close();
                    break;
                case Keys.Tab:
                case Keys.Left:
                case Keys.Right:
                case Keys.Up:
                case Keys.Down:
                    insUptNavigator.Navigator.Buttons.DoClick(insUptNavigator.Navigator.Buttons.EndEdit);
                    break;
                case Keys.Insert when e.Shift:
                    HareketEkle();
                    break;
                case Keys.Delete when e.Shift:
                    HareketSil();
                    break;
            }
        }
        private void Tablo_FocusedColumnChanged(object sender, FocusedColumnChangedEventArgs e)
        {
            OwnerForm.statusBarKisayol.Visibility = BarItemVisibility.Never;
            OwnerForm.statusBarKisayolAciklama.Visibility = BarItemVisibility.Never;

            if (!e.FocusedColumn.OptionsColumn.AllowEdit)
                Tablo_GotFocus(sender, EventArgs.Empty);
            else if (((IStatusBarKisayol)e.FocusedColumn).StatusBarKisayol != null)
            {
                OwnerForm.statusBarKisayol.Visibility = BarItemVisibility.Always;
                OwnerForm.statusBarKisayolAciklama.Visibility = BarItemVisibility.Always;

                OwnerForm.statusBarAciklama.Caption = ((IStatusBarKisayol)sender).StatusBarAciklama;
                OwnerForm.statusBarKisayolAciklama.Caption = ((IStatusBarKisayol)sender).StatusBarKisayolAciklama;
                OwnerForm.statusBarKisayol.Caption = ((IStatusBarKisayol)sender).StatusBarKisayol;
            }
            else if (((IStatusBarKisayol)e.FocusedColumn).StatusBarAciklama != null)
                OwnerForm.statusBarKisayolAciklama.Caption = ((IStatusBarKisayol)sender).StatusBarKisayolAciklama;
        }
        private void Tablo_SablonChanged(object sender, EventArgs e)
        {
            _tabloSablonKayitEdilecek = true;
            SablonKaydet();
        }

    }
}
