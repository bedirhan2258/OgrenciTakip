
using OgrenciTakip.BLL.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.GeneralForms;
using OgrenciTakip.UI.Win.Show;

namespace OgrenciTakip.UI.Win.Forms.IndirimForms
{
    public partial class IndirimListForm : BaseListForm
    {
        public IndirimListForm()
        {
            InitializeComponent();
            bll = new IndirimBll();
        }
        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            kartTuru = KartTuru.Indirim;
            formShow = new ShowEditForms<IndirimEditForm>();
            navigator = longNavigator.Navigator;
        }
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((IndirimBll)bll).List(x => x.Durum == aktifKartlariGoster && x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId);
        }
    }
}