using DevExpress.XtraBars;
using OgrenciTakip.BLL.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.AileBilgiForms;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.Show;

namespace OgrenciTakip.UI.Win.Forms
{
    public partial class AileBilgiListForm : BaseListForm
    {
        public AileBilgiListForm()
        {
            InitializeComponent();
            bll = new AileBilgiBll();
        }
        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            kartTuru = KartTuru.AileBilgi;
            formShow = new ShowEditForms<AileBilgiEditForm>();
            navigator = longNavigator.Navigator;
         
        }
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((AileBilgiBll)bll).List(FilterFunctions.Filter<AileBilgi>(aktifKartlariGoster));
        }

    }
}