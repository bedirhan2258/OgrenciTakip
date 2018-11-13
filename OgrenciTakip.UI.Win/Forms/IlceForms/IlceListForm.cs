
using OgrenciTakip.BLL.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.Show;

namespace OgrenciTakip.UI.Win.Forms.IlceForms
{
    public partial class IlceListForm : BaseListForm
    {
        #region Variables
        private readonly long _ilId;
        private readonly string _ilAdi; 
        #endregion
        public IlceListForm()
        {
            InitializeComponent();
        }
        public IlceListForm(params object[] prm)
        {
            InitializeComponent();
            bll = new IlceBLL();

            _ilId = (long)prm[0];
            _ilAdi = prm[1].ToString();
        }
        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            kartTuru = KartTuru.Ilce;
            // formShow = new ShowEditForms<IlceEditForm>();
            navigator = longNavigator.Navigator;
        }
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((IlceBLL)bll).List(x => x.Durum == aktifKartlariGoster && x.IlId == _ilId);
        }
        protected override void ShowEditForm(long id)
        {
            var result = new ShowEditForms<IlceEditForm>().ShowDialogEditForms(KartTuru.Ilce, _ilId, _ilAdi);
            //İşlem yapılacak

        }
    }
}