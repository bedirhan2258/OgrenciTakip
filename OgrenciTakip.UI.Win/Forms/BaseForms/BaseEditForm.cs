
using System;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using OgrenciTakip.BLL.Interfaces;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities.Base;
using OgrenciTakip.UI.Win.UserControls.Controls;

namespace OgrenciTakip.UI.Win.Forms.BaseForms
{
    public partial class BaseEditForm : RibbonForm
    {
        protected internal IslemTuru islemTuru;
        protected internal long id;
        protected internal bool refresh;
        protected MyDataLayoutControl dataLayoutControl;
        protected IBaseBll bll;
        protected KartTuru kartTuru;
        protected BaseEntity oldEntity;
        protected BaseEntity currentEnttiy;
        protected bool isLoaded;

        public BaseEditForm()
        {
            InitializeComponent();
        }
        protected void EventsLoad()
        {
            foreach (BarItem button in ribbonControl.Items)
            {
                button.ItemClick += Button_ItemClick;
            }
        }

        private void EntityDelete()
        {
            throw new NotImplementedException();
        }

        private void GeriAl()
        {
            throw new NotImplementedException();
        }

        private void Kaydet(bool v)
        {
            throw new NotImplementedException();
        }

        protected internal virtual void Yukle()
        {

        }
        protected virtual void NesneyiKontrollereBagla() { }

        protected virtual void GuncelNesneOlustur() { }
        protected internal virtual void ButonEnableDurumu()
        {
            if (!isLoaded) return;

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