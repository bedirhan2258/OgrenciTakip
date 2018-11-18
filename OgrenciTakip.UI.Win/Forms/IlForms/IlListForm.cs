
using DevExpress.XtraBars;
using OgrenciTakip.BLL.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Forms.IlceForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.Show;


namespace OgrenciTakip.UI.Win.Forms.IlForms
{
    public partial class IlListForm : BaseListForm
    {
        public IlListForm()
        {
            InitializeComponent();
            bll = new IlBLL();
            btnBagliKartlar.Caption = "İlçe Kartları";
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            kartTuru = KartTuru.Il;
            formShow = new ShowEditForms<IlEditForm>();
            navigator = longNavigator.Navigator;
            if (IsMdiChild)
                ShowItems = new BarItem[] { btnBagliKartlar };
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((IlBLL)bll).List(FilterFunctions.Filter<Il>(aktifKartlariGoster));
        }
        protected override void BagliKartAc()
        { 
            
            var entity = Tablo.GetRow<Il>();
            if (entity == null) return;
            ShowListForms<IlceListForm>.ShowListForm(KartTuru.Ilce, entity.Id, entity.IlAdi);
        }
    }
}