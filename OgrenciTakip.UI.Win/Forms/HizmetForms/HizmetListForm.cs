
using OgrenciTakip.BLL.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.GeneralForms;
using OgrenciTakip.UI.Win.Show;
using System;

namespace OgrenciTakip.UI.Win.Forms.HizmetForms
{
    public partial class HizmetListForm : BaseListForm
    {
        public HizmetListForm()
        {
            InitializeComponent();
            bll = new HizmetBll();
        }
        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            kartTuru = KartTuru.Hizmet;
            formShow = new ShowEditForms<HizmetEditForm>();
            navigator = longNavigator.Navigator;
            TarihAyarla();
        }
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((HizmetBll)bll).List(x => x.Durum == aktifKartlariGoster
            && x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId);

        }
        private void TarihAyarla()
        {
            txtHizmetBaslamaTarihi.Properties.MinValue = AnaForm.GunTarihininOncesineHizmetBaslamaTarihiGirilebilir ? AnaForm.EgitimBaslamaTarihi : DateTime.Now.Date < AnaForm.EgitimBaslamaTarihi ? AnaForm.EgitimBaslamaTarihi : DateTime.Now.Date;

            txtHizmetBaslamaTarihi.Properties.MaxValue = AnaForm.GunTarihininSonrasinaHizmetBaslamaTarihiGirilebilir ? AnaForm.DonemBitisTarihi :
                DateTime.Now.Date < AnaForm.EgitimBaslamaTarihi ? AnaForm.EgitimBaslamaTarihi : DateTime.Now.Date > AnaForm.DonemBitisTarihi ? AnaForm.DonemBitisTarihi : DateTime.Now.Date;

            txtHizmetBaslamaTarihi.DateTime = DateTime.Now.Date <= AnaForm.EgitimBaslamaTarihi ? AnaForm.EgitimBaslamaTarihi : DateTime.Now.Date > AnaForm.EgitimBaslamaTarihi && DateTime.Now.Date <= AnaForm.DonemBitisTarihi ? DateTime.Now.Date :
                DateTime.Now.Date > AnaForm.DonemBitisTarihi ? AnaForm.DonemBitisTarihi : DateTime.Now.Date;
        }
    }
}