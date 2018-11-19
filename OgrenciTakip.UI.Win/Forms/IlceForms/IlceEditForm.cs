
using OgrenciTakip.BLL.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;

namespace OgrenciTakip.UI.Win.Forms.IlceForms
{
    public partial class IlceEditForm : BaseEditForm
    {
        #region Variables
        private readonly long _ilId;
        private readonly string _ilAdi;
        #endregion

        public IlceEditForm(params object[] prm)
        {
            InitializeComponent();
            _ilId = (long)prm[0];
            _ilAdi = prm[1].ToString();

            dataLayoutControl = myDataLayoutControl;
            bll = new IlceBLL(myDataLayoutControl);
            kartTuru = KartTuru.Ilce;
            EventsLoad();
        }
        protected internal override void Yukle()
        {
            oldEntity = islemTuru == IslemTuru.EntityInsert ? new Ilce() : ((IlceBLL)bll).Single(FilterFunctions.Filter<Ilce>(id));
            NesneyiKontrollereBagla();
            Text = Text + $" - ( {_ilAdi} )";
            if (islemTuru != IslemTuru.EntityInsert) return;
            id = islemTuru.IdOlustur(oldEntity);
            txtKod.Text = ((IlceBLL)bll).YeniKodVer(x => x.IlId == _ilId);
            txtIlceAdi.Focus();
        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (Ilce)oldEntity;

            txtKod.Text = entity.Kod;
            txtIlceAdi.Text = entity.IlceAdi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }
        protected override void GuncelNesneOlustur()
        {
            currentEnttiy = new Ilce
            {
                Id = id,
                Kod = txtKod.Text,
                IlceAdi = txtIlceAdi.Text,
                IlId = _ilId,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn
            };
            ButonEnabledDurumu();
        }
        protected override bool EntityInsert()
        {
            return ((IlceBLL)bll).Insert(currentEnttiy, x => x.Kod == currentEnttiy.Kod && x.IlId == _ilId);
        }
        protected override bool EntityUpdate()
        {
            return ((IlceBLL)bll).Update(oldEntity, currentEnttiy, x => x.Kod == currentEnttiy.Kod && x.IlId == _ilId);
        }
    }
}