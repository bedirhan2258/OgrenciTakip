
using DevExpress.XtraPrinting;

namespace OgrenciTakip.UI.Win.GeneralForms
{
    public partial class RaporOnizleme : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        //Hocam detay formuna clik yaptığımda buraya hiç girmiyor.
        public RaporOnizleme(params object[] prm)
        {
            InitializeComponent();

            RaporGosterici.PrintingSystem = (PrintingSystemBase)prm[0];
            Text = $"{Text} ( {prm[1].ToString()} )";

        }
    }
}