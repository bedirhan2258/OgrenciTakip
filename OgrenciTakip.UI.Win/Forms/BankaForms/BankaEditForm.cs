
using DevExpress.XtraEditors;
using OgrenciTakip.BLL.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.DTO;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;

namespace OgrenciTakip.UI.Win.Forms.BankaForms
{
    public partial class BankaEditForm : BaseEditForm
    {
        public BankaEditForm()
        {
            InitializeComponent();

            dataLayoutControl = myDataLayoutControl;
            bll = new BankaBll(myDataLayoutControl);
            kartTuru = KartTuru.Banka;
            EventsLoad();
        }
        protected internal override void Yukle()
        {
            oldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new BankaS() : ((BankaBll)bll).Single(FilterFunctions.Filter<Banka>(id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            id = BaseIslemTuru.IdOlustur(oldEntity);
            txtKod.Text = ((BankaBll)bll).YeniKodVer();
            txtBankaAdi.Focus();
        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (BankaS)oldEntity;

            txtKod.Text = entity.Kod;
            txtBankaAdi.Text = entity.BankaAdi;
            txtOzelKod1.Id = entity.OzelKod1Id;
            txtOzelKod1.Text = entity.OzelKod1Adi;
            txtOzelKod2.Id = entity.OzelKod2Id;
            txtOzelKod2.Text = entity.OzelKod2Adi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }
        protected override void GuncelNesneOlustur()
        {
            currentEnttiy = new Banka
            {
                Id = id,
                Kod = txtKod.Text,
                BankaAdi = txtBankaAdi.Text,
                OzelKod1Id = txtOzelKod1.Id,
                OzelKod2Id = txtOzelKod2.Id,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn
            };
            ButonEnabledDurumu();
        }
        protected override void SecimYap(object sender)
        {
            if (!(sender is ButtonEdit)) return;

            using (var sec = new SelectFunctions())
                if (sender == txtOzelKod1)
                    sec.Sec(txtOzelKod1, KartTuru.Banka);
                else if (sender == txtOzelKod2)
                    sec.Sec(txtOzelKod2, KartTuru.Banka);
        }
    }
}