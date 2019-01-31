namespace OgrenciTakip.UI.Win.UserControls.UserControl.TahakkukEditFormTable
{
    partial class GeriOdemeBilgileriTable
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
            this.grid = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridControl();
            this.tablo = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridView();
            this.colTarih = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.repositoryTarih = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colHesapTuru = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.repositoryHesapTuru = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.colHesapId = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colHesapAdi = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.repositoryHesap = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colTutar = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.repositoryTutar = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.colAciklama = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryTarih)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryTarih.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryHesapTuru)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryHesap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryTutar)).BeginInit();
            this.SuspendLayout();
            // 
            // insUptNavigator
            // 
            this.insUptNavigator.Location = new System.Drawing.Point(0, 294);
            this.insUptNavigator.Size = new System.Drawing.Size(739, 24);
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 0);
            this.grid.MainView = this.tablo;
            this.grid.Name = "grid";
            this.grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryTarih,
            this.repositoryHesap,
            this.repositoryTutar,
            this.repositoryHesapTuru});
            this.grid.Size = new System.Drawing.Size(739, 294);
            this.grid.TabIndex = 5;
            this.grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tablo});
            // 
            // tablo
            // 
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
            this.tablo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTarih,
            this.colHesapTuru,
            this.colHesapId,
            this.colHesapAdi,
            this.colTutar,
            this.colAciklama});
            this.tablo.GridControl = this.grid;
            this.tablo.Name = "tablo";
            this.tablo.OptionsCustomization.AllowColumnMoving = false;
            this.tablo.OptionsCustomization.AllowSort = false;
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
            this.tablo.OptionsView.ShowFooter = true;
            this.tablo.OptionsView.ShowGroupPanel = false;
            this.tablo.OptionsView.ShowViewCaption = true;
            this.tablo.StatusBarAciklama = "Geri Ödeme Bilgileri Giriniz.";
            this.tablo.StatusBarKisayol = "Shift + Insert:";
            this.tablo.StatusBarKisayolAciklama = "Hareket Ekle.";
            this.tablo.ViewCaption = "Geri Ödeme Bilgileri";
            // 
            // colTarih
            // 
            this.colTarih.AppearanceCell.Options.UseTextOptions = true;
            this.colTarih.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTarih.Caption = "Tarih";
            this.colTarih.ColumnEdit = this.repositoryTarih;
            this.colTarih.FieldName = "Tarih";
            this.colTarih.Name = "colTarih";
            this.colTarih.OptionsFilter.AllowAutoFilter = false;
            this.colTarih.OptionsFilter.AllowFilter = false;
            this.colTarih.StatusBarAciklama = "Tarih Seçiniz.";
            this.colTarih.StatusBarKisayol = "F4 :";
            this.colTarih.StatusBarKisayolAciklama = "Seçim Yap.";
            this.colTarih.Visible = true;
            this.colTarih.VisibleIndex = 0;
            this.colTarih.Width = 90;
            // 
            // repositoryTarih
            // 
            this.repositoryTarih.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.repositoryTarih.AutoHeight = false;
            this.repositoryTarih.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryTarih.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryTarih.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.repositoryTarih.Name = "repositoryTarih";
            // 
            // colHesapTuru
            // 
            this.colHesapTuru.Caption = "Hesap Türü";
            this.colHesapTuru.ColumnEdit = this.repositoryHesapTuru;
            this.colHesapTuru.FieldName = "HesapTuru";
            this.colHesapTuru.Name = "colHesapTuru";
            this.colHesapTuru.OptionsFilter.AllowAutoFilter = false;
            this.colHesapTuru.OptionsFilter.AllowFilter = false;
            this.colHesapTuru.StatusBarAciklama = "Hesap Türü Seçiniz.";
            this.colHesapTuru.StatusBarKisayol = "F4 :";
            this.colHesapTuru.StatusBarKisayolAciklama = "Seçim Yap.";
            this.colHesapTuru.Visible = true;
            this.colHesapTuru.VisibleIndex = 1;
            this.colHesapTuru.Width = 90;
            // 
            // repositoryHesapTuru
            // 
            this.repositoryHesapTuru.AutoHeight = false;
            this.repositoryHesapTuru.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryHesapTuru.Name = "repositoryHesapTuru";
            // 
            // colHesapId
            // 
            this.colHesapId.Caption = "HesapId";
            this.colHesapId.FieldName = "HesapId";
            this.colHesapId.Name = "colHesapId";
            this.colHesapId.OptionsColumn.AllowEdit = false;
            this.colHesapId.OptionsColumn.ShowInCustomizationForm = false;
            this.colHesapId.OptionsFilter.AllowAutoFilter = false;
            this.colHesapId.OptionsFilter.AllowFilter = false;
            this.colHesapId.StatusBarAciklama = null;
            this.colHesapId.StatusBarKisayol = null;
            this.colHesapId.StatusBarKisayolAciklama = null;
            // 
            // colHesapAdi
            // 
            this.colHesapAdi.Caption = "Hesap Adı";
            this.colHesapAdi.ColumnEdit = this.repositoryHesap;
            this.colHesapAdi.FieldName = "HesapAdi";
            this.colHesapAdi.Name = "colHesapAdi";
            this.colHesapAdi.OptionsFilter.AllowAutoFilter = false;
            this.colHesapAdi.OptionsFilter.AllowFilter = false;
            this.colHesapAdi.StatusBarAciklama = "Hesap Seçiniz.";
            this.colHesapAdi.StatusBarKisayol = "F4 :";
            this.colHesapAdi.StatusBarKisayolAciklama = "Seçim Yap.";
            this.colHesapAdi.Visible = true;
            this.colHesapAdi.VisibleIndex = 2;
            this.colHesapAdi.Width = 150;
            // 
            // repositoryHesap
            // 
            this.repositoryHesap.AutoHeight = false;
            this.repositoryHesap.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryHesap.Name = "repositoryHesap";
            this.repositoryHesap.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // colTutar
            // 
            this.colTutar.Caption = "Tutar";
            this.colTutar.ColumnEdit = this.repositoryTutar;
            this.colTutar.FieldName = "Tutar";
            this.colTutar.Name = "colTutar";
            this.colTutar.OptionsFilter.AllowAutoFilter = false;
            this.colTutar.OptionsFilter.AllowFilter = false;
            this.colTutar.StatusBarAciklama = "Tutar Giriniz.";
            this.colTutar.StatusBarKisayol = "F4 :";
            this.colTutar.StatusBarKisayolAciklama = "Hesap Makinesi.";
            this.colTutar.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Tutar", "{0:n2}")});
            this.colTutar.Visible = true;
            this.colTutar.VisibleIndex = 3;
            this.colTutar.Width = 110;
            // 
            // repositoryTutar
            // 
            this.repositoryTutar.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.repositoryTutar.AutoHeight = false;
            this.repositoryTutar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryTutar.DisplayFormat.FormatString = "n2";
            this.repositoryTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryTutar.EditFormat.FormatString = "n2";
            this.repositoryTutar.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryTutar.Mask.EditMask = "n2";
            this.repositoryTutar.Name = "repositoryTutar";
            // 
            // colAciklama
            // 
            this.colAciklama.Caption = "Açıklama";
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.OptionsFilter.AllowAutoFilter = false;
            this.colAciklama.OptionsFilter.AllowFilter = false;
            this.colAciklama.StatusBarAciklama = "Açıklama Giriniz.";
            this.colAciklama.StatusBarKisayol = null;
            this.colAciklama.StatusBarKisayolAciklama = null;
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 4;
            this.colAciklama.Width = 350;
            // 
            // GeriOdemeBilgileriTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid);
            this.Name = "GeriOdemeBilgileriTable";
            this.Size = new System.Drawing.Size(739, 318);
            this.Controls.SetChildIndex(this.insUptNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryTarih.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryTarih)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryHesapTuru)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryHesap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryTutar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Grid.MyGridControl grid;
        private Grid.MyGridView tablo;
        private Grid.MyGridColumn colTarih;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryTarih;
        private Grid.MyGridColumn colHesapTuru;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryHesapTuru;
        private Grid.MyGridColumn colHesapId;
        private Grid.MyGridColumn colHesapAdi;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryHesap;
        private Grid.MyGridColumn colTutar;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryTutar;
        private Grid.MyGridColumn colAciklama;
    }
}
