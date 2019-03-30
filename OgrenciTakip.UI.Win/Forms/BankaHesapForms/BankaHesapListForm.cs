
using OgrenciTakip.BLL.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.GeneralForms;
using OgrenciTakip.UI.Win.Show;
using System;
using System.Linq.Expressions;

namespace OgrenciTakip.UI.Win.Forms.BankaHesapForms
{
    public partial class BankaHesapListForm : BaseListForm
    {
        #region Variables
        private readonly Expression<Func<BankaHesap, bool>> _filter;
        private readonly BankaHesapTuru _HesapTuru = BankaHesapTuru.VadesizMevduatHesabi;
        #endregion

        public BankaHesapListForm()
        {
            InitializeComponent();
            bll = new BankaHesapBll();
            _filter = x => x.Durum == aktifKartlariGoster && x.SubeId == AnaForm.SubeId;
        }


        public BankaHesapListForm(params object[] prm) : this()
        {
            if (prm[0].GetType() == typeof(BankaHesapTuru))
                _HesapTuru = (BankaHesapTuru)prm[0];

            else if (prm[0].GetType() == typeof(OdemeTipi))
            {
                var odemeTipi = (OdemeTipi)prm[0];

                switch (odemeTipi)
                {
                    case OdemeTipi.Epos:
                        _HesapTuru = BankaHesapTuru.EpostBlokeHesabi;
                        break;
                    case OdemeTipi.Ots:
                        _HesapTuru = BankaHesapTuru.OtsBlokeHesabi;
                        break;
                    case OdemeTipi.Pos:
                        _HesapTuru = BankaHesapTuru.PostBlokeHesabi;
                        break;
                }
            }
            _filter = x => x.Durum == aktifKartlariGoster && x.HesapTuru == _HesapTuru && x.SubeId == AnaForm.SubeId;
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.BankaHesap;
            formShow = new ShowEditForms<BankaHesapEditForm>();
            navigator = longNavigator.Navigator;
        }
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((BankaHesapBll)bll).List(_filter);
        }

    }
}