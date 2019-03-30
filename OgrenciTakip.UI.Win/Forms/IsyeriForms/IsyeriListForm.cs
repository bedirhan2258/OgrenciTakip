
using DevExpress.XtraBars;
using OgrenciTakip.BLL.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.Show;

namespace OgrenciTakip.UI.Win.Forms.IsyeriForms
{
    public partial class IsyeriListForm : BaseListForm
    {
        public IsyeriListForm()
        {
            InitializeComponent();
            bll = new IsyeriBll();
        }
        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Isyeri;
            formShow = new ShowEditForms<IsyeriEditForm>();
            navigator = longNavigator.Navigator;
           
        }
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((IsyeriBll)bll).List(FilterFunctions.Filter<Isyeri>(aktifKartlariGoster));
        }
    }
}