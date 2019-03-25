
using System;
using DevExpress.DataProcessing;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Navigation;
using OgrenciTakip.BLL.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Common.Functions;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.GeneralForms;

namespace OgrenciTakip.UI.Win.Forms.FaturaForms
{
    public partial class FaturaTahakkukEditForm : BaseEditForm
    {
        public FaturaTahakkukEditForm()
        {
            InitializeComponent();

            InitializeComponent();
            dataLayoutControl = myDataLayoutControl;
            kartTuru = KartTuru.Fatura;
            EventsLoad();

            HideItems = new BarItem[] { btnYeni, btnSil };
            ShowItems = new BarItem[] { btnYazdir };

            txtKdvSekli.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<KdvSekli>());
            txtFaturaAdresi.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<AdresTuru>());
            kayitSonrasiFormuKapat = false;
        }

        protected internal override void Yukle()
        {
            txtKdvSekli.SelectedItem = KdvSekli.Dahil.ToName();
            txtFaturaAdresi.SelectedItem = AdresTuru.EvAdresi.ToName();
            FaturaDonemiYukle();
            FaturaNoYukle();
            TabloYukle();
        }

        private void FaturaDonemiYukle()
        {
            using (var bll = new FaturaBll())
            {
                var list = bll.FaturaDonemList(x => x.Tahakkuk.SubeId == AnaForm.SubeId && x.Tahakkuk.DonemId == AnaForm.DonemId);
                list.ForEach(x => txtFaturaDonemi.Properties.Items.Add(x.Date.ToString("d")));
            }
        }

        private void FaturaNoYukle()
        {
            using (var bll = new FaturaBll())
            {
                txtSonFaturaNo.Value = bll.MaxFaturaNo(x => x.Tahakkuk.SubeId == AnaForm.SubeId && x.Tahakkuk.DonemId == AnaForm.DonemId);
                txtFaturaNo.Value = txtSonFaturaNo.Value + 1;
            }
        }

        protected internal override void ButonEnabledDurumu()
        {
            GeneralFunctions.ButtonEnabledDurumu(btnKaydet, btnGeriAl, faturaTahakkukTable.TableValueChanged);
        }

        protected override void TabloYukle()
        {
            faturaTahakkukTable.OwnerForm = this;
            faturaTahakkukTable.Yukle();
        }

        protected override bool EntityUpdate()
        {
            if (!faturaTahakkukTable.Kaydet()) return false;

            faturaTahakkukTable.Yukle();
            FaturaNoYukle();
            return true;
        }

        protected override void Control_SelectedValueChanged(object sender, EventArgs e)
        {
            if (sender != txtFaturaDonemi) return;

            faturaTahakkukTable.Listele();
            faturaTahakkukTable.Tablo.Focus();

        }

    }
}