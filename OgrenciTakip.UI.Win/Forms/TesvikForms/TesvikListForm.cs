
using DevExpress.XtraBars;
using OgrenciTakip.BLL.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.Show;

namespace OgrenciTakip.UI.Win.Forms.TesvikForms
{
    public partial class TesvikListForm : BaseListForm
    {
        public TesvikListForm()
        {
            InitializeComponent();
            bll = new TesvikBll();
        }
        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Tesvik;
            formShow = new ShowEditForms<TesvikEditForm>();
            navigator = longNavigator.Navigator;
           
        }
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((TesvikBll)bll).List(FilterFunctions.Filter<Tesvik>(aktifKartlariGoster));
        }
    }
}