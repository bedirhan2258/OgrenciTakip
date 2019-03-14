namespace OgrenciTakip.UI.Win.Reports.XtraReports.Tahakkuk
{
    partial class KullaniciTanimliRapor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Epos_Bilgileri = new DevExpress.DataAccess.ObjectBinding.ObjectDataSource(this.components);
            this.GeriOdeme_Bilgileri = new DevExpress.DataAccess.ObjectBinding.ObjectDataSource(this.components);
            this.Hizmet_Bilgileri = new DevExpress.DataAccess.ObjectBinding.ObjectDataSource(this.components);
            this.Iletisim_Bilgileri = new DevExpress.DataAccess.ObjectBinding.ObjectDataSource(this.components);
            this.Indirim_Bilgileri = new DevExpress.DataAccess.ObjectBinding.ObjectDataSource(this.components);
            this.Odeme_Bilgileri = new DevExpress.DataAccess.ObjectBinding.ObjectDataSource(this.components);
            this.Ogrenci_Bilgileri = new DevExpress.DataAccess.ObjectBinding.ObjectDataSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Epos_Bilgileri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GeriOdeme_Bilgileri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hizmet_Bilgileri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Iletisim_Bilgileri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Indirim_Bilgileri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Odeme_Bilgileri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ogrenci_Bilgileri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // TopMargin
            // 
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // Epos_Bilgileri
            // 
            this.Epos_Bilgileri.DataSource = typeof(OgrenciTakip.Model.DTO.EposBilgileriR);
            this.Epos_Bilgileri.Name = "Epos_Bilgileri";
            // 
            // GeriOdeme_Bilgileri
            // 
            this.GeriOdeme_Bilgileri.DataSource = typeof(OgrenciTakip.Model.DTO.GeriOdemeBilgileriR);
            this.GeriOdeme_Bilgileri.Name = "GeriOdeme_Bilgileri";
            // 
            // Hizmet_Bilgileri
            // 
            this.Hizmet_Bilgileri.DataSource = typeof(OgrenciTakip.Model.DTO.HizmetBilgileriR);
            this.Hizmet_Bilgileri.Name = "Hizmet_Bilgileri";
            // 
            // Iletisim_Bilgileri
            // 
            this.Iletisim_Bilgileri.DataSource = typeof(OgrenciTakip.Model.DTO.IletisimBilgileriR);
            this.Iletisim_Bilgileri.Name = "Iletisim_Bilgileri";
            // 
            // Indirim_Bilgileri
            // 
            this.Indirim_Bilgileri.DataSource = typeof(OgrenciTakip.Model.DTO.IndirimBilgileriR);
            this.Indirim_Bilgileri.Name = "Indirim_Bilgileri";
            // 
            // Odeme_Bilgileri
            // 
            this.Odeme_Bilgileri.DataSource = typeof(OgrenciTakip.Model.DTO.OdemeBilgileriR);
            this.Odeme_Bilgileri.Name = "Odeme_Bilgileri";
            // 
            // Ogrenci_Bilgileri
            // 
            this.Ogrenci_Bilgileri.DataSource = typeof(OgrenciTakip.Model.DTO.OgrenciR);
            this.Ogrenci_Bilgileri.Name = "Ogrenci_Bilgileri";
            // 
            // KullaniciTanimliRapor
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin});
            this.Baslik = "Kullanıcı Tanımlı Rapor";
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.Epos_Bilgileri,
            this.GeriOdeme_Bilgileri,
            this.Hizmet_Bilgileri,
            this.Iletisim_Bilgileri,
            this.Indirim_Bilgileri,
            this.Odeme_Bilgileri,
            this.Ogrenci_Bilgileri});
            this.DataSource = this.Ogrenci_Bilgileri;
            this.Name = "KullaniciTanimliRapor";
            this.Version = "18.1";
            ((System.ComponentModel.ISupportInitialize)(this.Epos_Bilgileri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GeriOdeme_Bilgileri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hizmet_Bilgileri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Iletisim_Bilgileri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Indirim_Bilgileri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Odeme_Bilgileri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ogrenci_Bilgileri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        protected internal DevExpress.DataAccess.ObjectBinding.ObjectDataSource Epos_Bilgileri;
        protected internal DevExpress.DataAccess.ObjectBinding.ObjectDataSource GeriOdeme_Bilgileri;
        protected internal DevExpress.DataAccess.ObjectBinding.ObjectDataSource Hizmet_Bilgileri;
        protected internal DevExpress.DataAccess.ObjectBinding.ObjectDataSource Iletisim_Bilgileri;
        protected internal DevExpress.DataAccess.ObjectBinding.ObjectDataSource Indirim_Bilgileri;
        protected internal DevExpress.DataAccess.ObjectBinding.ObjectDataSource Odeme_Bilgileri;
        protected internal DevExpress.DataAccess.ObjectBinding.ObjectDataSource Ogrenci_Bilgileri;
    }
}
