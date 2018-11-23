
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.Common.Enums;
using DevExpress.XtraGrid;
using OgrenciTakip.BLL.General;
using DevExpress.XtraBars;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Functions;

namespace OgrenciTakip.UI.Win.Forms.FiltreForms
{
    public partial class FiltreEditForm : BaseEditForm
    {
        #region Variables
        private readonly KartTuru _filtreKartTuru;
        private readonly GridControl _filtreGrid;
        #endregion

        public FiltreEditForm(params object[] prm)
        {
            InitializeComponent();

            _filtreKartTuru = (KartTuru)prm[0];
            _filtreGrid = (GridControl)prm[1];

            HideItems = new BarItem[] { btnYeni, btnGeriAl };
            ShowItems = new BarItem[] { btnFarkliKaydet, btnUygula };


            dataLayoutControl = myDataLayoutControl;
            bll = new FiltreBLL(myDataLayoutControl);
            kartTuru = KartTuru.Filtre;
            EventsLoad();

        }
        protected internal override void Yukle()
        {
            txtFiltreMetni.SourceControl = _filtreGrid;
            if (islemTuru == IslemTuru.EntityInsert)
            {
                oldEntity = new Filtre();
                id = islemTuru.IdOlustur(oldEntity);
                txtKod.Text = ((FiltreBLL)bll).YeniKodVer(x => x.KartTuru == _filtreKartTuru);

            }
            else
            {
                oldEntity = ((FiltreBLL)bll).Single(FilterFunctions.Filter<Filtre>(id));
                if (oldEntity == null)
                    islemTuru = IslemTuru.EntityInsert;
                NesneyiKontrollereBagla();
            }
        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (Filtre)oldEntity;

            txtKod.Text = entity.Kod;
            txtFiltreAdi.Text = entity.FiltreAdi;
            txtFiltreMetni.Text = entity.FiltreMetni;
        }
        protected override void GuncelNesneOlustur()
        {
            currentEnttiy = new Filtre
            {
                Id = id,
                Kod = txtKod.Text,
                FiltreAdi = txtFiltreMetni.FilterString,
                KartTuru = _filtreKartTuru
            };
            ButonEnabledDurumu();
        }
        protected override bool EntityInsert()
        {
            return ((FiltreBLL)bll).Insert(currentEnttiy, x => x.Kod == currentEnttiy.Kod && x.KartTuru == _filtreKartTuru);
        }
        protected override bool EntityUpdate()
        {
            return ((FiltreBLL)bll).Update(oldEntity, currentEnttiy, X => X.Kod == currentEnttiy.Kod && X.KartTuru == _filtreKartTuru);

        }
        protected override void FiltreUygula()
        {
            txtFiltreMetni.Select();
            txtFiltreMetni.ApplyFilter();
        }
        protected internal override void ButonEnabledDurumu()
        {
            if (!isLoaded) return;
            GeneralFunctions.ButtonEnabledDurumu(btnKaydet, btnFarkliKaydet, btnSil, islemTuru, oldEntity, currentEnttiy);

        }
    }
}