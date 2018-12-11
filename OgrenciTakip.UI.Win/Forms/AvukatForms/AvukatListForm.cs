
using DevExpress.XtraBars;
using OgrenciTakip.BLL.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.Show;

namespace OgrenciTakip.UI.Win.Forms.AvukatForms
{
    public partial class AvukatListForm : BaseListForm
    {
        public AvukatListForm()
        {
            InitializeComponent();
            bll = new AvukatBll();
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            kartTuru = KartTuru.Avukat;
            formShow = new ShowEditForms<AvukatEditForm>();
            navigator = longNavigator.Navigator;

        }
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((AvukatBll)bll).List(FilterFunctions.Filter<Avukat>(aktifKartlariGoster));
        }

    }
}