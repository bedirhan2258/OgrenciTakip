using DevExpress.XtraBars;
using OgrenciTakip.BLL.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using System.Linq;

namespace OgrenciTakip.UI.Win.Forms.FaturaForms
{
    public partial class FaturaPlaniEditForm : BaseEditForm
    {
        #region Variables
        private readonly long _tahakkukId;
        #endregion

        public FaturaPlaniEditForm()
        {
            InitializeComponent();
            dataLayoutControl = myDataLayoutControl;
            kartTuru = KartTuru.Fatura;
            EventsLoad();

            HideItems = new BarItem[] { btnYeni };
            btnSil.Caption = "İptal Et";
        }

        public FaturaPlaniEditForm(params object[] prm) : this()
        {
            _tahakkukId = (long)prm[0];
        }

        protected internal override void Yukle()
        {
            using (var bll = new HizmetBilgileriBll())
            {
                var list = bll.FaturaPlaniList(x => x.TahakkukId == _tahakkukId).ToList();

                txtOkulNo.Text = list[0].OkulNo;
                txtAdi.Text = list[0].Adi;
                txtSoyadi.Text = list[0].Soyadi;
                txtSinif.Text = list[0].SinifAdi;
                txtVeliAdi.Text = list[0].VeliAdi;
                txtVeliSoyadi.Text = list[0].VeliSoyadi;
                txtYakinlik.Text = list[0].VeliYakinlikAdi;
                txtMeslek.Text = list[0].VeliMeslekAdi;

                tablo.GridControl.DataSource = list;
                id = list[0].TahakkukId;
            }
        }

    }
}