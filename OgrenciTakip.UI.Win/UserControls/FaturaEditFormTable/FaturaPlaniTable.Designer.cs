namespace OgrenciTakip.UI.Win.UserControls.FaturaEditFormTable
{
    partial class FaturaPlaniTable
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
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colAciklama = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colPlanTarih = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.repositoryTarih = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colPlanTutar = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.repositoryDecimal = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.colPlanIndirimTutar = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colPlanNetTutar = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colFaturaNo = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colTahakkukTarih = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colTahakkukTutar = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colTahakkukIndirimTutar = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colTahakkukNetTutar = new OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryTarih)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryTarih.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDecimal)).BeginInit();
            this.SuspendLayout();
            // 
            // insUptNavigator
            // 
            this.insUptNavigator.Location = new System.Drawing.Point(0, 418);
            this.insUptNavigator.Size = new System.Drawing.Size(871, 24);
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 0);
            this.grid.MainView = this.tablo;
            this.grid.Name = "grid";
            this.grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryTarih,
            this.repositoryDecimal});
            this.grid.Size = new System.Drawing.Size(871, 418);
            this.grid.TabIndex = 1;
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
            this.gridBand2});
            this.tablo.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colAciklama,
            this.colPlanTarih,
            this.colPlanTutar,
            this.colPlanIndirimTutar,
            this.colPlanNetTutar,
            this.colFaturaNo,
            this.colTahakkukTarih,
            this.colTahakkukTutar,
            this.colTahakkukIndirimTutar,
            this.colTahakkukNetTutar});
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
            this.tablo.OptionsView.ShowFooter = true;
            this.tablo.OptionsView.ShowGroupPanel = false;
            this.tablo.OptionsView.ShowViewCaption = true;
            this.tablo.StatusBarAciklama = null;
            this.tablo.StatusBarKisayol = null;
            this.tablo.StatusBarKisayolAciklama = null;
            this.tablo.ViewCaption = "Fatura Planı";
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "Fatura Planı Bilgileri";
            this.gridBand1.Columns.Add(this.colAciklama);
            this.gridBand1.Columns.Add(this.colPlanTarih);
            this.gridBand1.Columns.Add(this.colPlanTutar);
            this.gridBand1.Columns.Add(this.colPlanIndirimTutar);
            this.gridBand1.Columns.Add(this.colPlanNetTutar);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 660;
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
            this.colAciklama.Width = 300;
            // 
            // colPlanTarih
            // 
            this.colPlanTarih.AppearanceCell.Options.UseTextOptions = true;
            this.colPlanTarih.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPlanTarih.Caption = "Plan Tarih";
            this.colPlanTarih.ColumnEdit = this.repositoryTarih;
            this.colPlanTarih.FieldName = "PlanTarih";
            this.colPlanTarih.Name = "colPlanTarih";
            this.colPlanTarih.OptionsColumn.AllowEdit = false;
            this.colPlanTarih.StatusBarAciklama = null;
            this.colPlanTarih.StatusBarKisayol = null;
            this.colPlanTarih.StatusBarKisayolAciklama = null;
            this.colPlanTarih.Visible = true;
            this.colPlanTarih.Width = 90;
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
            // colPlanTutar
            // 
            this.colPlanTutar.Caption = "Tutar";
            this.colPlanTutar.ColumnEdit = this.repositoryDecimal;
            this.colPlanTutar.CustomizationCaption = "Plan Tutar";
            this.colPlanTutar.FieldName = "PlanTutar";
            this.colPlanTutar.Name = "colPlanTutar";
            this.colPlanTutar.OptionsColumn.AllowEdit = false;
            this.colPlanTutar.StatusBarAciklama = null;
            this.colPlanTutar.StatusBarKisayol = null;
            this.colPlanTutar.StatusBarKisayolAciklama = null;
            this.colPlanTutar.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PlanTutar", "{0:n2}")});
            this.colPlanTutar.Visible = true;
            this.colPlanTutar.Width = 90;
            // 
            // repositoryDecimal
            // 
            this.repositoryDecimal.Appearance.Options.UseTextOptions = true;
            this.repositoryDecimal.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.repositoryDecimal.AutoHeight = false;
            this.repositoryDecimal.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryDecimal.DisplayFormat.FormatString = "{0:n2}";
            this.repositoryDecimal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryDecimal.Name = "repositoryDecimal";
            // 
            // colPlanIndirimTutar
            // 
            this.colPlanIndirimTutar.Caption = "İndirim";
            this.colPlanIndirimTutar.ColumnEdit = this.repositoryDecimal;
            this.colPlanIndirimTutar.CustomizationCaption = "Plan Indirim";
            this.colPlanIndirimTutar.FieldName = "PlanIndirimTutar";
            this.colPlanIndirimTutar.Name = "colPlanIndirimTutar";
            this.colPlanIndirimTutar.OptionsColumn.AllowEdit = false;
            this.colPlanIndirimTutar.StatusBarAciklama = null;
            this.colPlanIndirimTutar.StatusBarKisayol = null;
            this.colPlanIndirimTutar.StatusBarKisayolAciklama = null;
            this.colPlanIndirimTutar.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PlanIndirimTutar", "{0:n2}")});
            this.colPlanIndirimTutar.Visible = true;
            this.colPlanIndirimTutar.Width = 90;
            // 
            // colPlanNetTutar
            // 
            this.colPlanNetTutar.Caption = "Net Tutar";
            this.colPlanNetTutar.ColumnEdit = this.repositoryDecimal;
            this.colPlanNetTutar.CustomizationCaption = "Plan Net Tutar";
            this.colPlanNetTutar.FieldName = "PlanNetTutar";
            this.colPlanNetTutar.Name = "colPlanNetTutar";
            this.colPlanNetTutar.OptionsColumn.AllowEdit = false;
            this.colPlanNetTutar.StatusBarAciklama = null;
            this.colPlanNetTutar.StatusBarKisayol = null;
            this.colPlanNetTutar.StatusBarKisayolAciklama = null;
            this.colPlanNetTutar.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PlanNetTutar", "{0:n2}")});
            this.colPlanNetTutar.Visible = true;
            this.colPlanNetTutar.Width = 90;
            // 
            // gridBand2
            // 
            this.gridBand2.Caption = "Fatura Tahakkuk Bilgileri";
            this.gridBand2.Columns.Add(this.colFaturaNo);
            this.gridBand2.Columns.Add(this.colTahakkukTarih);
            this.gridBand2.Columns.Add(this.colTahakkukTutar);
            this.gridBand2.Columns.Add(this.colTahakkukIndirimTutar);
            this.gridBand2.Columns.Add(this.colTahakkukNetTutar);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 1;
            this.gridBand2.Width = 450;
            // 
            // colFaturaNo
            // 
            this.colFaturaNo.Caption = "Fatura No";
            this.colFaturaNo.FieldName = "FaturaNo";
            this.colFaturaNo.Name = "colFaturaNo";
            this.colFaturaNo.OptionsColumn.AllowEdit = false;
            this.colFaturaNo.StatusBarAciklama = null;
            this.colFaturaNo.StatusBarKisayol = null;
            this.colFaturaNo.StatusBarKisayolAciklama = null;
            this.colFaturaNo.Visible = true;
            this.colFaturaNo.Width = 90;
            // 
            // colTahakkukTarih
            // 
            this.colTahakkukTarih.AppearanceCell.Options.UseTextOptions = true;
            this.colTahakkukTarih.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTahakkukTarih.Caption = "Tarih";
            this.colTahakkukTarih.ColumnEdit = this.repositoryTarih;
            this.colTahakkukTarih.CustomizationCaption = "Tahakkuk Tarih";
            this.colTahakkukTarih.FieldName = "TahakkukTarih";
            this.colTahakkukTarih.Name = "colTahakkukTarih";
            this.colTahakkukTarih.OptionsColumn.AllowEdit = false;
            this.colTahakkukTarih.StatusBarAciklama = null;
            this.colTahakkukTarih.StatusBarKisayol = null;
            this.colTahakkukTarih.StatusBarKisayolAciklama = null;
            this.colTahakkukTarih.Visible = true;
            this.colTahakkukTarih.Width = 90;
            // 
            // colTahakkukTutar
            // 
            this.colTahakkukTutar.Caption = "Tutar";
            this.colTahakkukTutar.ColumnEdit = this.repositoryDecimal;
            this.colTahakkukTutar.CustomizationCaption = "Tahakkuk Tutar";
            this.colTahakkukTutar.FieldName = "TahakkukTutar";
            this.colTahakkukTutar.Name = "colTahakkukTutar";
            this.colTahakkukTutar.OptionsColumn.AllowEdit = false;
            this.colTahakkukTutar.StatusBarAciklama = null;
            this.colTahakkukTutar.StatusBarKisayol = null;
            this.colTahakkukTutar.StatusBarKisayolAciklama = null;
            this.colTahakkukTutar.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TahakkukTutar", "{0:n2}")});
            this.colTahakkukTutar.Visible = true;
            this.colTahakkukTutar.Width = 90;
            // 
            // colTahakkukIndirimTutar
            // 
            this.colTahakkukIndirimTutar.Caption = "İndirim";
            this.colTahakkukIndirimTutar.ColumnEdit = this.repositoryDecimal;
            this.colTahakkukIndirimTutar.CustomizationCaption = "Tahakkuk Indirim";
            this.colTahakkukIndirimTutar.FieldName = "TahakkukIndirimTutar";
            this.colTahakkukIndirimTutar.Name = "colTahakkukIndirimTutar";
            this.colTahakkukIndirimTutar.OptionsColumn.AllowEdit = false;
            this.colTahakkukIndirimTutar.StatusBarAciklama = null;
            this.colTahakkukIndirimTutar.StatusBarKisayol = null;
            this.colTahakkukIndirimTutar.StatusBarKisayolAciklama = null;
            this.colTahakkukIndirimTutar.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TahakkukIndirimTutar", "{0:n2}")});
            this.colTahakkukIndirimTutar.Visible = true;
            this.colTahakkukIndirimTutar.Width = 90;
            // 
            // colTahakkukNetTutar
            // 
            this.colTahakkukNetTutar.Caption = "Net Tutar";
            this.colTahakkukNetTutar.ColumnEdit = this.repositoryDecimal;
            this.colTahakkukNetTutar.CustomizationCaption = "Tahakkuk Net Tutar";
            this.colTahakkukNetTutar.FieldName = "TahakkukNetTutar";
            this.colTahakkukNetTutar.Name = "colTahakkukNetTutar";
            this.colTahakkukNetTutar.OptionsColumn.AllowEdit = false;
            this.colTahakkukNetTutar.StatusBarAciklama = null;
            this.colTahakkukNetTutar.StatusBarKisayol = null;
            this.colTahakkukNetTutar.StatusBarKisayolAciklama = null;
            this.colTahakkukNetTutar.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TahakkukNetTutar", "{0:n2}")});
            this.colTahakkukNetTutar.Visible = true;
            this.colTahakkukNetTutar.Width = 90;
            // 
            // FaturaPlaniTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid);
            this.Name = "FaturaPlaniTable";
            this.Size = new System.Drawing.Size(871, 442);
            this.Controls.SetChildIndex(this.insUptNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryTarih.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryTarih)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDecimal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Grid.MyBandedGridControl grid;
        private Grid.MyBandedGridView tablo;
        private Grid.MyBandedGridColumn colAciklama;
        private Grid.MyBandedGridColumn colPlanTarih;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryTarih;
        private Grid.MyBandedGridColumn colPlanTutar;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryDecimal;
        private Grid.MyBandedGridColumn colPlanIndirimTutar;
        private Grid.MyBandedGridColumn colPlanNetTutar;
        private Grid.MyBandedGridColumn colFaturaNo;
        private Grid.MyBandedGridColumn colTahakkukTarih;
        private Grid.MyBandedGridColumn colTahakkukTutar;
        private Grid.MyBandedGridColumn colTahakkukIndirimTutar;
        private Grid.MyBandedGridColumn colTahakkukNetTutar;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
    }
}
