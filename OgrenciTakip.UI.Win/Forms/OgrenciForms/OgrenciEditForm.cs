
using DevExpress.XtraEditors;
using OgrenciTakip.BLL.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Common.Functions;
using OgrenciTakip.Model.DTO;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.UserControls.Controls;
using System;

namespace OgrenciTakip.UI.Win.Forms.OgrenciForms
{
    public partial class OgrenciEditForm : BaseEditForm
    {
        public OgrenciEditForm()
        {
            InitializeComponent();

            dataLayoutControl = myDataLayoutControl;
            bll = new OgrenciBll(myDataLayoutControl);
            txtKanGrubu.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<KanGrubu>());
            txtCinsiyet.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<Cinsiyet>());
            kartTuru = KartTuru.Ogrenci;
            EventsLoad();
        }

        protected internal override void Yukle()
        {
            oldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new OgrenciS() : ((OgrenciBll)bll).Single(FilterFunctions.Filter<Ogrenci>(id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            id = BaseIslemTuru.IdOlustur(oldEntity);
            txtKod.Text = ((OgrenciBll)bll).YeniKodVer();
            txtTcKimlikNo.Focus();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (OgrenciS)oldEntity;
            txtKod.Text = entity.Kod;
            txtTcKimlikNo.Text = entity.TcKimlikNo;
            txtAdi.Text = entity.Adi;
            txtSoyadi.Text = entity.Soyadi;
            txtCinsiyet.SelectedItem = entity.Cinsiyet.ToName();
            txtTelefon.Text = entity.Telefon;
            txtKanGrubu.SelectedItem = entity.KanGrubu.ToName();
            txtBabaAdi.Text = entity.BabaAdi;
            txtAnaAdi.Text = entity.AnaAdi;
            txtDogumYeri.Text = entity.DogumYeri;
            txtDogumTarihi.EditValue = entity.DogumTarihi;
            txtKanGrubu.SelectedItem = entity.KanGrubu.ToName();
            txtKimlikSeri.Text = entity.KimlikSeri;
            txtKimlikSiraNo.Text = entity.KimlikSiraNo;
            txtKimlikIl.Id = entity.KimlikIlId;
            txtKimlikIl.Text = entity.KimlikIlAdi;
            txtKimlikIlce.Id = entity.KimlikIlceId;
            txtKimlikIlce.Text = entity.KimlikIlceAdi;
            txtKimlikMahalleKoy.Text = entity.KimlikMahalleKoy;
            txtKimlikCiltNo.Text = entity.KimlikCiltNo;
            txtKimlikAileSiraNo.Text = entity.KimlikAileSiraNo;
            txtKimlikBireySiraNo.Text = entity.KimlikAileSiraNo;
            txtKimlikVerildigiYer.Text = entity.KimlikVerildigiYer;
            txtKimlikVerilisNedeni.Text = entity.KimlikVerilisNedeni;
            txtKimlikKayitNo.Text = entity.KimlikKayitNo;
            txtKimlikVerilisTarihi.EditValue = entity.KimlikVerilisTarihi;
            imgResim.EditValue = entity.Resim;
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
            tglDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            currentEnttiy = new Ogrenci
            {
                Id = id,
                Kod = txtKod.Text,
                TcKimlikNo = txtTcKimlikNo.Text,
                Adi = txtAdi.Text,
                Soyadi = txtSoyadi.Text,
                Cinsiyet = txtCinsiyet.Text.GetEnum<Cinsiyet>(),
                Telefon = txtTelefon.Text,
                KanGrubu = txtKanGrubu.Text.GetEnum<KanGrubu>(),
                BabaAdi = txtBabaAdi.Text,
                AnaAdi = txtAnaAdi.Text,
                DogumYeri = txtDogumYeri.Text,
                DogumTarihi = (DateTime?)txtDogumTarihi.EditValue,
                KimlikSeri = txtKimlikSeri.Text,
                KimlikSiraNo = txtKimlikSiraNo.Text,
                KimlikIlId = txtKimlikIl.Id,
                KimlikIlceId = txtKimlikIlce.Id,
                KimlikMahalleKoy = txtKimlikMahalleKoy.Text,
                KimlikCiltNo = txtKimlikCiltNo.Text,
                KimlikAileSiraNo = txtKimlikAileSiraNo.Text,
                KimlikBireySiraNo = txtKimlikBireySiraNo.Text,
                KimlikVerildigiYer = txtKimlikVerildigiYer.Text,
                KimlikVerilisNedeni = txtKimlikVerilisNedeni.Text,
                KimlikKayitNo = txtKimlikKayitNo.Text,
                KimlikVerilisTarihi = (DateTime?)txtKimlikVerilisTarihi.EditValue,
                Resim = (byte[])imgResim.EditValue,
                OzelKod1Id = txtOzelKod1.Id,
                OzelKod2Id = txtOzelKod2.Id,
                OzelKod3Id = txtOzelKod3.Id,
                OzelKod4Id = txtOzelKod4.Id,
                OzelKod5Id = txtOzelKod5.Id,
                Durum = tglDurum.IsOn
            };

            ButonEnabledDurumu();
        }

        protected override void SecimYap(object sender)
        {
            if (!(sender is ButtonEdit)) return;

            using (var sec = new SelectFunctions())

                if (sender == txtKimlikIl)
                    sec.Sec(txtKimlikIl);
                else if (sender == txtKimlikIlce)
                    sec.Sec(txtKimlikIlce, txtKimlikIl);
                else if (sender == txtOzelKod1)
                    sec.Sec(txtOzelKod1, KartTuru.Ogrenci);
                else if (sender == txtOzelKod2)
                    sec.Sec(txtOzelKod2, KartTuru.Ogrenci);
                else if (sender == txtOzelKod3)
                    sec.Sec(txtOzelKod3, KartTuru.Ogrenci);
                else if (sender == txtOzelKod4)
                    sec.Sec(txtOzelKod4, KartTuru.Ogrenci);
                else if (sender == txtOzelKod5)
                    sec.Sec(txtOzelKod5, KartTuru.Ogrenci);
        }

        protected override void Control_EnabledChange(object sender, EventArgs e)
        {
            if (sender != txtKimlikIl) return;
            txtKimlikIl.ControlEnabledChange(txtKimlikIlce);
        }

        protected override void Control_Enter(object sender, EventArgs e)
        {
            if (!(sender is MyPictureEdit resim)) return;
            resim.Sec(resimMenu);
        }
    }
}