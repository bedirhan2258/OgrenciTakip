
using DevExpress.XtraBars;
using OgrenciTakip.BLL.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.Show;

namespace OgrenciTakip.UI.Win.Forms.RehberForms
{
    public partial class RehberListForm : BaseListForm
    {
        public RehberListForm()
        {
            InitializeComponent();
            bll = new RehberBll();
        }
        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Rehber;
            formShow = new ShowEditForms<RehberEditForm>();
            navigator = longNavigator.Navigator;    
        }
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((RehberBll)bll).List(FilterFunctions.Filter<Rehber>(aktifKartlariGoster));
        }
    }
}