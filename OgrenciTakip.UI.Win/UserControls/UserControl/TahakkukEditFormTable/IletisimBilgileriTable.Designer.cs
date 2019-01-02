namespace OgrenciTakip.UI.Win.UserControls.UserControl.TahakkukEditFormTable
{
    partial class IletisimBilgileriTable
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grid = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridControl();
            this.tablo = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridView();
            this.colVeli = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colFaturaAdresi = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colYakinlikId = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colYakinlikAdi = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colTcKimlikNo = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colAdi = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colSoyadi = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colEvTel = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colIsTel1 = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colCepTel1 = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colEvAdres = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colEvAdresIlAdi = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colEvAdresIlceAdi = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colIsAdres = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colIsAdresIlAdi = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colIsAdresIlceAdi = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colMeslekAdi = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colIsyeriAdi = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colGorevAdi = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.repositoryYakinlik = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.repositoryAdres = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.repositoryVeli = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand3 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand4 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand5 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand6 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryYakinlik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryAdres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryVeli)).BeginInit();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 0);
            this.grid.MainView = this.tablo;
            this.grid.Name = "grid";
            this.grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryYakinlik,
            this.repositoryAdres,
            this.repositoryVeli});
            this.grid.Size = new System.Drawing.Size(953, 261);
            this.grid.TabIndex = 5;
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
            this.tablo.BandPanelRowHeight = 20;
            this.tablo.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1,
            this.gridBand2,
            this.gridBand3,
            this.gridBand4,
            this.gridBand5,
            this.gridBand6});
            this.tablo.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colVeli,
            this.colFaturaAdresi,
            this.colYakinlikId,
            this.colYakinlikAdi,
            this.colTcKimlikNo,
            this.colAdi,
            this.colSoyadi,
            this.colEvTel,
            this.colIsTel1,
            this.colCepTel1,
            this.colEvAdres,
            this.colEvAdresIlAdi,
            this.colEvAdresIlceAdi,
            this.colIsAdres,
            this.colIsAdresIlAdi,
            this.colIsAdresIlceAdi,
            this.colMeslekAdi,
            this.colIsyeriAdi,
            this.colGorevAdi});
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
            this.tablo.OptionsView.ShowGroupPanel = false;
            this.tablo.OptionsView.ShowViewCaption = true;
            this.tablo.StatusBarAciklama = null;
            this.tablo.StatusBarKisayol = null;
            this.tablo.StatusBarKisayolAciklama = null;
            this.tablo.ViewCaption = "İletişim Bilgileri";
            // 
            // colVeli
            // 
            this.colVeli.Caption = "Veli";
            this.colVeli.ColumnEdit = this.repositoryVeli;
            this.colVeli.FieldName = "Veli";
            this.colVeli.Name = "colVeli";
            this.colVeli.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colVeli.OptionsFilter.AllowAutoFilter = false;
            this.colVeli.OptionsFilter.AllowFilter = false;
            this.colVeli.StatusBarAciklama = "Kişi Öğrenci Velisi İse İşaretleyiniz.";
            this.colVeli.StatusBarKisayol = "Space : ";
            this.colVeli.StatusBarKisayolAciklama = "İşaretle";
            this.colVeli.Visible = true;
            this.colVeli.Width = 65;
            // 
            // colFaturaAdresi
            // 
            this.colFaturaAdresi.Caption = "Fatura Adresi";
            this.colFaturaAdresi.ColumnEdit = this.repositoryAdres;
            this.colFaturaAdresi.FieldName = "FaturaAdresi";
            this.colFaturaAdresi.Name = "colFaturaAdresi";
            this.colFaturaAdresi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colFaturaAdresi.OptionsFilter.AllowAutoFilter = false;
            this.colFaturaAdresi.OptionsFilter.AllowFilter = false;
            this.colFaturaAdresi.StatusBarAciklama = "Adres Türü Seçiniz.";
            this.colFaturaAdresi.StatusBarKisayol = "F4 : ";
            this.colFaturaAdresi.StatusBarKisayolAciklama = "Seçim Yap.";
            this.colFaturaAdresi.Visible = true;
            this.colFaturaAdresi.Width = 90;
            // 
            // colYakinlikId
            // 
            this.colYakinlikId.Caption = "YakinlikId";
            this.colYakinlikId.FieldName = "YakinlikId";
            this.colYakinlikId.Name = "colYakinlikId";
            this.colYakinlikId.OptionsColumn.AllowEdit = false;
            this.colYakinlikId.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colYakinlikId.OptionsColumn.ShowInCustomizationForm = false;
            this.colYakinlikId.OptionsFilter.AllowAutoFilter = false;
            this.colYakinlikId.OptionsFilter.AllowFilter = false;
            this.colYakinlikId.StatusBarAciklama = null;
            this.colYakinlikId.StatusBarKisayol = null;
            this.colYakinlikId.StatusBarKisayolAciklama = null;
            // 
            // colYakinlikAdi
            // 
            this.colYakinlikAdi.Caption = "Yakınlık";
            this.colYakinlikAdi.ColumnEdit = this.repositoryYakinlik;
            this.colYakinlikAdi.FieldName = "YakinlikAdi";
            this.colYakinlikAdi.Name = "colYakinlikAdi";
            this.colYakinlikAdi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colYakinlikAdi.OptionsFilter.AllowAutoFilter = false;
            this.colYakinlikAdi.OptionsFilter.AllowFilter = false;
            this.colYakinlikAdi.StatusBarAciklama = "Yakınlık Türü Seçiniz.";
            this.colYakinlikAdi.StatusBarKisayol = "F4 : ";
            this.colYakinlikAdi.StatusBarKisayolAciklama = "Seçim Yap.";
            this.colYakinlikAdi.Visible = true;
            this.colYakinlikAdi.Width = 90;
            // 
            // colTcKimlikNo
            // 
            this.colTcKimlikNo.Caption = "Tc Kimlik No";
            this.colTcKimlikNo.FieldName = "TcKimlikNo";
            this.colTcKimlikNo.Name = "colTcKimlikNo";
            this.colTcKimlikNo.OptionsColumn.AllowEdit = false;
            this.colTcKimlikNo.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colTcKimlikNo.OptionsFilter.AllowAutoFilter = false;
            this.colTcKimlikNo.OptionsFilter.AllowFilter = false;
            this.colTcKimlikNo.StatusBarAciklama = null;
            this.colTcKimlikNo.StatusBarKisayol = null;
            this.colTcKimlikNo.StatusBarKisayolAciklama = null;
            this.colTcKimlikNo.Visible = true;
            this.colTcKimlikNo.Width = 110;
            // 
            // colAdi
            // 
            this.colAdi.Caption = "Adı";
            this.colAdi.FieldName = "Adi";
            this.colAdi.Name = "colAdi";
            this.colAdi.OptionsColumn.AllowEdit = false;
            this.colAdi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colAdi.OptionsFilter.AllowAutoFilter = false;
            this.colAdi.OptionsFilter.AllowFilter = false;
            this.colAdi.StatusBarAciklama = null;
            this.colAdi.StatusBarKisayol = null;
            this.colAdi.StatusBarKisayolAciklama = null;
            this.colAdi.Visible = true;
            this.colAdi.Width = 110;
            // 
            // colSoyadi
            // 
            this.colSoyadi.Caption = "Soyadı";
            this.colSoyadi.FieldName = "Soyadi";
            this.colSoyadi.Name = "colSoyadi";
            this.colSoyadi.OptionsColumn.AllowEdit = false;
            this.colSoyadi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colSoyadi.OptionsFilter.AllowAutoFilter = false;
            this.colSoyadi.OptionsFilter.AllowFilter = false;
            this.colSoyadi.StatusBarAciklama = null;
            this.colSoyadi.StatusBarKisayol = null;
            this.colSoyadi.StatusBarKisayolAciklama = null;
            this.colSoyadi.Visible = true;
            this.colSoyadi.Width = 110;
            // 
            // colEvTel
            // 
            this.colEvTel.Caption = "Ev Telefonu";
            this.colEvTel.FieldName = "EvTel";
            this.colEvTel.Name = "colEvTel";
            this.colEvTel.OptionsColumn.AllowEdit = false;
            this.colEvTel.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colEvTel.OptionsFilter.AllowAutoFilter = false;
            this.colEvTel.OptionsFilter.AllowFilter = false;
            this.colEvTel.StatusBarAciklama = null;
            this.colEvTel.StatusBarKisayol = null;
            this.colEvTel.StatusBarKisayolAciklama = null;
            this.colEvTel.Visible = true;
            this.colEvTel.Width = 110;
            // 
            // colIsTel1
            // 
            this.colIsTel1.Caption = "İş Telefonu -1";
            this.colIsTel1.FieldName = "IsTel1";
            this.colIsTel1.Name = "colIsTel1";
            this.colIsTel1.OptionsColumn.AllowEdit = false;
            this.colIsTel1.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colIsTel1.OptionsFilter.AllowAutoFilter = false;
            this.colIsTel1.OptionsFilter.AllowFilter = false;
            this.colIsTel1.StatusBarAciklama = null;
            this.colIsTel1.StatusBarKisayol = null;
            this.colIsTel1.StatusBarKisayolAciklama = null;
            this.colIsTel1.Visible = true;
            this.colIsTel1.Width = 110;
            // 
            // colCepTel1
            // 
            this.colCepTel1.Caption = "Cep Telefonu -1";
            this.colCepTel1.FieldName = "CepTel1";
            this.colCepTel1.Name = "colCepTel1";
            this.colCepTel1.OptionsColumn.AllowEdit = false;
            this.colCepTel1.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colCepTel1.OptionsFilter.AllowAutoFilter = false;
            this.colCepTel1.OptionsFilter.AllowFilter = false;
            this.colCepTel1.StatusBarAciklama = null;
            this.colCepTel1.StatusBarKisayol = null;
            this.colCepTel1.StatusBarKisayolAciklama = null;
            this.colCepTel1.Visible = true;
            this.colCepTel1.Width = 110;
            // 
            // colEvAdres
            // 
            this.colEvAdres.Caption = "Ev Adresi";
            this.colEvAdres.FieldName = "EvAdres";
            this.colEvAdres.Name = "colEvAdres";
            this.colEvAdres.OptionsColumn.AllowEdit = false;
            this.colEvAdres.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colEvAdres.OptionsFilter.AllowAutoFilter = false;
            this.colEvAdres.OptionsFilter.AllowFilter = false;
            this.colEvAdres.StatusBarAciklama = null;
            this.colEvAdres.StatusBarKisayol = null;
            this.colEvAdres.StatusBarKisayolAciklama = null;
            this.colEvAdres.Visible = true;
            this.colEvAdres.Width = 250;
            // 
            // colEvAdresIlAdi
            // 
            this.colEvAdresIlAdi.Caption = "İl";
            this.colEvAdresIlAdi.CustomizationCaption = "Ev Adresi İl Adı";
            this.colEvAdresIlAdi.FieldName = "EvAdresIlAdi";
            this.colEvAdresIlAdi.Name = "colEvAdresIlAdi";
            this.colEvAdresIlAdi.OptionsColumn.AllowEdit = false;
            this.colEvAdresIlAdi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colEvAdresIlAdi.OptionsFilter.AllowAutoFilter = false;
            this.colEvAdresIlAdi.OptionsFilter.AllowFilter = false;
            this.colEvAdresIlAdi.StatusBarAciklama = null;
            this.colEvAdresIlAdi.StatusBarKisayol = null;
            this.colEvAdresIlAdi.StatusBarKisayolAciklama = null;
            this.colEvAdresIlAdi.Visible = true;
            this.colEvAdresIlAdi.Width = 100;
            // 
            // colEvAdresIlceAdi
            // 
            this.colEvAdresIlceAdi.Caption = "İlçe";
            this.colEvAdresIlceAdi.CustomizationCaption = "Ev Adresi İlçe Adı";
            this.colEvAdresIlceAdi.FieldName = "EvAdresIlceAdi";
            this.colEvAdresIlceAdi.Name = "colEvAdresIlceAdi";
            this.colEvAdresIlceAdi.OptionsColumn.AllowEdit = false;
            this.colEvAdresIlceAdi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colEvAdresIlceAdi.OptionsFilter.AllowAutoFilter = false;
            this.colEvAdresIlceAdi.OptionsFilter.AllowFilter = false;
            this.colEvAdresIlceAdi.StatusBarAciklama = null;
            this.colEvAdresIlceAdi.StatusBarKisayol = null;
            this.colEvAdresIlceAdi.StatusBarKisayolAciklama = null;
            this.colEvAdresIlceAdi.Visible = true;
            this.colEvAdresIlceAdi.Width = 100;
            // 
            // colIsAdres
            // 
            this.colIsAdres.Caption = "İş Adresi";
            this.colIsAdres.FieldName = "IsAdres";
            this.colIsAdres.Name = "colIsAdres";
            this.colIsAdres.OptionsColumn.AllowEdit = false;
            this.colIsAdres.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colIsAdres.OptionsFilter.AllowAutoFilter = false;
            this.colIsAdres.OptionsFilter.AllowFilter = false;
            this.colIsAdres.StatusBarAciklama = null;
            this.colIsAdres.StatusBarKisayol = null;
            this.colIsAdres.StatusBarKisayolAciklama = null;
            this.colIsAdres.Visible = true;
            this.colIsAdres.Width = 250;
            // 
            // colIsAdresIlAdi
            // 
            this.colIsAdresIlAdi.Caption = "İl";
            this.colIsAdresIlAdi.CustomizationCaption = "İş Adresi İl Adı";
            this.colIsAdresIlAdi.FieldName = "IsAdresIlAdi";
            this.colIsAdresIlAdi.Name = "colIsAdresIlAdi";
            this.colIsAdresIlAdi.OptionsColumn.AllowEdit = false;
            this.colIsAdresIlAdi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colIsAdresIlAdi.OptionsFilter.AllowAutoFilter = false;
            this.colIsAdresIlAdi.OptionsFilter.AllowFilter = false;
            this.colIsAdresIlAdi.StatusBarAciklama = null;
            this.colIsAdresIlAdi.StatusBarKisayol = null;
            this.colIsAdresIlAdi.StatusBarKisayolAciklama = null;
            this.colIsAdresIlAdi.Visible = true;
            this.colIsAdresIlAdi.Width = 100;
            // 
            // colIsAdresIlceAdi
            // 
            this.colIsAdresIlceAdi.Caption = "İlçe";
            this.colIsAdresIlceAdi.CustomizationCaption = "İş Adresi İlçe Adı";
            this.colIsAdresIlceAdi.FieldName = "IsAdresIlceAdi";
            this.colIsAdresIlceAdi.Name = "colIsAdresIlceAdi";
            this.colIsAdresIlceAdi.OptionsColumn.AllowEdit = false;
            this.colIsAdresIlceAdi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colIsAdresIlceAdi.OptionsFilter.AllowAutoFilter = false;
            this.colIsAdresIlceAdi.OptionsFilter.AllowFilter = false;
            this.colIsAdresIlceAdi.StatusBarAciklama = null;
            this.colIsAdresIlceAdi.StatusBarKisayol = null;
            this.colIsAdresIlceAdi.StatusBarKisayolAciklama = null;
            this.colIsAdresIlceAdi.Visible = true;
            this.colIsAdresIlceAdi.Width = 100;
            // 
            // colMeslekAdi
            // 
            this.colMeslekAdi.Caption = "Meslek";
            this.colMeslekAdi.FieldName = "MeslekAdi";
            this.colMeslekAdi.Name = "colMeslekAdi";
            this.colMeslekAdi.OptionsColumn.AllowEdit = false;
            this.colMeslekAdi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colMeslekAdi.OptionsFilter.AllowAutoFilter = false;
            this.colMeslekAdi.OptionsFilter.AllowFilter = false;
            this.colMeslekAdi.StatusBarAciklama = null;
            this.colMeslekAdi.StatusBarKisayol = null;
            this.colMeslekAdi.StatusBarKisayolAciklama = null;
            this.colMeslekAdi.Visible = true;
            this.colMeslekAdi.Width = 110;
            // 
            // colIsyeriAdi
            // 
            this.colIsyeriAdi.Caption = "Adı";
            this.colIsyeriAdi.CustomizationCaption = "İşyeri Adı";
            this.colIsyeriAdi.FieldName = "Isyeri";
            this.colIsyeriAdi.Name = "colIsyeriAdi";
            this.colIsyeriAdi.OptionsColumn.AllowEdit = false;
            this.colIsyeriAdi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colIsyeriAdi.OptionsFilter.AllowAutoFilter = false;
            this.colIsyeriAdi.OptionsFilter.AllowFilter = false;
            this.colIsyeriAdi.StatusBarAciklama = null;
            this.colIsyeriAdi.StatusBarKisayol = null;
            this.colIsyeriAdi.StatusBarKisayolAciklama = null;
            this.colIsyeriAdi.Visible = true;
            this.colIsyeriAdi.Width = 250;
            // 
            // colGorevAdi
            // 
            this.colGorevAdi.Caption = "Görev";
            this.colGorevAdi.FieldName = "GorevAdi";
            this.colGorevAdi.Name = "colGorevAdi";
            this.colGorevAdi.OptionsColumn.AllowEdit = false;
            this.colGorevAdi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colGorevAdi.OptionsFilter.AllowAutoFilter = false;
            this.colGorevAdi.OptionsFilter.AllowFilter = false;
            this.colGorevAdi.StatusBarAciklama = null;
            this.colGorevAdi.StatusBarKisayol = null;
            this.colGorevAdi.StatusBarKisayolAciklama = null;
            this.colGorevAdi.Visible = true;
            this.colGorevAdi.Width = 110;
            // 
            // repositoryYakinlik
            // 
            this.repositoryYakinlik.AutoHeight = false;
            this.repositoryYakinlik.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryYakinlik.Name = "repositoryYakinlik";
            this.repositoryYakinlik.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // repositoryAdres
            // 
            this.repositoryAdres.AutoHeight = false;
            this.repositoryAdres.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryAdres.Name = "repositoryAdres";
            // 
            // repositoryVeli
            // 
            this.repositoryVeli.AutoHeight = false;
            this.repositoryVeli.Name = "repositoryVeli";
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "Genel Bilgiler";
            this.gridBand1.Columns.Add(this.colVeli);
            this.gridBand1.Columns.Add(this.colFaturaAdresi);
            this.gridBand1.Columns.Add(this.colYakinlikAdi);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 245;
            // 
            // gridBand2
            // 
            this.gridBand2.Caption = "Kimlik Bilgileri";
            this.gridBand2.Columns.Add(this.colTcKimlikNo);
            this.gridBand2.Columns.Add(this.colAdi);
            this.gridBand2.Columns.Add(this.colSoyadi);
            this.gridBand2.Columns.Add(this.colMeslekAdi);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 1;
            this.gridBand2.Width = 440;
            // 
            // gridBand3
            // 
            this.gridBand3.Caption = "Telefon";
            this.gridBand3.Columns.Add(this.colEvTel);
            this.gridBand3.Columns.Add(this.colIsTel1);
            this.gridBand3.Columns.Add(this.colCepTel1);
            this.gridBand3.Name = "gridBand3";
            this.gridBand3.VisibleIndex = 2;
            this.gridBand3.Width = 330;
            // 
            // gridBand4
            // 
            this.gridBand4.Caption = "Ev Adresi";
            this.gridBand4.Columns.Add(this.colEvAdres);
            this.gridBand4.Columns.Add(this.colEvAdresIlAdi);
            this.gridBand4.Columns.Add(this.colEvAdresIlceAdi);
            this.gridBand4.Name = "gridBand4";
            this.gridBand4.VisibleIndex = 3;
            this.gridBand4.Width = 450;
            // 
            // gridBand5
            // 
            this.gridBand5.Caption = "İş Adresi";
            this.gridBand5.Columns.Add(this.colIsAdres);
            this.gridBand5.Columns.Add(this.colIsAdresIlAdi);
            this.gridBand5.Columns.Add(this.colIsAdresIlceAdi);
            this.gridBand5.Name = "gridBand5";
            this.gridBand5.VisibleIndex = 4;
            this.gridBand5.Width = 450;
            // 
            // gridBand6
            // 
            this.gridBand6.Caption = "Çalıştığı veya Sahibi Olduğu İşyeri Bilgisi";
            this.gridBand6.Columns.Add(this.colIsyeriAdi);
            this.gridBand6.Columns.Add(this.colGorevAdi);
            this.gridBand6.Name = "gridBand6";
            this.gridBand6.VisibleIndex = 5;
            this.gridBand6.Width = 360;
            // 
            // IletisimBilgileriTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid);
            this.Name = "IletisimBilgileriTable";
            this.Size = new System.Drawing.Size(953, 285);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryYakinlik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryAdres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryVeli)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Grid.MyBandedGridControl grid;
        private Grid.MyBandedGridView tablo;
        private Grid.MyBandedGridColumn colVeli;
        private Grid.MyBandedGridColumn colFaturaAdresi;
        private Grid.MyBandedGridColumn colYakinlikId;
        private Grid.MyBandedGridColumn colYakinlikAdi;
        private Grid.MyBandedGridColumn colTcKimlikNo;
        private Grid.MyBandedGridColumn colAdi;
        private Grid.MyBandedGridColumn colSoyadi;
        private Grid.MyBandedGridColumn colEvTel;
        private Grid.MyBandedGridColumn colIsTel1;
        private Grid.MyBandedGridColumn colCepTel1;
        private Grid.MyBandedGridColumn colEvAdres;
        private Grid.MyBandedGridColumn colEvAdresIlAdi;
        private Grid.MyBandedGridColumn colEvAdresIlceAdi;
        private Grid.MyBandedGridColumn colIsAdres;
        private Grid.MyBandedGridColumn colIsAdresIlAdi;
        private Grid.MyBandedGridColumn colIsAdresIlceAdi;
        private Grid.MyBandedGridColumn colMeslekAdi;
        private Grid.MyBandedGridColumn colIsyeriAdi;
        private Grid.MyBandedGridColumn colGorevAdi;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryVeli;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryAdres;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryYakinlik;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand3;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand4;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand5;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand6;
    }
}
