
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

namespace OgrenciTakip.UI.Win.Forms.IletisimForms
{
    public partial class IletisimListForm : BaseListForm
    {
        #region Variables
        private readonly Expression<Func<Iletisim, bool>> _filter;
        #endregion

        public IletisimListForm()
        {
            InitializeComponent();
            bll = new IletisimBll();
            _filter = x => x.Durum == aktifKartlariGoster;
        }

        public IletisimListForm(params object[] prm) : this()
        {
            _filter = x => !ListeDisiTutulacakKayitlar.Contains(x.Id) && x.Durum == aktifKartlariGoster;
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            kartTuru = KartTuru.Iletisim;
            formShow = new ShowEditForms<IletisimEditForm>();
            navigator = longNavigator.Navigator;
        }

        protected override void Listele()
        {
            var list = ((IletisimBll)bll).List(_filter);
            Tablo.GridControl.DataSource = list;

            if (!multiSelect) return;
            if (list.Any())
                EklenebilecekEntityVar = true;
            else
                Messages.KartBulunamadiMesaji("Kart");

        }


    }
}