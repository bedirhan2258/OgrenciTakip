
using DevExpress.XtraBars;
using OgrenciTakip.BLL.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.Show;

namespace OgrenciTakip.UI.Win.Forms.KontenjanForms
{
    public partial class KontenjanListForm : BaseListForm
    {
        public KontenjanListForm()
        {
            InitializeComponent();

            bll = new KontenjanBll();
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Kontenjan;
            formShow = new ShowEditForms<KontenjanEditForm>();
            navigator = longNavigator.Navigator;
            
        }
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((KontenjanBll)bll).List(FilterFunctions.Filter<Kontenjan>(aktifKartlariGoster));
        }
    }
}