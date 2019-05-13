
using DevExpress.XtraBars;
using OgrenciTakip.BLL.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Common.Message;
using OgrenciTakip.Model.DTO;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Show;
using System;
using System.Linq;
using System.Linq.Expressions;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.GeneralForms;

namespace OgrenciTakip.UI.Win.Forms.DonemForms
{
    public partial class DonemListForm : BaseListForm
    {
        #region Variables
        private readonly Expression<Func<Donem, bool>> _filter;
        #endregion

        public DonemListForm()
        {
            InitializeComponent();
            bll = new DonemBll();
            _filter = x => x.Durum == aktifKartlariGoster;
            ShowItems = new BarItem[] { btnParametreler, barF4, barF4Aciklama };
        }

        public DonemListForm(params object[] prm) : this()
        {
            _filter = x => !ListeDisiTutulacakKayitlar.Contains(x.Id) && x.Durum == aktifKartlariGoster;
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Donem;
            formShow = new ShowEditForms<DonemEditForm>();
            navigator = longNavigator.Navigator;

        }

        protected override void Listele()
        {
            var list = ((DonemBll)bll).List(_filter);
            Tablo.GridControl.DataSource = list;

            if (!multiSelect) return;
            if (list.Any())
                EklenebilecekEntityVar = true;
            else
                Messages.KartBulunamadiMesaji("Kart");

        }

        protected override void BagliKartAc()
        {
            var entity = Tablo.GetRow<Donem>();
            if (entity == null) return;
            ShowEditForms<DonemParametreEditForm>.ShowDialogEditForms(null, entity.Id);
        }
    }
}