using System;
using DevExpress.XtraBars;
using OgrenciTakip.UI.Win.Forms.BaseForms;

namespace OgrenciTakip.UI.Win.Forms.KullaniciForms
{
    public partial class KullaniciBirimYetkileriEditForm : BaseEditForm
    {
        public KullaniciBirimYetkileriEditForm()
        {
            InitializeComponent();

            dataLayoutControl = myDataLayoutControl;
            EventsLoad();
            HideItems = new BarItem[] { btnYeni, btnSil, btnKaydet, btnGeriAl };
            TabloYukle();
        }

        protected internal override void Yukle()
        {
            subeTable.Yukle();
            donemTable.Yukle();
        }

        protected internal override void ButonEnabledDurumu() { }

        protected override void BaseEditForm_Shown(object sender, EventArgs e)
        {
            kullaniciTable.Tablo.Focus();
        }

        protected override void TabloYukle()
        {
            kullaniciTable.OwnerForm = this;
            subeTable.OwnerForm = this;
            donemTable.OwnerForm = this;
            kullaniciTable.Yukle();
        }
    }
}