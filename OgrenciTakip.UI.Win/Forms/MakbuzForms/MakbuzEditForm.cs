﻿
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout.Utils;
using OgrenciTakip.BLL.General;
using OgrenciTakip.BLL.Interfaces;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Common.Functions;
using OgrenciTakip.Common.Message;
using OgrenciTakip.Model.DTO;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.GeneralForms;
using OgrenciTakip.UI.Win.Show;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace OgrenciTakip.UI.Win.Forms.MakbuzForms
{
    public partial class MakbuzEditForm : BaseEditForm
    {
        #region Variables
        protected internal readonly MakbuzTuru MakbuzTuru;
        private readonly MakbuzHesapTuru _hesapTuru;
        #endregion


        public MakbuzEditForm(params object[] prm)
        {
            InitializeComponent();
            dataLayoutControl = myDataLayoutControl;
            bll = new MakbuzBll(myDataLayoutControl);
            kartTuru = KartTuru.Makbuz;
            EventsLoad();

            HideItems = new BarItem[] { btnYeni };
            ShowItems = new BarItem[] { btnYazdir };

            kayitSonrasiFormuKapat = false;

            MakbuzTuru = (MakbuzTuru)prm[0];
            _hesapTuru = (MakbuzHesapTuru)prm[1];
            FarkliSubeIslemi = prm.Length > 2 && (bool)prm[2];
        }

        protected internal override void Yukle()
        {
            oldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new MakbuzS() : ((MakbuzBll)bll).Single(FilterFunctions.Filter<Makbuz>(id));
            AlanIslemleri();
            NesneyiKontrollereBagla();
            TabloYukle();
            MakbuzTuruEnabled();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            id = BaseIslemTuru.IdOlustur(oldEntity);
            txtMakbuzNo.Text = ((MakbuzBll)bll).YeniKodVer(x => x.DonemId == AnaForm.DonemId && x.SubeId == AnaForm.SubeId);
            txtTarih.DateTime = DateTime.Now.Date;
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (MakbuzS)oldEntity;

            txtMakbuzNo.Text = entity.Kod;
            txtTarih.DateTime = entity.Tarih;
            txtHesapTuru.SelectedItem = _hesapTuru.ToName();

            if (BaseIslemTuru == IslemTuru.EntityInsert)
            {
                switch (_hesapTuru)
                {
                    case MakbuzHesapTuru.Kasa when AnaForm.KullaniciParametreleri.DefaultKasaHesapId != null:
                        txtHesap.Id = AnaForm.KullaniciParametreleri.DefaultKasaHesapId;
                        txtHesap.Text = AnaForm.KullaniciParametreleri.DefaultKasaHesapAdi;
                        break;
                    case MakbuzHesapTuru.Banka when AnaForm.KullaniciParametreleri.DefaultBankaHesapId != null:
                        txtHesap.Id = AnaForm.KullaniciParametreleri.DefaultBankaHesapId;
                        txtHesap.Text = AnaForm.KullaniciParametreleri.DefaultBankaHesapAdi;
                        break;
                    case MakbuzHesapTuru.Avukat when AnaForm.KullaniciParametreleri.DefaultAvukatHesapId != null:
                        txtHesap.Id = AnaForm.KullaniciParametreleri.DefaultAvukatHesapId;
                        txtHesap.Text = AnaForm.KullaniciParametreleri.DefaultAvukatHesapAdi;
                        break;
                    case MakbuzHesapTuru.Transfer when MakbuzTuru == MakbuzTuru.GelenBelgeyiOnaylama:
                        txtHesap.Id = AnaForm.SubeId;
                        txtHesap.Text = AnaForm.SubeAdi;
                        break;
                }
            }
            else
            {
                txtHesap.Id = entity.AvukatHesapId ?? entity.BankaHesapId ?? entity.CariHesapId ?? entity.KasaHesapId ?? entity.SubeHesapId;
                txtHesap.Text = entity.HesapAdi;
            }
        }
        protected override void GuncelNesneOlustur()
        {
            var hesapTuru = txtHesapTuru.Text.GetEnum<MakbuzHesapTuru>();
            currentEntity = new Makbuz
            {
                Id = id,
                Kod = txtMakbuzNo.Text,
                Tarih = txtTarih.DateTime.Date,
                MakbuzTuru = MakbuzTuru,
                HesapTuru = hesapTuru,
                AvukatHesapId = hesapTuru == MakbuzHesapTuru.Avukat ? txtHesap.Id : null,
                BankaHesapId = hesapTuru == MakbuzHesapTuru.Banka || hesapTuru == MakbuzHesapTuru.Epos || hesapTuru == MakbuzHesapTuru.Ots || hesapTuru == MakbuzHesapTuru.Pos ? txtHesap.Id : null,
                CariHesapId = hesapTuru == MakbuzHesapTuru.Cari || hesapTuru == MakbuzHesapTuru.Mahsup ? txtHesap.Id : null,
                KasaHesapId = hesapTuru == MakbuzHesapTuru.Kasa ? txtHesap.Id : null,
                SubeHesapId = hesapTuru == MakbuzHesapTuru.Transfer ? txtHesap.Id : null,
                HareketSayisi = makbuzHareketleriTable.Tablo.DataRowCount,
                MakbuzToplami = decimal.Parse(makbuzHareketleriTable.colIslemTutari.SummaryText),
                DonemId = AnaForm.DonemId,
                SubeId = AnaForm.SubeId
            };
            ButonEnabledDurumu();
        }

        protected internal override void ButonEnabledDurumu()
        {
            if (!isLoaded) return;

            if (FarkliSubeIslemi)
                GeneralFunctions.ButtonEnabledDurumu(btnYeni, btnKaydet, btnGeriAl, btnSil);
            else
                GeneralFunctions.ButtonEnabledDurumu(btnYeni, btnKaydet, btnGeriAl, btnSil, oldEntity, currentEntity, makbuzHareketleriTable.TableValueChanged);
        }

        protected override bool EntityInsert()
        {
            GuncelNesneOlustur();
            if (HataliGiris()) return false;
            if (makbuzHareketleriTable.HataliGiris()) return false;

            var result = ((MakbuzBll)bll).Insert(currentEntity, x => x.Kod == currentEntity.Kod &&
               x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId) && makbuzHareketleriTable.Kaydet();

            if (result && !kayitSonrasiFormuKapat)
                makbuzHareketleriTable.Yukle();

            return result;
        }

        protected override bool EntityUpdate()
        {
            GuncelNesneOlustur();
            if (HataliGiris()) return false;
            if (makbuzHareketleriTable.HataliGiris()) return false;

            var result = ((MakbuzBll)bll).Update(oldEntity, currentEntity, x => x.Kod == currentEntity.Kod &&
             x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId) && makbuzHareketleriTable.Kaydet();

            if (result && !kayitSonrasiFormuKapat)
                makbuzHareketleriTable.Yukle();

            return result;
        }

        protected override void EntityDelete()
        {
            if (makbuzHareketleriTable.TopluHareketSil()) return;
            if (!((IBaseCommonBll)bll).Delete(oldEntity)) return;
            refreshYapilacak = true;
            Close();
        }

        protected internal bool HataliGiris()
        {
            if (!txtHesap.Visible || txtHesap.Id != null) return false;

            Messages.SecimHataMesaji("Hesap");
            txtHesap.Focus();
            return true;
        }

        private void AlanIslemleri()
        {
            Text = $"{Text} - {MakbuzTuru.ToName()}";
            txtTarih.Properties.MinValue = AnaForm.DonemParametreleri.GunTarihininOncesineMakbuzTarihiGirilebilir ? AnaForm.DonemParametreleri.DonemBaslamaTarihi : DateTime.Now.Date;
            txtTarih.Properties.MaxValue = AnaForm.DonemParametreleri.GunTarihininSonrasinaMakbuzTarihiGirilebilir ? AnaForm.DonemParametreleri.DonemBitisTarihi : DateTime.Now.Date;

            switch (MakbuzTuru)
            {
                case MakbuzTuru.BlokeyeAlma:
                case MakbuzTuru.BlokeCozumu:
                    txtHesapTuru.Properties.Items.AddRange(Enum.GetValues(typeof(MakbuzHesapTuru)).Cast<MakbuzHesapTuru>().Where(x => x == MakbuzHesapTuru.Epos || x == MakbuzHesapTuru.Ots || x == MakbuzHesapTuru.Pos).Select(x => x.ToName()).ToList());
                    break;

                case MakbuzTuru.PorfoyeGeriIade:
                case MakbuzTuru.PorfoyeKarsiliksizIade:
                    txtHesapTuru.Properties.Items.AddRange(Enum.GetValues(typeof(MakbuzHesapTuru)).Cast<MakbuzHesapTuru>().Where(x => x == MakbuzHesapTuru.Avukat || x == MakbuzHesapTuru.Banka || x == MakbuzHesapTuru.Cari).Select(x => x.ToName()).ToList());
                    break;

                case MakbuzTuru.OdenmisOlarakIsaretleme:
                case MakbuzTuru.KarsiliksizOlarakIsaretleme:
                case MakbuzTuru.MusteriyeGeriIade:
                case MakbuzTuru.TahsiliImkansızHaleGelme:
                    txtHesapTuru.Properties.Items.Add(_hesapTuru.ToName());
                    layoutHesapAdi.Visibility = LayoutVisibility.Never;
                    break;

                default:
                    txtHesapTuru.Properties.Items.Add(_hesapTuru.ToName());

                    break;
            }
        }

        protected internal void MakbuzTuruEnabled()
        {
            switch (MakbuzTuru)
            {
                case MakbuzTuru.BlokeyeAlma:
                case MakbuzTuru.BlokeCozumu:
                case MakbuzTuru.PorfoyeGeriIade:
                case MakbuzTuru.PorfoyeKarsiliksizIade:
                case MakbuzTuru.AvukataGonderme:
                case MakbuzTuru.AvukatYoluylaTahsilEtme:
                case MakbuzTuru.BankayaTahsileGonderme:
                case MakbuzTuru.BankaYoluylaTahsilEtme:
                case MakbuzTuru.CiroEtme:
                case MakbuzTuru.BaskaSubeyeGonderme:
                    txtHesap.Enabled = makbuzHareketleriTable.Tablo.DataRowCount == 0;
                    txtHesapTuru.Enabled = makbuzHareketleriTable.Tablo.DataRowCount == 0;
                    break;

                case MakbuzTuru.GelenBelgeyiOnaylama:
                    txtHesapTuru.Enabled = false;
                    txtHesap.Enabled = false;
                    break;
            }
        }

        protected override void SecimYap(object sender)
        {
            if (!(sender is ButtonEdit)) return;

            using (var sec = new SelectFunctions())
            {
                switch (txtHesapTuru.Text.GetEnum<MakbuzHesapTuru>())
                {
                    case MakbuzHesapTuru.Avukat:
                        sec.Sec(txtHesap, KartTuru.Avukat);
                        break;

                    case MakbuzHesapTuru.Banka:
                        sec.Sec(txtHesap, KartTuru.BankaHesap, BankaHesapTuru.VadesizMevduatHesabi);
                        break;

                    case MakbuzHesapTuru.Cari:
                    case MakbuzHesapTuru.Mahsup:
                        sec.Sec(txtHesap, KartTuru.Cari);
                        break;

                    case MakbuzHesapTuru.Epos:
                        sec.Sec(txtHesap, KartTuru.BankaHesap, BankaHesapTuru.EpostBlokeHesabi);
                        break;

                    case MakbuzHesapTuru.Ots:
                        sec.Sec(txtHesap, KartTuru.BankaHesap, BankaHesapTuru.OtsBlokeHesabi);
                        break;

                    case MakbuzHesapTuru.Pos:
                        sec.Sec(txtHesap, KartTuru.BankaHesap, BankaHesapTuru.PostBlokeHesabi);
                        break;

                    case MakbuzHesapTuru.Kasa:
                        sec.Sec(txtHesap, KartTuru.Kasa);
                        break;

                        //case MakbuzHesapTuru.Transfer:
                        //    sec.Sec(txtHesap, KartTuru.Sube);
                        //    break;

                }
            }

        }

        protected override void TabloYukle()
        {
            makbuzHareketleriTable.OwnerForm = this;
            makbuzHareketleriTable.Yukle();
        }

        protected override void Yazdir()
        {
            var source = new List<MakbuzHareketleriR>();

            for (int i = 0; i < makbuzHareketleriTable.Tablo.DataRowCount; i++)
            {
                var entity = makbuzHareketleriTable.Tablo.GetRow<MakbuzHareketleriL>(i);
                if (entity == null) return;
                var row = new MakbuzHareketleriR
                {
                    OgrenciNo = entity.OgrenciNo,
                    Adi = entity.Adi,
                    Soyadi = entity.Soyadi,
                    SinifAdi = entity.SinifAdi,
                    SubeAdi = entity.OgrenciSubeAdi,
                    PortfoyNo = entity.OdemeBilgileriId,
                    OdemeTuruAdi = entity.OdemeTuruAdi,
                    Vade = entity.Vade,
                    AsilBorclu = entity.AsilBorclu,
                    Ciranta = entity.Ciranta,
                    BankaveSubeAdi = entity.BankaAdi + " / " + entity.BankaSubeAdi,
                    BelgeNo = entity.BelgeNo,
                    HesapNo = entity.HesapNo,
                    Tutar = entity.Tutar,
                    IslemOncesiTutar = entity.IslemOncesiTutar,
                    IslemTutari = entity.IslemTutari,
                    Tarih = txtTarih.DateTime.Date,
                    MakbuzNo = txtMakbuzNo.Text,
                    MakbuzTuru = MakbuzTuru.ToName(),
                    HesapTuru = _hesapTuru.ToName(),
                    HesapAdi = txtHesap.Text,
                    BelgeDurumu = entity.BelgeDurumu.ToName()
                };
                source.Add(row);
            }
            ShowListForms<RaporSecim>.ShowDialogListForm(KartTuru.Rapor, false, RaporBolumTuru.MakbuzRaporlari, source);
        }

        protected override void Control_SelectedValueChanged(object sender, EventArgs e)
        {
            if (sender != txtHesapTuru) return;
            txtHesap.Id = null;
            txtHesap.Text = null;
            txtHesap.Focus();
        }

        protected override void BaseEditForm_Shown(object sender, EventArgs e)
        {
            if (layoutHesapAdi.Visible && txtHesap.Id == null)
                txtHesap.Focus();
            else
                makbuzHareketleriTable.Tablo.GridControl.Focus();
        }

    }
}