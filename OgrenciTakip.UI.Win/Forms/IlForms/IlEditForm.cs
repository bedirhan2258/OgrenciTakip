
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
            oldEntity = islemTuru == IslemTuru.EntityInsert ? new Il() : ((IlBLL)bll).Single(FilterFunctions.Filter<Il>(id));
            NesneyiKontrollereBagla();

            if (islemTuru != IslemTuru.EntityInsert) return;
            txtKod.Text = ((OkulBLL)bll).YeniKodVer();
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
            currentEnttiy = new Okul
            {
                Id = id,
                Kod = txtKod.Text,
                Aciklama = memoAciklama.Text,
                Durum = tglDurum.IsOn
            };
            ButonEnabledDurumu();
        }
    }
}