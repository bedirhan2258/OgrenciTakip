
using OgrenciTakip.BLL.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;

namespace OgrenciTakip.UI.Win.IptalNedeniForms
{
    public partial class IptalNedeniEditForm : BaseEditForm
    {
        public IptalNedeniEditForm()
        {
            InitializeComponent();

            dataLayoutControl = myDataLayoutControl;
            bll = new IptalNedeniBll(myDataLayoutControl);
            kartTuru = KartTuru.IptalNedeni;
            EventsLoad();
        }
        protected internal override void Yukle()
        {
            oldEntity = islemTuru == IslemTuru.EntityInsert ? new IptalNedeni() : ((IptalNedeniBll)bll).Single(FilterFunctions.Filter<IptalNedeni>(id));
            NesneyiKontrollereBagla();

            if (islemTuru != IslemTuru.EntityInsert) return;
            id = islemTuru.IdOlustur(oldEntity);
            txtKod.Text = ((IptalNedeniBll)bll).YeniKodVer();
            txtIptalNedeniAdi.Focus();
        }
        protected override void NesneyiKontrollereBagla()
        {5
            var entity = (IptalNedeni)oldEntity;
            txtKod.Text = entity.Kod;
            txtIptalNedeniAdi.Text = entity.IptalNedeniAdi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }
        protected override void GuncelNesneOlustur()
        {
            currentEnttiy = new IptalNedeni
            {
                Id = id,
                Kod = txtKod.Text,
                IptalNedeniAdi = txtIptalNedeniAdi.Text,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn
            };

            ButonEnabledDurumu();
        }
    }
}