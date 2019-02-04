
using DevExpress.XtraEditors;
using OgrenciTakip.BLL.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.DTO;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.GeneralForms;
using System;

namespace OgrenciTakip.UI.Win.Forms.SinifForms
{
    public partial class SinifEditForm : BaseEditForm
    {
        public SinifEditForm()
        {
            InitializeComponent();
            dataLayoutControl = myDataLayoutControl;
            bll = new SinifBll(myDataLayoutControl);
            kartTuru = KartTuru.Sinif;
            EventsLoad();
        }

        protected internal override void Yukle()
        {
            oldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new SinifS() : ((SinifBll)bll).Single(FilterFunctions.Filter<Sinif>(id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            id = BaseIslemTuru.IdOlustur(oldEntity);
            txtKod.Text = ((SinifBll)bll).YeniKodVer(x => x.SubeId == AnaForm.SubeId);
            txtSinifAdi.Focus();
        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (SinifS)oldEntity;

            txtKod.Text = entity.Kod;
            txtSinifAdi.Text = entity.SinifAdi;
            txtGrup.Id = entity.GrupId;
            txtGrup.Text = entity.GrupAdi;
            txtHedefOgrenciSayisi.Value = entity.HedefOgrenciSayisi;
            txtHedefCiro.Value = entity.HedefCiro;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }
        protected override void GuncelNesneOlustur()
        {
            currentEnttiy = new Sinif
            {
                Id = id,
                Kod = txtKod.Text,
                SinifAdi = txtSinifAdi.Text,
                GrupId = Convert.ToInt64(txtGrup.Id),
                HedefOgrenciSayisi = (int)txtHedefOgrenciSayisi.Value,
                HedefCiro = txtHedefCiro.Value,
                Aciklama = txtAciklama.Text,
                SubeId = AnaForm.SubeId,
                Durum = tglDurum.IsOn

            };
            ButonEnabledDurumu();
        }
        protected override void SecimYap(object sender)
        {
            if (!(sender is ButtonEdit)) return;

            using (var sec = new SelectFunctions())
                if (sender == txtGrup)
                    sec.Sec(txtGrup);
        }
        protected override bool EntityInsert()
        {
            return ((SinifBll)bll).Insert(currentEnttiy, x => x.Kod == currentEnttiy.Kod &&
             x.SubeId == AnaForm.SubeId);
        }
        protected override bool EntityUpdate()
        {
            return ((SinifBll)bll).Update(oldEntity, currentEnttiy, x => x.Kod == currentEnttiy.Kod &&
            x.SubeId == AnaForm.SubeId);
        }
    }
}