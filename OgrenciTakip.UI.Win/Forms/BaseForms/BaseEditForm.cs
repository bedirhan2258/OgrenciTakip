using System;
using System.Windows.Forms;
using DevExpress.Utils.Extensions;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
//using DevExpress.XtraPrinting.Native;
using OgrenciTakip.BLL.Interfaces;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Common.Message;
using OgrenciTakip.Model.Entities.Base;
using OgrenciTakip.Model.Entities.Base.Interfaces;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.Interfaces;
using OgrenciTakip.UI.Win.UserControls.Controls;
using OgrenciTakip.UI.Win.UserControls.Grid;

namespace OgrenciTakip.UI.Win.Forms.BaseForms
{
    public partial class BaseEditForm : RibbonForm
    {
        private bool _formSablonKayitEdilecek;

        #region Varaibles
        protected IBaseBll bll;
        protected KartTuru kartTuru;
        protected BaseEntity oldEntity;
        protected BaseEntity currentEnttiy;
        protected MyDataLayoutControl dataLayoutControl;
        protected MyDataLayoutControl[] dataLayoutControls;
        protected bool isLoaded;
        protected bool kayitSonrasiFormuKapat = true;
        protected BarItem[] ShowItems;
        protected BarItem[] HideItems;

        protected internal IslemTuru islemTuru;
        protected internal long id;
        protected internal bool refreshYapilacak;
        protected bool FarkliSubeIslemi;
        #endregion

        public BaseEditForm()
        {
            InitializeComponent();
        }

        protected void EventsLoad()
        {
            //Button Events
            foreach (BarItem button in ribbonControl.Items)
            {
                button.ItemClick += Button_ItemClick;
            }
            //Form Events
            LocationChanged += BaseEditForm_LocationChanged;
            SizeChanged += BaseEditForm_SizeChanged;
            Load += BaseEditForm_Load;
            FormClosing += BaseEditForm_FormClosing;
            void ControlEvents(Control control)
            {
                control.KeyDown += Control_KeyDown;
                control.GotFocus += Control_GotFocus;
                control.Leave += Control_Leave;
                control.Enter += Control_Enter;
                switch (control)
                {
                    case FilterControl edt:
                        edt.FilterChanged += Control_EditValueChanged;
                        break;
                    case ComboBoxEdit edt:
                        edt.EditValueChanged += Control_EditValueChanged;
                        edt.SelectedValueChanged += Control_SelectedValueChanged;

                        break;
                    case MyButtonEdit edt:
                        edt.IdChanged += Control_IdChanged;
                        edt.EnabledChange += Control_EnabledChange;
                        edt.ButtonClick += Control_ButtonClick;
                        edt.DoubleClick += Control_DoubleClick;
                        break;
                    case BaseEdit edt:
                        edt.EditValueChanged += Control_EditValueChanged;
                        break;
                    case TabPane tab:
                        tab.SelectedPageChanged += Control_SelectedPageChanged;
                        break;
                }
            }
            if (dataLayoutControls == null)
            {
                if (dataLayoutControl == null) return;
                foreach (Control ctrl in dataLayoutControl.Controls)
                {
                    ControlEvents(ctrl);
                }
            }
            else
            {
                foreach (var layout in dataLayoutControls)
                {
                    foreach (Control ctrl in layout.Controls)
                    {
                        ControlEvents(ctrl);
                    }
                }
            }

        }




        ////////////////////////////////////////////////////////////////////////Fonksiyonlar/////////////////////////////////////////////////7
        private void EntityDelete()
        {

            if (!((IBaseCommonBll)bll).Delete(oldEntity)) return;
            refreshYapilacak = true;
            Close();
        }

        private void ButonGizleGoster()
        {
            ShowItems?.ForEach(x => x.Visibility = BarItemVisibility.Always);
            HideItems?.ForEach(x => x.Visibility = BarItemVisibility.Never);
            //Güncellenecek
        }

