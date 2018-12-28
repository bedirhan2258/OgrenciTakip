
using DevExpress.XtraBars;
using OgrenciTakip.BLL.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Common.Message;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.GeneralForms;
using OgrenciTakip.UI.Win.Show;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace OgrenciTakip.UI.Win.Forms.TahakkukForms
{
    #region Variables
    public partial class TahakkukListForm : BaseListForm
    #endregion

    {
        private readonly Expression<Func<Tahakkuk, bool>> _filter;

        public TahakkukListForm()
        {
            InitializeComponent();
            bll = new TahakkukBll();
            HideItems = new BarItem[] { btnYeni };
            _filter = x => x.Durum == aktifKartlariGoster && x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId;
        }
        public TahakkukListForm(params object[] prm) : this()
        {
            _filter = x => !ListeDisiTutulacakKayitlar.Contains(x.Id) && x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId;
        }
        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            kartTuru = KartTuru.Tahakkuk;
            formShow = new ShowEditForms<TahakkukEditForm>();
            navigator = longNavigator.Navigator;
        }
        protected override void Listele()
        {
            var list = ((TahakkukBll)bll).List(_filter);
            Tablo.GridControl.DataSource = list;
            if (!multiSelect) return;
            if (list.Any())
                EklenebilecekEntityVar = true;
            else
                Messages.KartBulunamadiMesaji("Kart");
        }
    }
}