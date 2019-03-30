
using DevExpress.XtraBars;
using OgrenciTakip.BLL.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.Show;

namespace OgrenciTakip.UI.Win.Forms.GorevForms
{
    public partial class GorevListForm : BaseListForm
    {
        public GorevListForm()
        {
            InitializeComponent();
            bll = new GorevBll();
        }
        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Gorev;
            formShow = new ShowEditForms<GorevEditForm>();
            navigator = longNavigator.Navigator;
            
        }
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((GorevBll)bll).List(FilterFunctions.Filter<Gorev>(aktifKartlariGoster));
        }
    }
}