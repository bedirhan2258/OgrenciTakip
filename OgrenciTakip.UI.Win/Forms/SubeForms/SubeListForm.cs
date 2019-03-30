
using OgrenciTakip.BLL.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Common.Message;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.Show;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace OgrenciTakip.UI.Win.Forms.SubeForms
{
    public partial class SubeListForm : BaseListForm
    {
        #region Variables
        private readonly Expression<Func<Sube, bool>> _filter;
        #endregion

        public SubeListForm()
        {
            InitializeComponent();
            bll = new SubeBll();
            _filter = x => x.Durum == aktifKartlariGoster;
        }

        public SubeListForm(params object[] prm) : this()
        {
            _filter = x => !ListeDisiTutulacakKayitlar.Contains(x.Id) && x.Durum == aktifKartlariGoster;
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Sube;
            formShow = new ShowEditForms<SubeEditForm>();
            navigator = longNavigator.Navigator;
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((SubeBll)bll).List(FilterFunctions.Filter<Sube>(aktifKartlariGoster));

            var list = ((SubeBll)bll).List(_filter);
            Tablo.GridControl.DataSource = list;

            if (!multiSelect) return;
            if (list.Any())
                EklenebilecekEntityVar = true;
            else
                Messages.KartBulunamadiMesaji("Kart");
        }
    }
}