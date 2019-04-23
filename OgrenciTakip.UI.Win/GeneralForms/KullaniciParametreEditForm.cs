
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using OgrenciTakip.BLL.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.DTO;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.Model.Entities.Base.Interfaces;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.UserControls.Controls;
using System;
using System.Drawing;

namespace OgrenciTakip.UI.Win.GeneralForms
{
    public partial class KullaniciParametreEditForm : BaseEditForm
    {
        private readonly long _kullaniciId;

        public KullaniciParametreEditForm(params object[] prm)
        {
            InitializeComponent();

            _kullaniciId = (long)prm[0];
            dataLayoutControl = myDataLayoutControl;
            bll = new KullaniciParametreBll();
            HideItems = new BarItem[] { btnYeni, btnSil };
            EventsLoad();
          }

        protected internal override void Yukle()
        {
            oldEntity = ((KullaniciParametreBll)bll).Single(x => x.KullaniciId == _kullaniciId) ?? new KullaniciParametreS();
            BaseIslemTuru = oldEntity.Id == 0 ? IslemTuru.EntityInsert : IslemTuru.EntityUpdate;
            NesneyiKontrollereBagla();
            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            id = BaseIslemTuru.IdOlustur(oldEntity);
         
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (KullaniciParametreS)oldEntity;
            id = entity.Id;
            txtDefaultAvukatHesap.Id = entity.DefaultAvukatHesapId;
            txtDefaultAvukatHesap.Text = entity.DefaultAvukatHesapAdi;
            txtDefaultBankaHesap.Id = entity.DefaultBankaHesapId;
            txtDefaultBankaHesap.Text = entity.DefaultBankaHesapAdi;
            txtDefaultKasaHesap.Id = entity.DefaultKasaHesapId;
            txtDefaultKasaHesap.Text = entity.DefaultKasaHesapAdi;
            txtRaporlariOnayAlmadanKapat.Checked = entity.RaporlariOnayAlmadanKapat;
            txtTableViewCaptionForeColor.Color = Color.FromArgb(entity.TableViewCaptionForeColor);
            txtTableColumnHeaderForeColor.Color = Color.FromArgb(entity.TableColumnHeaderForeColor);
            txtTableBandPanelForeColor.Color = Color.FromArgb(entity.TableBandPanelForeColor);
            imgArkaPlanResim.EditValue = entity.ArkaPlanResim;
        }

        protected override void GuncelNesneOlustur()
        {
            currentEnttiy = new KullaniciParametre
            {
                Id = id,
                Kod = "Param-001",
                KullaniciId = AnaForm.KullaniciId,
                DefaultAvukatHesapId = txtDefaultAvukatHesap.Id,
                DefaultBankaHesapId = txtDefaultBankaHesap.Id,
                DefaultKasaHesapId = txtDefaultKasaHesap.Id,
                RaporlariOnayAlmadanKapat = txtRaporlariOnayAlmadanKapat.Checked,
                TableViewCaptionForeColor = txtTableViewCaptionForeColor.Color.ToArgb(),
                TableColumnHeaderForeColor = txtTableColumnHeaderForeColor.Color.ToArgb(),
                TableBandPanelForeColor = txtTableBandPanelForeColor.Color.ToArgb(),
                ArkaPlanResim = (byte[])imgArkaPlanResim.EditValue,
            };

            ButonEnabledDurumu();
        }

        protected internal override IBaseEntity ReturnEntity()
        {
            var entity = new KullaniciParametreS()
            {
                DefaultAvukatHesapId = txtDefaultAvukatHesap.Id,
                DefaultAvukatHesapAdi = txtDefaultAvukatHesap.Text,
                DefaultBankaHesapId = txtDefaultBankaHesap.Id,
                DefaultBankaHesapAdi = txtDefaultBankaHesap.Text,
                DefaultKasaHesapId = txtDefaultKasaHesap.Id,
                DefaultKasaHesapAdi = txtDefaultKasaHesap.Text,
                RaporlariOnayAlmadanKapat = txtRaporlariOnayAlmadanKapat.Checked,
                TableViewCaptionForeColor = txtTableViewCaptionForeColor.Color.ToArgb(),
                TableColumnHeaderForeColor = txtTableColumnHeaderForeColor.Color.ToArgb(),
                TableBandPanelForeColor = txtTableBandPanelForeColor.ForeColor.ToArgb(),
                ArkaPlanResim = (byte[])imgArkaPlanResim.EditValue,

            };

            return entity;
        }

        protected override bool EntityInsert()
        {
            var result = base.EntityInsert();
            if (!result) return false;
            ReturnEntity();
            return true;
        }

        protected override bool EntityUpdate()
        {
            var result = base.EntityUpdate();
            if (!result) return false;
            ReturnEntity();
            return true;
        }

        protected override void Control_Enter(object sender, EventArgs e)
        {
            if (!(sender is MyPictureEdit resim)) return;
            resim.Sec(resimMenu);
        }

        protected override void SecimYap(object sender)
        {
            if (!(sender is ButtonEdit)) return;

            using (var sec = new SelectFunctions())

                if (sender == txtDefaultAvukatHesap)
                    sec.Sec(txtDefaultAvukatHesap);
                else if (sender == txtDefaultBankaHesap)
                    sec.Sec(txtDefaultBankaHesap);
                else if (sender == txtDefaultKasaHesap)
                    sec.Sec(txtDefaultKasaHesap);
        }
    }
}