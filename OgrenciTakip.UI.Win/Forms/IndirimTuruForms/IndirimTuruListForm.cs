
using DevExpress.XtraBars;
using OgrenciTakip.BLL.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.Show;

namespace OgrenciTakip.UI.Win.Forms.IndirimTuruForms
{
    public partial class IndirimTuruListForm : BaseListForm
    {
        public IndirimTuruListForm()
        {
            InitializeComponent();
            bll = new IndirimTuruBll();
        }
        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.IndirimTuru;
            formShow = new ShowEditForms<IndirimTuruEditForm>();
            navigator = longNavigator.Navigator;
            
        }
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((IndirimTuruBll)bll).List(FilterFunctions.Filter<IndirimTuru>(aktifKartlariGoster));
        }
    }
}