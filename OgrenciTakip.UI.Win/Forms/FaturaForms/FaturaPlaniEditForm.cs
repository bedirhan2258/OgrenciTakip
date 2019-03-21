using DevExpress.XtraBars;
using OgrenciTakip.BLL.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Common.Message;
using OgrenciTakip.Model.DTO;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.UserControls.FaturaEditFormTable;
using System;
using System.Linq;
using System.Windows.Forms;
namespace OgrenciTakip.UI.Win.Forms.FaturaForms
{
    public partial class FaturaPlaniEditForm : BaseEditForm
    {
        #region Variables
        //private readonly long _tahakkukId;
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

        //public FaturaPlaniEditForm(params object[] prm) : this()
        //{
        //    _tahakkukId = (long)prm[0];
        //}

        protected internal override void Yukle()
        {
            TabloYukle();
            using (var bll = new HizmetBilgileriBll())
            {
                var list = bll.FaturaPlaniList(x => x.TahakkukId == id).ToList();

                txtOgrenciNo.Text = list[0].OkulNo;
                txtAdi.Text = list[0].Adi;
                txtSoyadi.Text = list[0].Soyadi;
                txtSinif.Text = list[0].SinifAdi;
                txtVeliAdi.Text = list[0].VeliAdi;
                txtVeliSoyadi.Text = list[0].VeliSoyadi;
                txtYakinlik.Text = list[0].VeliYakinlikAdi;
                txtMeslek.Text = list[0].VeliMeslekAdi;

                tablo.GridControl.DataSource = list;
                // id = list[0].TahakkukId;
            }
        }

        protected internal override void ButonEnabledDurumu()
        {
            GeneralFunctions.ButtonEnabledDurumu(btnKaydet, btnGeriAl, faturaPlaniTable.TableValueChanged);
        }

        protected override void TabloYukle()
        {
            faturaPlaniTable.OwnerForm = this;
            faturaPlaniTable.Yukle();
        }

        protected override bool EntityInsert()
        {
            return faturaPlaniTable.Kaydet();
        }

        protected override bool EntityUpdate()
        {
            return faturaPlaniTable.Kaydet();
        }

        protected override void EntityDelete()
        {
            if (Messages.HayirSeciliEvetHayir("Fatura Planı İptal Edilecek Onaylıyor Musunuz?", "İptal Onay") != DialogResult.Yes) return;

            var source = faturaPlaniTable.Tablo.DataController.ListSource.Cast<FaturaPlaniL>().Where(x => x.TahakkukTarih == null).ToList();
            if (source.Count == 0) return;

            source.ForEach(x => x.Delete = true);
            faturaPlaniTable.Tablo.RefleshDataSource();
            faturaPlaniTable.TableValueChanged = true;
            ButonEnabledDurumu();
        }

        protected override void BaseEditForm_Shown(object sender, EventArgs e)
        {
            faturaPlaniTable.Tablo.Focus();
        }

    }
}