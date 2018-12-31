namespace OgrenciTakip.UI.Win.Forms.TahakkukForms
{
    partial class TahakkukListForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TahakkukListForm));
            this.longNavigator = new OgrenciTakip.UI.Win.UserControls.Navigators.LongNavigator();
            this.grid = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridControl();
            this.tablo = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridView();
            this.colTcKimlikNo = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colAdi = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colSoyadi = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colBabaAdi = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colAnaAdi = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colOgrenciNo = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colOkulNo = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colKayitTarihi = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colKayitSekli = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colKayitDurumu = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colSinifAdi = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colYabanciDilAdi = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colGeldigiOkulAdi = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colKontenjanAdi = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colTesvikAdi = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colRehberAdi = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colSubeAdi = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colSonrakiDonemKayitDurumu = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colSonrakiDonemKayitDurumuAciklama = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colOzelKod1Adi = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colOzelKod2Adi = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colOzelKod3Adi = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colOzelKod4Adi = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colOzelKod5Adi = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colId = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bndSecim = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand3 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand4 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // btnGonder
            // 
            this.btnGonder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGonder.ImageOptions.Image")));
            this.btnGonder.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGonder.ImageOptions.LargeImage")));
            // 
            // longNavigator
            // 
            this.longNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.longNavigator.Location = new System.Drawing.Point(0, 357);
            this.longNavigator.Name = "longNavigator";
            this.longNavigator.Size = new System.Drawing.Size(1170, 24);
            this.longNavigator.TabIndex = 2;
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 102);
            this.grid.MainView = this.tablo;
            this.grid.MenuManager = this.ribbonControl;
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(1170, 255);
            this.grid.TabIndex = 3;
            this.grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tablo});
            // 
            // tablo
            // 
            this.tablo.Appearance.BandPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.tablo.Appearance.BandPanel.ForeColor = System.Drawing.Color.DarkBlue;
            this.tablo.Appearance.BandPanel.Options.UseFont = true;
            this.tablo.Appearance.BandPanel.Options.UseForeColor = true;
            this.tablo.Appearance.BandPanel.Options.UseTextOptions = true;
            this.tablo.Appearance.BandPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.tablo.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.tablo.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Maroon;
            this.tablo.Appearance.FooterPanel.Options.UseFont = true;
            this.tablo.Appearance.FooterPanel.Options.UseForeColor = true;
            this.tablo.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.tablo.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.tablo.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.tablo.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.tablo.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon;
            this.tablo.Appearance.ViewCaption.Options.UseForeColor = true;
            this.tablo.BandPanelRowHeight = 40;
            this.tablo.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.bndSecim,
            this.gridBand1,
            this.gridBand2,
            this.gridBand3,
            this.gridBand4});
            this.tablo.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colId,
            this.colOgrenciNo,
            this.colOkulNo,
            this.colTcKimlikNo,
            this.colAdi,
            this.colSoyadi,
            this.colBabaAdi,
            this.colAnaAdi,
            this.colKayitTarihi,
            this.colKayitSekli,
            this.colKayitDurumu,
            this.colSinifAdi,
            this.colGeldigiOkulAdi,
            this.colKontenjanAdi,
            this.colYabanciDilAdi,
            this.colRehberAdi,
            this.colTesvikAdi,
            this.colSonrakiDonemKayitDurumu,
            this.colSonrakiDonemKayitDurumuAciklama,
            this.colOzelKod1Adi,
            this.colOzelKod2Adi,
            this.colOzelKod3Adi,
            this.colOzelKod4Adi,
            this.colOzelKod5Adi,
            this.colSubeAdi});
            this.tablo.GridControl = this.grid;
            this.tablo.Name = "tablo";
            this.tablo.OptionsMenu.EnableColumnMenu = false;
            this.tablo.OptionsMenu.EnableFooterMenu = false;
            this.tablo.OptionsMenu.EnableGroupPanelMenu = false;
            this.tablo.OptionsNavigation.EnterMoveNextColumn = true;
            this.tablo.OptionsPrint.AutoWidth = false;
            this.tablo.OptionsPrint.PrintFooter = false;
            this.tablo.OptionsPrint.PrintGroupFooter = false;
            this.tablo.OptionsView.ColumnAutoWidth = false;
            this.tablo.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.tablo.OptionsView.RowAutoHeight = true;
            this.tablo.OptionsView.ShowAutoFilterRow = true;
            this.tablo.OptionsView.ShowGroupPanel = false;
            this.tablo.OptionsView.ShowViewCaption = true;
            this.tablo.StatusBarAciklama = null;
            this.tablo.StatusBarKisayol = null;
            this.tablo.StatusBarKisayolAciklama = null;
            this.tablo.ViewCaption = "Tahakkuk Kartları";
            // 
            // colTcKimlikNo
            // 
            this.colTcKimlikNo.AppearanceCell.Options.UseTextOptions = true;
            this.colTcKimlikNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTcKimlikNo.Caption = "Tc Kimlik No";
            this.colTcKimlikNo.FieldName = "TcKimlikNo";
            this.colTcKimlikNo.Name = "colTcKimlikNo";
            this.colTcKimlikNo.OptionsColumn.AllowEdit = false;
            this.colTcKimlikNo.StatusBarAciklama = null;
            this.colTcKimlikNo.StatusBarKisayol = null;
            this.colTcKimlikNo.StatusBarKisayolAciklama = null;
            this.colTcKimlikNo.Visible = true;
            this.colTcKimlikNo.Width = 100;
            // 
            // colAdi
            // 
            this.colAdi.Caption = "Adı";
            this.colAdi.FieldName = "Adi";
            this.colAdi.Name = "colAdi";
            this.colAdi.OptionsColumn.AllowEdit = false;
            this.colAdi.StatusBarAciklama = null;
            this.colAdi.StatusBarKisayol = null;
            this.colAdi.StatusBarKisayolAciklama = null;
            this.colAdi.Visible = true;
            this.colAdi.Width = 100;
            // 
            // colSoyadi
            // 
            this.colSoyadi.Caption = "Soyadı";
            this.colSoyadi.FieldName = "Soyadi";
            this.colSoyadi.Name = "colSoyadi";
            this.colSoyadi.OptionsColumn.AllowEdit = false;
            this.colSoyadi.StatusBarAciklama = null;
            this.colSoyadi.StatusBarKisayol = null;
            this.colSoyadi.StatusBarKisayolAciklama = null;
            this.colSoyadi.Visible = true;
            this.colSoyadi.Width = 100;
            // 
            // colBabaAdi
            // 
            this.colBabaAdi.Caption = "Baba Adı";
            this.colBabaAdi.FieldName = "BabaAdi";
            this.colBabaAdi.Name = "colBabaAdi";
            this.colBabaAdi.OptionsColumn.AllowEdit = false;
            this.colBabaAdi.StatusBarAciklama = null;
            this.colBabaAdi.StatusBarKisayol = null;
            this.colBabaAdi.StatusBarKisayolAciklama = null;
            this.colBabaAdi.Visible = true;
            this.colBabaAdi.Width = 100;
            // 
            // colAnaAdi
            // 
            this.colAnaAdi.Caption = "Ana Adı";
            this.colAnaAdi.FieldName = "AnaAdi";
            this.colAnaAdi.Name = "colAnaAdi";
            this.colAnaAdi.OptionsColumn.AllowEdit = false;
            this.colAnaAdi.StatusBarAciklama = null;
            this.colAnaAdi.StatusBarKisayol = null;
            this.colAnaAdi.StatusBarKisayolAciklama = null;
            this.colAnaAdi.Visible = true;
            this.colAnaAdi.Width = 100;
            // 
            // colOgrenciNo
            // 
            this.colOgrenciNo.AppearanceCell.Options.UseTextOptions = true;
            this.colOgrenciNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colOgrenciNo.Caption = "Öğrenci No";
            this.colOgrenciNo.FieldName = "Kod";
            this.colOgrenciNo.Name = "colOgrenciNo";
            this.colOgrenciNo.OptionsColumn.AllowEdit = false;
            this.colOgrenciNo.Visible = true;
            this.colOgrenciNo.Width = 85;
            // 
            // colOkulNo
            // 
            this.colOkulNo.Caption = "Okul No";
            this.colOkulNo.FieldName = "OkulNo";
            this.colOkulNo.Name = "colOkulNo";
            this.colOkulNo.OptionsColumn.AllowEdit = false;
            this.colOkulNo.StatusBarAciklama = null;
            this.colOkulNo.StatusBarKisayol = null;
            this.colOkulNo.StatusBarKisayolAciklama = null;
            this.colOkulNo.Visible = true;
            this.colOkulNo.Width = 85;
            // 
            // colKayitTarihi
            // 
            this.colKayitTarihi.AppearanceCell.Options.UseTextOptions = true;
            this.colKayitTarihi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKayitTarihi.Caption = "Kayıt Tarihi";
            this.colKayitTarihi.FieldName = "KayitTarihi";
            this.colKayitTarihi.Name = "colKayitTarihi";
            this.colKayitTarihi.OptionsColumn.AllowEdit = false;
            this.colKayitTarihi.StatusBarAciklama = null;
            this.colKayitTarihi.StatusBarKisayol = null;
            this.colKayitTarihi.StatusBarKisayolAciklama = null;
            this.colKayitTarihi.Visible = true;
            this.colKayitTarihi.Width = 90;
            // 
            // colKayitSekli
            // 
            this.colKayitSekli.Caption = "Kayıt Şekli";
            this.colKayitSekli.FieldName = "KayitSekli";
            this.colKayitSekli.Name = "colKayitSekli";
            this.colKayitSekli.OptionsColumn.AllowEdit = false;
            this.colKayitSekli.StatusBarAciklama = null;
            this.colKayitSekli.StatusBarKisayol = null;
            this.colKayitSekli.StatusBarKisayolAciklama = null;
            this.colKayitSekli.Visible = true;
            this.colKayitSekli.Width = 110;
            // 
            // colKayitDurumu
            // 
            this.colKayitDurumu.Caption = "Kayıt Durumu";
            this.colKayitDurumu.FieldName = "KayitDurumu";
            this.colKayitDurumu.Name = "colKayitDurumu";
            this.colKayitDurumu.OptionsColumn.AllowEdit = false;
            this.colKayitDurumu.StatusBarAciklama = null;
            this.colKayitDurumu.StatusBarKisayol = null;
            this.colKayitDurumu.StatusBarKisayolAciklama = null;
            this.colKayitDurumu.Visible = true;
            this.colKayitDurumu.Width = 110;
            // 
            // colSinifAdi
            // 
            this.colSinifAdi.Caption = "Sınıf";
            this.colSinifAdi.FieldName = "SinifAdi";
            this.colSinifAdi.Name = "colSinifAdi";
            this.colSinifAdi.OptionsColumn.AllowEdit = false;
            this.colSinifAdi.StatusBarAciklama = null;
            this.colSinifAdi.StatusBarKisayol = null;
            this.colSinifAdi.StatusBarKisayolAciklama = null;
            this.colSinifAdi.Visible = true;
            this.colSinifAdi.Width = 100;
            // 
            // colYabanciDilAdi
            // 
            this.colYabanciDilAdi.Caption = "Yabancı Dil";
            this.colYabanciDilAdi.FieldName = "YabanciDilAdi";
            this.colYabanciDilAdi.Name = "colYabanciDilAdi";
            this.colYabanciDilAdi.OptionsColumn.AllowEdit = false;
            this.colYabanciDilAdi.StatusBarAciklama = null;
            this.colYabanciDilAdi.StatusBarKisayol = null;
            this.colYabanciDilAdi.StatusBarKisayolAciklama = null;
            this.colYabanciDilAdi.Visible = true;
            this.colYabanciDilAdi.Width = 100;
            // 
            // colGeldigiOkulAdi
            // 
            this.colGeldigiOkulAdi.Caption = "Geldiği Okul";
            this.colGeldigiOkulAdi.FieldName = "GeldigiOkulAdi";
            this.colGeldigiOkulAdi.Name = "colGeldigiOkulAdi";
            this.colGeldigiOkulAdi.OptionsColumn.AllowEdit = false;
            this.colGeldigiOkulAdi.StatusBarAciklama = null;
            this.colGeldigiOkulAdi.StatusBarKisayol = null;
            this.colGeldigiOkulAdi.StatusBarKisayolAciklama = null;
            this.colGeldigiOkulAdi.Visible = true;
            this.colGeldigiOkulAdi.Width = 120;
            // 
            // colKontenjanAdi
            // 
            this.colKontenjanAdi.Caption = "Kontenjan Türü";
            this.colKontenjanAdi.FieldName = "KontenjanAdi";
            this.colKontenjanAdi.Name = "colKontenjanAdi";
            this.colKontenjanAdi.OptionsColumn.AllowEdit = false;
            this.colKontenjanAdi.StatusBarAciklama = null;
            this.colKontenjanAdi.StatusBarKisayol = null;
            this.colKontenjanAdi.StatusBarKisayolAciklama = null;
            this.colKontenjanAdi.Visible = true;
            this.colKontenjanAdi.Width = 120;
            // 
            // colTesvikAdi
            // 
            this.colTesvikAdi.Caption = "Teşvik Türü";
            this.colTesvikAdi.FieldName = "TesvikAdi";
            this.colTesvikAdi.Name = "colTesvikAdi";
            this.colTesvikAdi.OptionsColumn.AllowEdit = false;
            this.colTesvikAdi.StatusBarAciklama = null;
            this.colTesvikAdi.StatusBarKisayol = null;
            this.colTesvikAdi.StatusBarKisayolAciklama = null;
            this.colTesvikAdi.Visible = true;
            this.colTesvikAdi.Width = 120;
            // 
            // colRehberAdi
            // 
            this.colRehberAdi.Caption = "Rehber";
            this.colRehberAdi.FieldName = "RehberAdi";
            this.colRehberAdi.Name = "colRehberAdi";
            this.colRehberAdi.OptionsColumn.AllowEdit = false;
            this.colRehberAdi.StatusBarAciklama = null;
            this.colRehberAdi.StatusBarKisayol = null;
            this.colRehberAdi.StatusBarKisayolAciklama = null;
            this.colRehberAdi.Visible = true;
            this.colRehberAdi.Width = 100;
            // 
            // colSubeAdi
            // 
            this.colSubeAdi.Caption = "Şube Adı";
            this.colSubeAdi.FieldName = "SubeAdi";
            this.colSubeAdi.Name = "colSubeAdi";
            this.colSubeAdi.OptionsColumn.AllowEdit = false;
            this.colSubeAdi.StatusBarAciklama = null;
            this.colSubeAdi.StatusBarKisayol = null;
            this.colSubeAdi.StatusBarKisayolAciklama = null;
            this.colSubeAdi.Visible = true;
            this.colSubeAdi.Width = 150;
            // 
            // colSonrakiDonemKayitDurumu
            // 
            this.colSonrakiDonemKayitDurumu.Caption = "Kayıt Durumu";
            this.colSonrakiDonemKayitDurumu.CustomizationCaption = "Sonraki Dönem Kayıt Durumu";
            this.colSonrakiDonemKayitDurumu.FieldName = "SonrakiDonemKayitDurumu";
            this.colSonrakiDonemKayitDurumu.Name = "colSonrakiDonemKayitDurumu";
            this.colSonrakiDonemKayitDurumu.OptionsColumn.AllowEdit = false;
            this.colSonrakiDonemKayitDurumu.StatusBarAciklama = null;
            this.colSonrakiDonemKayitDurumu.StatusBarKisayol = null;
            this.colSonrakiDonemKayitDurumu.StatusBarKisayolAciklama = null;
            this.colSonrakiDonemKayitDurumu.Visible = true;
            this.colSonrakiDonemKayitDurumu.Width = 150;
            // 
            // colSonrakiDonemKayitDurumuAciklama
            // 
            this.colSonrakiDonemKayitDurumuAciklama.Caption = "Açıklama";
            this.colSonrakiDonemKayitDurumuAciklama.CustomizationCaption = "Sonraki Dönem Kayıt Durumu Açıklama";
            this.colSonrakiDonemKayitDurumuAciklama.FieldName = "SonrakiDonemKayitDurumuAciklama";
            this.colSonrakiDonemKayitDurumuAciklama.Name = "colSonrakiDonemKayitDurumuAciklama";
            this.colSonrakiDonemKayitDurumuAciklama.OptionsColumn.AllowEdit = false;
            this.colSonrakiDonemKayitDurumuAciklama.StatusBarAciklama = null;
            this.colSonrakiDonemKayitDurumuAciklama.StatusBarKisayol = null;
            this.colSonrakiDonemKayitDurumuAciklama.StatusBarKisayolAciklama = null;
            this.colSonrakiDonemKayitDurumuAciklama.Visible = true;
            this.colSonrakiDonemKayitDurumuAciklama.Width = 250;
            // 
            // colOzelKod1Adi
            // 
            this.colOzelKod1Adi.Caption = "Özel Kod-1";
            this.colOzelKod1Adi.FieldName = "OzelKod1Adi";
            this.colOzelKod1Adi.Name = "colOzelKod1Adi";
            this.colOzelKod1Adi.OptionsColumn.AllowEdit = false;
            this.colOzelKod1Adi.StatusBarAciklama = null;
            this.colOzelKod1Adi.StatusBarKisayol = null;
            this.colOzelKod1Adi.StatusBarKisayolAciklama = null;
            this.colOzelKod1Adi.Visible = true;
            this.colOzelKod1Adi.Width = 120;
            // 
            // colOzelKod2Adi
            // 
            this.colOzelKod2Adi.Caption = "Özel Kod-2";
            this.colOzelKod2Adi.FieldName = "OzelKod2Adi";
            this.colOzelKod2Adi.Name = "colOzelKod2Adi";
            this.colOzelKod2Adi.OptionsColumn.AllowEdit = false;
            this.colOzelKod2Adi.StatusBarAciklama = null;
            this.colOzelKod2Adi.StatusBarKisayol = null;
            this.colOzelKod2Adi.StatusBarKisayolAciklama = null;
            this.colOzelKod2Adi.Visible = true;
            this.colOzelKod2Adi.Width = 120;
            // 
            // colOzelKod3Adi
            // 
            this.colOzelKod3Adi.Caption = "Özel Kod-3";
            this.colOzelKod3Adi.FieldName = "OzelKod3Adi";
            this.colOzelKod3Adi.Name = "colOzelKod3Adi";
            this.colOzelKod3Adi.OptionsColumn.AllowEdit = false;
            this.colOzelKod3Adi.StatusBarAciklama = null;
            this.colOzelKod3Adi.StatusBarKisayol = null;
            this.colOzelKod3Adi.StatusBarKisayolAciklama = null;
            this.colOzelKod3Adi.Visible = true;
            this.colOzelKod3Adi.Width = 120;
            // 
            // colOzelKod4Adi
            // 
            this.colOzelKod4Adi.Caption = "Özel Kod-4";
            this.colOzelKod4Adi.FieldName = "OzelKod4Adi";
            this.colOzelKod4Adi.Name = "colOzelKod4Adi";
            this.colOzelKod4Adi.OptionsColumn.AllowEdit = false;
            this.colOzelKod4Adi.StatusBarAciklama = null;
            this.colOzelKod4Adi.StatusBarKisayol = null;
            this.colOzelKod4Adi.StatusBarKisayolAciklama = null;
            this.colOzelKod4Adi.Visible = true;
            this.colOzelKod4Adi.Width = 120;
            // 
            // colOzelKod5Adi
            // 
            this.colOzelKod5Adi.Caption = "Özel Kod-5";
            this.colOzelKod5Adi.FieldName = "OzelKod5Adi";
            this.colOzelKod5Adi.Name = "colOzelKod5Adi";
            this.colOzelKod5Adi.OptionsColumn.AllowEdit = false;
            this.colOzelKod5Adi.StatusBarAciklama = null;
            this.colOzelKod5Adi.StatusBarKisayol = null;
            this.colOzelKod5Adi.StatusBarKisayolAciklama = null;
            this.colOzelKod5Adi.Visible = true;
            this.colOzelKod5Adi.Width = 120;
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // bndSecim
            // 
            this.bndSecim.Caption = "Seç";
            this.bndSecim.Name = "bndSecim";
            this.bndSecim.Visible = false;
            this.bndSecim.VisibleIndex = -1;
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "Öğrenci Bilgileri";
            this.gridBand1.Columns.Add(this.colTcKimlikNo);
            this.gridBand1.Columns.Add(this.colAdi);
            this.gridBand1.Columns.Add(this.colSoyadi);
            this.gridBand1.Columns.Add(this.colBabaAdi);
            this.gridBand1.Columns.Add(this.colAnaAdi);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 500;
            // 
            // gridBand2
            // 
            this.gridBand2.Caption = "Tahakkuk Bilgileri";
            this.gridBand2.Columns.Add(this.colOgrenciNo);
            this.gridBand2.Columns.Add(this.colOkulNo);
            this.gridBand2.Columns.Add(this.colKayitTarihi);
            this.gridBand2.Columns.Add(this.colKayitSekli);
            this.gridBand2.Columns.Add(this.colKayitDurumu);
            this.gridBand2.Columns.Add(this.colSinifAdi);
            this.gridBand2.Columns.Add(this.colYabanciDilAdi);
            this.gridBand2.Columns.Add(this.colGeldigiOkulAdi);
            this.gridBand2.Columns.Add(this.colKontenjanAdi);
            this.gridBand2.Columns.Add(this.colTesvikAdi);
            this.gridBand2.Columns.Add(this.colRehberAdi);
            this.gridBand2.Columns.Add(this.colSubeAdi);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 1;
            this.gridBand2.Width = 1290;
            // 
            // gridBand3
            // 
            this.gridBand3.Caption = "Sonraki Dönem";
            this.gridBand3.Columns.Add(this.colSonrakiDonemKayitDurumu);
            this.gridBand3.Columns.Add(this.colSonrakiDonemKayitDurumuAciklama);
            this.gridBand3.Name = "gridBand3";
            this.gridBand3.VisibleIndex = 2;
            this.gridBand3.Width = 400;
            // 
            // gridBand4
            // 
            this.gridBand4.Caption = "Özel Kod";
            this.gridBand4.Columns.Add(this.colOzelKod1Adi);
            this.gridBand4.Columns.Add(this.colOzelKod2Adi);
            this.gridBand4.Columns.Add(this.colOzelKod3Adi);
            this.gridBand4.Columns.Add(this.colOzelKod4Adi);
            this.gridBand4.Columns.Add(this.colOzelKod5Adi);
            this.gridBand4.Name = "gridBand4";
            this.gridBand4.VisibleIndex = 3;
            this.gridBand4.Width = 600;
            // 
            // TahakkukListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 412);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.longNavigator);
            this.Name = "TahakkukListForm";
            this.Text = "Tahakkuk Kartları";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.longNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Navigators.LongNavigator longNavigator;
        private UserControls.Grid.MyBandedGridControl grid;
        private UserControls.Grid.MyBandedGridView tablo;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colId;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colOgrenciNo;
        private UserControls.Grid.MyBandedGridColumn colTcKimlikNo;
        private UserControls.Grid.MyBandedGridColumn colAdi;
        private UserControls.Grid.MyBandedGridColumn colSoyadi;
        private UserControls.Grid.MyBandedGridColumn colBabaAdi;
        private UserControls.Grid.MyBandedGridColumn colAnaAdi;
        private UserControls.Grid.MyBandedGridColumn colOkulNo;
        private UserControls.Grid.MyBandedGridColumn colKayitTarihi;
        private UserControls.Grid.MyBandedGridColumn colKayitSekli;
        private UserControls.Grid.MyBandedGridColumn colKayitDurumu;
        private UserControls.Grid.MyBandedGridColumn colSinifAdi;
        private UserControls.Grid.MyBandedGridColumn colYabanciDilAdi;
        private UserControls.Grid.MyBandedGridColumn colGeldigiOkulAdi;
        private UserControls.Grid.MyBandedGridColumn colKontenjanAdi;
        private UserControls.Grid.MyBandedGridColumn colTesvikAdi;
        private UserControls.Grid.MyBandedGridColumn colRehberAdi;
        private UserControls.Grid.MyBandedGridColumn colSubeAdi;
        private UserControls.Grid.MyBandedGridColumn colSonrakiDonemKayitDurumu;
        private UserControls.Grid.MyBandedGridColumn colSonrakiDonemKayitDurumuAciklama;
        private UserControls.Grid.MyBandedGridColumn colOzelKod1Adi;
        private UserControls.Grid.MyBandedGridColumn colOzelKod2Adi;
        private UserControls.Grid.MyBandedGridColumn colOzelKod3Adi;
        private UserControls.Grid.MyBandedGridColumn colOzelKod4Adi;
        private UserControls.Grid.MyBandedGridColumn colOzelKod5Adi;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand bndSecim;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand3;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand4;
    }
}