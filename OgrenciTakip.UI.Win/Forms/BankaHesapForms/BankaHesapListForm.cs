
using OgrenciTakip.BLL.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.GeneralForms;
using OgrenciTakip.UI.Win.Show;

namespace OgrenciTakip.UI.Win.Forms.BankaHesapForms
{
    public partial class BankaHesapListForm : BaseListForm
    {
        public BankaHesapListForm()
        {
            InitializeComponent();
            bll = new BankaHesapBll();
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            kartTuru = KartTuru.BankaHesap;
            formShow = new ShowEditForms<BankaHesapEditForm>();
            navigator = longNavigator.Navigator;
        }
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((BankaHesapBll)bll).List(x => x.Durum == aktifKartlariGoster && x.SubeId == AnaForm.SubeId);
        }

    }
}