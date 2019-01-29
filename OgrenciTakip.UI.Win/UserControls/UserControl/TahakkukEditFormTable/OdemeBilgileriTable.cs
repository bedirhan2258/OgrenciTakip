
using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Base;
using OgrenciTakip.BLL.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Common.Message;
using OgrenciTakip.Model.DTO;
using OgrenciTakip.UI.Win.Forms.TahakkukForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.GeneralForms;
using OgrenciTakip.UI.Win.Show;
using OgrenciTakip.UI.Win.UserControls.UserControl.Base;
using System;
using System.Linq;
using System.Windows.Forms;

namespace OgrenciTakip.UI.Win.UserControls.UserControl.TahakkukEditFormTable
{
    public partial class OdemeBilgileriTable : BaseTablo
    {
        public OdemeBilgileriTable()
        {
            InitializeComponent();

            Bll = new OdemeBilgileriBll();
            Tablo = tablo;
            EventsLoad();
            ShowItems = new BarItem[] { btnBelgeHareketleri };
        }

        protected override void Listele()
        {
            tablo.GridControl.DataSource = ((OdemeBilgileriBll)Bll).List(x => x.TahakkukId == OwnerForm.id).ToBingingList<OdemeBilgileriL>();
        }

        protected override void HareketEkle()
        {
            decimal BakiyeHesapla()
            {
                return 0;
            }

            var source = tablo.DataController.ListSource;
            var dahaOnceGirilenTaksitSayisi = source.Cast<OdemeBilgileriL>().Count(x => !x.Delete && x.BelgeDurumu != BelgeDurumu.MusteriyeGeriIade);

            if (!ShowEditForms<TopluOdemePlaniEditForm>.ShowDialogEditForms(source, OwnerForm.id, BakiyeHesapla(), ((TahakkukEditForm)OwnerForm).txtKayitTarihi.DateTime.Date, dahaOnceGirilenTaksitSayisi)) return;

            tablo.Focus();
            tablo.RefleshDataSource();
            tablo.FocusedRowHandle = tablo.DataRowCount - 1;
            insUptNavigator.Navigator.Buttons.DoClick(insUptNavigator.Navigator.Buttons.EndEdit);
            tablo.FocusedColumn = colOdemeTuruAdi;
            ButtonEnabledDurumu(true);
        }

        protected override void SutunGizleGoster()
        {
            if (tablo.DataRowCount == 0) return;

            var entity = tablo.GetRow<OdemeBilgileriL>();
            if (entity == null) return;

            colBankaHesapAdi.VisibleIndex = 10;
            colTakipNo.VisibleIndex = 11;
            colBlokeGunSayisi.VisibleIndex = 12;
            colBankaAdi.VisibleIndex = 13;
            colBankaSubeAdi.VisibleIndex = 14;
            colHesapNo.VisibleIndex = 15;
            colBelgeNo.VisibleIndex = 16;
            colAsilBorclu.VisibleIndex = 17;
            colCiranta.VisibleIndex = 18;

            colBankaHesapAdi.Visible = entity.OdemeTipi == OdemeTipi.Epos || entity.OdemeTipi == OdemeTipi.Ots || entity.OdemeTipi == OdemeTipi.Pos;
            colTakipNo.Visible = entity.OdemeTipi == OdemeTipi.Pos;
            colBlokeGunSayisi.Visible = entity.OdemeTipi == OdemeTipi.Epos || entity.OdemeTipi == OdemeTipi.Ots || entity.OdemeTipi == OdemeTipi.Pos;
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

            var entity = tablo.GetRow<OdemeBilgileriL>();
            if (entity == null) return;

            colBankaHesapAdi.OptionsColumn.AllowEdit = entity.SonHareketId == null;
            colVade.OptionsColumn.AllowEdit = entity.SonHareketId == null;
            colTutar.OptionsColumn.AllowEdit = entity.SonHareketId == null;
            colTakipNo.OptionsColumn.AllowEdit = entity.SonHareketId == null;
            colBlokeGunSayisi.OptionsColumn.AllowEdit = entity.SonHareketId == null;
            colBankaAdi.OptionsColumn.AllowEdit = entity.SonHareketId == null;
            colBankaSubeAdi.OptionsColumn.AllowEdit = entity.SonHareketId == null;
            colHesapNo.OptionsColumn.AllowEdit = entity.SonHareketId == null;
            colBelgeNo.OptionsColumn.AllowEdit = entity.SonHareketId == null;
            colAsilBorclu.OptionsColumn.AllowEdit = entity.SonHareketId == null;
            colCiranta.OptionsColumn.AllowEdit = entity.SonHareketId == null;

        }

