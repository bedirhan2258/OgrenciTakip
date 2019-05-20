
using DevExpress.XtraEditors;
using OgrenciTakip.BLL.Functions;
using OgrenciTakip.BLL.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Common.Functions;
using OgrenciTakip.Data.Context;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Yonetim.Forms.BaseForms;
//using OgrenciTakip.UI.Yonetim.Functions;
using System;
using System.Security;

namespace OgrenciTakip.UI.Yonetim.GeneralForms
{
    public partial class KurumEditForm : BaseEditForm
    {
        #region Variables
        private readonly string _server;
        private readonly SecureString _kullaniciAdi;
        private readonly SecureString _sifre;
        private readonly YetkilendirmeTuru _yetkilendirmeTuru;
        #endregion

        public KurumEditForm(params object[] prm)
        {
            InitializeComponent();

            dataLayoutControl = myDataLayoutControl;
            bll = new KurumBll(myDataLayoutControl);
            kartTuru = KartTuru.Kurum;
            txtYetkilendirmeTuru.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<YetkilendirmeTuru>());
            EventsLoad();

            _server = prm[0].ToString();
            _kullaniciAdi = (SecureString)prm[1];
            _sifre = (SecureString)prm[2];
            _yetkilendirmeTuru = (YetkilendirmeTuru)prm[3];
            txtYetkilendirmeTuru.SelectedItem = _yetkilendirmeTuru.ToName();
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

        protected override bool EntityInsert()
        {
            if (!Functions.YonetimGeneralFunctions.BaglantiKontrolu(txtServer.Text, txtKullaniciAdi.Text.ConvertToSecureString(), txtSifre.Text.ConvertToSecureString(), txtYetkilendirmeTuru.Text.GetEnum<YetkilendirmeTuru>())) return false;

            Functions.YonetimGeneralFunctions.CreateConnectionString(txtKod.Text, txtServer.Text, txtKullaniciAdi.Text.ConvertToSecureString(), txtSifre.Text.ConvertToSecureString(), txtYetkilendirmeTuru.Text.GetEnum<YetkilendirmeTuru>());

            if (!Functions.YonetimGeneralFunctions.CreateDatabase<OgrenciTakipContext>("Lütfen Bekleyiniz", "Kurum Veritabanı Oluşturuluyor.", "Kurum Veritabanı Oluşturulacaktır. Onaylıyor Musunuz?", "Kurum Veritabanı Başarılı Bir Şekilde Oluşturuldu.")) return false;

            Functions.YonetimGeneralFunctions.CreateConnectionString("OgrenciTakip2018_Yonetim", txtServer.Text, txtKullaniciAdi.Text.ConvertToSecureString(), txtSifre.Text.ConvertToSecureString(), txtYetkilendirmeTuru.Text.GetEnum<YetkilendirmeTuru>());
            return base.EntityInsert();
        }

        protected override bool EntityUpdate()
        {
            if (!Functions.YonetimGeneralFunctions.BaglantiKontrolu(txtServer.Text, txtKullaniciAdi.Text.ConvertToSecureString(), txtSifre.Text.ConvertToSecureString(), txtYetkilendirmeTuru.Text.GetEnum<YetkilendirmeTuru>())) return false;

            Functions.YonetimGeneralFunctions.CreateConnectionString("OgrenciTakip2018_Yonetim", txtServer.Text, txtKullaniciAdi.Text.ConvertToSecureString(), txtSifre.Text.ConvertToSecureString(), txtYetkilendirmeTuru.Text.GetEnum<YetkilendirmeTuru>());

            return base.EntityUpdate();
        }

        protected override void Control_SelectedValueChanged(object sender, EventArgs e)
        {

            if (!(sender is ComboBoxEdit edit)) return;
            var yetkilendirmeTuru = edit.Text.GetEnum<YetkilendirmeTuru>();

            txtKullaniciAdi.Enabled = yetkilendirmeTuru == YetkilendirmeTuru.SqlServer;
            txtSifre.Enabled = yetkilendirmeTuru == YetkilendirmeTuru.SqlServer;
            txtKullaniciAdi.Focus();

            if (yetkilendirmeTuru != YetkilendirmeTuru.Windows) return;
            txtKullaniciAdi.Text = "";
            txtSifre.Text = "";
        }

        private void txtKod_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}