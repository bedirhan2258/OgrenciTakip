
using DevExpress.XtraEditors;
using OgrenciTakip.BLL.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Common.Functions;
using OgrenciTakip.Model.DTO;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.GeneralForms;
using System;

namespace OgrenciTakip.UI.Win.Forms.BankaHesapForms
{
    public partial class BankaHesapEditForm : BaseEditForm
    {
        public BankaHesapEditForm()
        {
            InitializeComponent();

            dataLayoutControl = myDataLayoutControl;
            bll = new BankaHesapBll(myDataLayoutControl);
            txtHesapTuru.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<BankaHesapTuru>());
            kartTuru = KartTuru.BankaHesap;
            EventsLoad();
        }

        protected internal override void Yukle()
        {
            oldEntity = islemTuru == IslemTuru.EntityInsert ? new BankaHesapS() : ((BankaHesapBll)bll).Single(FilterFunctions.Filter<BankaHesap>(id));
            NesneyiKontrollereBagla();

            if (islemTuru != IslemTuru.EntityInsert) return;
            id = islemTuru.IdOlustur(oldEntity);
            txtKod.Text = ((BankaHesapBll)bll).YeniKodVer(x => x.SubeId == AnaForm.SubeId);
            txtHesapAdi.Focus();
        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (BankaHesapS)oldEntity;

            txtKod.Text = entity.Kod;
            txtHesapAdi.Text = entity.HesapAdi;
            txtHesapTuru.SelectedItem = entity.HesapTuru.ToName();
            txtBanka.Id = entity.BankaId;
            txtBanka.Text = entity.BankaAdi;
            txtBankaSube.Id = entity.BankaSubeId;
            txtBankaSube.Text = entity.BankaSubeAdi;
            txtBlokeGunSayisi.Value = entity.BlokeGunSayisi;
            txtIsyeriNo.Text = entity.IsyeriNo;
            txtTerninalNo.Text = entity.TerminalNo;
            txtHesapAcilisTarihi.DateTime = entity.HesapAcilisTarihi;
            txtHesapNo.Text = entity.HesapNo;
            txtIbanNo.Text = entity.IbanNo;
            txtOzelKod1.Id = entity.OzelKod1Id;
            txtOzelKod1.Text = entity.OzelKod1Adi;
            txtOzelKod2.Id = entity.OzelKod2Id;
            txtOzelKod2.Text = entity.OzelKod2Adi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }
        protected override void GuncelNesneOlustur()
        {
            BankaHesapTuru hesap= txtHesapTuru.Text.GetEnum<BankaHesapTuru>();

            currentEnttiy = new BankaHesap
            {
                Id = id,
                Kod = txtKod.Text,
                HesapAdi = txtHesapAdi.Text,
                HesapTuru = txtHesapTuru.Text.GetEnum<BankaHesapTuru>(),
                BankaId = Convert.ToInt64(txtBanka.Id),
                BankaSubeId = Convert.ToInt64(txtBankaSube.Id),
                BlokeGunSayisi = (byte)txtBlokeGunSayisi.Value,
                IsyeriNo = txtIsyeriNo.Text,
                TerminalNo = txtTerninalNo.Text,
                HesapAcilisTarihi = txtHesapAcilisTarihi.DateTime.Date,
                HesapNo = txtHesapNo.Text,
                IbanNo = txtIbanNo.Text,
                OzelKod1Id = txtOzelKod1.Id,
                OzelKod2Id = txtOzelKod2.Id,
                SubeId = AnaForm.SubeId,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn
            };
            ButonEnabledDurumu();
        }
        protected override bool EntityInsert()
        {
            return ((BankaHesapBll)bll).Insert(currentEnttiy, x => x.Kod == currentEnttiy.Kod &&
             x.SubeId == AnaForm.SubeId);
        }
        protected override bool EntityUpdate()
        {
            return ((BankaHesapBll)bll).Update(oldEntity, currentEnttiy, x => x.Kod == currentEnttiy.Kod &&
            x.SubeId == AnaForm.SubeId);
        }

        protected override void SecimYap(object sender)
        {
            if (!(sender is ButtonEdit)) return;

            using (var sec = new SelectFunctions())
                if (sender == txtBanka)
                    sec.Sec(txtBanka);
                else if (sender == txtBankaSube)
                    sec.Sec(txtBankaSube, txtBanka);
                else if (sender == txtOzelKod1)
                    sec.Sec(txtOzelKod1, KartTuru.BankaHesap);
                else if (sender == txtOzelKod2)
                    sec.Sec(txtOzelKod2, KartTuru.BankaHesap);
        }

        protected override void Control_EnabledChange(object sender, EventArgs e)
        {
            if (sender != txtBanka) return;
            txtBanka.ControlEnabledChange(txtBankaSube);

        }
        protected override void Control_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!(sender is ComboBoxEdit edt)) return;
            var hesapTuru = edt.Text.GetEnum<BankaHesapTuru>();
            if (hesapTuru == BankaHesapTuru.EpostBlokeHesabi || hesapTuru == BankaHesapTuru.OtsBlokeHesabi || hesapTuru == BankaHesapTuru.PostBlokeHesabi)
            {
                txtBlokeGunSayisi.Enabled = true;
                txtIsyeriNo.Enabled = true;
                txtTerninalNo.Enabled = true;
            }
            else
            {
                txtBlokeGunSayisi.Enabled = false;
                txtIsyeriNo.Enabled = false;
                txtTerninalNo.Enabled = false;
                txtBlokeGunSayisi.Value = 0;
                txtIsyeriNo.Text = null;
                txtTerninalNo.Text = null;
            }
        }
    }
}