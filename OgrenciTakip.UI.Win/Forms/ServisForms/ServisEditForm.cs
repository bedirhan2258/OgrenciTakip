using OgrenciTakip.BLL.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.GeneralForms;

namespace OgrenciTakip.UI.Win.Forms.ServisForms
{
    public partial class ServisEditForm : BaseEditForm
    {
        public ServisEditForm()
        {
            InitializeComponent();

            dataLayoutControl = myDataLayoutControl;
            bll = new ServisBll(myDataLayoutControl);
            kartTuru = KartTuru.Servis;
            EventsLoad();
        }
        protected internal override void Yukle()
        {
            oldEntity = islemTuru == IslemTuru.EntityInsert ? new Servis() : ((ServisBll)bll).Single(FilterFunctions.Filter<Servis>(id));
            NesneyiKontrollereBagla();
            if (islemTuru != IslemTuru.EntityInsert) return;
            id = islemTuru.IdOlustur(oldEntity);
            txtKod.Text = ((ServisBll)bll).YeniKodVer(x => x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId);
            txtServisYeri.Focus();
        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (Servis)oldEntity;

            txtKod.Text = entity.Kod;
            txtServisYeri.Text = entity.ServisYeri;
            txtUcret.Value = entity.Ucret;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }
        protected override void GuncelNesneOlustur()
        {
            currentEnttiy = new Servis
            {
                Id = id,
                Kod = txtKod.Text,
                ServisYeri = txtServisYeri.Text,
                Aciklama = txtAciklama.Text,
                SubeId = AnaForm.SubeId,
                Ucret = txtUcret.Value,
                DonemId = AnaForm.DonemId,
                Durum = tglDurum.IsOn

            };
            ButonEnabledDurumu();
        }
        protected override bool EntityInsert()
        {
            return ((ServisBll)bll).Insert(currentEnttiy, x => x.Kod == currentEnttiy.Kod &&
             x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId);
        }
        protected override bool EntityUpdate()
        {
            return ((ServisBll)bll).Update(oldEntity, currentEnttiy, x => x.Kod == currentEnttiy.Kod &&
            x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId);
        }
    }
}