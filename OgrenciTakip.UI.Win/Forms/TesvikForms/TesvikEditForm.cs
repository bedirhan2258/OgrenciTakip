using OgrenciTakip.BLL.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;

namespace OgrenciTakip.UI.Win.Forms.TesvikForms
{
    public partial class TesvikEditForm : BaseEditForm
    {
        public TesvikEditForm()
        {
            InitializeComponent();

            dataLayoutControl = myDataLayoutControl;
            bll = new TesvikBll(myDataLayoutControl);
            kartTuru = KartTuru.Tesvik;
            EventsLoad();
        }
        protected internal override void Yukle()
        {
            oldEntity = islemTuru == IslemTuru.EntityInsert ? new Tesvik() : ((TesvikBll)bll).Single(FilterFunctions.Filter<Tesvik>(id));
            NesneyiKontrollereBagla();

            if (islemTuru != IslemTuru.EntityInsert) return;
            id = islemTuru.IdOlustur(oldEntity);
            txtKod.Text = ((TesvikBll)bll).YeniKodVer();
            txtTesvikAdi.Focus();
        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (Tesvik)oldEntity;
            txtKod.Text = entity.Kod;
            txtTesvikAdi.Text = entity.TesvikAdi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }
        protected override void GuncelNesneOlustur()
        {
            currentEnttiy = new Tesvik
            {
                Id = id,
                Kod = txtKod.Text,
                TesvikAdi = txtTesvikAdi.Text,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn
            };

            ButonEnabledDurumu();
        }
    }
}