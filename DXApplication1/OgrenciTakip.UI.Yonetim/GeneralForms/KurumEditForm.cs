
using OgrenciTakip.BLL.Functions;
using OgrenciTakip.BLL.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Common.Functions;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Yonetim.Forms.BaseForms;
using System.Security;

namespace OgrenciTakip.UI.Yonetim.GeneralForms
{
    public partial class KurumEditForm : BaseEditForm
    {
        private readonly string _server;
        private readonly SecureString _kullaniciAdi;
        private readonly SecureString _sifre;

        public KurumEditForm()
        {
            InitializeComponent();

            dataLayoutControl = myDataLayoutControl;
            bll = new KurumBll(myDataLayoutControl);
            kartTuru = KartTuru.Kurum;
            txtYetkilendirmeTuru.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<YetkilendirmeTuru>());
            EventsLoad();
        }

        protected internal override void Yukle()
        {
            oldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new Kurum() : ((KurumBll)bll).Single(FilterFunctions.Filter<Kurum>(id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            id = BaseIslemTuru.IdOlustur(oldEntity);
            txtKod.Text = "Yeni_Kurum";
            txtKod.Enabled = true;
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (Kurum)oldEntity;

            txtKod.Text = entity.Kod;
            txtKurumAdi.Text = entity.KurumAdi;
            txtServer.Text = BaseIslemTuru == IslemTuru.EntityInsert ? _server : entity.Server;
            txtYetkilendirmeTuru.SelectedItem = txtYetkilendirmeTuru.Text.GetEnum<YetkilendirmeTuru>();
            txtKullaniciAdi.Text = BaseIslemTuru == IslemTuru.EntityInsert ? _kullaniciAdi.ConvertToUnSecureString() : entity.KullaniciAdi.Decrypt(entity.Id + entity.Kod);
            txtSifre.Text = BaseIslemTuru == IslemTuru.EntityInsert ? _sifre.ConvertToUnSecureString() : entity.Sifre.Decrypt(entity.Id + entity.Kod);
        }

        protected override void GuncelNesneOlustur()
        {
            currentEnttiy = new Kurum
            {
                Id = id,
                Kod = txtKod.Text,
                KurumAdi = txtKurumAdi.Text,
                Server = txtServer.Text,
                YetkilendirmeTuru = txtYetkilendirmeTuru.Text.GetEnum<YetkilendirmeTuru>(),
            };

            ((Kurum)currentEnttiy).KullaniciAdi = txtKullaniciAdi.Text.Encrypt(currentEnttiy.Id + currentEnttiy.Kod);
            ((Kurum)currentEnttiy).Sifre = txtSifre.Text.Encrypt(currentEnttiy.Id + currentEnttiy.Kod);

            ButonEnabledDurumu();
        }

    }
}