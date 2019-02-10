

using OgrenciTakip.BLL.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Common.Functions;
using OgrenciTakip.Common.Message;
using OgrenciTakip.Model.DTO;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.GeneralForms;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace OgrenciTakip.UI.Win.Forms.MakbuzForms
{
    public partial class BelgeSecimForm : BaseListForm
    {
        #region Variables
        private readonly Expression<Func<OdemeBilgileri, bool>> _filter;
        private readonly MakbuzTuru _makbuzTuru;
        private readonly MakbuzHesapTuru _hesapTuru;
        private readonly long _hesapId;
        #endregion

        public BelgeSecimForm(params object[] prm)
        {
            InitializeComponent();

            _makbuzTuru = (MakbuzTuru)prm[0];
            _makbuzHesapTuru = (MakbuzHesapTuru)prm[1];
            _hesapId = (long)prm[2];

            _filter = x => !ListeDisiTutulacakKayitlar.Contains(x.Id) && x.Tahakkuk.DonemId == AnaForm.DonemId;
        }


        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            kartTuru = KartTuru.Hizmet;
            navigator = longNavigator.Navigator;
        }

        protected override void Listele()
        {
            var list = ((BelgeSecimBll)bll).List(_filter, _makbuzTuru, _hesapTuru, _hesapTuru.ToName().GetEnum<OdemeTipi>(), _hesapId, AnaForm.SubeId);
            Tablo.GridControl.DataSource = list;
            if (!multiSelect) return;
            if (list.Any())
                EklenebilecekEntityVar = true;
            else
                Messages.KartBulunamadiMesaji("Kart");
        }
    }
}