using System;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
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

        private void EntityDelete()
        {
            throw new NotImplementedException();
        }

        private void GeriAl()
        {
            throw new NotImplementedException();
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
                case System.Windows.Forms.DialogResult.Yes:
                    return KayitIslemi();

                case System.Windows.Forms.DialogResult.No:
                    if (kapanis)
                    {
                        btnKaydet.Enabled = false;
                    }
                    return true;

                case System.Windows.Forms.DialogResult.Cancel:
                    return true;

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
        }


    }
}