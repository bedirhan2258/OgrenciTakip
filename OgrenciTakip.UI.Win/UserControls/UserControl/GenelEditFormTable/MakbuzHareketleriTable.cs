
using DevExpress.Utils.Extensions;
using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Base;
using OgrenciTakip.BLL.Functions;
using OgrenciTakip.BLL.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Common.Functions;
using OgrenciTakip.Common.Message;
using OgrenciTakip.Model.DTO;
using OgrenciTakip.UI.Win.Forms.MakbuzForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.GeneralForms;
using OgrenciTakip.UI.Win.Show;
using OgrenciTakip.UI.Win.UserControls.UserControl.Base;
using System;
using System.Linq;
using System.Windows.Forms;

namespace OgrenciTakip.UI.Win.UserControls.UserControl.GenelEditFormTable
{
    public partial class MakbuzHareketleriTable : BaseTablo
    {
        public MakbuzHareketleriTable()
        {
            InitializeComponent();
            Bll = new MakbuzHareketleriBll();
            Tablo = tablo;
            EventsLoad();
            ShowItems = new BarItem[] { btnBelgeHareketleri };
        }

        protected override void Listele()
        {
            tablo.GridControl.DataSource = ((MakbuzHareketleriBll)Bll).List(x => x.MakbuzId == OwnerForm.id).ToBindingList<MakbuzHareketleriL>();
        }

        protected override void HareketEkle()
        {
            if (((MakbuzEditForm)OwnerForm).HataliGiris()) return;

            var source = tablo.DataController.ListSource;
            ListeDisiTutulacakKayitlar = source.Cast<MakbuzHareketleriL>().Where(x => !x.Delete).Select(x => (long)x.OdemeBilgileriId).ToList();

            var entities = ShowListForms<BelgeSecimListForm>.ShowDialogListForm(KartTuru.BelgeSecim, ListeDisiTutulacakKayitlar, true, ((MakbuzEditForm)OwnerForm).MakbuzTuru, ((MakbuzEditForm)OwnerForm).txtHesapTuru.Text.GetEnum<MakbuzHesapTuru>(), ((MakbuzEditForm)OwnerForm).txtHesap.Id).EntityListConvert<BelgeSecimL>();
            if (entities == null) return;

            foreach (var entity in entities)
            {
                var row = new MakbuzHareketleriL
                {
                    MakbuzId = OwnerForm.id,
                    OgrenciNo = entity.OgrenciNo,
                    Adi = entity.Adi,
                    Soyadi = entity.Soyadi,
                    SinifAdi = entity.SinifAdi,
                    OgrenciSubeAdi = entity.OgrenciSubeAdi,
                    BelgeSubeAdi = entity.BelgeSubeAdi,
                    OdemeBilgileriId = entity.OdemeBilgileriId,
                    OdemeTuruAdi = entity.OdemeTuruAdi,
                    OdemeTipi = entity.OdemeTipi,
                    BankaHesapAdi = entity.BankaHesapAdi,
                    TakipNo = entity.TakipNo,
                    GirisTarihi = entity.GirisTarihi,
                    Vade = entity.Vade,
                    HesabaGecisTarihi = entity.HesabaGecisTarihi,
                    Tutar = entity.Tutar,
                    IslemOncesiTutar = entity.Tutar - (entity.Tahsil + entity.Iade),
                    IslemTutari = entity.Tutar - (entity.Tahsil + entity.Iade),
                    BankaAdi = entity.BankaAdi,
                    BankaSubeAdi = entity.BankaSubeAdi,
                    BelgeNo = entity.BelgeNo,
                    HesapNo = entity.HesapNo,
                    AsilBorclu = entity.AsilBorclu,
                    Ciranta = entity.Ciranta,
                    BelgeDurumu = ((MakbuzEditForm)OwnerForm).MakbuzTuru == MakbuzTuru.BaskaSubeyeGonderme ? BelgeDurumu.OnayBekliyor : ((MakbuzEditForm)OwnerForm).MakbuzTuru == MakbuzTuru.GelenBelgeyiOnaylama ? BelgeDurumu.Portfoyde : ((MakbuzEditForm)OwnerForm).MakbuzTuru.ToName().GetEnum<BelgeDurumu>(),
                    KullaniciId = AnaForm.KullaniciId,
                    EskiSubeId = AnaForm.SubeId,
                    YeniSubeId = ((MakbuzEditForm)OwnerForm).MakbuzTuru == MakbuzTuru.BaskaSubeyeGonderme ? ((MakbuzEditForm)OwnerForm).txtHesap.Id : null,
                    Insert = true
                };
                source.Add(row);
            }

            tablo.Focus();
            tablo.RefleshDataSource();
            tablo.FocusedRowHandle = tablo.DataRowCount - 1;
            tablo.FocusedColumn = colIslemTutari;

            SutunGizleGoster();
            RowCellAllowEdit();
            ButtonEnabledDurumu(true);

        }

