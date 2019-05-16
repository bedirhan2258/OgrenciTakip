
using DevExpress.XtraBars;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Common.Message;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OgrenciTakip.UI.Win.Forms.KullaniciForms
{
    public partial class RolYetkiKartlariListForm : BaseListForm
    {
        public RolYetkiKartlariListForm()
        {
            InitializeComponent();
            HideItems = new BarItem[] { btnYeni, btnSil, btnDuzelt, btnKolonlar, barInsert, barInsertAciklama, barDelete, barDeleteAciklama, barDuzelt, barDuzeltAciklama, barKolonlar, barKolonlarAciklama };
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Yetki;
            navigator = longNavigator.Navigator;
        }

        protected override void Listele()
        {
            var enumList = Enum.GetValues(typeof(KartTuru)).Cast<KartTuru>().ToList();
            var liste = new List<RolYetki>();

            enumList.ForEach(x =>
            {
                var entity = new RolYetki
                {
                    KartTuru = x
                };
                liste.Add(entity);
            });

            var list = liste.Where(x => !ListeDisiTutulacakKayitlar.Contains((long)x.KartTuru));
            Tablo.GridControl.DataSource = list;

            if (!multiSelect) return;
            if (list.Any())
                EklenebilecekEntityVar = true;
            else
                Messages.KartBulunamadiMesaji("Kart");
        }
    }
}