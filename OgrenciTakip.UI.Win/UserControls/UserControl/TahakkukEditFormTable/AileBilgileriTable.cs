
using OgrenciTakip.BLL.Functions;
using OgrenciTakip.BLL.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.DTO;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.Show;
using OgrenciTakip.UI.Win.UserControls.UserControl.Base;
using System.Linq;

namespace OgrenciTakip.UI.Win.UserControls.UserControl.TahakkukEditFormTable
{
    public partial class AileBilgileriTable : BaseTablo
    {
        public AileBilgileriTable()
        {
            InitializeComponent();
            Bll = new AileBilgileriBll();
            Tablo = tablo;
            EventsLoad();
        }

        protected internal override void Listele()
        {
            tablo.GridControl.DataSource = ((AileBilgileriBll)Bll).List(x => x.TahakkukId == OwnerForm.id).ToBindingList<AileBilgileriL>();
        }

        protected override void HareketEkle()
        {

            var source = tablo.DataController.ListSource;
            ListeDisiTutulacakKayitlar = source.Cast<AileBilgileriL>().Where(x => !x.Delete).Select(x => x.AileBilgiId).ToList();

            var entities = ShowListForms<AileBilgiListForm>.ShowDialogListForm(KartTuru.AileBilgi, ListeDisiTutulacakKayitlar, true, false).EntityListConvert<AileBilgi>();
            if (entities == null) return;

            foreach (var entity in entities)
            {
                var row = new AileBilgileriL
                {
                    TahakkukId = OwnerForm.id,
                    AileBilgiId = entity.Id,
                    BilgiAdi = entity.BilgiAdi,
                    Aciklama = null,
                    Insert = true
                };
                source.Add(row);
            }

            tablo.Focus();
            tablo.RefleshDataSource();
            tablo.FocusedRowHandle = tablo.DataRowCount - 1;
            tablo.FocusedColumn = colBilgiAdi;
            ButtonEnabledDurumu(true);

        }
    }
}
