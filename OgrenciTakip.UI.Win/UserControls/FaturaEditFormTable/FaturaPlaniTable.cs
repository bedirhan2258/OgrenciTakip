
using OgrenciTakip.BLL.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.DTO;
using OgrenciTakip.UI.Win.Forms.FaturaForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.Show;
using OgrenciTakip.UI.Win.UserControls.UserControl.Base;
using System.Linq;

namespace OgrenciTakip.UI.Win.UserControls.FaturaEditFormTable
{
    public partial class FaturaPlaniTable : BaseTablo
    {
        public FaturaPlaniTable()
        {
            InitializeComponent();
            Bll = new FaturaBll();
            Tablo = tablo;
            EventsLoad();
        }

        protected override void Listele()
        {
            tablo.GridControl.DataSource = ((FaturaBll)Bll).List(x => x.TahakkukId == OwnerForm.id).ToBindingList<FaturaPlaniL>();
        }

        protected override void HareketEkle()
        {
            var alinanHizmetlerSource = ((FaturaPlaniEditForm)OwnerForm).tablo.DataController.ListSource.Cast<FaturaAlinanHizmetlerL>().ToList();
            var faturaPlaniSource = tablo.DataController.ListSource;
            if (!ShowEditForms<TopluFaturaPlaniEditForm>.ShowDialogEditForms(KartTuru.Fatura, alinanHizmetlerSource, faturaPlaniSource)) return;

            tablo.Focus();
            tablo.RefleshDataSource();
            tablo.FocusedRowHandle = tablo.DataRowCount - 1;
            tablo.FocusedColumn = colAciklama;
            ButtonEnabledDurumu(true);
        }

    }
}
