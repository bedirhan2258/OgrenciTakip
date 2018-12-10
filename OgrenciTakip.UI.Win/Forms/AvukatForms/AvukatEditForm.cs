
using DevExpress.XtraEditors;
using OgrenciTakip.BLL.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.DTO;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;
using System;

namespace OgrenciTakip.UI.Win.Forms.AvukatForms
{
    public partial class AvukatEditForm : BaseEditForm
    {

        public AvukatEditForm()
        {
            InitializeComponent();

            bll = new AvukatBll(myDataLayoutControl);
            dataLayoutControl = myDataLayoutControl;
            kartTuru = KartTuru.Avukat;
            EventsLoad();
        }

        protected internal override void Yukle()
        {
            oldEntity = islemTuru == IslemTuru.EntityInsert ? new AvukatS() : ((AvukatBll)bll).Single(FilterFunctions.Filter<Avukat>(id));
            NesneyiKontrollereBagla();

            if (islemTuru != IslemTuru.EntityInsert) return;
            id = islemTuru.IdOlustur(oldEntity);
            txtKod.Text = ((AvukatBll)bll).YeniKodVer();
            txtAdiSoyadi.Focus();
        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (AvukatS)oldEntity;

            txtKod.Text = entity.Kod;
            txtAdiSoyadi.Text = entity.AdiSoyadi;
            txtSozlesmeNo.Text = entity.SozlesmeNo;
            txtBaslamaTarihi.EditValue = entity.SozlesmeBaslamaTarihi;
            txtBitisTarihi.EditValue = entity.SozlesmeBitisTarihi;
            txtOzelKod1.Id = entity.OzelKod1Id;
            txtOzelKod1.Text = entity.OzelKod1Adi;
            txtOzelKod2.Id = entity.OzelKod2Id;
            txtOzelKod2.Text = entity.OzelKod2Adi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }
        protected override void GuncelNesneOlustur()
        {
            currentEnttiy = new Avukat
            {
                Id = id,
                Kod = txtKod.Text,
                AdiSoyadi = txtAdiSoyadi.Text,
                SozlesmeNo = txtSozlesmeNo.Text,
                SozlesmeBaslamaTarihi = (DateTime?)txtBaslamaTarihi.EditValue,
                SozlesmeBitisTarihi = (DateTime?)txtBitisTarihi.EditValue,
                OzelKod1Id = txtOzelKod1.Id,
                OzelKod2Id = txtOzelKod2.Id,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn
            };
            ButonEnabledDurumu();
        }
        protected override void SecimYap(object sender)
        {
            if (!(sender is ButtonEdit)) return;

            using (var sec = new SelectFunctions())
                if (sender == txtOzelKod1)
                    sec.Sec(txtOzelKod1, KartTuru.Avukat);
                else if (sender == txtOzelKod2)
                    sec.Sec(txtOzelKod2, KartTuru.Avukat);
        }
    }
}