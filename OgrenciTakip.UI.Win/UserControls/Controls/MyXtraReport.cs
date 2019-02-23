
using DevExpress.XtraReports.UI;
using System.ComponentModel;

namespace OgrenciTakip.UI.Win.UserControls.Controls
{
    [ToolboxItem(true)]
    public partial class MyXtraReport : XtraReport
    {
        public MyXtraReport()
        {
            InitializeComponent();
        }

        public string Baslik { get; set; }

    }
}
