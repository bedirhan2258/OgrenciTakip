
using OgrenciTakip.UI.Yonetim.Forms.BaseForms;

namespace OgrenciTakip.UI.Yonetim.GeneralForms
{
    public partial class KurumEditForm : BaseEditForm
    {
        public KurumEditForm()
        {
            InitializeComponent();
              
            dataLayoutControl = myDataLayoutControl;
            //bll = new AileBilgiBll(myDataLayoutControl);

            //kartTuru = KartTuru.AileBilgi;
            //EventsLoad();
        }
    }
}