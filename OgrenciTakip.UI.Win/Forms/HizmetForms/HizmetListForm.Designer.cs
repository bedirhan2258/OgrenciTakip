namespace OgrenciTakip.UI.Win.Forms.HizmetForms
{
    partial class HizmetListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HizmetListForm));
            this.ustPanel = new DevExpress.XtraEditors.PanelControl();
            this.txtHizmetBaslamaTarihi = new OgrenciTakip.UI.Win.UserControls.Controls.MyDateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.longNavigator = new OgrenciTakip.UI.Win.UserControls.Navigators.LongNavigator();
            this.grid = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridControl();
            this.tablo = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridView();
            this.colId = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colKod = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colHizmetAdi = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colHizmetTuruId = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colHizmetTuruAdi = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colBaslamaTarihi = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colBitisTarihi = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colUcret = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colAciklama = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.repositoryTarih = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.repositoryUcret = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ustPanel)).BeginInit();
            this.ustPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHizmetBaslamaTarihi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHizmetBaslamaTarihi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryTarih)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryTarih.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryUcret)).BeginInit();
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
            // ustPanel
            // 
            this.ustPanel.Controls.Add(this.txtHizmetBaslamaTarihi);
            this.ustPanel.Controls.Add(this.labelControl1);
            this.ustPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ustPanel.Location = new System.Drawing.Point(0, 102);
            this.ustPanel.Name = "ustPanel";
            this.ustPanel.Size = new System.Drawing.Size(1170, 35);
            this.ustPanel.TabIndex = 2;
            this.ustPanel.Visible = false;
            // 
            // txtHizmetBaslamaTarihi
            // 
            this.txtHizmetBaslamaTarihi.EditValue = null;
            this.txtHizmetBaslamaTarihi.EnterMoveNextControl = true;
            this.txtHizmetBaslamaTarihi.Location = new System.Drawing.Point(121, 7);
            this.txtHizmetBaslamaTarihi.MenuManager = this.ribbonControl;
            this.txtHizmetBaslamaTarihi.Name = "txtHizmetBaslamaTarihi";
            this.txtHizmetBaslamaTarihi.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtHizmetBaslamaTarihi.Properties.Appearance.Options.UseTextOptions = true;
            this.txtHizmetBaslamaTarihi.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtHizmetBaslamaTarihi.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtHizmetBaslamaTarihi.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtHizmetBaslamaTarihi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtHizmetBaslamaTarihi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtHizmetBaslamaTarihi.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtHizmetBaslamaTarihi.Size = new System.Drawing.Size(100, 20);
            this.txtHizmetBaslamaTarihi.StatusBarAciklama = null;
            this.txtHizmetBaslamaTarihi.StatusBarKisayol = "F4 :";
            this.txtHizmetBaslamaTarihi.StatusBarKisayolAciklama = "Tarih Seç";
            this.txtHizmetBaslamaTarihi.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(5, 10);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(110, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Hizmet Başlama Tarihi :";
            // 
            // longNavigator
            // 
            this.longNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.longNavigator.Location = new System.Drawing.Point(0, 357);
            this.longNavigator.Name = "longNavigator";
            this.longNavigator.Size = new System.Drawing.Size(1170, 24);
            this.longNavigator.TabIndex = 3;
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 137);
            this.grid.MainView = this.tablo;
            this.grid.MenuManager = this.ribbonControl;
            this.grid.Name = "grid";
            this.grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryTarih,
            this.repositoryUcret});
            this.grid.Size = new System.Drawing.Size(1170, 220);
            this.grid.TabIndex = 4;
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
            this.colId,
            this.colKod,
            this.colHizmetAdi,
            this.colHizmetTuruId,
            this.colHizmetTuruAdi,
            this.colBaslamaTarihi,
            this.colBitisTarihi,
            this.colUcret,
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
            this.tablo.ViewCaption = "Hizmet Kartları";
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.OptionsColumn.ShowInCustomizationForm = false;
            this.colId.StatusBarAciklama = null;
            this.colId.StatusBarKisayol = null;
            this.colId.StatusBarKisayolAciklama = null;
            // 
            // colKod
            // 
            this.colKod.AppearanceCell.Options.UseTextOptions = true;
            this.colKod.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKod.Caption = "Kod";
            this.colKod.FieldName = "Kod";
            this.colKod.Name = "colKod";
            this.colKod.OptionsColumn.AllowEdit = false;
            this.colKod.StatusBarAciklama = null;
            this.colKod.StatusBarKisayol = null;
            this.colKod.StatusBarKisayolAciklama = null;
            this.colKod.Visible = true;
            this.colKod.VisibleIndex = 0;
            this.colKod.Width = 110;
            // 
            // colHizmetAdi
            // 
            this.colHizmetAdi.Caption = "Hizmet Adı";
            this.colHizmetAdi.FieldName = "HizmetAdi";
            this.colHizmetAdi.Name = "colHizmetAdi";
            this.colHizmetAdi.OptionsColumn.AllowEdit = false;
            this.colHizmetAdi.StatusBarAciklama = null;
            this.colHizmetAdi.StatusBarKisayol = null;
            this.colHizmetAdi.StatusBarKisayolAciklama = null;
            this.colHizmetAdi.Visible = true;
            this.colHizmetAdi.VisibleIndex = 1;
            this.colHizmetAdi.Width = 250;
            // 
            // colHizmetTuruId
            // 
            this.colHizmetTuruId.Caption = "Hizmet Türü Id";
            this.colHizmetTuruId.FieldName = "HizmetTuruId";
            this.colHizmetTuruId.Name = "colHizmetTuruId";
            this.colHizmetTuruId.OptionsColumn.AllowEdit = false;
            this.colHizmetTuruId.OptionsColumn.ShowInCustomizationForm = false;
            this.colHizmetTuruId.StatusBarAciklama = null;
            this.colHizmetTuruId.StatusBarKisayol = null;
            this.colHizmetTuruId.StatusBarKisayolAciklama = null;
            // 
            // colHizmetTuruAdi
            // 
            this.colHizmetTuruAdi.Caption = "Hizmet Türü";
            this.colHizmetTuruAdi.FieldName = "HizmetTuruAdi";
            this.colHizmetTuruAdi.Name = "colHizmetTuruAdi";
            this.colHizmetTuruAdi.OptionsColumn.AllowEdit = false;
            this.colHizmetTuruAdi.StatusBarAciklama = null;
            this.colHizmetTuruAdi.StatusBarKisayol = null;
            this.colHizmetTuruAdi.StatusBarKisayolAciklama = null;
            this.colHizmetTuruAdi.Visible = true;
            this.colHizmetTuruAdi.VisibleIndex = 2;
            this.colHizmetTuruAdi.Width = 132;
            // 
            // colBaslamaTarihi
            // 
            this.colBaslamaTarihi.AppearanceCell.Options.UseTextOptions = true;
            this.colBaslamaTarihi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBaslamaTarihi.Caption = "Başlama Tarihi";
            this.colBaslamaTarihi.ColumnEdit = this.repositoryTarih;
            this.colBaslamaTarihi.FieldName = "BaslamaTarihi";
            this.colBaslamaTarihi.Name = "colBaslamaTarihi";
            this.colBaslamaTarihi.OptionsColumn.AllowEdit = false;
            this.colBaslamaTarihi.StatusBarAciklama = null;
            this.colBaslamaTarihi.StatusBarKisayol = null;
            this.colBaslamaTarihi.StatusBarKisayolAciklama = null;
            this.colBaslamaTarihi.Visible = true;
            this.colBaslamaTarihi.VisibleIndex = 3;
            this.colBaslamaTarihi.Width = 110;
            // 
            // colBitisTarihi
            // 
            this.colBitisTarihi.AppearanceCell.Options.UseTextOptions = true;
            this.colBitisTarihi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBitisTarihi.Caption = "Bitiş Tarihi";
            this.colBitisTarihi.ColumnEdit = this.repositoryTarih;
            this.colBitisTarihi.FieldName = "BitisTarihi";
            this.colBitisTarihi.Name = "colBitisTarihi";
            this.colBitisTarihi.OptionsColumn.AllowEdit = false;
            this.colBitisTarihi.StatusBarAciklama = null;
            this.colBitisTarihi.StatusBarKisayol = null;
            this.colBitisTarihi.StatusBarKisayolAciklama = null;
            this.colBitisTarihi.Visible = true;
            this.colBitisTarihi.VisibleIndex = 4;
            this.colBitisTarihi.Width = 110;
            // 
            // colUcret
            // 
            this.colUcret.Caption = "Ücret";
            this.colUcret.ColumnEdit = this.repositoryUcret;
            this.colUcret.FieldName = "Ucret";
            this.colUcret.Name = "colUcret";
            this.colUcret.OptionsColumn.AllowEdit = false;
            this.colUcret.StatusBarAciklama = null;
            this.colUcret.StatusBarKisayol = null;
            this.colUcret.StatusBarKisayolAciklama = null;
            this.colUcret.Visible = true;
            this.colUcret.VisibleIndex = 5;
            this.colUcret.Width = 110;
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
            this.colAciklama.VisibleIndex = 6;
            this.colAciklama.Width = 320;
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
            // repositoryUcret
            // 
            this.repositoryUcret.AutoHeight = false;
            this.repositoryUcret.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryUcret.DisplayFormat.FormatString = "n2";
            this.repositoryUcret.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryUcret.Mask.EditMask = "n2";
            this.repositoryUcret.Name = "repositoryUcret";
            // 
            // HizmetListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 412);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.longNavigator);
            this.Controls.Add(this.ustPanel);
            this.Name = "HizmetListForm";
            this.Text = "Hizmet Kartları";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.ustPanel, 0);
            this.Controls.SetChildIndex(this.longNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ustPanel)).EndInit();
            this.ustPanel.ResumeLayout(false);
            this.ustPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHizmetBaslamaTarihi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHizmetBaslamaTarihi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryTarih.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryTarih)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryUcret)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl ustPanel;
        private UserControls.Controls.MyDateEdit txtHizmetBaslamaTarihi;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private UserControls.Navigators.LongNavigator longNavigator;
        private UserControls.Grid.MyGridControl grid;
        private UserControls.Grid.MyGridView tablo;
        private UserControls.Grid.MyGridColumn colId;
        private UserControls.Grid.MyGridColumn colKod;
        private UserControls.Grid.MyGridColumn colHizmetAdi;
        private UserControls.Grid.MyGridColumn colHizmetTuruId;
        private UserControls.Grid.MyGridColumn colHizmetTuruAdi;
        private UserControls.Grid.MyGridColumn colBaslamaTarihi;
        private UserControls.Grid.MyGridColumn colBitisTarihi;
        private UserControls.Grid.MyGridColumn colUcret;
        private UserControls.Grid.MyGridColumn colAciklama;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryTarih;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryUcret;
    }
}