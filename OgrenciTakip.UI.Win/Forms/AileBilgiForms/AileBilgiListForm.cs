using DevExpress.XtraBars;
using OgrenciTakip.BLL.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Common.Message;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.AileBilgiForms;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.Show;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace OgrenciTakip.UI.Win.Forms
{
    public partial class AileBilgiListForm : BaseListForm
    {
        #region Variables
        private readonly Expression<Func<AileBilgi, bool>> _filter;
        #endregion

        public AileBilgiListForm()
        {
            InitializeComponent();
            bll = new AileBilgiBll();
            _filter = x => x.Durum == aktifKartlariGoster;
        }

        public AileBilgiListForm(params object[] prm) : this()
        {
            _filter = x => !ListeDisiTutulacakKayitlar.Contains(x.Id) && x.Durum == aktifKartlariGoster;
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            kartTuru = KartTuru.AileBilgi;
            formShow = new ShowEditForms<AileBilgiEditForm>();
            navigator = longNavigator.Navigator;

        }
        protected override void Listele()
        {
            var list = ((AileBilgiBll)bll).List(_filter);
            Tablo.GridControl.DataSource = list;

            if (!multiSelect) return;
            if (list.Any())
                EklenebilecekEntityVar = true;
            else
                Messages.KartBulunamadiMesaji("Kart");

        }

    }
}