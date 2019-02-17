
using DevExpress.XtraBars;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.UI.Win.Forms.BaseForms;

namespace OgrenciTakip.UI.Win.Forms.MakbuzForms
{
    public partial class BelgeHareketleriListForm : BaseListForm
    {
        public BelgeHareketleriListForm()
        {
            InitializeComponent();
            HideItems = new BarItem[] { btnYeni, btnSil, btnSec, barInsert, barInsertAciklama, barDelete, barDeleteAciklama, barEnter, barEnterAciklama };

        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            kartTuru = KartTuru.BelgeHareketleri;
            navigator = longNavigator.Navigator;
            navigator.TextStringFormat = "Belge Hareketleri ( {0} / {1} )";
        }

        protected override void Listele()
        {
            base.Listele();
        }
    }
}