
using DevExpress.XtraBars;
using OgrenciTakip.BLL.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.Show;

namespace OgrenciTakip.UI.Win.Forms.SinifGrupForms
{
    public partial class SinifGrupListForm : BaseListForm
    {
        public SinifGrupListForm()
        {
            InitializeComponent();
            bll = new SinifGrupBll();
        }


        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.SinifGrup;
            formShow = new ShowEditForms<SinifGrupEditForm>();
            navigator = longNavigator.Navigator;
            
        }
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((SinifGrupBll)bll).List(FilterFunctions.Filter<SinifGrup>(aktifKartlariGoster));
        }
    }
}