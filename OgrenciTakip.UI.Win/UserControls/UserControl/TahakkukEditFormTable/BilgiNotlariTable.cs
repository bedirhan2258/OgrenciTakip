
using OgrenciTakip.BLL.General;
using OgrenciTakip.Common.Message;
using OgrenciTakip.Model.DTO;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.UserControls.UserControl.Base;
using System;

namespace OgrenciTakip.UI.Win.UserControls.UserControl.TahakkukEditFormTable
{
    public partial class BilgiNotlariTable : BaseTablo
    {
        public BilgiNotlariTable()
        {
            InitializeComponent();
            Bll = new BilgiNotlariBll();
            Tablo = tablo;
            EventsLoad();
        }
        protected override void Listele()
        {
            tablo.GridControl.DataSource = ((BilgiNotlariBll)Bll).List(x => x.TahakkukId == OwnerForm.id).ToBingingList<BilgiNotlariL>();
        }

        protected override void HareketEkle()
        {

            var source = tablo.DataController.ListSource;

            var row = new BilgiNotlariL
            {
                TahakkukId = OwnerForm.id,
                Tarih = DateTime.Now,
                Insert = true
            };

            source.Add(row);


            tablo.Focus();
            tablo.RefleshDataSource();
            tablo.FocusedRowHandle = tablo.DataRowCount - 1;
            tablo.FocusedColumn = colBilgiNotu;
            ButtonEnabledDurumu(true);

        }
        protected internal override bool HataliGiris()
        {
            if (!TableValueChanged) return false;

            if (tablo.HasColumnErrors)
                tablo.ClearColumnErrors();

            for (int i = 0; i < tablo.DataRowCount; i++)
            {
                var entity = tablo.GetRow<BilgiNotlariL>(i);

                if (string.IsNullOrEmpty(entity.BilgiNotu))
                {
                    tablo.FocusedRowHandle = i;
                    tablo.FocusedColumn = colBilgiNotu;
                    tablo.SetColumnError(colBilgiNotu, "Bilgi Notu  Alanına Geçerli Bir Değer Giriniz.");
                }

                if (!tablo.HasColumnErrors) continue;

                Messages.TabloEksikBilgiMesaji($"{tablo.ViewCaption} Tablosu");
                return true;
            }
            return false;
        }
    }
}
