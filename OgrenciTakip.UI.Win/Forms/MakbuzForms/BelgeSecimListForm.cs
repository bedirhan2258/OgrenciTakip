﻿
using OgrenciTakip.BLL.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Common.Functions;
using OgrenciTakip.Common.Message;
using OgrenciTakip.Model.DTO;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.GeneralForms;
using System;
using OgrenciTakip.UI.Win.Functions;
using System.Linq;
using System.Linq.Expressions;

namespace OgrenciTakip.UI.Win.Forms.MakbuzForms
{
    public partial class BelgeSecimListForm : BaseListForm
    {
        #region Variables
        private readonly Expression<Func<OdemeBilgileri, bool>> _filter;
        private readonly MakbuzTuru _makbuzTuru;
        private readonly MakbuzHesapTuru _hesapTuru;
        private readonly long _hesapId;
        #endregion

        public BelgeSecimListForm(params object[] prm)
        {
            InitializeComponent();

            _makbuzTuru = (MakbuzTuru)prm[0];
            _hesapTuru = (MakbuzHesapTuru)prm[1];
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

        protected override void SutunGizleGoster()
        {
            if (tablo.DataRowCount == 0) return;
            var entity = tablo.GetRow<BelgeSecimL>(false);
            if (entity == null) return;

            bndBelgeDetayBilgileri.Visible = entity.OdemeTipi == OdemeTipi.Cek || entity.OdemeTipi == OdemeTipi.Senet;
            colTakipNo.Visible = entity.OdemeTipi == OdemeTipi.Pos;
            colBankaHesapAdi.Visible = entity.OdemeTipi == OdemeTipi.Epos || entity.OdemeTipi == OdemeTipi.Ots || entity.OdemeTipi == OdemeTipi.Pos;
            colBankaAdi.Visible = entity.OdemeTipi == OdemeTipi.Cek;
            colBankaSubeAdi.Visible = entity.OdemeTipi == OdemeTipi.Cek;
            colHesapNo.Visible = entity.OdemeTipi == OdemeTipi.Cek;
            colBelgeNo.Visible = entity.OdemeTipi == OdemeTipi.Cek;
            colAsilBorclu.Visible = entity.OdemeTipi == OdemeTipi.Cek || entity.OdemeTipi == OdemeTipi.Senet;
            colCiranta.Visible = entity.OdemeTipi == OdemeTipi.Cek || entity.OdemeTipi == OdemeTipi.Senet;
        }

    }
}