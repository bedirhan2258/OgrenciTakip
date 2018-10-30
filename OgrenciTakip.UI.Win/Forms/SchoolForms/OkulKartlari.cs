

using OgrenciTakip.BLL.General;
using OgrenciTakip.UI.Win.Forms.BaseForms;

namespace OgrenciTakip.UI.Win.Forms.SchoolForms
{
    public partial class OkulKartlari : BaseKartlarForm
    {
        public OkulKartlari()
        {
            InitializeComponent();
            OkulBLL okulBLL = new OkulBLL();
            grid.DataSource = okulBLL.List(null);
        }

       
    }
}