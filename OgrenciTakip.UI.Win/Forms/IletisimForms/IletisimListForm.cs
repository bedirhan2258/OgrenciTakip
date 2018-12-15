
using OgrenciTakip.BLL.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.Show;

namespace OgrenciTakip.UI.Win.Forms.IletisimForms
{
    public partial class IletisimListForm : BaseListForm
    {
        public IletisimListForm()
        {
            InitializeComponent();

            bll = new IletisimBll();

        }
        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            kartTuru = KartTuru.Iletisim;
            formShow = new ShowEditForms<IletisimEditForm>();
            navigator = longNavigator.Navigator;
        }
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((IletisimBll)bll).List(FilterFunctions.Filter<Iletisim>(aktifKartlariGoster));
        }

        
    }
}