        protected override void SutunGizleGoster()
        {
            if (tablo.DataRowCount == 0) return;
            var entity = tablo.GetRow<MakbuzHareketleriL>(false);

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

        protected override void RowCellAllowEdit()
        {
            if (tablo.DataRowCount == 0) return;

            var entity = tablo.GetRow<MakbuzHareketleriL>(false);
            if (entity == null) return;

            var makbuzTuru = ((MakbuzEditForm)OwnerForm).MakbuzTuru;

            switch (makbuzTuru)
            {
                case MakbuzTuru.AvukataGonderme:
                case MakbuzTuru.TahsilEtmeKasa:
                case MakbuzTuru.TahsilEtmeBanka:
                    colIslemTutari.OptionsColumn.AllowEdit = entity.Id == 0 || entity.Id >= entity.SonHareketId;
                    break;
            }
        }

        protected override void HareketSil()
        {
            if (Messages.SilMesaj("Makbuz Hareketi") != DialogResult.Yes) return;

            var entity = tablo.GetRow<MakbuzHareketleriL>();
            if (entity == null) return;

            if (entity.Id != 0 && entity.Id < entity.SonHareketId)
            {
                Messages.OdemeBelgesiSilinemezMesaj(true);
                return;
            }

            entity.Delete = true;
            tablo.RefleshDataSource();
            ButtonEnabledDurumu(true);
        }

        protected internal bool TopluHareketSil()
        {
            if (Messages.SilMesaj("Makbuz Kartı") != DialogResult.Yes) return false;

            if (((MakbuzEditForm)OwnerForm).BaseIslemTuru != IslemTuru.EntityInsert)
            {
                var silinemeyenBelgeSayisi = 0;
                var source = tablo.DataController.ListSource.Cast<MakbuzHareketleriL>();
                source.ForEach(x =>
                {
                    if (x.Id == 0 || x.Id > x.SonHareketId)
                    {
                        x.Delete = true;
                        ButtonEnabledDurumu(true);
                    }
                    else
                        silinemeyenBelgeSayisi++;
                });

                tablo.RefleshDataSource();

                if (silinemeyenBelgeSayisi > 0)
                {
                    Messages.HataMesaji($"Makbuz İçerisinde Daha Sonra İşlem Görmüş {silinemeyenBelgeSayisi} Adet Belge Bulunmaktadır. Makbuz Tamamen İptal Edilemez");
                    return false;
                }

                Kaydet();
                return true;
            }
            return true;
        }

        protected internal override bool HataliGiris()
        {
            if (!TableValueChanged) return false;
            if (tablo.HasColumnErrors) tablo.ClearColumnErrors();

            for (int i = 0; i < tablo.DataRowCount; i++)
            {
                var entity = tablo.GetRow<MakbuzHareketleriL>(i);

                if (entity.IslemTutari <= 0)
                {
                    tablo.FocusedRowHandle = i;
                    tablo.FocusedColumn = colIslemTutari;
                    tablo.SetColumnError(colIslemTutari, "İşlem Tutarı, Sıfıra Eşit Veya Sıfırdan Küçük Olamaz ");
                }

                if (entity.IslemTutari > entity.IslemOncesiTutar)
                {
                    tablo.FocusedRowHandle = i;
                    tablo.FocusedColumn = colIslemTutari;
                    tablo.SetColumnError(colIslemTutari, "İşlem Tutarı Kalan Bakiyeden Büyük Olamaz. ");
                }

                if (!tablo.HasColumnErrors) continue;
                Messages.TabloEksikBilgiMesaji($"{tablo.ViewCaption} Tablosu");
                return true;
            }
            return false;
        }

        protected override void BelgeHareketleri()
        {
            var entity = tablo.GetRow<MakbuzHareketleriL>();
            if (entity == null) return;

            ShowListForms<BelgeHareketleriListForm>.ShowDialogListForm(KartTuru.BelgeHareketleri, null, entity.OdemeBilgileriId);
        }

        protected override void Tablo_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            base.Tablo_CellValueChanged(sender, e);
            var entity = tablo.GetRow<MakbuzHareketleriL>();
            if (entity == null) return;

            if (e.Column != colIslemTutari) return;

            if ((decimal)e.Value < entity.IslemOncesiTutar)
                entity.BelgeDurumu = entity.BelgeDurumu == BelgeDurumu.AvukatYoluylaTahsilEtme ? BelgeDurumu.KismiAvukatYoluylaTahsilEtme : BelgeDurumu.KismiTahsilEdildi;
            else
                entity.BelgeDurumu = ((MakbuzEditForm)OwnerForm).MakbuzTuru.ToName().GetEnum<BelgeDurumu>();
        }

        protected override void Tablo_RowCountChanged(object sender, EventArgs e)
        {
            ((MakbuzEditForm)OwnerForm).MakbuzTuruEnabled();
        }

    }
}
