
using DevExpress.XtraBars;
using OgrenciTakip.BLL.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.Show;


namespace OgrenciTakip.UI.Win.IptalNedeniForms
{
    public partial class IptalNedeniListForm : BaseListForm
    {
        public IptalNedeniListForm()
        {
            InitializeComponent();
            bll = new IptalNedeniBll();
        }
        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            kartTuru = KartTuru.IptalNedeni;
            formShow = new ShowEditForms<IptalNedeniEditForm>();
            navigator = longNavigator.Navigator;
            if (IsMdiChild)
                ShowItems = new BarItem[] { btnBagliKartlar };
        }
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((IptalNedeniBll)bll).List(FilterFunctions.Filter<IptalNedeni>(aktifKartlariGoster));
        }
    }
}