        private bool Kaydet(bool kapanis)
        {
            bool KayitIslemi()
            {
                Cursor.Current = Cursors.WaitCursor;

                switch (islemTuru)
                {
                    case IslemTuru.EntityInsert:
                        if (EntityInsert())
                            return KayitSonrasiIslemler();
                        break;

                    case IslemTuru.EntityUpdate:
                        if (EntityUpdate())
                            return KayitSonrasiIslemler();
                        break;

                }
                bool KayitSonrasiIslemler()
                {
                    oldEntity = currentEnttiy;
                    refreshYapilacak = true;
                    ButonEnabledDurumu();
                    if (kayitSonrasiFormuKapat)
                    {
                        Close();
                    }
                    else
                    {
                        islemTuru = islemTuru == IslemTuru.EntityInsert ? IslemTuru.EntityUpdate : islemTuru;
                    }
                    return true;
                }
                return false;
            }


            var result = kapanis ? Messages.KapanisMesaj() : Messages.KayitMesaj();
            switch (result)
            {
                case DialogResult.Yes:
                    return KayitIslemi();

                case System.Windows.Forms.DialogResult.No:
                    if (kapanis)
                    {
                        btnKaydet.Enabled = false;
                    }
                    return true;

                case DialogResult.Cancel:
                    return false;

            }

            return false;
        }

        private void GeriAl()
        {
            if (Messages.HayirSeciliEvetHayir("Yapılan değişiklikler geri alınacaktır.Onaylıyor musunuz?", "Geri Al Onay") != DialogResult.Yes) return;
            if (islemTuru == IslemTuru.EntityUpdate)
                Yukle();
            else
                Close();
        }

        private void FarkliKaydet()
        {
            if (Messages.EvetSeciliEvetHayir("Bu Filtre Referans Alınarak Yeni Bir Filtre Oluşturulacaktır. Onaylıyormusunuz?", "Kayıt Onay") != DialogResult.Yes) return;
            islemTuru = IslemTuru.EntityInsert;
            Yukle();

            if (Kaydet(true))
                Close();
        }

        private void SablonYukle()
        {
            Name.FormSablonYukle(this);
        }

        private void SablonKaydet()
        {
            if (_formSablonKayitEdilecek)
                Name.FormSablonKaydet(Left, Top, Width, Height, WindowState);
        }

        protected virtual void SecimYap(object sender) { }

        protected virtual void FiltreUygula()
        {

        }

        protected virtual void TaksitOlustur() { }

        protected virtual bool EntityUpdate()
        {
            return ((IBaseGenelBll)bll).Update(oldEntity, currentEnttiy);
        }

        protected virtual bool EntityInsert()
        {
            return ((IBaseGenelBll)bll).Insert(currentEnttiy);
        }

        protected virtual void BaskiOnIzleme() { }

        protected virtual void Yazdir() { }

        protected virtual void NesneyiKontrollereBagla() { }

        protected virtual void GuncelNesneOlustur() { }
        protected virtual void TabloYukle() { }


        protected internal virtual void Yukle()
        {

        }

        protected internal virtual IBaseEntity ReturnEntity() { return null; }

        protected internal virtual void ButonEnabledDurumu()
        {
            if (!isLoaded) return;
            GeneralFunctions.ButtonEnabledDurumu(btnYeni, btnKaydet, btnGeriAl, btnSil, oldEntity, currentEnttiy);
        }

        protected virtual void BagliTabloYukle() { }

        protected virtual bool BagliTabloKaydet() { return false; }

        protected virtual bool BagliTabloHataliGirisKontrol() { return false; }

        ////////////////////////////////////////////////////////////////////////7777//Eventler////////////////////////////////////////////////////////////////////



        private void Control_Leave(object sender, EventArgs e)
        {
            statusBarKisayol.Visibility = BarItemVisibility.Never;
            statusBarKisayolAciklama.Visibility = BarItemVisibility.Never;
        }
        protected virtual void Control_Enter(object sender, EventArgs e) { }


