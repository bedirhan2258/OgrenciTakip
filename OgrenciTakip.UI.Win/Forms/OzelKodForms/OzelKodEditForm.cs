
using OgrenciTakip.BLL.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;

namespace OgrenciTakip.UI.Win.Forms.OzelKodForms
{
    public partial class OzelKodEditForm : BaseEditForm
    {
        #region Variables
        private readonly KartTuru _ozelKodKartTuru;
        private readonly OzelKodTuru _ozelKodTuru; 
        #endregion
        public OzelKodEditForm(params object[] prm)
        {
            InitializeComponent();

            _ozelKodTuru = (OzelKodTuru)prm[0];
            _ozelKodKartTuru = (KartTuru)prm[1];

            dataLayoutControl = myDataLayoutControl;
            bll = new OzelKodBll(myDataLayoutControl);
            kartTuru = KartTuru.OzelKod;
            EventsLoad();
        }

        protected internal override void Yukle()
        {
            oldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new OzelKod() : ((OzelKodBll)bll).Single(FilterFunctions.Filter<OzelKod>(id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            id = BaseIslemTuru.IdOlustur(oldEntity);
            txtKod.Text = ((OzelKodBll)bll).YeniKodVer(x => x.KodTuru == _ozelKodTuru && x.KartTuru == _ozelKodKartTuru);
            txtOzelKodAdi.Focus();
        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (OzelKod)oldEntity;

            txtKod.Text = entity.Kod;
            txtOzelKodAdi.Text = entity.OzelKodAdi;
            txtAciklama.Text = entity.Aciklama;

        }
        protected override void GuncelNesneOlustur()
        {
            currentEntity = new OzelKod
            {
                Id = id,
                Kod = txtKod.Text,
                OzelKodAdi = txtOzelKodAdi.Text,
                KodTuru = _ozelKodTuru,
                KartTuru = _ozelKodKartTuru,
                Aciklama = txtAciklama.Text,

            };
            ButonEnabledDurumu();
        }
        protected override bool EntityInsert()
        {
            return ((OzelKodBll)bll).Insert(currentEntity, x => x.Kod == currentEntity.Kod && x.KodTuru == _ozelKodTuru && x.KartTuru == _ozelKodKartTuru);
        }
        protected override bool EntityUpdate()
        {
            return ((OzelKodBll)bll).Update(oldEntity, currentEntity, x => x.Kod == currentEntity.Kod && x.KodTuru == _ozelKodTuru && x.KartTuru == _ozelKodKartTuru);
        }
    }
}