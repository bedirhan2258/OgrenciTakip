
using DevExpress.XtraBars;
using OgrenciTakip.BLL.Functions;
using OgrenciTakip.BLL.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.DTO;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Forms.TahakkukForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.GeneralForms;
using OgrenciTakip.UI.Win.Show;

namespace OgrenciTakip.UI.Win.Forms.OgrenciForms
{
    public partial class OgrenciListForm : BaseListForm
    {
        public OgrenciListForm()
        {
            InitializeComponent();
            bll = new OgrenciBll();
            ShowItems = new BarItem[] { btnTahakkukYap };
        }
        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Ogrenci;
            formShow = new ShowEditForms<OgrenciEditForm>();
            navigator = longNavigator.Navigator;

        }
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((OgrenciBll)bll).List(FilterFunctions.Filter<Ogrenci>(aktifKartlariGoster));
        }
        protected override void TahakkukYap()
        {
            var entity = tablo.GetRow<OgrenciL>().EntityConvert<Ogrenci>();

            using (var Bll = new TahakkukBll())
            {
                var tahakkuk = Bll.SingleSummary(x => x.OgrenciId == entity.Id && x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId);
                if (tahakkuk != null)
                    ShowEditForms<TahakkukEditForm>.ShowDialogEditForms(KartTuru.Tahakkuk, tahakkuk.Id, null);
                else
                    ShowEditForms<TahakkukEditForm>.ShowDialogEditForms(KartTuru.Tahakkuk, -1, entity);
            }
        }
    }
}