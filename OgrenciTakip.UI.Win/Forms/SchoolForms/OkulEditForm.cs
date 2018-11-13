using System;
using DevExpress.XtraLayout;
using OgrenciTakip.BLL.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.DTO;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;

namespace OgrenciTakip.UI.Win.Forms.SchoolForms
{
    public partial class OkulEditForm : BaseEditForm
    {
        public OkulEditForm()
        {
            InitializeComponent();
            dataLayoutControl = myDataLayoutControl;
            bll = new OkulBLL(myDataLayoutControl);
            kartTuru = KartTuru.Okul;
            EventsLoad();

        }

        protected internal override void Yukle()
        {
            oldEntity = islemTuru == IslemTuru.EntityInsert ? new OkulS() : ((OkulBLL)bll).Single(FilterFunctions.Filter<Okul>(id));
            NesneyiKontrollereBagla();

            if (islemTuru != IslemTuru.EntityInsert) return;
            txtKod.Text = ((OkulBLL)bll).YeniKodVer();
            txtOkulAdi.Focus();
        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (OkulS)oldEntity;

            txtKod.Text = entity.Kod;
            txtOkulAdi.Text = entity.OkulAdi;
            btnIl.Id = entity.IlId;
            btnIl.Text = entity.IlAdi;
            btnIlce.Id = entity.IlceId;
            btnIlce.Text = entity.IlceAdi;
            memoAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }
        protected override void GuncelNesneOlustur()
        {
            currentEnttiy = new Okul
            {
                Id = id,
                Kod = txtKod.Text,
                OkulAdi = txtOkulAdi.Text,
                IlId = Convert.ToInt64(btnIl.Id),
                IlceId = Convert.ToInt64(btnIlce.Id),
                Aciklama = memoAciklama.Text,
                Durum = tglDurum.IsOn
            };
            ButonEnabledDurumu();
        }
        protected override void SecimYap(object sender)
        {
            
        }
    }
}