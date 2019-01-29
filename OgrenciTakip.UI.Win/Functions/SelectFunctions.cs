using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model;
using OgrenciTakip.Model.DTO;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BankaForms;
using OgrenciTakip.UI.Win.Forms.BankaHesapForms;
using OgrenciTakip.UI.Win.Forms.BankaSubeForms;
using OgrenciTakip.UI.Win.Forms.GorevForms;
using OgrenciTakip.UI.Win.Forms.HizmetForms;
using OgrenciTakip.UI.Win.Forms.HizmetTuruForms;
using OgrenciTakip.UI.Win.Forms.IlceForms;
using OgrenciTakip.UI.Win.Forms.IlForms;
using OgrenciTakip.UI.Win.Forms.IndirimTuruForms;
using OgrenciTakip.UI.Win.Forms.IsyeriForms;
using OgrenciTakip.UI.Win.Forms.KontenjanForms;
using OgrenciTakip.UI.Win.Forms.MeslekForms;
using OgrenciTakip.UI.Win.Forms.OdemeTuruForms;
using OgrenciTakip.UI.Win.Forms.OzelKodForms;
using OgrenciTakip.UI.Win.Forms.RehberForms;
using OgrenciTakip.UI.Win.Forms.SchoolForms;
using OgrenciTakip.UI.Win.Forms.SinifForms;
using OgrenciTakip.UI.Win.Forms.SinifGrupForms;
using OgrenciTakip.UI.Win.Forms.TesvikForms;
using OgrenciTakip.UI.Win.Forms.YabanciDilForms;
using OgrenciTakip.UI.Win.Show;
using OgrenciTakip.UI.Win.UserControls.Controls;
using System;


namespace OgrenciTakip.UI.Win.Functions
{
    public class SelectFunctions : IDisposable
    {
        #region Variables
        private MyButtonEdit _btnEdit;
        private MyButtonEdit _prmEdit;
        private KartTuru _kartTuru;
        private OdemeTipi _odemeTipi;
        #endregion

        public void Sec(MyButtonEdit btnEdit)
        {
            _btnEdit = btnEdit;
            SecimYap();
        }

        public void Sec(MyButtonEdit btnEdit, OdemeTipi odemeTipi)
        {
            _btnEdit = btnEdit;
            _odemeTipi = odemeTipi;
            SecimYap();
        }

        public void Sec(MyButtonEdit btnEdit, KartTuru kartTuru)
        {
            _btnEdit = btnEdit;
            _kartTuru = kartTuru;
            SecimYap();
        }

        public void Sec(MyButtonEdit btnEdit, MyButtonEdit prmEdit)
        {
            _btnEdit = btnEdit;
            _prmEdit = prmEdit;
            SecimYap();
        }

        private void SecimYap()
        {
            switch (_btnEdit.Name)
            {
                case "txtIl":
                case "txtEvAdresIl":
                case "txtIsAdresIl":
                case "txtKimlikIl":
                    {
                        var entity = (Il)ShowListForms<IlListForm>.ShowDialogListForm(KartTuru.Il, _btnEdit.Id);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.IlAdi;
                        }
                    }
                    break;

                case "txtIlce":
                case "txtEvAdresIlce":
                case "txtIsAdresIlce":
                case "txtKimlikIlce":
                    {
                        var entity = (Ilce)ShowListForms<IlceListForm>.ShowDialogListForm(KartTuru.Ilce, _btnEdit.Id, _prmEdit.Id, _prmEdit.Text);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.IlceAdi;
                        }
                    }
                    break;

                case "txtGrup":
                    {
                        var entity = (SinifGrup)ShowListForms<SinifGrupListForm>.ShowDialogListForm(KartTuru.SinifGrup, _btnEdit.Id);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.GrupAdi;
                        }
                    }
                    break;

