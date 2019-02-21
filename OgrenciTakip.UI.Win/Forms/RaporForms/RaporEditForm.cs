
using OgrenciTakip.BLL.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;

namespace OgrenciTakip.UI.Win.Forms.RaporForms
{
    public partial class RaporEditForm : BaseEditForm
    {
        #region Variables
        private readonly KartTuru _raporTuru;
        private readonly RaporBolumTuru _raporBolumTuru;
        private readonly byte[] _dosya;
        #endregion

        public RaporEditForm(params object[] prm)
        {
            InitializeComponent();
            dataLayoutControl = myDataLayoutControl;
            bll = new RaporBll(myDataLayoutControl);
            kartTuru = KartTuru.Rapor;
            EventsLoad();

            _raporTuru = (KartTuru)prm[0];
            _raporBolumTuru = (RaporBolumTuru)prm[1];
            _dosya = (byte[])prm[2];
        }

        protected internal override void Yukle()
        {
            oldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new Rapor() : ((RaporBll)bll).Single(FilterFunctions.Filter<Rapor>(id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            id = BaseIslemTuru.IdOlustur(oldEntity);
            txtKod.Text = ((RaporBll)bll).YeniKodVer();
            txtRaporAdi.Focus();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (Rapor)oldEntity;
            txtKod.Text = entity.Kod;
            txtRaporAdi.Text = entity.RaporAdi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }
        protected override void GuncelNesneOlustur()
        {
            currentEnttiy = new Rapor
            {
                Id = id,
                Kod = txtKod.Text,
                RaporAdi = txtRaporAdi.Text,

                RaporBolumTuru = _raporBolumTuru,
                Dosya = _dosya,
                RaporTuru = _raporTuru,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn
            };

            ButonEnabledDurumu();
        }

        protected override bool EntityInsert()
        {
            return ((RaporBll)bll).Insert(currentEnttiy, x => x.Kod == currentEnttiy.Kod && x.RaporTuru == _raporTuru);
        }

        protected override bool EntityUpdate()
        {
            return ((RaporBll)bll).Update(oldEntity, currentEnttiy, x => x.Kod == currentEnttiy.Kod && x.RaporTuru == _raporTuru);
        }
    }
}