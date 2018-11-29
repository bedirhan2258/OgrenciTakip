
using OgrenciTakip.BLL.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;

namespace OgrenciTakip.UI.Win.Forms.GorevForms
{
    public partial class GorevEditForm : BaseEditForm
    {
        public GorevEditForm()
        {
            InitializeComponent();
            dataLayoutControl = myDataLayoutControl;
            bll = new GorevBll(myDataLayoutControl);
            kartTuru = KartTuru.Gorev;
            EventsLoad();
        }

        protected internal override void Yukle()
        {
            oldEntity = islemTuru == IslemTuru.EntityInsert ? new Gorev() : ((GorevBll)bll).Single(FilterFunctions.Filter<Gorev>(id));
            NesneyiKontrollereBagla();

            if (islemTuru != IslemTuru.EntityInsert) return;
            id = islemTuru.IdOlustur(oldEntity);
            txtKod.Text = ((GorevBll)bll).YeniKodVer();
            txtGorevAdi.Focus();
        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (Gorev)oldEntity;
            txtKod.Text = entity.Kod;
            txtGorevAdi.Text = entity.GorevAdi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }
        protected override void GuncelNesneOlustur()
        {
            currentEnttiy = new Gorev
            {
                Id = id,
                Kod = txtKod.Text,
                GorevAdi = txtGorevAdi.Text,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn
            };

            ButonEnabledDurumu();
        }
    }
}