                case "txtHizmetTuru":
                    {
                        var entity = (HizmetTuru)ShowListForms<HizmetTuruListForm>.ShowDialogListForm(KartTuru.HizmetTuru, _btnEdit.Id);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.HizmetTuruAdi;
                        }
                    }
                    break;

                case "txtOzelKod1":
                    {
                        var entity = (OzelKod)ShowListForms<OzelKodListForm>.ShowDialogListForm(KartTuru.OzelKod, _btnEdit.Id, OzelKodTuru.OzelKod1, _kartTuru);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.OzelKodAdi;
                        }
                    }
                    break;

                case "txtOzelKod2":
                    {
                        var entity = (OzelKod)ShowListForms<OzelKodListForm>.ShowDialogListForm(KartTuru.OzelKod, _btnEdit.Id, OzelKodTuru.OzelKod2, _kartTuru);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.OzelKodAdi;
                        }
                    }
                    break;

                case "txtOzelKod3":
                    {
                        var entity = (OzelKod)ShowListForms<OzelKodListForm>.ShowDialogListForm(KartTuru.OzelKod, _btnEdit.Id, OzelKodTuru.OzelKod3, _kartTuru);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.OzelKodAdi;
                        }
                    }
                    break;

                case "txtOzelKod4":
                    {
                        var entity = (OzelKod)ShowListForms<OzelKodListForm>.ShowDialogListForm(KartTuru.OzelKod, _btnEdit.Id, OzelKodTuru.OzelKod4, _kartTuru);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.OzelKodAdi;
                        }
                    }
                    break;

                case "txtOzelKod5":
                    {
                        var entity = (OzelKod)ShowListForms<OzelKodListForm>.ShowDialogListForm(KartTuru.OzelKod, _btnEdit.Id, OzelKodTuru.OzelKod5, _kartTuru);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.OzelKodAdi;
                        }
                    }
                    break;

                case "txtBanka":
                    {
                        var entity = (BankaL)ShowListForms<BankaListForm>.ShowDialogListForm(KartTuru.Banka, _btnEdit.Id);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.BankaAdi;
                        }
                    }
                    break;

                case "txtBankaSube":
                    {
                        var entity = (BankaSube)ShowListForms<BankaSubeListForm>.ShowDialogListForm(KartTuru.BankaSube, _btnEdit.Id, _prmEdit.Id, _prmEdit.Text);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.SubeAdi;
                        }
                    }
                    break;

                case "txtMeslek":
                    {
                        var entity = (Meslek)ShowListForms<MeslekListForm>.ShowDialogListForm(KartTuru.Meslek, _btnEdit.Id);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.MeslekAdi;
                        }
                    }
                    break;

                case "txtIsYeriAdi":
                    {
                        var entity = (Isyeri)ShowListForms<IsyeriListForm>.ShowDialogListForm(KartTuru.Isyeri, _btnEdit.Id);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.IsyeriAdi;
                        }
                    }
                    break;

                case "txtGorev":
                    {
                        var entity = (Gorev)ShowListForms<GorevListForm>.ShowDialogListForm(KartTuru.Gorev, _btnEdit.Id);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.GorevAdi;
                        }
                    }
                    break;

                case "txtIndirimTuru":
                    {
                        var entity = (IndirimTuru)ShowListForms<IndirimTuruListForm>.ShowDialogListForm(KartTuru.IndirimTuru, _btnEdit.Id);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.IndirimTuruAdi;
                        }
                    }
                    break;

                case "txtSinif":
                    {
                        var entity = (SinifL)ShowListForms<SinifListForm>.ShowDialogListForm(KartTuru.Sinif, _btnEdit.Id);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.SinifAdi;
                        }
                    }
                    break;

                case "txtYabanciDil":
                    {
                        var entity = (YabanciDil)ShowListForms<YabanciDilListForm>.ShowDialogListForm(KartTuru.YabanciDil, _btnEdit.Id);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.DilAdi;
                        }
                    }
                    break;

                case "txtGeldigiOkul":
                    {
                        var entity = (OkulL)ShowListForms<OkulListForm>.ShowDialogListForm(KartTuru.Okul, _btnEdit.Id);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.OkulAdi;
                        }
                    }
                    break;

                case "txtKontenjan":
                    {
                        var entity = (Kontenjan)ShowListForms<KontenjanListForm>.ShowDialogListForm(KartTuru.Kontenjan, _btnEdit.Id);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.KontenjanAdi;
                        }
                    }
                    break;

                case "txtTesvik":
                    {
                        var entity = (Tesvik)ShowListForms<TesvikListForm>.ShowDialogListForm(KartTuru.Tesvik, _btnEdit.Id);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.TesvikAdi;
                        }
                    }
                    break;

                case "txtRehber":
                    {
                        var entity = (Rehber)ShowListForms<RehberListForm>.ShowDialogListForm(KartTuru.Rehber, _btnEdit.Id);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.AdiSoyadi;
                        }
                    }
                    break;

                case "txtBankaHesap":
                    {
                        var entity = (BankaHesapL)ShowListForms<BankaHesapListForm>.ShowDialogListForm(KartTuru.BankaHesap, _btnEdit.Id, _odemeTipi);
                        if (entity != null)
                        {
                            _btnEdit.Tag = entity.BlokeGunSayisi;
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.HesapAdi;
                        }
                    }
                    break;

                case "txtOdemeTuru":
                    {
                        var entity = (OdemeTuru)ShowListForms<OdemeTuruListForm>.ShowDialogListForm(KartTuru.OdemeTuru, _btnEdit.Id);
                        if (entity != null)
                        {
                            _btnEdit.Tag = entity.OdemeTipi;
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.OdemeTuruAdi;
                        }
                    }
                    break;
            }
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);

        }
    }
}
