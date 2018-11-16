using System;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using OgrenciTakip.BLL.Interfaces;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Common.Message;
using OgrenciTakip.Model.Entities.Base;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.UserControls.Controls;

namespace OgrenciTakip.UI.Win.Forms.BaseForms
{
    public partial class BaseEditForm : RibbonForm
    {
        protected internal IslemTuru islemTuru;
        protected internal long id;
        protected internal bool refreshYapilacak;
        protected MyDataLayoutControl dataLayoutControl;
        protected MyDataLayoutControl[] datalayoutControls;
        protected IBaseBll bll;
        protected KartTuru kartTuru;
        protected BaseEntity oldEntity;
        protected BaseEntity currentEnttiy;
        protected bool isLoaded;
        protected bool kayitSonrasiFormuKapat = true;

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
            Load += BaseEditForm_Load;
            FormClosing += BaseEditForm_FormClosing;
            void ControlEvents(Control control)
            {
                control.KeyDown += Control_KeyDown;
                switch (control)
                {
                    case MyButtonEdit edt:
                        edt.IdChanged += Control_IdChanged;
                        edt.EnabledChange += Control_EnabledChange;
                        edt.ButtonClick += Control_ButtonClick;
                        edt.DoubleClick += Control_DoubleClick;
                        break;
                    case BaseEdit edt:
                        edt.EditValueChanged += Control_EditValueChanged;
                        break;
                }
            }
            if (datalayoutControls == null)
            {
                if (dataLayoutControl == null) return;
                foreach (Control ctrl in dataLayoutControl.Controls)
                {
                    ControlEvents(ctrl);
                }
            }
            else
            {
                foreach (var layout in datalayoutControls)
                {
                    foreach (Control ctrl in layout.Controls)
                    {
                        ControlEvents(ctrl);
                    }
                }
            }

        }

        private void BaseEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
           // SablonKaydet();
            if (btnKaydet.Visibility == BarItemVisibility.Never || !btnKaydet.Enabled) return;

            if (!Kaydet(true))
                e.Cancel = true;
        }

        private void SablonKaydet()
        {
            throw new NotImplementedException();
        }

        protected virtual void Control_EnabledChange(object sender, EventArgs e) { }

        private void Control_EditValueChanged(object sender, EventArgs e)
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
            //SablonYukle();
            //ButtonGizleGoster();
            id = islemTuru.IdOlustur(oldEntity);
            //Guncelleme yapılacak.

        }
        protected virtual void SecimYap(object sender) { }
        private void EntityDelete()
        {

            if (!((IBaseCommonBll)bll).Delete(oldEntity)) return;
            refreshYapilacak = true;
            Close();
        }

        private void GeriAl()
        {
            if (Messages.HayirSeciliEvetHayir("Yapılan değişiklikler geri alınacaktır.Onaylıyor musunuz?", "Geri Al Onay") != DialogResult.Yes) return;
            if (islemTuru == IslemTuru.EntityUpdate)
                Yukle();
            else
                Close();
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

        protected virtual bool EntityUpdate()
        {
            return ((IBaseGenelBll)bll).Update(oldEntity, currentEnttiy);
        }

        protected virtual bool EntityInsert()
        {
            return ((IBaseGenelBll)bll).Insert(currentEnttiy);
        }

        protected internal virtual void Yukle()
        {

        }
        protected virtual void NesneyiKontrollereBagla() { }

        protected virtual void GuncelNesneOlustur() { }
        protected internal virtual void ButonEnabledDurumu()
        {
            if (!isLoaded) return;
            GeneralFunctions.ButtonEnabledDurumu(btnYeni, btnKaydet, btnGeriAl, btnSil, oldEntity, currentEnttiy);
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
            else if (e.Item == btnGeriAl)
            {
                GeriAl();
            }
            else if (e.Item == btnSil)
            {
                //Yetki Kontrolü olacak
                EntityDelete();
            }
            else if (e.Item == btnCikis)
            {
                Close();
            }
            Cursor.Current = DefaultCursor;
        }


    }
}