using OgrenciTakip.BLL.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Common.Functions;
using OgrenciTakip.Model.DTO;
using OgrenciTakip.UI.Win.Forms.TahakkukForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.GeneralForms;
using OgrenciTakip.UI.Win.Reports.FormReports.Base;
using OgrenciTakip.UI.Win.Show;
using System.Linq;

namespace OgrenciTakip.UI.Win.Reports.FormReports
{
    public partial class HizmetAlimRaporu : BaseRapor
    {
        public HizmetAlimRaporu()
        {
            InitializeComponent();
        }

        protected override void DegiskenleriDoldur()
        {
            DataLayoutControl = myDataLayoutControl;
            Tablo = tablo;
            Navigator = longNavigator.Navigator;
            Subeler = txtSubeler;
            Hizmetler = txtHizmetler;
            HizmetAlimTuru = txtHizmetAlimTuru;
            KayitSekilleri = txtKayitSekli;
            KayitDurumlari = txtKayitDurumu;

            SubeKartlariYukle();
            KayitSekliYukle();
            KayitDurumuYukle();
            HizmetKartlariYukle();
            txtHizmetAlimTuru.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<HizmetAlimDurumu>());
            txtHizmetAlimTuru.SelectedItem = HizmetAlimDurumu.HizmetiAlanlar.ToName();
            RaporTuru = KartTuru.HizmetAlimRaporu;
        }

        protected override void Listele()
        {
            var subeler = txtSubeler.CheckedComboBoxList<long>();
            var hizmetler = txtHizmetler.CheckedComboBoxList<long>();
            var kayitSekli = txtKayitSekli.CheckedComboBoxList<KayitSekli>();
            var kayitDurumu = txtKayitDurumu.CheckedComboBoxList<KayitDurumu>();


            using (var bll = new HizmetAlimRaporuBll())
            {
                tablo.GridControl.DataSource = bll.List(x =>
                    subeler.Contains(x.SubeId) &&
                    kayitSekli.Contains(x.KayitSekli) &&
                    kayitDurumu.Contains(x.KayitDurumu) &&
                    x.DonemId == AnaForm.DonemId, hizmetler, txtHizmetAlimTuru.Text.GetEnum<HizmetAlimDurumu>());
                base.Listele();
            }

        }

        protected override void ShowEditForm()
        {
            var entity = tablo.GetRow<HizmetAlimRaporuL>();
            if (entity == null) return;
            ShowEditForms<TahakkukEditForm>.ShowDialogEditForms(KartTuru.Tahakkuk, entity.TahakkukId, entity.SubeId != AnaForm.SubeId || entity.DonemId != AnaForm.DonemId);
        }

    }
}