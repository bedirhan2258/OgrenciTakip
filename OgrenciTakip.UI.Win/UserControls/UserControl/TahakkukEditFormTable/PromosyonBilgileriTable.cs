
using OgrenciTakip.BLL.Functions;
using OgrenciTakip.BLL.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.DTO;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.PromosyonForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.Show;
using OgrenciTakip.UI.Win.UserControls.UserControl.Base;
using System.Linq;

namespace OgrenciTakip.UI.Win.UserControls.UserControl.TahakkukEditFormTable
{
    public partial class PromosyonBilgileriTable : BaseTablo
    {
        public PromosyonBilgileriTable()
        {
            InitializeComponent();
            Bll = new PromosyonBilgileriBll();
            Tablo = tablo;
            EventsLoad();
        }

        protected internal override void Listele()
        {
            tablo.GridControl.DataSource = ((PromosyonBilgileriBll)Bll).List(x => x.TahakkukId == OwnerForm.id).ToBindingList<PromosyonBilgileriL>();
        }

        protected override void HareketEkle()
        {

            var source = tablo.DataController.ListSource;
            ListeDisiTutulacakKayitlar = source.Cast<PromosyonBilgileriL>().Where(x => !x.Delete).Select(x => x.PromosyonId).ToList();

            var entities = ShowListForms<PromosyonListForm>.ShowDialogListForm(KartTuru.Promosyon, ListeDisiTutulacakKayitlar, true, false).EntityListConvert<Promosyon>();
            if (entities == null) return;

            foreach (var entity in entities)
            {
                var row = new PromosyonBilgileriL
                {
                    PromosyonId = entity.Id,
                    TahakkukId = OwnerForm.id,
                    Kod = entity.Kod,
                    PromosyonAdi = entity.PromosyonAdi,
                    Insert = true
                };
                source.Add(row);
            }

            tablo.Focus();
            tablo.RefleshDataSource();
            tablo.FocusedRowHandle = tablo.DataRowCount - 1;
            tablo.FocusedColumn = colKod;
            ButtonEnabledDurumu(true);

        }
    }
}
