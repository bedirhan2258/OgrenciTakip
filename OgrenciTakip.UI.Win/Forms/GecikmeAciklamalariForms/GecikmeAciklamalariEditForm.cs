
using OgrenciTakip.BLL.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.DTO;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.GeneralForms;
using System;

namespace OgrenciTakip.UI.Win.Forms.GecikmeAciklamalariForms
{
    public partial class GecikmeAciklamalariEditForm : BaseEditForm
    {
        #region Variables
        private readonly int _portfoyNo;
        #endregion

        public GecikmeAciklamalariEditForm(params object[] prm)
        {
            InitializeComponent();

            _portfoyNo = (int)prm[0];

            dataLayoutControl = myDataLayoutControl;
            bll = new GecikmeAciklamalariBll(myDataLayoutControl);
            kartTuru = KartTuru.Aciklama;
            EventsLoad();
        }

        protected internal override void Yukle()
        {
            oldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new GecikmeAciklamalariS() : ((GecikmeAciklamalariBll)bll).Single(FilterFunctions.Filter<GecikmeAciklamalari>(id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            id = BaseIslemTuru.IdOlustur(oldEntity);
            txtKod.Text = ((GecikmeAciklamalariBll)bll).YeniKodVer(x => x.OdemeBilgileriId == _portfoyNo);
            txtAciklama.Focus();
        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (GecikmeAciklamalariS)oldEntity;

            txtKod.Text = entity.Kod;
            txtKullaniciAdi.Text = BaseIslemTuru == IslemTuru.EntityInsert ? AnaForm.KullaniciAdi : entity.KullaniciAdi;
            txtTarihSaat.DateTime = BaseIslemTuru == IslemTuru.EntityInsert ? DateTime.Now : entity.TarihSaat;
            txtAciklama.Text = entity.Aciklama;
        }
        protected override void GuncelNesneOlustur()
        {
            currentEntity = new GecikmeAciklamalari
            {
                Id = id,
                Kod = txtKod.Text,
                OdemeBilgileriId = _portfoyNo,
                KullaniciId = BaseIslemTuru == IslemTuru.EntityInsert ? AnaForm.KullaniciId : 0,
                TarihSaat = txtTarihSaat.DateTime,
                Aciklama = txtAciklama.Text,

            };
            ButonEnabledDurumu();
        }
        protected override bool EntityInsert()
        {
            return ((GecikmeAciklamalariBll)bll).Insert(currentEntity, x => x.Kod == currentEntity.Kod && x.OdemeBilgileriId == _portfoyNo);
        }
        protected override bool EntityUpdate()
        {
            return ((GecikmeAciklamalariBll)bll).Update(oldEntity, currentEntity, x => x.Kod == currentEntity.Kod && x.OdemeBilgileriId == _portfoyNo);
        }
    }
}