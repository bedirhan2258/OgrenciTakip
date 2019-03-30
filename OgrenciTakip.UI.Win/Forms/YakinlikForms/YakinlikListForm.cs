
using DevExpress.XtraBars;
using OgrenciTakip.BLL.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.Show;

namespace OgrenciTakip.UI.Win.Forms.YakinlikForms
{
    public partial class YakinlikListForm : BaseListForm
    {
        public YakinlikListForm()
        {
            InitializeComponent();
            bll = new YakinlikBll();
        }
        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Yakinlik;
            formShow = new ShowEditForms<YakinlikEditForm>();
            navigator = longNavigator.Navigator;
           
        }
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((YakinlikBll)bll).List(FilterFunctions.Filter<Yakinlik>(aktifKartlariGoster));
        }
    }
}