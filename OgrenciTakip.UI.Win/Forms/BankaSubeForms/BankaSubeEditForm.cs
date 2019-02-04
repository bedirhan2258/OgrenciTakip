
using OgrenciTakip.BLL.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;

namespace OgrenciTakip.UI.Win.Forms.BankaSubeForms
{
    public partial class BankaSubeEditForm : BaseEditForm
    {
        #region Variables
        private readonly long _bankaId;
        private readonly string _bankaAdi; 
        #endregion
        public BankaSubeEditForm(params object[] prm)
        {
            InitializeComponent();

            _bankaId = (long)prm[0];
            _bankaAdi = prm[1].ToString();

            dataLayoutControl = myDataLayoutControl;
            bll = new BankaSubeBll(myDataLayoutControl);
            kartTuru = KartTuru.BankaSube;
            EventsLoad();
        }
        protected internal override void Yukle()
        {
            oldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new BankaSube() : ((BankaSubeBll)bll).Single(FilterFunctions.Filter<BankaSube>(id));
            NesneyiKontrollereBagla();
            Text = Text + $" - ( {_bankaAdi} )";
            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            id = BaseIslemTuru.IdOlustur(oldEntity);
            txtKod.Text = ((BankaSubeBll)bll).YeniKodVer(x => x.BankaId == _bankaId);
            txtSubeAdi.Focus();
        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (BankaSube)oldEntity;

            txtKod.Text = entity.Kod;
            txtSubeAdi.Text = entity.SubeAdi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }
        protected override void GuncelNesneOlustur()
        {
            currentEnttiy = new BankaSube
            {
                Id = id,
                Kod = txtKod.Text,
                SubeAdi = txtSubeAdi.Text,
                BankaId = _bankaId,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn
            };
            ButonEnabledDurumu();
        }
        protected override bool EntityInsert()
        {
            return ((BankaSubeBll)bll).Insert(currentEnttiy, x => x.Kod == currentEnttiy.Kod && x.BankaId == _bankaId);
        }
        protected override bool EntityUpdate()
        {
            return ((BankaSubeBll)bll).Update(oldEntity, currentEnttiy, x => x.Kod == currentEnttiy.Kod && x.BankaId == _bankaId);
        }
    }
}