        private void Control_GotFocus(object sender, EventArgs e)
        {
            var type = sender.GetType();
            if (type == typeof(MyButtonEdit) || type == typeof(MyGridView) || type == typeof(MyPictureEdit) || type == typeof(MyComboBoxEdit) || type == typeof(MyDateEdit) || type == typeof(MyCalcEdit))
            {
                statusBarKisayol.Visibility = BarItemVisibility.Always;
                statusBarKisayolAciklama.Visibility = BarItemVisibility.Always;

                statusBarAciklama.Caption = ((IStatusBarAciklama)sender).StatusBarAciklama;
                statusBarKisayol.Caption = ((IStatusBarKisayol)sender).StatusBarKisayol;
                statusBarKisayolAciklama.Caption = ((IStatusBarKisayol)sender).StatusBarKisayolAciklama;
            }
            else if (sender is IStatusBarAciklama ctrl)
            {
                statusBarAciklama.Caption = ctrl.StatusBarAciklama;
            }
        }

        private void BaseEditForm_SizeChanged(object sender, EventArgs e)
        {
            _formSablonKayitEdilecek = true;
        }

        private void BaseEditForm_LocationChanged(object sender, EventArgs e)
        {
            _formSablonKayitEdilecek = true;
        }

        private void BaseEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SablonKaydet();
            if (btnKaydet.Visibility == BarItemVisibility.Never || !btnKaydet.Enabled) return;

            if (!Kaydet(true))
                e.Cancel = true;
        }

        protected virtual void Control_EditValueChanged(object sender, EventArgs e)
        {
            if (!isLoaded) return;
            GuncelNesneOlustur();
        }

        private void Control_DoubleClick(object sender, EventArgs e)
        {
            SecimYap(sender);
        }

        private void Control_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            SecimYap(sender);
        }

        private void Control_IdChanged(object sender, IdChangedEventArgs e)
        {
            if (!isLoaded) return;
            GuncelNesneOlustur();
        }

        private void Control_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
            if (sender is MyButtonEdit edt)
            {
                switch (e.KeyCode)
                {
                    //kontrol+shift +delete basılırsa aynı anda bu işlemleri yap demek
                    case Keys.Delete when e.Control && e.Shift:
                        edt.Id = null;
                        edt.EditValue = null;
                        break;
                    case Keys.F4:
                    case Keys.Down when e.Modifiers == Keys.Alt:
                        SecimYap(edt);
                        break;
                }
            }
        }

        private void BaseEditForm_Load(object sender, EventArgs e)
        {
            isLoaded = true;
            GuncelNesneOlustur();
            SablonYukle();
            ButonGizleGoster();

            if (FarkliSubeIslemi)
                Messages.UyariMesaji("İşlem Yapılan Kart Çalışılan Şube Veya Dönemde Olmadığı İçin Yapılan Değişiklikler Kayıt Edilemez.");
        }

        private void Button_ItemClick(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (e.Item == btnYeni)
            {
                //Yetki Kontrol Olucak
                islemTuru = IslemTuru.EntityInsert;
                Yukle();
            }
            else if (e.Item == btnKaydet)
            {
                Kaydet(false);
            }
            else if (e.Item == btnFarkliKaydet)
            {
                //Yetki Kontrolü yapılacak
                FarkliKaydet();
            }
            else if (e.Item == btnGeriAl)
            {
                GeriAl();
            }
            else if (e.Item == btnSil)
            {
                //Yetki Kontrolü olacak
                EntityDelete();
            }
            else if (e.Item == btnUygula)
            {
                FiltreUygula();
            }
            else if (e.Item == btnTaksitOlustur)
            {
                TaksitOlustur();
            }
            else if (e.Item == btnYazdir)
            {
                Yazdir();
            }
            else if (e.Item == btnBaskiOnizleme)
            {
                BaskiOnIzleme();
            }
            else if (e.Item == btnCikis)
            {
                Close();
            }

            Cursor.Current = DefaultCursor;
        }



        protected virtual void Control_SelectedValueChanged(object sender, EventArgs e) { }

        protected virtual void Control_EnabledChange(object sender, EventArgs e) { }

        protected virtual void Control_SelectedPageChanged(object sender, SelectedPageChangedEventArgs e) { }

    }
}