namespace OgrenciTakip.UI.Win.Forms.BankaHesapForms
{
    partial class BankaHesapListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BankaHesapListForm));
            this.longNavigator = new OgrenciTakip.UI.Win.UserControls.Navigators.LongNavigator();
            this.grid = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridControl();
            this.tablo = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colKod = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.txtHesapAdi = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.txtHesapTuru = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colBankaAdi = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colBankaSubeAdi = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colHesapAcilisTarihi = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.repositoryTarih = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colBlokeGunSayisi = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colHesapNo = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colIbanNo = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colIsyeriNo = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colTerminalNo = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.gridBand3 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colOzelKod1Adi = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colOzelKod2Adi = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.gridBand4 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colAciklama = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colId = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryTarih)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryTarih.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Size = new System.Drawing.Size(1930, 102);
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
            this.longNavigator.Location = new System.Drawing.Point(0, 550);
            this.longNavigator.Name = "longNavigator";
            this.longNavigator.Size = new System.Drawing.Size(1930, 24);
            this.longNavigator.TabIndex = 2;
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 102);
            this.grid.MainView = this.tablo;
            this.grid.MenuManager = this.ribbonControl;
            this.grid.Name = "grid";
            this.grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryTarih});
            this.grid.Size = new System.Drawing.Size(1930, 448);
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
            this.gridBand1,
            this.gridBand2,
            this.gridBand3,
            this.gridBand4});
            this.tablo.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colId,
            this.colKod,
            this.txtHesapAdi,
            this.txtHesapTuru,
            this.colBankaAdi,
            this.colBankaSubeAdi,
            this.colHesapAcilisTarihi,
            this.colBlokeGunSayisi,
            this.colHesapNo,
            this.colIbanNo,
            this.colIsyeriNo,
            this.colTerminalNo,
            this.colOzelKod1Adi,
            this.colOzelKod2Adi,
            this.colAciklama});
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
            this.tablo.ViewCaption = "Banka Hesap Kartları";
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "Hesap Bilgileri";
            this.gridBand1.Columns.Add(this.colKod);
            this.gridBand1.Columns.Add(this.txtHesapAdi);
            this.gridBand1.Columns.Add(this.txtHesapTuru);
            this.gridBand1.Columns.Add(this.colBankaAdi);
            this.gridBand1.Columns.Add(this.colBankaSubeAdi);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 741;
            // 
            // colKod
            // 
            this.colKod.AppearanceCell.Options.UseTextOptions = true;
            this.colKod.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKod.Caption = "Kod";
            this.colKod.FieldName = "Kod";
            this.colKod.Name = "colKod";
            this.colKod.OptionsColumn.AllowEdit = false;
            this.colKod.Visible = true;
            this.colKod.Width = 124;
            // 
            // txtHesapAdi
            // 
            this.txtHesapAdi.Caption = "Hesap Adı";
            this.txtHesapAdi.FieldName = "HesapAdi";
            this.txtHesapAdi.Name = "txtHesapAdi";
            this.txtHesapAdi.OptionsColumn.AllowEdit = false;
            this.txtHesapAdi.StatusBarAciklama = null;
            this.txtHesapAdi.StatusBarKisayol = null;
            this.txtHesapAdi.StatusBarKisayolAciklama = null;
            this.txtHesapAdi.Visible = true;
            this.txtHesapAdi.Width = 227;
            // 
            // txtHesapTuru
            // 
            this.txtHesapTuru.Caption = "Hesap Türü";
            this.txtHesapTuru.FieldName = "HesapTuru";
            this.txtHesapTuru.Name = "txtHesapTuru";
            this.txtHesapTuru.OptionsColumn.AllowEdit = false;
            this.txtHesapTuru.StatusBarAciklama = null;
            this.txtHesapTuru.StatusBarKisayol = null;
            this.txtHesapTuru.StatusBarKisayolAciklama = null;
            this.txtHesapTuru.Visible = true;
            this.txtHesapTuru.Width = 130;
            // 
            // colBankaAdi
            // 
            this.colBankaAdi.Caption = "Banka Adı";
            this.colBankaAdi.FieldName = "BankaAdi";
            this.colBankaAdi.Name = "colBankaAdi";
            this.colBankaAdi.OptionsColumn.AllowEdit = false;
            this.colBankaAdi.StatusBarAciklama = null;
            this.colBankaAdi.StatusBarKisayol = null;
            this.colBankaAdi.StatusBarKisayolAciklama = null;
            this.colBankaAdi.Visible = true;
            this.colBankaAdi.Width = 130;
            // 
            // colBankaSubeAdi
            // 
            this.colBankaSubeAdi.Caption = "Banka Şube Adı";
            this.colBankaSubeAdi.FieldName = "BankaSubeAdi";
            this.colBankaSubeAdi.Name = "colBankaSubeAdi";
            this.colBankaSubeAdi.OptionsColumn.AllowEdit = false;
            this.colBankaSubeAdi.StatusBarAciklama = null;
            this.colBankaSubeAdi.StatusBarKisayol = null;
            this.colBankaSubeAdi.StatusBarKisayolAciklama = null;
            this.colBankaSubeAdi.Visible = true;
            this.colBankaSubeAdi.Width = 130;
            // 
            // gridBand2
            // 
            this.gridBand2.Caption = "Hesap Detay Bilgileri";
            this.gridBand2.Columns.Add(this.colHesapAcilisTarihi);
            this.gridBand2.Columns.Add(this.colBlokeGunSayisi);
            this.gridBand2.Columns.Add(this.colHesapNo);
            this.gridBand2.Columns.Add(this.colIbanNo);
            this.gridBand2.Columns.Add(this.colIsyeriNo);
            this.gridBand2.Columns.Add(this.colTerminalNo);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 1;
            this.gridBand2.Width = 848;
            // 
            // colHesapAcilisTarihi
            // 
            this.colHesapAcilisTarihi.AppearanceCell.Options.UseTextOptions = true;
            this.colHesapAcilisTarihi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colHesapAcilisTarihi.Caption = "Açılış  Tarihi";
            this.colHesapAcilisTarihi.ColumnEdit = this.repositoryTarih;
            this.colHesapAcilisTarihi.CustomizationCaption = "Hesap Açılış Tarihi";
            this.colHesapAcilisTarihi.FieldName = "HesapAcilisTarihi";
            this.colHesapAcilisTarihi.Name = "colHesapAcilisTarihi";
            this.colHesapAcilisTarihi.OptionsColumn.AllowEdit = false;
            this.colHesapAcilisTarihi.StatusBarAciklama = null;
            this.colHesapAcilisTarihi.StatusBarKisayol = null;
            this.colHesapAcilisTarihi.StatusBarKisayolAciklama = null;
            this.colHesapAcilisTarihi.Visible = true;
            this.colHesapAcilisTarihi.Width = 134;
            // 
            // repositoryTarih
            // 
            this.repositoryTarih.AutoHeight = false;
            this.repositoryTarih.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryTarih.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryTarih.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.repositoryTarih.Name = "repositoryTarih";
            // 
            // colBlokeGunSayisi
            // 
            this.colBlokeGunSayisi.Caption = "Bloke Gün Sayısı";
            this.colBlokeGunSayisi.FieldName = "BlokeGunSayisi";
            this.colBlokeGunSayisi.Name = "colBlokeGunSayisi";
            this.colBlokeGunSayisi.OptionsColumn.AllowEdit = false;
            this.colBlokeGunSayisi.StatusBarAciklama = null;
            this.colBlokeGunSayisi.StatusBarKisayol = null;
            this.colBlokeGunSayisi.StatusBarKisayolAciklama = null;
            this.colBlokeGunSayisi.Visible = true;
            this.colBlokeGunSayisi.Width = 126;
            // 
            // colHesapNo
            // 
            this.colHesapNo.Caption = "Hesap No";
            this.colHesapNo.FieldName = "HesapNo";
            this.colHesapNo.Name = "colHesapNo";
            this.colHesapNo.OptionsColumn.AllowEdit = false;
            this.colHesapNo.StatusBarAciklama = null;
            this.colHesapNo.StatusBarKisayol = null;
            this.colHesapNo.StatusBarKisayolAciklama = null;
            this.colHesapNo.Visible = true;
            this.colHesapNo.Width = 177;
            // 
            // colIbanNo
            // 
            this.colIbanNo.Caption = "Iban No";
            this.colIbanNo.FieldName = "IbanNo";
            this.colIbanNo.Name = "colIbanNo";
            this.colIbanNo.OptionsColumn.AllowEdit = false;
            this.colIbanNo.StatusBarAciklama = null;
            this.colIbanNo.StatusBarKisayol = null;
            this.colIbanNo.StatusBarKisayolAciklama = null;
            this.colIbanNo.Visible = true;
            this.colIbanNo.Width = 200;
            // 
            // colIsyeriNo
            // 
            this.colIsyeriNo.Caption = "İşyeri No";
            this.colIsyeriNo.FieldName = "IsyeriNo";
            this.colIsyeriNo.Name = "colIsyeriNo";
            this.colIsyeriNo.OptionsColumn.AllowEdit = false;
            this.colIsyeriNo.StatusBarAciklama = null;
            this.colIsyeriNo.StatusBarKisayol = null;
            this.colIsyeriNo.StatusBarKisayolAciklama = null;
            this.colIsyeriNo.Visible = true;
            this.colIsyeriNo.Width = 128;
            // 
            // colTerminalNo
            // 
            this.colTerminalNo.Caption = "Terminal No";
            this.colTerminalNo.FieldName = "TerminalNo";
            this.colTerminalNo.Name = "colTerminalNo";
            this.colTerminalNo.OptionsColumn.AllowEdit = false;
            this.colTerminalNo.StatusBarAciklama = null;
            this.colTerminalNo.StatusBarKisayol = null;
            this.colTerminalNo.StatusBarKisayolAciklama = null;
            this.colTerminalNo.Visible = true;
            this.colTerminalNo.Width = 83;
            // 
            // gridBand3
            // 
            this.gridBand3.Caption = "Özel Kod";
            this.gridBand3.Columns.Add(this.colOzelKod1Adi);
            this.gridBand3.Columns.Add(this.colOzelKod2Adi);
            this.gridBand3.Name = "gridBand3";
            this.gridBand3.VisibleIndex = 2;
            this.gridBand3.Width = 260;
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
            this.colOzelKod1Adi.Width = 130;
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
            this.colOzelKod2Adi.Width = 130;
            // 
            // gridBand4
            // 
            this.gridBand4.Caption = "Ek Bilgiler";
            this.gridBand4.Columns.Add(this.colAciklama);
            this.gridBand4.Name = "gridBand4";
            this.gridBand4.VisibleIndex = 3;
            this.gridBand4.Width = 250;
            // 
            // colAciklama
            // 
            this.colAciklama.Caption = "Açıklama";
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.OptionsColumn.AllowEdit = false;
            this.colAciklama.StatusBarAciklama = null;
            this.colAciklama.StatusBarKisayol = null;
            this.colAciklama.StatusBarKisayolAciklama = null;
            this.colAciklama.Visible = true;
            this.colAciklama.Width = 250;
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // BankaHesapListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1930, 605);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.longNavigator);
            this.Name = "BankaHesapListForm";
            this.Text = "Banka Hesap Kartları";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.longNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryTarih.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryTarih)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Navigators.LongNavigator longNavigator;
        private UserControls.Grid.MyBandedGridControl grid;
        private UserControls.Grid.MyBandedGridView tablo;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colKod;
        private UserControls.Grid.MyBandedGridColumn txtHesapAdi;
        private UserControls.Grid.MyBandedGridColumn txtHesapTuru;
        private UserControls.Grid.MyBandedGridColumn colBankaAdi;
        private UserControls.Grid.MyBandedGridColumn colBankaSubeAdi;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private UserControls.Grid.MyBandedGridColumn colHesapAcilisTarihi;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryTarih;
        private UserControls.Grid.MyBandedGridColumn colBlokeGunSayisi;
        private UserControls.Grid.MyBandedGridColumn colHesapNo;
        private UserControls.Grid.MyBandedGridColumn colIbanNo;
        private UserControls.Grid.MyBandedGridColumn colIsyeriNo;
        private UserControls.Grid.MyBandedGridColumn colTerminalNo;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand3;
        private UserControls.Grid.MyBandedGridColumn colOzelKod1Adi;
        private UserControls.Grid.MyBandedGridColumn colOzelKod2Adi;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand4;
        private UserControls.Grid.MyBandedGridColumn colAciklama;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colId;
    }
}