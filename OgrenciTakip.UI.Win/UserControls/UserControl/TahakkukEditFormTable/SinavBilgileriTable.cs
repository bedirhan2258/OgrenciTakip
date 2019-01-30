
using OgrenciTakip.BLL.General;
using OgrenciTakip.Common.Message;
using OgrenciTakip.Model.DTO;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.UserControls.UserControl.Base;
using System;

namespace OgrenciTakip.UI.Win.UserControls.UserControl.TahakkukEditFormTable
{
    public partial class SinavBilgileriTable : BaseTablo
    {
        public SinavBilgileriTable()
        {
            InitializeComponent();

            Bll = new SinavBilgileriBll();
            Tablo = tablo;
            EventsLoad();
        }
        protected override void Listele()
        {
            tablo.GridControl.DataSource = ((SinavBilgileriBll)Bll).List(x => x.TahakkukId == OwnerForm.id).ToBindingList<SinavBilgileriL>();
        }

        protected override void HareketEkle()
        {
            var source = tablo.DataController.ListSource;
            var row = new SinavBilgileriL
            {
                TahakkukId = OwnerForm.id,
                Tarih = DateTime.Now.Date,
                Insert = true
            };

            source.Add(row);
            
            tablo.Focus();
            tablo.RefleshDataSource();
            tablo.FocusedRowHandle = tablo.DataRowCount - 1;
            tablo.FocusedColumn = colSinavAdi;
            ButtonEnabledDurumu(true);
        }
        protected internal override bool HataliGiris()
        {
            if (!TableValueChanged) return false;

            if (tablo.HasColumnErrors)
                tablo.ClearColumnErrors();

            for (int i = 0; i < tablo.DataRowCount; i++)
            {
                var entity = tablo.GetRow<SinavBilgileriL>(i);

                if (string.IsNullOrEmpty(entity.SinavAdi))
                {
                    tablo.FocusedRowHandle = i;
                    tablo.FocusedColumn = colSinavAdi;
                    tablo.SetColumnError(colSinavAdi, "Sınav Adı Alanına Geçerli Bir Değer Giriniz.");
                }
                if (string.IsNullOrEmpty(entity.PuanTuru))
                {
                    tablo.FocusedRowHandle = i;
                    tablo.FocusedColumn = colPuanTuru;
                    tablo.SetColumnError(colPuanTuru, "Puan Türü Alanına Geçerli Bir Değer Giriniz.");
                }

                if (!tablo.HasColumnErrors) continue;

                Messages.TabloEksikBilgiMesaji($"{tablo.ViewCaption} Tablosu");
                return true;
            }
            return false;
        }
    }
}
