namespace OgrenciTakip.UI.Win.UserControls.UserControl.TahakkukEditFormTable
{
    partial class TahakkukBilgileriTable
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
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue1 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            this.grid = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridControl();
            this.tablo = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridView();
            this.colSubeAdi = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colDonemAdi = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colBrutHizmet = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.repositoryDecimal = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.colKistDonemDusulenHizmet = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colNetHizmet = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colBrutIndirim = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colKistDonemDusulenIndirim = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colNetIndirim = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colNetUcret = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDecimal)).BeginInit();
            this.SuspendLayout();
            // 
            // insUptNavigator
            // 
            this.insUptNavigator.Location = new System.Drawing.Point(0, 321);
            this.insUptNavigator.Size = new System.Drawing.Size(991, 24);
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 0);
            this.grid.MainView = this.tablo;
            this.grid.Name = "grid";
            this.grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryDecimal});
            this.grid.Size = new System.Drawing.Size(991, 321);
            this.grid.TabIndex = 6;
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
            this.colSubeAdi,
            this.colDonemAdi,
            this.colBrutHizmet,
            this.colKistDonemDusulenHizmet,
            this.colNetHizmet,
            this.colBrutIndirim,
            this.colKistDonemDusulenIndirim,
            this.colNetIndirim,
            this.colNetUcret});
            gridFormatRule1.ApplyToRow = true;
            gridFormatRule1.Name = "Format0";
            formatConditionRuleValue1.Appearance.BackColor = System.Drawing.Color.MistyRose;
            formatConditionRuleValue1.Appearance.FontStyleDelta = System.Drawing.FontStyle.Italic;
            formatConditionRuleValue1.Appearance.ForeColor = System.Drawing.Color.Red;
            formatConditionRuleValue1.Appearance.Options.HighPriority = true;
            formatConditionRuleValue1.Appearance.Options.UseBackColor = true;
            formatConditionRuleValue1.Appearance.Options.UseFont = true;
            formatConditionRuleValue1.Appearance.Options.UseForeColor = true;
            formatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Equal;
            formatConditionRuleValue1.Value1 = true;
            gridFormatRule1.Rule = formatConditionRuleValue1;
            this.tablo.FormatRules.Add(gridFormatRule1);
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
            this.tablo.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.tablo.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.tablo.OptionsView.RowAutoHeight = true;
            this.tablo.OptionsView.ShowGroupPanel = false;
            this.tablo.OptionsView.ShowViewCaption = true;
            this.tablo.StatusBarAciklama = "Öğrenciye Yapılan Ücret Tahakukları";
            this.tablo.StatusBarKisayol = "";
            this.tablo.StatusBarKisayolAciklama = "";
            this.tablo.ViewCaption = "Tahakkuklar";
            // 
            // colSubeAdi
            // 
            this.colSubeAdi.Caption = "Şube";
            this.colSubeAdi.FieldName = "SubeAdi";
            this.colSubeAdi.Name = "colSubeAdi";
            this.colSubeAdi.OptionsColumn.AllowEdit = false;
            this.colSubeAdi.OptionsColumn.AllowMove = false;
            this.colSubeAdi.OptionsColumn.AllowShowHide = false;
            this.colSubeAdi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colSubeAdi.OptionsFilter.AllowAutoFilter = false;
            this.colSubeAdi.OptionsFilter.AllowFilter = false;
            this.colSubeAdi.StatusBarAciklama = null;
            this.colSubeAdi.StatusBarKisayol = null;
            this.colSubeAdi.StatusBarKisayolAciklama = null;
            this.colSubeAdi.Visible = true;
            this.colSubeAdi.VisibleIndex = 0;
            this.colSubeAdi.Width = 180;
            // 
            // colDonemAdi
            // 
            this.colDonemAdi.Caption = "Dönem";
            this.colDonemAdi.FieldName = "DonemAdi";
            this.colDonemAdi.Name = "colDonemAdi";
            this.colDonemAdi.OptionsColumn.AllowEdit = false;
            this.colDonemAdi.OptionsColumn.AllowMove = false;
            this.colDonemAdi.OptionsColumn.AllowShowHide = false;
            this.colDonemAdi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDonemAdi.OptionsFilter.AllowAutoFilter = false;
            this.colDonemAdi.OptionsFilter.AllowFilter = false;
            this.colDonemAdi.StatusBarAciklama = null;
            this.colDonemAdi.StatusBarKisayol = null;
            this.colDonemAdi.StatusBarKisayolAciklama = null;
            this.colDonemAdi.Visible = true;
            this.colDonemAdi.VisibleIndex = 1;
            this.colDonemAdi.Width = 160;
            // 
            // colBrutHizmet
            // 
            this.colBrutHizmet.Caption = "Brüt Hizmet";
            this.colBrutHizmet.ColumnEdit = this.repositoryDecimal;
            this.colBrutHizmet.FieldName = "BrutHizmet";
            this.colBrutHizmet.Name = "colBrutHizmet";
            this.colBrutHizmet.OptionsColumn.AllowEdit = false;
            this.colBrutHizmet.OptionsColumn.AllowMove = false;
            this.colBrutHizmet.OptionsColumn.AllowShowHide = false;
            this.colBrutHizmet.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colBrutHizmet.OptionsFilter.AllowAutoFilter = false;
            this.colBrutHizmet.OptionsFilter.AllowFilter = false;
            this.colBrutHizmet.StatusBarAciklama = null;
            this.colBrutHizmet.StatusBarKisayol = null;
            this.colBrutHizmet.StatusBarKisayolAciklama = null;
            this.colBrutHizmet.Visible = true;
            this.colBrutHizmet.VisibleIndex = 2;
            this.colBrutHizmet.Width = 90;
            // 
            // repositoryDecimal
            // 
            this.repositoryDecimal.AutoHeight = false;
            this.repositoryDecimal.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryDecimal.DisplayFormat.FormatString = "{0:n2}";
            this.repositoryDecimal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryDecimal.EditFormat.FormatString = "{0:n2}";
            this.repositoryDecimal.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryDecimal.Mask.EditMask = "n2";
            this.repositoryDecimal.Name = "repositoryDecimal";
            // 
            // colKistDonemDusulenHizmet
            // 
            this.colKistDonemDusulenHizmet.Caption = "Kıst Dönem Düşülen Hizmet";
            this.colKistDonemDusulenHizmet.ColumnEdit = this.repositoryDecimal;
            this.colKistDonemDusulenHizmet.FieldName = "KistDonemDusulenHizmet";
            this.colKistDonemDusulenHizmet.Name = "colKistDonemDusulenHizmet";
            this.colKistDonemDusulenHizmet.OptionsColumn.AllowEdit = false;
            this.colKistDonemDusulenHizmet.OptionsColumn.AllowMove = false;
            this.colKistDonemDusulenHizmet.OptionsColumn.AllowShowHide = false;
            this.colKistDonemDusulenHizmet.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colKistDonemDusulenHizmet.OptionsFilter.AllowAutoFilter = false;
            this.colKistDonemDusulenHizmet.OptionsFilter.AllowFilter = false;
            this.colKistDonemDusulenHizmet.StatusBarAciklama = null;
            this.colKistDonemDusulenHizmet.StatusBarKisayol = null;
            this.colKistDonemDusulenHizmet.StatusBarKisayolAciklama = null;
            this.colKistDonemDusulenHizmet.Visible = true;
            this.colKistDonemDusulenHizmet.VisibleIndex = 3;
            this.colKistDonemDusulenHizmet.Width = 90;
            // 
            // colNetHizmet
            // 
            this.colNetHizmet.Caption = "Net Hizmet";
            this.colNetHizmet.ColumnEdit = this.repositoryDecimal;
            this.colNetHizmet.FieldName = "NetHizmet";
            this.colNetHizmet.Name = "colNetHizmet";
            this.colNetHizmet.OptionsColumn.AllowEdit = false;
            this.colNetHizmet.OptionsColumn.AllowMove = false;
            this.colNetHizmet.OptionsColumn.AllowShowHide = false;
            this.colNetHizmet.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colNetHizmet.OptionsFilter.AllowAutoFilter = false;
            this.colNetHizmet.OptionsFilter.AllowFilter = false;
            this.colNetHizmet.StatusBarAciklama = null;
            this.colNetHizmet.StatusBarKisayol = null;
            this.colNetHizmet.StatusBarKisayolAciklama = null;
            this.colNetHizmet.Visible = true;
            this.colNetHizmet.VisibleIndex = 4;
            this.colNetHizmet.Width = 90;
            // 
            // colBrutIndirim
            // 
            this.colBrutIndirim.Caption = "Brüt İndirim";
            this.colBrutIndirim.ColumnEdit = this.repositoryDecimal;
            this.colBrutIndirim.FieldName = "BrutIndirim";
            this.colBrutIndirim.Name = "colBrutIndirim";
            this.colBrutIndirim.OptionsColumn.AllowEdit = false;
            this.colBrutIndirim.OptionsColumn.AllowMove = false;
            this.colBrutIndirim.OptionsColumn.AllowShowHide = false;
            this.colBrutIndirim.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colBrutIndirim.OptionsFilter.AllowAutoFilter = false;
            this.colBrutIndirim.OptionsFilter.AllowFilter = false;
            this.colBrutIndirim.StatusBarAciklama = null;
            this.colBrutIndirim.StatusBarKisayol = null;
            this.colBrutIndirim.StatusBarKisayolAciklama = null;
            this.colBrutIndirim.Visible = true;
            this.colBrutIndirim.VisibleIndex = 5;
            this.colBrutIndirim.Width = 90;
            // 
            // colKistDonemDusulenIndirim
            // 
            this.colKistDonemDusulenIndirim.AppearanceCell.Options.UseTextOptions = true;
            this.colKistDonemDusulenIndirim.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKistDonemDusulenIndirim.Caption = "Kıst Dönem Düşülen İndirim";
            this.colKistDonemDusulenIndirim.ColumnEdit = this.repositoryDecimal;
            this.colKistDonemDusulenIndirim.FieldName = "KistDonemDusulenIndirim";
            this.colKistDonemDusulenIndirim.Name = "colKistDonemDusulenIndirim";
            this.colKistDonemDusulenIndirim.OptionsColumn.AllowEdit = false;
            this.colKistDonemDusulenIndirim.OptionsColumn.AllowMove = false;
            this.colKistDonemDusulenIndirim.OptionsColumn.AllowShowHide = false;
            this.colKistDonemDusulenIndirim.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colKistDonemDusulenIndirim.OptionsFilter.AllowAutoFilter = false;
            this.colKistDonemDusulenIndirim.OptionsFilter.AllowFilter = false;
            this.colKistDonemDusulenIndirim.StatusBarAciklama = null;
            this.colKistDonemDusulenIndirim.StatusBarKisayol = null;
            this.colKistDonemDusulenIndirim.StatusBarKisayolAciklama = null;
            this.colKistDonemDusulenIndirim.Visible = true;
            this.colKistDonemDusulenIndirim.VisibleIndex = 6;
            this.colKistDonemDusulenIndirim.Width = 93;
            // 
            // colNetIndirim
            // 
            this.colNetIndirim.Caption = "Net İndirim";
            this.colNetIndirim.ColumnEdit = this.repositoryDecimal;
            this.colNetIndirim.FieldName = "NetIndirim";
            this.colNetIndirim.Name = "colNetIndirim";
            this.colNetIndirim.OptionsColumn.AllowEdit = false;
            this.colNetIndirim.OptionsColumn.AllowMove = false;
            this.colNetIndirim.OptionsColumn.AllowShowHide = false;
            this.colNetIndirim.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colNetIndirim.OptionsFilter.AllowAutoFilter = false;
            this.colNetIndirim.OptionsFilter.AllowFilter = false;
            this.colNetIndirim.StatusBarAciklama = null;
            this.colNetIndirim.StatusBarKisayol = null;
            this.colNetIndirim.StatusBarKisayolAciklama = null;
            this.colNetIndirim.Visible = true;
            this.colNetIndirim.VisibleIndex = 7;
            this.colNetIndirim.Width = 90;
            // 
            // colNetUcret
            // 
            this.colNetUcret.Caption = "Net Ücret";
            this.colNetUcret.ColumnEdit = this.repositoryDecimal;
            this.colNetUcret.FieldName = "NetUcret";
            this.colNetUcret.Name = "colNetUcret";
            this.colNetUcret.OptionsColumn.AllowEdit = false;
            this.colNetUcret.OptionsColumn.AllowMove = false;
            this.colNetUcret.OptionsColumn.AllowShowHide = false;
            this.colNetUcret.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colNetUcret.OptionsFilter.AllowAutoFilter = false;
            this.colNetUcret.OptionsFilter.AllowFilter = false;
            this.colNetUcret.StatusBarAciklama = null;
            this.colNetUcret.StatusBarKisayol = null;
            this.colNetUcret.StatusBarKisayolAciklama = null;
            this.colNetUcret.Visible = true;
            this.colNetUcret.VisibleIndex = 8;
            this.colNetUcret.Width = 88;
            // 
            // TahakkukBilgileriTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid);
            this.Name = "TahakkukBilgileriTable";
            this.Size = new System.Drawing.Size(991, 345);
            this.Controls.SetChildIndex(this.insUptNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDecimal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Grid.MyGridControl grid;
        private Grid.MyGridView tablo;
        private Grid.MyGridColumn colSubeAdi;
        private Grid.MyGridColumn colBrutIndirim;
        private Grid.MyGridColumn colDonemAdi;
        private Grid.MyGridColumn colBrutHizmet;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryDecimal;
        private Grid.MyGridColumn colKistDonemDusulenHizmet;
        private Grid.MyGridColumn colNetHizmet;
        private Grid.MyGridColumn colKistDonemDusulenIndirim;
        private Grid.MyGridColumn colNetIndirim;
        private Grid.MyGridColumn colNetUcret;
    }
}
