
using DevExpress.XtraBars;
using OgrenciTakip.BLL.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.Show;

namespace OgrenciTakip.UI.Win.Forms.YabanciDilForms
{
    public partial class YabanciDilListForm : BaseListForm
    {
        public YabanciDilListForm()
        {
            InitializeComponent();
            bll = new YabanciDilBll();
        }
        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.YabanciDil;
            formShow = new ShowEditForms<YabanciDİlEditForm>();
            navigator = longNavigator.Navigator;
          
        }
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((YabanciDilBll)bll).List(FilterFunctions.Filter<YabanciDil>(aktifKartlariGoster));
        }
    }
}