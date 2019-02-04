
using OgrenciTakip.BLL.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;

namespace OgrenciTakip.UI.Win.Forms.YakinlikForms
{
    public partial class YakinlikEditForm : BaseEditForm
    {
        public YakinlikEditForm()
        {
            InitializeComponent();

            dataLayoutControl = myDataLayoutControl;
            bll = new YakinlikBll(myDataLayoutControl);
            kartTuru = KartTuru.Yakinlik;
            EventsLoad();
        }

        protected internal override void Yukle()
        {
            oldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new Yakinlik() : ((YakinlikBll)bll).Single(FilterFunctions.Filter<Yakinlik>(id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            id = BaseIslemTuru.IdOlustur(oldEntity);
            txtKod.Text = ((YakinlikBll)bll).YeniKodVer();
            txtYakinlikAdi.Focus();
        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (Yakinlik)oldEntity;
            txtKod.Text = entity.Kod;
            txtYakinlikAdi.Text = entity.YakinlikAdi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }
        protected override void GuncelNesneOlustur()
        {
            currentEnttiy = new Yakinlik
            {
                Id = id,
                Kod = txtKod.Text,
                YakinlikAdi = txtYakinlikAdi.Text,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn
            };

            ButonEnabledDurumu();
        }
    }
}