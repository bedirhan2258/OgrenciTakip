
using OgrenciTakip.BLL.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.GeneralForms;
using OgrenciTakip.UI.Win.Show;

namespace OgrenciTakip.UI.Win.Forms.SinifForms
{
    public partial class SinifListForm : BaseListForm
    {
        public SinifListForm()
        {
            InitializeComponent();
            bll = new SinifBll();
        }
        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Sinif;
            navigator = longNavigator.Navigator;
            formShow = new ShowEditForms<SinifEditForm>();
        }
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((SinifBll)bll).List(x => x.Durum == aktifKartlariGoster
            && x.SubeId == AnaForm.SubeId);
        }
    }
}