
using OgrenciTakip.BLL.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;

namespace OgrenciTakip.UI.Win.Forms.YabanciDilForms
{
    public partial class YabanciDİlEditForm : BaseEditForm
    {
        public YabanciDİlEditForm()
        {
            InitializeComponent();

            dataLayoutControl = myDataLayoutControl;
            bll = new YabanciDilBll(myDataLayoutControl);
            kartTuru = KartTuru.YabanciDil;
            EventsLoad();
        }

        protected internal override void Yukle()
        {
            oldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new YabanciDil() : ((YabanciDilBll)bll).Single(FilterFunctions.Filter<YabanciDil>(id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            id = BaseIslemTuru.IdOlustur(oldEntity);
            txtKod.Text = ((YabanciDilBll)bll).YeniKodVer();
            txtDilAdi.Focus();
        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (YabanciDil)oldEntity;
            txtKod.Text = entity.Kod;
            txtDilAdi.Text = entity.DilAdi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }
        protected override void GuncelNesneOlustur()
        {
            currentEnttiy = new YabanciDil
            {
                Id = id,
                Kod = txtKod.Text,
                DilAdi = txtDilAdi.Text,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn
            };

            ButonEnabledDurumu();
        }
    }
}