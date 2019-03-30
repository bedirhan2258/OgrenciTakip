
using DevExpress.XtraBars;
using OgrenciTakip.BLL.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.Show;

namespace OgrenciTakip.UI.Win.Forms.HizmetTuruForms
{
    public partial class HizmetTuruListForm : BaseListForm
    {
        public HizmetTuruListForm()
        {
            InitializeComponent();
            bll = new HizmetTuruBll();
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.HizmetTuru;
            formShow = new ShowEditForms<HizmetTuruEditForm>();
            navigator = longNavigator.Navigator;
         
        }
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((HizmetTuruBll)bll).List(FilterFunctions.Filter<HizmetTuru>(aktifKartlariGoster));
        }
    }
}