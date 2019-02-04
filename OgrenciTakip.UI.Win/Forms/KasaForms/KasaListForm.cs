
using OgrenciTakip.BLL.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.GeneralForms;
using OgrenciTakip.UI.Win.Show;

namespace OgrenciTakip.UI.Win.Forms.KasaForms
{
    public partial class CarliListForm : BaseListForm
    {
        public CarliListForm()
        {
            InitializeComponent();
            bll = new KasaBll();
        }
        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            kartTuru = KartTuru.Kasa;
            formShow = new ShowEditForms<KasaEditForm>();
            navigator = longNavigator.Navigator;
        }
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((KasaBll)bll).List(x => x.Durum == aktifKartlariGoster && x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId);
        }
    }
}