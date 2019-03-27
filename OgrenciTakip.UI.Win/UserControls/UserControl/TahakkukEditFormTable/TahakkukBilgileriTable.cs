using DevExpress.XtraBars;
using OgrenciTakip.BLL.General;
using OgrenciTakip.UI.Win.UserControls.UserControl.Base;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.Model.DTO;
using OgrenciTakip.UI.Win.Show;
using OgrenciTakip.UI.Win.Forms.TahakkukForms;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.UI.Win.GeneralForms;

namespace OgrenciTakip.UI.Win.UserControls.UserControl.TahakkukEditFormTable
{
    public partial class TahakkukBilgileriTable : BaseTablo
    {
        public TahakkukBilgileriTable()
        {
            InitializeComponent();

            Bll = new TahakkukBll();
            Tablo = tablo;
            EventsLoad();

            insUptNavigator.Navigator.Buttons.Append.Visible = false;
            insUptNavigator.Navigator.Buttons.Remove.Visible = false;
            insUptNavigator.Navigator.Buttons.PrevPage.Visible = true;
            insUptNavigator.Navigator.Buttons.NextPage.Visible = true;

            HideItems = new BarItem[] { btnHareketEkle, btnHareketSil };
            ShowItems = new BarItem[] { btnKartDuzenle };
        }

        protected internal override void Listele()
        {
            tablo.GridControl.DataSource = ((TahakkukBll)Bll).OgrenciTahakkukList(x => x.OgrenciId == OwnerForm.id);
        }

        protected override void OpenEntity()
        {
            var entity = tablo.GetRow<OgrenciTahakkukL>();
            if (entity == null) return;
            ShowEditForms<TahakkukEditForm>.ShowDialogEditForms(KartTuru.Tahakkuk, entity.TahakkukId, entity.SubeId != AnaForm.SubeId || entity.DonemId != AnaForm.DonemId);
        }
    }
}
