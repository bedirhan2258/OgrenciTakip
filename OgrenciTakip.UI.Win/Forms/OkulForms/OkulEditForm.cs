using System;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout;
using OgrenciTakip.BLL.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.DTO;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.UserControls.Controls;

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
            id = islemTuru.IdOlustur(oldEntity);
            txtKod.Text = ((OkulBLL)bll).YeniKodVer();
            txtOkulAdi.Focus();
        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (OkulS)oldEntity;

            txtKod.Text = entity.Kod;
            txtOkulAdi.Text = entity.OkulAdi;
            txtIl.Id = entity.IlId;
            txtIl.Text = entity.IlAdi;
            txtIlce.Id = entity.IlceId;
            txtIlce.Text = entity.IlceAdi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }
        protected override void GuncelNesneOlustur()
        {
            currentEnttiy = new Okul
            {
                Id = id,
                Kod = txtKod.Text,
                OkulAdi = txtOkulAdi.Text,
                IlId = Convert.ToInt64(txtIl.Id),
                IlceId = Convert.ToInt64(txtIlce.Id),
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn
            };
            ButonEnabledDurumu();
        }
        protected override void SecimYap(object sender)
        {
            if (!(sender is ButtonEdit)) return;
            using (var sec = new SelectFunctions())
            {
                if (sender == txtIl)
                    sec.Sec(txtIl);
                else if (sender == txtIlce)
                    sec.Sec(txtIlce, txtIl);
            }
        }
        protected override void Control_EnabledChange(object sender, EventArgs e)
        {
            if (sender != txtIl) return;
            txtIl.ControlEnabledChange(txtIlce);

        }
    }
}