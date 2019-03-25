

using OgrenciTakip.BLL.Functions;
using OgrenciTakip.BLL.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model;
using OgrenciTakip.Model.DTO;
using OgrenciTakip.UI.Win.Forms.EvrakForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.Show;
using OgrenciTakip.UI.Win.UserControls.UserControl.Base;
using System.Linq;

namespace OgrenciTakip.UI.Win.UserControls.UserControl.TahakkukEditFormTable
{
    public partial class EvrakBilgileriTable : BaseTablo
    {
        public EvrakBilgileriTable()
        {
            InitializeComponent();
            Bll = new EvrakBilgileriBll();
            Tablo = tablo;
            EventsLoad();
        }
        protected internal override void Listele()
        {
            tablo.GridControl.DataSource = ((EvrakBilgileriBll)Bll).List(x => x.TahakkukId == OwnerForm.id).ToBindingList<EvrakBilgileriL>();
        }

        protected override void HareketEkle()
        {

            var source = tablo.DataController.ListSource;
            ListeDisiTutulacakKayitlar = source.Cast<EvrakBilgileriL>().Where(x => !x.Delete).Select(x => x.EvrakId).ToList();

            var entities = ShowListForms<EvrakListForm>.ShowDialogListForm(KartTuru.Evrak, ListeDisiTutulacakKayitlar, true, false).EntityListConvert<Evrak>();
            if (entities == null) return;

            foreach (var entity in entities)
            {
                var row = new EvrakBilgileriL
                {
                    TahakkukId = OwnerForm.id,
                    EvrakId = entity.Id,
                    Kod = entity.Kod,
                    EvrakAdi = entity.EvrakAdi,
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
