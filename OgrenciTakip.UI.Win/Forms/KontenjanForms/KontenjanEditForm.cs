
using OgrenciTakip.BLL.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;

namespace OgrenciTakip.UI.Win.Forms.KontenjanForms
{
    public partial class KontenjanEditForm : BaseEditForm
    {
        public KontenjanEditForm()
        {
            InitializeComponent();

            dataLayoutControl = myDataLayoutControl;
            bll = new KontenjanBll(myDataLayoutControl);
            kartTuru = KartTuru.Kontenjan;
            EventsLoad();
        }
        protected internal override void Yukle()
        {
            oldEntity = islemTuru == IslemTuru.EntityInsert ? new Kontenjan() : ((KontenjanBll)bll).Single(FilterFunctions.Filter<Kontenjan>(id));
            NesneyiKontrollereBagla();

            if (islemTuru != IslemTuru.EntityInsert) return;
            id = islemTuru.IdOlustur(oldEntity);
            txtKod.Text = ((KontenjanBll)bll).YeniKodVer();
            txtKontenjanAdi.Focus();
        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (Kontenjan)oldEntity;
            txtKod.Text = entity.Kod;
            txtKontenjanAdi.Text = entity.KontenjanAdi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }
        protected override void GuncelNesneOlustur()
        {
            currentEnttiy = new Kontenjan
            {
                Id = id,
                Kod = txtKod.Text,
                KontenjanAdi = txtKontenjanAdi.Text,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn
            };

            ButonEnabledDurumu();
        }
    }
}