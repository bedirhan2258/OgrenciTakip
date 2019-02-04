
using DevExpress.XtraEditors;
using OgrenciTakip.BLL.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.DTO;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.GeneralForms;
using System;

namespace OgrenciTakip.UI.Win.Forms.IndirimForms
{
    public partial class IndirimEditForm : BaseEditForm
    {
        public IndirimEditForm()
        {
            InitializeComponent();
            dataLayoutControl = myDataLayoutControl;
            bll = new IndirimBll(myDataLayoutControl);
            kartTuru = KartTuru.Indirim;
            EventsLoad();
        }
        protected internal override void Yukle()
        {
            oldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new IndirimS() : ((IndirimBll)bll).Single(FilterFunctions.Filter<Indirim>(id));
            NesneyiKontrollereBagla();
            TabloYukle();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            id = BaseIslemTuru.IdOlustur(oldEntity);
            txtKod.Text = ((IndirimBll)bll).YeniKodVer(x => x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId);
            txtIndirimAdi.Focus();
        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (IndirimS)oldEntity;

            txtKod.Text = entity.Kod;
            txtIndirimAdi.Text = entity.IndirimAdi;
            txtIndirimTuru.Id = entity.IndirimTuruId;
            txtIndirimTuru.Text = entity.IndirimTuruAdi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }
        protected override void GuncelNesneOlustur()
        {
            currentEnttiy = new Indirim
            {
                Id = id,
                Kod = txtKod.Text,
                IndirimAdi = txtIndirimAdi.Text,
                IndirimTuruId = Convert.ToInt64(txtIndirimTuru.Id),
                Aciklama = txtAciklama.Text,
                DonemId = AnaForm.DonemId,
                SubeId = AnaForm.SubeId,
                Durum = tglDurum.IsOn

            };
            ButonEnabledDurumu();
        }

        protected internal override void ButonEnabledDurumu()
        {
            if (!isLoaded) return;
            GeneralFunctions.ButtonEnabledDurumu(btnYeni, btnKaydet, btnGeriAl, btnSil, oldEntity, currentEnttiy, hizmetTablo.TableValueChanged);
        }

        protected override bool EntityInsert()
        {
            if (hizmetTablo.HataliGiris()) return false;

            return ((IndirimBll)bll).Insert(currentEnttiy, x => x.Kod == currentEnttiy.Kod &&
             x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId) && hizmetTablo.Kaydet();
        }
        protected override bool EntityUpdate()
        {
            if (hizmetTablo.HataliGiris()) return false;
            return ((IndirimBll)bll).Update(oldEntity, currentEnttiy, x => x.Kod == currentEnttiy.Kod &&
            x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId) && hizmetTablo.Kaydet();
        }
        protected override void SecimYap(object sender)
        {
            if (!(sender is ButtonEdit)) return;

            using (var sec = new SelectFunctions())
                if (sender == txtIndirimTuru)
                    sec.Sec(txtIndirimTuru);
        }
        protected override void TabloYukle()
        {
            hizmetTablo.OwnerForm = this;
            hizmetTablo.Yukle();
        }
    }
}