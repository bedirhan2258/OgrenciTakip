
using System;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using OgrenciTakip.BLL.Interfaces;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities.Base;
using OgrenciTakip.UI.Win.Functions;
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

        private void Kaydet(bool v)
        {
            throw new NotImplementedException();
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