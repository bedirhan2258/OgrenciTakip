
using OgrenciTakip.BLL.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.GeneralForms;
using OgrenciTakip.UI.Win.Show;

namespace OgrenciTakip.UI.Win.Forms.PromosyonForms
{
    public partial class PromosyonListForm : BaseListForm
    {
        public PromosyonListForm()
        {
            InitializeComponent();
            bll = new PromosyonBll();
        }
        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            kartTuru = KartTuru.Promosyon;
            navigator = longNavigator.Navigator;
            formShow = new ShowEditForms<PromosyonEditForm>();
        }
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((PromosyonBll)bll).List(x => x.Durum == aktifKartlariGoster
            && x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId);
        }
    }
}