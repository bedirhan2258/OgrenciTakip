
using DevExpress.XtraBars;
using OgrenciTakip.BLL.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.Show;

namespace OgrenciTakip.UI.Win.Forms.MeslekForms
{
    public partial class MeslekListForm : BaseListForm
    {
        public MeslekListForm()
        {
            InitializeComponent();
            bll = new MeslekBll();
        }
        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            kartTuru = KartTuru.Meslek;
            formShow = new ShowEditForms<MeslekEditForm>();
            navigator = longNavigator.Navigator;
            if (IsMdiChild)
                ShowItems = new BarItem[] { btnBagliKartlar };
        }
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((MeslekBll)bll).List(FilterFunctions.Filter<Meslek>(aktifKartlariGoster));
        }
    }
}