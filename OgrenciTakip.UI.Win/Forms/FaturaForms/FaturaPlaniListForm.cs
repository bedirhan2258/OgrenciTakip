
using OgrenciTakip.BLL.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.GeneralForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.Model.DTO;
using OgrenciTakip.Common.Message;
using OgrenciTakip.UI.Win.Show;

namespace OgrenciTakip.UI.Win.Forms.FaturaForms
{
    public partial class FaturaPlaniListForm : BaseListForm
    {
        public FaturaPlaniListForm()
        {
            InitializeComponent();
            bll = new TahakkukBll();
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            kartTuru = KartTuru.Fatura;
            navigator = longNavigator.Navigator;
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((TahakkukBll)bll).FaturaTahakkukList(x => x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId);
        }

        protected override void ShowEditForm(long id)
        {
            var entity = tablo.GetRow<FaturaL>();
            if (entity == null) return;

            if (entity.HizmetNetTutar == 0)
            {
                Messages.HataMesaji("Öğrencinin Net Ücreti Sıfır ( 0 ) Olduğu İçin Fatura Planı Oluşturamazsınız."); return;
            }

            var result = ShowEditForms<FaturaPlaniEditForm>.ShowDialogEditForms(KartTuru.Fatura, id, null);
            ShowEditFormDefault(result);

        }

        private void grid_Click(object sender, System.EventArgs e)
        {

        }
    }
}