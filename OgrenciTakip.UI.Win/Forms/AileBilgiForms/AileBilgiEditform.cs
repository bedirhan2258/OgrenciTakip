using OgrenciTakip.BLL.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;

namespace OgrenciTakip.UI.Win.Forms.AileBilgiForms
{
    public partial class AileBilgiEditForm : BaseEditForm
    {
        public AileBilgiEditForm()
        {
            InitializeComponent();

            dataLayoutControl = myDataLayoutControl;
            bll = new AileBilgiBll(myDataLayoutControl);
            
            kartTuru = KartTuru.AileBilgi;
            EventsLoad();
        }
        protected internal override void Yukle()
        {
            oldEntity = islemTuru == IslemTuru.EntityInsert ? new AileBilgi() : ((AileBilgiBll)bll).Single(FilterFunctions.Filter<AileBilgi>(id));
            NesneyiKontrollereBagla();

            if (islemTuru != IslemTuru.EntityInsert) return;
            id = islemTuru.IdOlustur(oldEntity);
            txtKod.Text = ((AileBilgiBll)bll).YeniKodVer();
            txtBilgiAdi.Focus();
        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (AileBilgi)oldEntity;
            txtKod.Text = entity.Kod;
            txtBilgiAdi.Text = entity.BilgiAdi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }
        protected override void GuncelNesneOlustur()
        {
            currentEnttiy = new AileBilgi
            {
                Id = id,
                Kod = txtKod.Text,
                BilgiAdi = txtBilgiAdi.Text,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn
            };

            ButonEnabledDurumu();
        }

    }
}