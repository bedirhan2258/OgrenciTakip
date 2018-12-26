
using OgrenciTakip.BLL.Functions;
using OgrenciTakip.BLL.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.DTO;
using OgrenciTakip.UI.Win.Forms.HizmetForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.GeneralForms;
using OgrenciTakip.UI.Win.Show;
using OgrenciTakip.UI.Win.UserControls.UserControl.Base;
using System.Linq;

namespace OgrenciTakip.UI.Win.UserControls.IndirimEditFormTable
{
    public partial class IndiriminUygulanacagiHizmetlerTable : BaseTablo
    {
        public IndiriminUygulanacagiHizmetlerTable()
        {
            InitializeComponent();

            Bll = new IndiriminUygulanacagiHizmetBilgileriBll();
            Tablo = tablo;
            EventsLoad();
        }
        protected override void Listele()
        {
            //Bana sorgu sonucundan toList tipinde bişey geliyor fakat bunu benım TobinngList şeklinde cast etmem gerekiyor.Çünkü Yeni butonu pasif olarak gelıyor.
            //Bunu için generafucntions class içinde TobindingList adlı method oluşturuldu.
            tablo.GridControl.DataSource = ((IndiriminUygulanacagiHizmetBilgileriBll)Bll).List(x => x.IndirimId == OwnerForm.id).ToBingingList<IndiriminUygulanacagiHizmetBilgileriL>();
        }
        protected override void HareketEkle()
        {
            //List olarak datasource alıyoruz.
           
            var source = tablo.DataController.ListSource;
            ListeDisiTutulacakKayitlar = source.Cast<IndiriminUygulanacagiHizmetBilgileriL>().Where(x => !x.Delete).Select(x => x.HizmetId).ToList();

            var entities = ShowListForms<HizmetListForm>.ShowDialogListForm(KartTuru.Hizmet, ListeDisiTutulacakKayitlar, true).EntityListConvert<HizmetL>();
            if (entities == null) return;

            foreach (var entity in entities)
            {
                var row = new IndiriminUygulanacagiHizmetBilgileriL
                {
                    IndirimId = OwnerForm.id,
                    HizmetId = entity.Id,
                    HizmetAdi = entity.HizmetAdi,
                    IndirimTutari = 0,
                    IndirimOrani = 0,
                    SubeId = AnaForm.SubeId,
                    DonemId = AnaForm.DonemId,
                    Insert = true
                };
                source.Add(row);
            }
            tablo.Focus();
            tablo.RefleshDataSource();
            tablo.FocusedRowHandle = tablo.DataRowCount - 1;
            tablo.FocusedColumn = colIndirimTutari;
            ButtonEnabledDurumu(true);


        }
        protected internal override bool HataliGiris()
        {
            return base.HataliGiris();
        }
    }
}