        protected internal override bool HataliGiris()
        {
            if (!TableValueChanged) return false;
            if (tablo.HasColumnErrors) tablo.ClearColumnErrors();

            for (int i = 0; i < tablo.DataRowCount; i++)
            {
                var entity = tablo.GetRow<OdemeBilgileriL>(i);

                if (entity.Tutar == 0)
                {
                    tablo.FocusedRowHandle = i;
                    tablo.FocusedColumn = colTutar;
                    tablo.SetColumnError(colTutar, "Belge Tutarı Sıfır ( 0 ) Olamaz.");
                }
                switch (entity.OdemeTipi)
                {
                    case OdemeTipi.Cek:
                        if (entity.BankaId == null)
                        {
                            tablo.FocusedRowHandle = i;
                            tablo.FocusedColumn = colBankaAdi;
                            tablo.SetColumnError(colTutar, "Banka Seçimi Yapmalısınız.");
                        }

                        if (entity.BankaSubeId == null)
                        {
                            tablo.FocusedRowHandle = i;
                            tablo.FocusedColumn = colBankaSubeAdi;
                            tablo.SetColumnError(colBankaSubeAdi, "Banka Şube Seçimi Yapmalısınız.");
                        }

                        if (string.IsNullOrEmpty(entity.BelgeNo))
                        {
                            tablo.FocusedRowHandle = i;
                            tablo.FocusedColumn = colBelgeNo;
                            tablo.SetColumnError(colBelgeNo, "Belge No Alanına Geçerli Bir Değer Giriniz.");
                        }

                        if (string.IsNullOrEmpty(entity.AsilBorclu))
                        {
                            tablo.FocusedRowHandle = i;
                            tablo.FocusedColumn = colAsilBorclu;
                            tablo.SetColumnError(colAsilBorclu, "Asil Borçlu  Alanına Geçerli Bir Değer Giriniz.");
                        }
                        break;

                    case OdemeTipi.Senet:

                        if (string.IsNullOrEmpty(entity.AsilBorclu))
                        {
                            tablo.FocusedRowHandle = i;
                            tablo.FocusedColumn = colAsilBorclu;
                            tablo.SetColumnError(colAsilBorclu, "Asil Borçlu  Alanına Geçerli Bir Değer Giriniz.");
                        }
                        break;

                    case OdemeTipi.Epos:
                    case OdemeTipi.Ots:
                    case OdemeTipi.Pos:

                        if (entity.BankaHesapId == null)
                        {
                            tablo.FocusedRowHandle = i;
                            tablo.FocusedColumn = colBankaHesapAdi;
                            tablo.SetColumnError(colBankaHesapAdi, "Banka Hesap Seçimi Yapmalısınız.");
                        }
                        break;
                }

                if (!tablo.HasColumnErrors) continue;
                Messages.TabloEksikBilgiMesaji($"{tablo.ViewCaption} Tablosu");
                return true;
            }
            return false;
        }

        protected override void HareketSil()
        {
            if (tablo.DataRowCount == 0) return;
            if (Messages.SilMesaj("Ödeme Bilgisi") != DialogResult.Yes) return;

            var entity = tablo.GetRow<OdemeBilgileriL>();

            if (entity.SonHareketId != null)
            {
                Messages.OdemeBelgesiSilinemezMesaj(false);
                return;
            }

            entity.Delete = true;
            tablo.RefleshDataSource();
            ButtonEnabledDurumu(true);
        }

        protected override void Tablo_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            base.Tablo_CellValueChanged(sender, e);

            var entity = tablo.GetRow<OdemeBilgileriL>();

            if (e.Column == colVade)
            {
                entity.VadeYazi = ((DateTime)e.Value).YaziIleVade();
                entity.HesabaGecisTarihi = entity.Vade.AddDays(entity.BlokeGunSayisi);
            }

            else if (e.Column == colTutar)
            {
                entity.TutarYazi = ((decimal)e.Value).YaziIleTutar();
            }

            else if (e.Column == colBlokeGunSayisi)
            {
                entity.HesabaGecisTarihi = entity.Vade.AddDays(entity.BlokeGunSayisi);
            }

            else if (e.Column == colBankaId)
            {
                entity.BankaSubeId = null;
                entity.BankaSubeAdi = null;
                colBankaSubeAdi.OptionsColumn.AllowEdit = entity.BankaId != null;
            }

        }

        protected override void Tablo_FocusedColumnChanged(object sender, FocusedColumnChangedEventArgs e)
        {
            base.Tablo_FocusedColumnChanged(sender, e);

            if (e.FocusedColumn == colBankaHesapAdi)
            {
                e.FocusedColumn.Sec(tablo, insUptNavigator.Navigator, repositoryBankaHesap, colBankaHesapId);
            }

            else if (e.FocusedColumn == colBankaAdi)
            {
                e.FocusedColumn.Sec(tablo, insUptNavigator.Navigator, repositoryBanka, colBankaId);
            }

            else if (e.FocusedColumn == colBankaSubeAdi)
            {
                e.FocusedColumn.Sec(tablo, insUptNavigator.Navigator, repositoryBankaSube, colBankaSubeId, colBankaId, colBankaAdi);
            }

            else if (e.FocusedColumn == colVade)
            {
                repositoryVade.MinValue = ((TahakkukEditForm)OwnerForm).txtKayitTarihi.DateTime.Date;
                repositoryVade.MaxValue = AnaForm.MaksimumTaksitTarihi;
            }
        }
    }
}
