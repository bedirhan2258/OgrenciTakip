
using DevExpress.XtraEditors;
using OgrenciTakip.BLL.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.DTO;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.GeneralForms;

namespace OgrenciTakip.UI.Win.Forms.KasaForms
{
    public partial class KasaEditForm : BaseEditForm
    {
        public KasaEditForm()
        {
            InitializeComponent();

            dataLayoutControl = myDataLayoutControl;
            bll = new KasaBll(myDataLayoutControl);
            kartTuru = KartTuru.Kasa;
            EventsLoad();
        }

        protected internal override void Yukle()
        {
            oldEntity = islemTuru == IslemTuru.EntityInsert ? new KasaS() : ((KasaBll)bll).Single(FilterFunctions.Filter<Kasa>(id));
            NesneyiKontrollereBagla();

            if (islemTuru != IslemTuru.EntityInsert) return;
            id = islemTuru.IdOlustur(oldEntity);
            txtKod.Text = ((KasaBll)bll).YeniKodVer(x => x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId);
            txtKasaAdi.Focus();
        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (KasaS)oldEntity;

            txtKod.Text = entity.Kod;
            txtKasaAdi.Text = entity.KasaAdi;
            txtOzelKod1.Id = entity.OzelKod1Id;
            txtOzelKod1.Text = entity.OzelKod1Adi;
            txtOzelKod2.Id = entity.OzelKod2Id;
            txtOzelKod2.Text = entity.OzelKod2Adi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }
        protected override void GuncelNesneOlustur()
        {
            currentEnttiy = new Kasa
            {
                Id = id,
                Kod = txtKod.Text,
                KasaAdi = txtKasaAdi.Text,
                OzelKod1Id = txtOzelKod1.Id,
                OzelKod2Id = txtOzelKod2.Id,
                SubeId = AnaForm.SubeId,
                DonemId = AnaForm.DonemId,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn
            };
            ButonEnabledDurumu();
        }
        protected override bool EntityInsert()
        {
            return ((KasaBll)bll).Insert(currentEnttiy, x => x.Kod == currentEnttiy.Kod &&
             x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId);
        }
        protected override bool EntityUpdate()
        {
            return ((KasaBll)bll).Update(oldEntity, currentEnttiy, x => x.Kod == currentEnttiy.Kod &&
            x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId);
        }
        protected override void SecimYap(object sender)
        {
            if (!(sender is ButtonEdit)) return;

            using (var sec = new SelectFunctions())
                if (sender == txtOzelKod1)
                    sec.Sec(txtOzelKod1, KartTuru.Kasa);
                else if (sender == txtOzelKod2)
                    sec.Sec(txtOzelKod2, KartTuru.Kasa);
        }
    }
}