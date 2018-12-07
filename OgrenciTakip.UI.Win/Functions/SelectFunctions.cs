using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.HizmetForms;
using OgrenciTakip.UI.Win.Forms.HizmetTuruForms;
using OgrenciTakip.UI.Win.Forms.IlceForms;
using OgrenciTakip.UI.Win.Forms.IlForms;
using OgrenciTakip.UI.Win.Forms.SinifGrupForms;
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
        #endregion

        public void Sec(MyButtonEdit btnEdit)
        {
            _btnEdit = btnEdit;
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
                    {
                        var entity = (Il)ShowListForms<IlListForm>.ShowDialogListForm(_kartTuru, _btnEdit.Id);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.IlAdi;
                        }
                    }
                    break;

                case "txtIlce":
                    {
                        var entity = (Ilce)ShowListForms<IlceListForm>.ShowDialogListForm(_kartTuru, _btnEdit.Id, _prmEdit.Id, _prmEdit.Text);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.IlceAdi;
                        }
                    }
                    break;

                case "txtGrup":
                    {
                        var entity = (SinifGrup)ShowListForms<SinifGrupListForm>.ShowDialogListForm(_kartTuru, _btnEdit.Id);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.GrupAdi;
                        }
                    }
                    break;
                case "txtHizmetTuru":
                    {
                        var entity = (HizmetTuru)ShowListForms<HizmetTuruListForm>.ShowDialogListForm(_kartTuru, _btnEdit.Id);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.HizmetTuruAdi;
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
