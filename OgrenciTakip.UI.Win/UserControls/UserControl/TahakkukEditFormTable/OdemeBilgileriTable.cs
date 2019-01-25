
using DevExpress.XtraBars;
using OgrenciTakip.BLL.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.DTO;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.UserControls.UserControl.Base;
using System.Linq;

namespace OgrenciTakip.UI.Win.UserControls.UserControl.TahakkukEditFormTable
{
    public partial class OdemeBilgileriTable : BaseTablo
    {
        public OdemeBilgileriTable()
        {
            InitializeComponent();

            Bll = new OdemeBilgileriBll();
            Tablo = tablo;
            EventsLoad();
            ShowItems = new BarItem[] { btnBelgeHareketleri };
        }

        protected override void Listele()
        {
            tablo.GridControl.DataSource = ((OdemeBilgileriBll)Bll).List(x => x.TahakkukId == OwnerForm.id).ToBingingList<OdemeBilgileriL>();
        }
        protected override void HareketEkle()
        {
            var source = tablo.DataController.ListSource;
            var dahaOnceGirilenTaksitSayisi = source.Cast<OdemeBilgileriL>().Count(x => !x.Delete && x.BelgeDurumu != BelgeDurumu.MusteriyeGeriIade);
        }
    }
}
