
using DevExpress.XtraBars;
using OgrenciTakip.BLL.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.GeneralForms;
using OgrenciTakip.UI.Win.Show;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.Model.DTO;

namespace OgrenciTakip.UI.Win.Forms.MakbuzForms
{
    public partial class MakbuzListForm : BaseListForm
    {
        public MakbuzListForm()
        {
            InitializeComponent();
            bll = new MakbuzBll();
            ShowItems = new BarItem[] { btnYeniMakbuz };
            HideItems = new BarItem[] { btnYeni, btnSil, barDelete, barDeleteAciklama, btnAktifPasifKartlar };
            barInsertAciklama.Caption = "Yeni Makbuz";
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            kartTuru = KartTuru.Makbuz;
            formShow = new ShowEditForms<MakbuzEditForm>();
            navigator = longNavigator.Navigator;
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((MakbuzBll)bll).List(x => x.DonemId == AnaForm.DonemId && x.SubeId == AnaForm.SubeId);
        }

        protected override void Button_ItemClick(object sender, ItemClickEventArgs e)
        {
            long id = 0;
            base.Button_ItemClick(sender, e);

            if (e.Item == btnYeniMakbuz)
            {
                var link = (BarSubItemLink)e.Item.Links[0];
                link.Focus();
                link.OpenMenu();
                link.Item.ItemLinks[0].Focus();
            }

            else if (e.Item == btnAvukataGonderme)
            {
                id = ShowEditForms<MakbuzEditForm>.ShowDialogEditForms(KartTuru.Makbuz, -1, MakbuzTuru.AvukataGonderme, MakbuzHesapTuru.Avukat);
            }

            else if (e.Item == btnAvukatYoluylaTahsilEtme)
            {
                id = ShowEditForms<MakbuzEditForm>.ShowDialogEditForms(KartTuru.Makbuz, -1, MakbuzTuru.AvukatYoluylaTahsilEtme, MakbuzHesapTuru.Avukat);
            }

            else if (e.Item == btnTahsilEtmeBanka)
            {
                id = ShowEditForms<MakbuzEditForm>.ShowDialogEditForms(KartTuru.Makbuz, -1, MakbuzTuru.TahsilEtmeBanka, MakbuzHesapTuru.Banka);
            }

            else if (e.Item == btnBlokeyeAlma)
            {
                id = ShowEditForms<MakbuzEditForm>.ShowDialogEditForms(KartTuru.Makbuz, -1, MakbuzTuru.BlokeyeAlma, MakbuzHesapTuru.Pos);
            }

            else if (e.Item == btnBlokeCozumu)
            {
                id = ShowEditForms<MakbuzEditForm>.ShowDialogEditForms(KartTuru.Makbuz, -1, MakbuzTuru.BlokeCozumu, MakbuzHesapTuru.Pos);
            }

            else if (e.Item == btnBankayaTahsileGonderme)
            {
                id = ShowEditForms<MakbuzEditForm>.ShowDialogEditForms(KartTuru.Makbuz, -1, MakbuzTuru.BankayaTahsileGonderme, MakbuzHesapTuru.Banka);
            }

            else if (e.Item == btnBankaYoluylaTahsilEtme)
            {
                id = ShowEditForms<MakbuzEditForm>.ShowDialogEditForms(KartTuru.Makbuz, -1, MakbuzTuru.BankaYoluylaTahsilEtme, MakbuzHesapTuru.Banka);
            }

            else if (e.Item == btnCiroEtme)
            {
                id = ShowEditForms<MakbuzEditForm>.ShowDialogEditForms(KartTuru.Makbuz, -1, MakbuzTuru.CiroEtme, MakbuzHesapTuru.Cari);
            }

            else if (e.Item == btnMahsupEtme)
            {
                id = ShowEditForms<MakbuzEditForm>.ShowDialogEditForms(KartTuru.Makbuz, -1, MakbuzTuru.MapsupEtme, MakbuzHesapTuru.Mahsup);
            }

            else if (e.Item == btnOdenmisOlarakIsaretleme)
            {
                id = ShowEditForms<MakbuzEditForm>.ShowDialogEditForms(KartTuru.Makbuz, -1, MakbuzTuru.OdenmisOlarakIsaretleme, MakbuzHesapTuru.Cari);
            }

            else if (e.Item == btnMusteriyeGeriIade)
            {
                id = ShowEditForms<MakbuzEditForm>.ShowDialogEditForms(KartTuru.Makbuz, -1, MakbuzTuru.MusteriyeGeriIade, MakbuzHesapTuru.Iade);
            }

            else if (e.Item == btnPortfoyeGeriIade)
            {
                id = ShowEditForms<MakbuzEditForm>.ShowDialogEditForms(KartTuru.Makbuz, -1, MakbuzTuru.PorfoyeGeriIade, MakbuzHesapTuru.Banka);
            }

            else if (e.Item == btnPortfoyeKarsiliksizIade)
            {
                id = ShowEditForms<MakbuzEditForm>.ShowDialogEditForms(KartTuru.Makbuz, -1, MakbuzTuru.PorfoyeKarsiliksizIade, MakbuzHesapTuru.Banka);
            }

            else if (e.Item == btnBaskaSubeyeGonderme)
            {
                id = ShowEditForms<MakbuzEditForm>.ShowDialogEditForms(KartTuru.Makbuz, -1, MakbuzTuru.BaskaSubeyeGonderme, MakbuzHesapTuru.Transfer);
            }

            else if (e.Item == btnGelenBelgeyiOnaylama)
            {
                id = ShowEditForms<MakbuzEditForm>.ShowDialogEditForms(KartTuru.Makbuz, -1, MakbuzTuru.GelenBelgeyiOnaylama, MakbuzHesapTuru.Transfer);
            }

            else if (e.Item == btnTahsilEtmeKasa)
            {
                id = ShowEditForms<MakbuzEditForm>.ShowDialogEditForms(KartTuru.Makbuz, -1, MakbuzTuru.TahsilEtmeKasa, MakbuzHesapTuru.Kasa);
            }

            else if (e.Item == btnKarsiliksizOlarakIsaretleme)
            {
                id = ShowEditForms<MakbuzEditForm>.ShowDialogEditForms(KartTuru.Makbuz, -1, MakbuzTuru.KarsiliksizOlarakIsaretleme, MakbuzHesapTuru.Supheli);
            }

            else if (e.Item == btnTahsiliImkansizHaleGelme)
            {
                id = ShowEditForms<MakbuzEditForm>.ShowDialogEditForms(KartTuru.Makbuz, -1, MakbuzTuru.TahsiliImkansızHaleGelme, MakbuzHesapTuru.Supheli);
            }

            if (id > 0)
                ShowEditFormDefault(id);

            tablo.Focus();

        }

        protected override void ShowEditForm(long id)
        {
            var entity = tablo.GetRow<MakbuzL>();
            if (entity == null) return;
            var result = ShowEditForms<MakbuzEditForm>.ShowDialogEditForms(KartTuru.Makbuz, id, entity.MakbuzTuru, entity.HesapTuru);
            ShowEditFormDefault(result);
        }
    }
}