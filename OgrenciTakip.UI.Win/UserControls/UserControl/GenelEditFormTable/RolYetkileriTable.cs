
using OgrenciTakip.BLL.Functions;
using OgrenciTakip.BLL.General;
using OgrenciTakip.Model.DTO;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.KullaniciForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.Show;
using OgrenciTakip.UI.Win.UserControls.UserControl.Base;
using System.Linq;

namespace OgrenciTakip.UI.Win.UserControls.UserControl.GenelEditFormTable
{
    public partial class RolYetkileriTable : BaseTablo
    {
        public RolYetkileriTable()
        {
            InitializeComponent();

            Bll = new RolYetkileriBll();
            Tablo = tablo;
            EventsLoad();
        }

        protected internal override void Listele()
        {
            tablo.GridControl.DataSource = ((RolYetkileriBll)Bll).List(x => x.RolId == OwnerForm.id).ToBindingList<RolYetkileriL>();
        }

        protected override void HareketEkle()
        {
            var source = tablo.DataController.ListSource;
            ListeDisiTutulacakKayitlar = source.Cast<RolYetkileriL>().Where(x => !x.Delete).Select(x => (long)x.KartTuru).ToList();

            var entities = ShowListForms<RolYetkiKartlariListForm>.ShowDialogListForm(ListeDisiTutulacakKayitlar, true).EntityListConvert<RolYetki>();
            if (entities == null) return;

            foreach (var entity in entities)
            {
                var row = new RolYetkileriL
                {
                    RolId = OwnerForm.id,
                    KartTuru = entity.KartTuru,

                };
                source.Add(row);
            }
            tablo.Focus();
            tablo.RefleshDataSource();
            tablo.FocusedRowHandle = tablo.DataRowCount - 1;
            ButtonEnabledDurumu(true);
        }

    }
}
