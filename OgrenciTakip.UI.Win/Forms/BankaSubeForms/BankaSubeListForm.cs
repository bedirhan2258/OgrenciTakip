
using OgrenciTakip.BLL.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Show;

namespace OgrenciTakip.UI.Win.Forms.BankaSubeForms
{
    public partial class BankaSubeListForm : BaseListForm
    {

        #region Variables
        private readonly long _bankaId;
        private readonly string _bankaAdi;
        #endregion
        public BankaSubeListForm(params object[] prm)
        {
            InitializeComponent();
            bll = new BankaSubeBll();

            _bankaId = (long)prm[0];
            _bankaAdi = prm[1].ToString();
        }
        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.BankaSube;
            navigator = longNavigator.Navigator;
            Text = Text + $" - ( {_bankaAdi} ) ";
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((BankaSubeBll)bll).List(x => x.Durum == aktifKartlariGoster && x.BankaId == _bankaId);
        }
        protected override void ShowEditForm(long id)
        {
            var result = ShowEditForms<BankaSubeEditForm>.ShowDialogEditForms(KartTuru.BankaSube, id, _bankaId, _bankaAdi);
            ShowEditFormDefault(result);
        }
    }
}