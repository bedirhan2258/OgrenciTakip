
using OgrenciTakip.BLL.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.DTO;
using OgrenciTakip.UI.Win.Forms.MakbuzForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.Show;
using OgrenciTakip.UI.Win.UserControls.UserControl.Base;
using System.Linq;

namespace OgrenciTakip.UI.Win.UserControls.UserControl.GenelEditFormTable
{
    public partial class MakbuzHareketleriTable : BaseTablo
    {
        public MakbuzHareketleriTable()
        {
            InitializeComponent();
            Bll = new MakbuzHareketleriBll();
            Tablo = tablo;
            EventsLoad();
        }

        protected override void Listele()
        {
            tablo.GridControl.DataSource = ((MakbuzHareketleriBll)Bll).List(x => x.MakbuzId == OwnerForm.id).ToBindingList<MakbuzHareketleriL>();
        }

        protected override void HareketEkle()
        {
            if (((MakbuzEditForm)OwnerForm).HataliGiris()) return;

            var source = tablo.DataController.ListSource;
            ListeDisiTutulacakKayitlar = source.Cast<MakbuzHareketleriL>().Where(x => !x.Delete).Select(x => (long)x.OdemeBilgileriId).ToList();

            var entities = ShowListForms<MakbuzListForm>.ShowDialogListForm(KartTuru.AileBilgi, ListeDisiTutulacakKayitlar, true, false).EntityListConvert<AileBilgi>();
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
