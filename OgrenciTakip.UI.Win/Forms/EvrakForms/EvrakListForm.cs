

using OgrenciTakip.BLL.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.GeneralForms;
using OgrenciTakip.UI.Win.Show;

namespace OgrenciTakip.UI.Win.Forms.EvrakForms
{
    public partial class EvrakListForm : BaseListForm
    {
        public EvrakListForm()
        {
            InitializeComponent();

            bll = new EvrakBll();
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            kartTuru = KartTuru.Evrak;
            navigator = longNavigator.Navigator;
            formShow = new ShowEditForms<EvrakEditForm>();
        }
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((EvrakBll)bll).List(x => x.Durum == aktifKartlariGoster
            && x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId);
        }
    }
}