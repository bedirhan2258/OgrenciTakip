
using OgrenciTakip.BLL.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;

namespace OgrenciTakip.UI.Win.Forms.RehberForms
{
    public partial class RehberEditForm : BaseEditForm
    {
        public RehberEditForm()
        {
            InitializeComponent();

            dataLayoutControl = myDataLayoutControl;
            bll = new RehberBll(myDataLayoutControl);
            kartTuru = KartTuru.Rehber;
            EventsLoad();
        }
        protected internal override void Yukle()
        {
            oldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new Rehber() : ((RehberBll)bll).Single(FilterFunctions.Filter<Rehber>(id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            id = BaseIslemTuru.IdOlustur(oldEntity);
            txtKod.Text = ((RehberBll)bll).YeniKodVer();
            txtAdiSoyadi.Focus();
        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (Rehber)oldEntity;
            txtKod.Text = entity.Kod;
            txtAdiSoyadi.Text = entity.AdiSoyadi;
            txtTelefon1.Text = entity.Telefon1;
            txtTelefon2.Text = entity.Telefon2;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }
        protected override void GuncelNesneOlustur()
        {
            currentEnttiy = new Rehber
            {
                Id = id,
                Kod = txtKod.Text,
                AdiSoyadi = txtAdiSoyadi.Text,
                Aciklama = txtAciklama.Text,
                Telefon1 = txtTelefon1.Text,
                Telefon2 = txtTelefon2.Text,
                Durum = tglDurum.IsOn
            };

            ButonEnabledDurumu();
        }
    }
}