
using OgrenciTakip.BLL.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;

namespace OgrenciTakip.UI.Win.Forms.IlForms
{
    public partial class IlEditForm : BaseEditForm
    {
        public IlEditForm()
        {
            InitializeComponent();
            dataLayoutControl = myDataLayoutControl;
            bll = new IlBLL(myDataLayoutControl);
            kartTuru = KartTuru.Il;
            EventsLoad();

        }

        protected internal override void Yukle()
        {
            oldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new Il() : ((IlBLL)bll).Single(FilterFunctions.Filter<Il>(id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            id = BaseIslemTuru.IdOlustur(oldEntity);
            txtKod.Text = ((IlBLL)bll).YeniKodVer();
            txtIlAdi.Focus();
        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (Il)oldEntity;

            txtKod.Text = entity.Kod;
            txtIlAdi.Text = entity.IlAdi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }
        protected override void GuncelNesneOlustur()
        {
            currentEnttiy = new Il
            {
                Id = id,
                Kod = txtKod.Text,
                IlAdi = txtIlAdi.Text,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn
            };
            ButonEnabledDurumu();
        }
    }
}