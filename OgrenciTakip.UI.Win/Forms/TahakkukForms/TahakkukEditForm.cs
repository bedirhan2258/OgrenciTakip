

using DevExpress.XtraBars;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using OgrenciTakip.BLL.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Common.Functions;
using OgrenciTakip.Model.DTO;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.Model.Entities.Base.Interfaces;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.GeneralForms;
using OgrenciTakip.UI.Win.UserControls.UserControl.Base;
using OgrenciTakip.UI.Win.UserControls.UserControl.TahakkukEditFormTable;
using System;
using System.Linq;

namespace OgrenciTakip.UI.Win.Forms.TahakkukForms
{
    public partial class TahakkukEditForm : BaseEditForm
    {
        private readonly Ogrenci _ogrenci;
        private BaseTablo _kardesbilgileriTable;
        private BaseTablo _aileBilgileriTable;
        private BaseTablo _sinavBilgileriTable;
        private BaseTablo _evrakBilgileriTable;
        private BaseTablo _promosyonBilgileriTable;

        public TahakkukEditForm()
        {
            InitializeComponent();
            dataLayoutControls = new[] { DataLayoutGenel, DataLayoutGenelBilgiler };
            bll = new TahakkukBll(DataLayoutGenelBilgiler);
            kartTuru = KartTuru.Tahakkuk;
            EventsLoad();

            HideItems = new BarItem[] { btnYeni };
            ShowItems = new BarItem[] { btnYazdir };

            txtKayitSekli.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<KayitSekli>());
            txtKayitDurumu.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<KayitDurumu>());
            txtSonrakiDonemKayitDurumu.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<SonrakiDonemKayitDurumu>());

            txtKayitTarihi.Properties.MinValue = AnaForm.DonemBaslamaTarihi;
            txtKayitTarihi.Properties.MaxValue = AnaForm.DonemBitisTarihi;

            btnYazdir.Caption = "Kayıt Evrakları";
        }

        public TahakkukEditForm(params object[] prm) : this()
        {
            if (prm[0] is Ogrenci ogr)
                _ogrenci = ogr;

            else if (prm[0] is bool yesNo)
                FarkliSubeIslemi = yesNo;
        }

        protected internal override void Yukle()
        {
            oldEntity = islemTuru == IslemTuru.EntityInsert ? new TahakkukS() : ((TahakkukBll)bll).Single(FilterFunctions.Filter<Tahakkuk>(id));
            NesneyiKontrollereBagla();
            BagliTabloYukle();


            if (islemTuru != IslemTuru.EntityInsert) return;
            id = islemTuru.IdOlustur(oldEntity);
            txtKod.Text = ((TahakkukBll)bll).YeniKodVer(x => x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId);

        }

        protected override void BagliTabloYukle()
        {
            bool TableValueChanged(BaseTablo tablo)
            {
                return tablo.Tablo.DataController.ListSource.Cast<IBaseHareketEntity>().Any(x => x.Insert || x.Update || x.Delete);
            }

            if (_kardesbilgileriTable != null)
                _kardesbilgileriTable.Yukle();

            else if (_aileBilgileriTable != null)
                _aileBilgileriTable.Yukle();

            else if (_sinavBilgileriTable != null)
                _sinavBilgileriTable.Yukle();

            else if (_evrakBilgileriTable != null)
                _evrakBilgileriTable.Yukle();

            else if (_promosyonBilgileriTable != null)
                _promosyonBilgileriTable.Yukle();

        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (TahakkukS)oldEntity;

            txtTcKimlikNo.Text = islemTuru == IslemTuru.EntityInsert ? _ogrenci.TcKimlikNo : entity.TcKimlikNo;
            txtAdi.Text = islemTuru == IslemTuru.EntityInsert ? _ogrenci.Adi : entity.Adi;
            txtSoyadi.Text = islemTuru == IslemTuru.EntityInsert ? _ogrenci.Soyadi : entity.Soyadi;
            txtBabaAdi.Text = islemTuru == IslemTuru.EntityInsert ? _ogrenci.BabaAdi : entity.BabaAdi;
            txtAnaAdi.Text = islemTuru == IslemTuru.EntityInsert ? _ogrenci.AnaAdi : entity.AnaAdi;
            txtDurum.Text = entity.Durum ? IptalDurumu.DevamEdiyor.ToName() : IptalDurumu.IptalEdildi.ToName();
            txtKod.Text = entity.Kod;
            txtOkulNo.Text = entity.OkulNo;
            txtKayitTarihi.DateTime = entity.KayitTarihi;
            txtKayitSekli.SelectedItem = entity.KayitSekli.ToName();
            txtKayitDurumu.SelectedItem = entity.KayitDurumu.ToName();
            txtSinif.Id = entity.SinifId;
            txtSinif.Text = entity.SinifAdi;
            txtYabanciDil.Id = entity.YabanciDilId;
            txtYabanciDil.Text = entity.YabanciDilAdi;
            txtGeldigiOkul.Id = entity.GeldigiOkulId;
            txtGeldigiOkul.Text = entity.GeldigiOkulAdi;
            txtKontenjan.Id = entity.KontenjanId;
            txtKontenjan.Text = entity.KontenjanAdi;
            txtTesvik.Id = entity.TesvikId;
            txtTesvik.Text = entity.TesvikAdi;
            txtRehber.Id = entity.RehberId;
            txtRehber.Text = entity.RehberAdi;
            txtSonrakiDonemKayitDurumu.SelectedItem = entity.SonrakiDonemKayitDurumu.ToName();
            txtSonrakiDonemKayitDurumuAciklama.Text = entity.SonrakiDonemKayitDurumuAciklama;
            txtOzelKod1.Text = entity.OzelKod1Adi;
            txtOzelKod1.Id = entity.OzelKod1Id;
            txtOzelKod2.Text = entity.OzelKod2Adi;
            txtOzelKod2.Id = entity.OzelKod2Id;
            txtOzelKod3.Text = entity.OzelKod3Adi;
            txtOzelKod3.Id = entity.OzelKod3Id;
            txtOzelKod4.Text = entity.OzelKod4Adi;
            txtOzelKod4.Id = entity.OzelKod4Id;
            txtOzelKod5.Text = entity.OzelKod5Adi;
            txtOzelKod5.Id = entity.OzelKod5Id;
        }
        protected override void GuncelNesneOlustur()
        {
            currentEnttiy = new Tahakkuk
            {
                Id = id,
                Kod = txtKod.Text,
                OgrenciId = islemTuru == IslemTuru.EntityInsert ? _ogrenci.Id : ((TahakkukS)oldEntity).OgrenciId,
                OkulNo = txtOkulNo.Text,
                KayitTarihi = txtKayitTarihi.DateTime.Date,
                KayitSekli = txtKayitSekli.Text.GetEnum<KayitSekli>(),
                KayitDurumu = txtKayitDurumu.Text.GetEnum<KayitDurumu>(),
                SinifId = Convert.ToInt64(txtSinif.Id),
                YabanciDilId = txtYabanciDil.Id,
                GeldigiOkulId = txtGeldigiOkul.Id,
                KontenjanId = txtKontenjan.Id,
                TesvikId = txtTesvik.Id,
                RehberId = txtRehber.Id,
                SonrakiDonemKayitDurumu = txtSonrakiDonemKayitDurumu.Text.GetEnum<SonrakiDonemKayitDurumu>(),
                SonrakiDonemKayitDurumuAciklama = txtSonrakiDonemKayitDurumuAciklama.Text,
                OzelKod1Id = txtOzelKod1.Id,
                OzelKod2Id = txtOzelKod2.Id,
                OzelKod3Id = txtOzelKod3.Id,
                OzelKod4Id = txtOzelKod4.Id,
                OzelKod5Id = txtOzelKod5.Id,
                Durum = txtDurum.Text.GetEnum<IptalDurumu>() == IptalDurumu.DevamEdiyor,
                DonemId = AnaForm.DonemId,
                SubeId = AnaForm.SubeId,


            };
            ButonEnabledDurumu();
        }

        protected override bool EntityInsert()
        {
            if (BagliTabloHataliGirisKontrol())
                return false;

            var result = ((TahakkukBll)bll).Insert(currentEnttiy, x => x.Kod == currentEnttiy.Kod &&
               x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId) && BagliTabloKaydet();

            if (result)
                BagliTabloYukle();

            return result;
        }
        protected override bool EntityUpdate()
        {
            if (BagliTabloHataliGirisKontrol())
                return false;

            var result = ((TahakkukBll)bll).Update(oldEntity, currentEnttiy, x => x.Kod == currentEnttiy.Kod &&
             x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId) && BagliTabloKaydet();

            if (result)
                BagliTabloYukle();

            return result;
        }

        protected override bool BagliTabloHataliGirisKontrol()
        {
            if (_sinavBilgileriTable != null && _sinavBilgileriTable.HataliGiris())
            {
                tabUst.SelectedPage = pageAileSinavBilgileri;
                _sinavBilgileriTable.Tablo.GridControl.Focus();
                return true;
            }
            return false;
        }

        protected override void SecimYap(object sender)
        {
            if (!(sender is ButtonEdit)) return;
            using (var sec = new SelectFunctions())
                if (sender == txtSinif)
                    sec.Sec(txtSinif);
                else if (sender == txtYabanciDil)
                    sec.Sec(txtYabanciDil);
                else if (sender == txtGeldigiOkul)
                    sec.Sec(txtGeldigiOkul);
                else if (sender == txtKontenjan)
                    sec.Sec(txtKontenjan);
                else if (sender == txtTesvik)
                    sec.Sec(txtTesvik);
                else if (sender == txtRehber)
                    sec.Sec(txtRehber);
                else if (sender == txtOzelKod1)
                    sec.Sec(txtOzelKod1, KartTuru.Tahakkuk);
                else if (sender == txtOzelKod2)
                    sec.Sec(txtOzelKod2, KartTuru.Tahakkuk);
                else if (sender == txtOzelKod3)
                    sec.Sec(txtOzelKod3, KartTuru.Tahakkuk);
                else if (sender == txtOzelKod4)
                    sec.Sec(txtOzelKod4, KartTuru.Tahakkuk);
                else if (sender == txtOzelKod5)
                    sec.Sec(txtOzelKod5, KartTuru.Tahakkuk);
        }
        protected internal override void ButonEnabledDurumu()
        {
            if (!isLoaded) return;

            bool TableValueChanged()
            {
                if (_kardesbilgileriTable != null && _kardesbilgileriTable.TableValueChanged) return true;
                if (_aileBilgileriTable != null && _aileBilgileriTable.TableValueChanged) return true;
                if (_sinavBilgileriTable != null && _sinavBilgileriTable.TableValueChanged) return true;
                if (_evrakBilgileriTable != null && _evrakBilgileriTable.TableValueChanged) return true;
                if (_promosyonBilgileriTable != null && _promosyonBilgileriTable.TableValueChanged) return true;

                return false;
            }

            if (FarkliSubeIslemi)
                GeneralFunctions.ButtonEnabledDurumu(btnYeni, btnKaydet, btnGeriAl, btnSil);
            else
                GeneralFunctions.ButtonEnabledDurumu(btnYeni, btnKaydet, btnGeriAl, btnSil, oldEntity, currentEnttiy, TableValueChanged());
        }

        protected override bool BagliTabloKaydet()
        {
            if (_kardesbilgileriTable != null && !_kardesbilgileriTable.Kaydet()) return false;
            if (_aileBilgileriTable != null && !_aileBilgileriTable.Kaydet()) return false;
            if (_sinavBilgileriTable != null && !_sinavBilgileriTable.Kaydet()) return false;
            if (_evrakBilgileriTable != null && !_evrakBilgileriTable.Kaydet()) return false;
            if (_promosyonBilgileriTable != null && !_promosyonBilgileriTable.Kaydet()) return false;
            return true;
        }

        protected override void Control_SelectedPageChanged(object sender, SelectedPageChangedEventArgs e)
        {
            if (e.Page == pageGenelBilgiler)
            {
                txtOkulNo.Focus();
                txtOkulNo.SelectAll();
            }
            else if (e.Page == pageKardesBilgileri)
            {
                if (pageKardesBilgileri.Controls.Count == 0)
                {
                    _kardesbilgileriTable = new KardesBilgileriTable().AddTable(this);
                    pageKardesBilgileri.Controls.Add(_kardesbilgileriTable);
                    _kardesbilgileriTable.Yukle();
                }
                _kardesbilgileriTable.Tablo.GridControl.Focus();
            }

            else if (e.Page == pageAileSinavBilgileri)
            {
                if (layoutControlAileSinavBilgileri.Items.Count == 0)
                {
                    _aileBilgileriTable = new AileBilgileriTable().AddTable(this);
                    // pageAileSinavBilgileri.Controls.Add(_aileBilgileriTable);
                    layoutControlAileSinavBilgileri.LayoutControlInsert(_aileBilgileriTable, 0, 0, 0, 0);
                    _aileBilgileriTable.Yukle();

                    _sinavBilgileriTable = new SinavBilgileriTable().AddTable(this);
                    layoutControlAileSinavBilgileri.LayoutControlInsert(_sinavBilgileriTable, 1, 0, 0, 0);
                    _sinavBilgileriTable.Yukle();
                }
                _aileBilgileriTable.Tablo.GridControl.Focus();
            }

            else if (e.Page == pageEvrakPromosyonBilgileri)
            {
                if (layoutControlEvrakPromosyonBilgileri.Items.Count == 0)
                {
                    _evrakBilgileriTable = new EvrakBilgileriTable().AddTable(this);
                    layoutControlEvrakPromosyonBilgileri.LayoutControlInsert(_evrakBilgileriTable, 0, 0, 0, 0);
                    _evrakBilgileriTable.Yukle();

                    _promosyonBilgileriTable = new PromosyonBilgileriTable().AddTable(this);
                    layoutControlEvrakPromosyonBilgileri.LayoutControlInsert(_promosyonBilgileriTable, 1, 0, 0, 0);
                    _promosyonBilgileriTable.Yukle();
                }
                _evrakBilgileriTable.Tablo.GridControl.Focus();
            }
        }

    }
}