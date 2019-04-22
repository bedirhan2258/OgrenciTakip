
using DevExpress.XtraBars;
using OgrenciTakip.UI.Win.Forms.BaseForms;

namespace OgrenciTakip.UI.Win.GeneralForms
{
    public partial class KullaniciParametreEditForm : BaseEditForm
    {
        public KullaniciParametreEditForm()
        {
            InitializeComponent();

            dataLayoutControl = myDataLayoutControl;
            bll = new KullaniciParametreBll();
            HideItems = new BarItem[] { btnYeni, btnSil };
            EventsLoad();
        }

        protected internal override void Yukle()
        {
            oldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new AileBilgi() : ((AileBilgiBll)bll).Single(FilterFunctions.Filter<AileBilgi>(id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            id = BaseIslemTuru.IdOlustur(oldEntity);
            txtKod.Text = ((AileBilgiBll)bll).YeniKodVer();
            txtBilgiAdi.Focus();
        }
    }
}