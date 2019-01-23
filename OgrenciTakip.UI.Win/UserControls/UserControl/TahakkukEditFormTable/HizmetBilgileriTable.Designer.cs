namespace OgrenciTakip.UI.Win.UserControls.UserControl.TahakkukEditFormTable
{
    partial class HizmetBilgileriTable
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
            this.colHizmetId = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colHizmetAdi = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colHizmetTuruId = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colServisId = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colServisYeriAdi = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colIslemTarihi = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.repositoryTarih = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colBaslamaTarihi = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colBrutUcret = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.repositoryDecimal = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.colKistDonemDusulenUcret = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colNetUcret = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colIptalEdildi = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colEgitimDonemiGunSayisi = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colAlinanHizmetGunSayisi = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colGunlukUcret = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colIptalTarihi = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.repositoryIptalTarihi = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colIptalNedeniId = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colIptalNedeniAdi = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.repositoryIptalNedeni = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colGittigiOkulId = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colGittigiOkulAdi = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.repositoryGittigiOKul = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colIptalAciklama = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryTarih)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryTarih.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDecimal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryIptalTarihi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryIptalTarihi.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryIptalNedeni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryGittigiOKul)).BeginInit();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 0);
            this.grid.MainView = this.tablo;
            this.grid.Name = "grid";
            this.grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryTarih,
            this.repositoryDecimal,
            this.repositoryIptalNedeni,
            this.repositoryGittigiOKul,
            this.repositoryIptalTarihi});
            this.grid.Size = new System.Drawing.Size(618, 265);
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
            this.colHizmetId,
            this.colHizmetAdi,
            this.colHizmetTuruId,
            this.colServisId,
            this.colServisYeriAdi,
            this.colIslemTarihi,
            this.colBaslamaTarihi,
            this.colBrutUcret,
            this.colKistDonemDusulenUcret,
            this.colNetUcret,
            this.colIptalEdildi,
            this.colEgitimDonemiGunSayisi,
            this.colAlinanHizmetGunSayisi,
            this.colGunlukUcret,
            this.colIptalTarihi,
            this.colIptalNedeniId,
            this.colIptalNedeniAdi,
            this.colGittigiOkulId,
            this.colGittigiOkulAdi,
            this.colIptalAciklama});
            gridFormatRule1.ApplyToRow = true;
            gridFormatRule1.Column = this.colIptalEdildi;
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
            this.tablo.OptionsView.ShowFooter = true;
            this.tablo.OptionsView.ShowGroupPanel = false;
            this.tablo.OptionsView.ShowViewCaption = true;
            this.tablo.StatusBarAciklama = null;
            this.tablo.StatusBarKisayol = null;
            this.tablo.StatusBarKisayolAciklama = null;
            this.tablo.ViewCaption = "Hizmet Bilgileri";
            // 
            // colHizmetId
            // 
            this.colHizmetId.Caption = "HizmetId";
            this.colHizmetId.FieldName = "HizmetId";
            this.colHizmetId.Name = "colHizmetId";
            this.colHizmetId.OptionsColumn.AllowEdit = false;
            this.colHizmetId.OptionsColumn.ShowInCustomizationForm = false;
            this.colHizmetId.StatusBarAciklama = null;
            this.colHizmetId.StatusBarKisayol = null;
            this.colHizmetId.StatusBarKisayolAciklama = null;
            // 
            // colHizmetAdi
            // 
            this.colHizmetAdi.Caption = "Hizmet Adı";
            this.colHizmetAdi.FieldName = "HizmetAdi";
            this.colHizmetAdi.Name = "colHizmetAdi";
            this.colHizmetAdi.OptionsColumn.AllowEdit = false;
            this.colHizmetAdi.OptionsColumn.AllowMove = false;
            this.colHizmetAdi.OptionsColumn.AllowShowHide = false;
            this.colHizmetAdi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colHizmetAdi.OptionsFilter.AllowAutoFilter = false;
            this.colHizmetAdi.OptionsFilter.AllowFilter = false;
            this.colHizmetAdi.StatusBarAciklama = null;
            this.colHizmetAdi.StatusBarKisayol = null;
            this.colHizmetAdi.StatusBarKisayolAciklama = null;
            this.colHizmetAdi.Visible = true;
            this.colHizmetAdi.VisibleIndex = 0;
            this.colHizmetAdi.Width = 225;
            // 
            // colHizmetTuruId
            // 
            this.colHizmetTuruId.Caption = "HizmetTuruId";
            this.colHizmetTuruId.FieldName = "HizmetTuruId";
            this.colHizmetTuruId.Name = "colHizmetTuruId";
            this.colHizmetTuruId.OptionsColumn.AllowEdit = false;
            this.colHizmetTuruId.OptionsColumn.ShowInCustomizationForm = false;
            this.colHizmetTuruId.StatusBarAciklama = null;
            this.colHizmetTuruId.StatusBarKisayol = null;
            this.colHizmetTuruId.StatusBarKisayolAciklama = null;
            // 
            // colServisId
            // 
            this.colServisId.Caption = "ServisId";
            this.colServisId.FieldName = "ServisId";
            this.colServisId.Name = "colServisId";
            this.colServisId.OptionsColumn.AllowEdit = false;
            this.colServisId.OptionsColumn.ShowInCustomizationForm = false;
            this.colServisId.StatusBarAciklama = null;
            this.colServisId.StatusBarKisayol = null;
            this.colServisId.StatusBarKisayolAciklama = null;
            // 
            // colServisYeriAdi
            // 
            this.colServisYeriAdi.Caption = "Servis Yeri";
            this.colServisYeriAdi.FieldName = "ServisYeriAdi";
            this.colServisYeriAdi.Name = "colServisYeriAdi";
            this.colServisYeriAdi.OptionsColumn.AllowEdit = false;
            this.colServisYeriAdi.OptionsColumn.AllowMove = false;
            this.colServisYeriAdi.OptionsColumn.AllowShowHide = false;
            this.colServisYeriAdi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colServisYeriAdi.OptionsFilter.AllowAutoFilter = false;
            this.colServisYeriAdi.OptionsFilter.AllowFilter = false;
            this.colServisYeriAdi.StatusBarAciklama = null;
            this.colServisYeriAdi.StatusBarKisayol = null;
            this.colServisYeriAdi.StatusBarKisayolAciklama = null;
            this.colServisYeriAdi.Width = 151;
            // 
            // colIslemTarihi
            // 
            this.colIslemTarihi.AppearanceCell.Options.UseTextOptions = true;
            this.colIslemTarihi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIslemTarihi.Caption = "İşlem Tarihi";
            this.colIslemTarihi.ColumnEdit = this.repositoryTarih;
            this.colIslemTarihi.FieldName = "IslemTarihi";
            this.colIslemTarihi.Name = "colIslemTarihi";
            this.colIslemTarihi.OptionsColumn.AllowEdit = false;
            this.colIslemTarihi.OptionsColumn.AllowMove = false;
            this.colIslemTarihi.OptionsColumn.AllowShowHide = false;
            this.colIslemTarihi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colIslemTarihi.OptionsFilter.AllowAutoFilter = false;
            this.colIslemTarihi.OptionsFilter.AllowFilter = false;
            this.colIslemTarihi.StatusBarAciklama = null;
            this.colIslemTarihi.StatusBarKisayol = null;
            this.colIslemTarihi.StatusBarKisayolAciklama = null;
            this.colIslemTarihi.Visible = true;
            this.colIslemTarihi.VisibleIndex = 5;
            this.colIslemTarihi.Width = 100;
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
            // colBaslamaTarihi
            // 
            this.colBaslamaTarihi.AppearanceCell.Options.UseTextOptions = true;
            this.colBaslamaTarihi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBaslamaTarihi.Caption = "Başlama Tarihi";
            this.colBaslamaTarihi.ColumnEdit = this.repositoryTarih;
            this.colBaslamaTarihi.FieldName = "BaslamaTarihi";
            this.colBaslamaTarihi.Name = "colBaslamaTarihi";
            this.colBaslamaTarihi.OptionsColumn.AllowEdit = false;
            this.colBaslamaTarihi.OptionsColumn.AllowMove = false;
            this.colBaslamaTarihi.OptionsColumn.AllowShowHide = false;
            this.colBaslamaTarihi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colBaslamaTarihi.OptionsFilter.AllowAutoFilter = false;
            this.colBaslamaTarihi.OptionsFilter.AllowFilter = false;
            this.colBaslamaTarihi.StatusBarAciklama = null;
            this.colBaslamaTarihi.StatusBarKisayol = null;
            this.colBaslamaTarihi.StatusBarKisayolAciklama = null;
            this.colBaslamaTarihi.Visible = true;
            this.colBaslamaTarihi.VisibleIndex = 1;
            this.colBaslamaTarihi.Width = 100;
            // 
            // colBrutUcret
            // 
            this.colBrutUcret.Caption = "Brüt Ücret";
            this.colBrutUcret.ColumnEdit = this.repositoryDecimal;
            this.colBrutUcret.FieldName = "BrutUcret";
            this.colBrutUcret.Name = "colBrutUcret";
            this.colBrutUcret.OptionsColumn.AllowEdit = false;
            this.colBrutUcret.OptionsColumn.AllowMove = false;
            this.colBrutUcret.OptionsColumn.AllowShowHide = false;
            this.colBrutUcret.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colBrutUcret.OptionsFilter.AllowAutoFilter = false;
            this.colBrutUcret.OptionsFilter.AllowFilter = false;
            this.colBrutUcret.StatusBarAciklama = null;
            this.colBrutUcret.StatusBarKisayol = null;
            this.colBrutUcret.StatusBarKisayolAciklama = null;
            this.colBrutUcret.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "BrutUcret", "{0:n2}")});
            this.colBrutUcret.Visible = true;
            this.colBrutUcret.VisibleIndex = 2;
            this.colBrutUcret.Width = 100;
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
            // colKistDonemDusulenUcret
            // 
            this.colKistDonemDusulenUcret.Caption = "Kıst Dönem Düşülen Ücret";
            this.colKistDonemDusulenUcret.ColumnEdit = this.repositoryDecimal;
            this.colKistDonemDusulenUcret.FieldName = "KistDonemDusulenUcret";
            this.colKistDonemDusulenUcret.Name = "colKistDonemDusulenUcret";
            this.colKistDonemDusulenUcret.OptionsColumn.AllowEdit = false;
            this.colKistDonemDusulenUcret.OptionsColumn.AllowMove = false;
            this.colKistDonemDusulenUcret.OptionsColumn.AllowShowHide = false;
            this.colKistDonemDusulenUcret.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colKistDonemDusulenUcret.OptionsFilter.AllowAutoFilter = false;
            this.colKistDonemDusulenUcret.OptionsFilter.AllowFilter = false;
            this.colKistDonemDusulenUcret.StatusBarAciklama = null;
            this.colKistDonemDusulenUcret.StatusBarKisayol = null;
            this.colKistDonemDusulenUcret.StatusBarKisayolAciklama = null;
            this.colKistDonemDusulenUcret.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "KistDonemDusulenUcret", "{0:n2}")});
            this.colKistDonemDusulenUcret.Visible = true;
            this.colKistDonemDusulenUcret.VisibleIndex = 3;
            this.colKistDonemDusulenUcret.Width = 100;
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
            this.colNetUcret.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NetUcret", "{0:n2}")});
            this.colNetUcret.Visible = true;
            this.colNetUcret.VisibleIndex = 4;
            this.colNetUcret.Width = 100;
            // 
            // colIptalEdildi
            // 
            this.colIptalEdildi.Caption = "IptalEdildi";
            this.colIptalEdildi.FieldName = "IptalEdildi";
            this.colIptalEdildi.Name = "colIptalEdildi";
            this.colIptalEdildi.OptionsColumn.AllowEdit = false;
            this.colIptalEdildi.OptionsColumn.ShowInCustomizationForm = false;
            this.colIptalEdildi.StatusBarAciklama = null;
            this.colIptalEdildi.StatusBarKisayol = null;
            this.colIptalEdildi.StatusBarKisayolAciklama = null;
            // 
            // colEgitimDonemiGunSayisi
            // 
            this.colEgitimDonemiGunSayisi.AppearanceCell.Options.UseTextOptions = true;
            this.colEgitimDonemiGunSayisi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEgitimDonemiGunSayisi.Caption = "Eğitim Dönemi Gün Sayısı";
            this.colEgitimDonemiGunSayisi.FieldName = "EgitimDonemiGunSayisi";
            this.colEgitimDonemiGunSayisi.Name = "colEgitimDonemiGunSayisi";
            this.colEgitimDonemiGunSayisi.OptionsColumn.AllowEdit = false;
            this.colEgitimDonemiGunSayisi.OptionsColumn.AllowMove = false;
            this.colEgitimDonemiGunSayisi.OptionsColumn.AllowShowHide = false;
            this.colEgitimDonemiGunSayisi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colEgitimDonemiGunSayisi.OptionsFilter.AllowAutoFilter = false;
            this.colEgitimDonemiGunSayisi.OptionsFilter.AllowFilter = false;
            this.colEgitimDonemiGunSayisi.StatusBarAciklama = null;
            this.colEgitimDonemiGunSayisi.StatusBarKisayol = null;
            this.colEgitimDonemiGunSayisi.StatusBarKisayolAciklama = null;
            this.colEgitimDonemiGunSayisi.Visible = true;
            this.colEgitimDonemiGunSayisi.VisibleIndex = 6;
            this.colEgitimDonemiGunSayisi.Width = 85;
            // 
            // colAlinanHizmetGunSayisi
            // 
            this.colAlinanHizmetGunSayisi.AppearanceCell.Options.UseTextOptions = true;
            this.colAlinanHizmetGunSayisi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAlinanHizmetGunSayisi.Caption = "Alınan Hizmet Gün Sayısı";
            this.colAlinanHizmetGunSayisi.FieldName = "AlinanHizmetGunSayisi";
            this.colAlinanHizmetGunSayisi.Name = "colAlinanHizmetGunSayisi";
            this.colAlinanHizmetGunSayisi.OptionsColumn.AllowEdit = false;
            this.colAlinanHizmetGunSayisi.OptionsColumn.AllowMove = false;
            this.colAlinanHizmetGunSayisi.OptionsColumn.AllowShowHide = false;
            this.colAlinanHizmetGunSayisi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colAlinanHizmetGunSayisi.OptionsFilter.AllowAutoFilter = false;
            this.colAlinanHizmetGunSayisi.OptionsFilter.AllowFilter = false;
            this.colAlinanHizmetGunSayisi.StatusBarAciklama = null;
            this.colAlinanHizmetGunSayisi.StatusBarKisayol = null;
            this.colAlinanHizmetGunSayisi.StatusBarKisayolAciklama = null;
            this.colAlinanHizmetGunSayisi.Visible = true;
            this.colAlinanHizmetGunSayisi.VisibleIndex = 7;
            this.colAlinanHizmetGunSayisi.Width = 85;
            // 
            // colGunlukUcret
            // 
            this.colGunlukUcret.Caption = "Günlük Ücret";
            this.colGunlukUcret.ColumnEdit = this.repositoryDecimal;
            this.colGunlukUcret.FieldName = "GunlukUcret";
            this.colGunlukUcret.Name = "colGunlukUcret";
            this.colGunlukUcret.OptionsColumn.AllowEdit = false;
            this.colGunlukUcret.OptionsColumn.AllowMove = false;
            this.colGunlukUcret.OptionsColumn.AllowShowHide = false;
            this.colGunlukUcret.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colGunlukUcret.OptionsFilter.AllowAutoFilter = false;
            this.colGunlukUcret.OptionsFilter.AllowFilter = false;
            this.colGunlukUcret.StatusBarAciklama = null;
            this.colGunlukUcret.StatusBarKisayol = null;
            this.colGunlukUcret.StatusBarKisayolAciklama = null;
            this.colGunlukUcret.Visible = true;
            this.colGunlukUcret.VisibleIndex = 8;
            this.colGunlukUcret.Width = 85;
            // 
            // colIptalTarihi
            // 
            this.colIptalTarihi.AppearanceCell.Options.UseTextOptions = true;
            this.colIptalTarihi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIptalTarihi.Caption = "İptal Tarihi";
            this.colIptalTarihi.ColumnEdit = this.repositoryIptalTarihi;
            this.colIptalTarihi.FieldName = "IptalTarihi";
            this.colIptalTarihi.Name = "colIptalTarihi";
            this.colIptalTarihi.OptionsColumn.AllowEdit = false;
            this.colIptalTarihi.OptionsColumn.AllowMove = false;
            this.colIptalTarihi.OptionsColumn.AllowShowHide = false;
            this.colIptalTarihi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colIptalTarihi.OptionsFilter.AllowAutoFilter = false;
            this.colIptalTarihi.OptionsFilter.AllowFilter = false;
            this.colIptalTarihi.StatusBarAciklama = null;
            this.colIptalTarihi.StatusBarKisayol = null;
            this.colIptalTarihi.StatusBarKisayolAciklama = null;
            this.colIptalTarihi.Visible = true;
            this.colIptalTarihi.VisibleIndex = 9;
            this.colIptalTarihi.Width = 100;
            // 
            // repositoryIptalTarihi
            // 
            this.repositoryIptalTarihi.AutoHeight = false;
            this.repositoryIptalTarihi.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryIptalTarihi.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryIptalTarihi.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.repositoryIptalTarihi.Name = "repositoryIptalTarihi";
            // 
            // colIptalNedeniId
            // 
            this.colIptalNedeniId.Caption = "IptalNedeniId";
            this.colIptalNedeniId.FieldName = "IptalNedeniId";
            this.colIptalNedeniId.Name = "colIptalNedeniId";
            this.colIptalNedeniId.OptionsColumn.AllowEdit = false;
            this.colIptalNedeniId.OptionsColumn.ShowInCustomizationForm = false;
            this.colIptalNedeniId.StatusBarAciklama = null;
            this.colIptalNedeniId.StatusBarKisayol = null;
            this.colIptalNedeniId.StatusBarKisayolAciklama = null;
            // 
            // colIptalNedeniAdi
            // 
            this.colIptalNedeniAdi.Caption = "İptal Nedeni";
            this.colIptalNedeniAdi.ColumnEdit = this.repositoryIptalNedeni;
            this.colIptalNedeniAdi.FieldName = "IptalNedeniAdi";
            this.colIptalNedeniAdi.Name = "colIptalNedeniAdi";
            this.colIptalNedeniAdi.OptionsColumn.AllowEdit = false;
            this.colIptalNedeniAdi.OptionsColumn.AllowMove = false;
            this.colIptalNedeniAdi.OptionsColumn.AllowShowHide = false;
            this.colIptalNedeniAdi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colIptalNedeniAdi.OptionsFilter.AllowAutoFilter = false;
            this.colIptalNedeniAdi.OptionsFilter.AllowFilter = false;
            this.colIptalNedeniAdi.StatusBarAciklama = null;
            this.colIptalNedeniAdi.StatusBarKisayol = null;
            this.colIptalNedeniAdi.StatusBarKisayolAciklama = null;
            this.colIptalNedeniAdi.Visible = true;
            this.colIptalNedeniAdi.VisibleIndex = 10;
            this.colIptalNedeniAdi.Width = 150;
            // 
            // repositoryIptalNedeni
            // 
            this.repositoryIptalNedeni.AutoHeight = false;
            this.repositoryIptalNedeni.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryIptalNedeni.Name = "repositoryIptalNedeni";
            this.repositoryIptalNedeni.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // colGittigiOkulId
            // 
            this.colGittigiOkulId.Caption = "GittigiOkulId";
            this.colGittigiOkulId.FieldName = "GittigiOkulId";
            this.colGittigiOkulId.Name = "colGittigiOkulId";
            this.colGittigiOkulId.OptionsColumn.AllowEdit = false;
            this.colGittigiOkulId.OptionsColumn.ShowInCustomizationForm = false;
            this.colGittigiOkulId.StatusBarAciklama = null;
            this.colGittigiOkulId.StatusBarKisayol = null;
            this.colGittigiOkulId.StatusBarKisayolAciklama = null;
            // 
            // colGittigiOkulAdi
            // 
            this.colGittigiOkulAdi.Caption = "Gittiği Okul";
            this.colGittigiOkulAdi.ColumnEdit = this.repositoryGittigiOKul;
            this.colGittigiOkulAdi.FieldName = "GittigiOkulAdi";
            this.colGittigiOkulAdi.Name = "colGittigiOkulAdi";
            this.colGittigiOkulAdi.OptionsColumn.AllowEdit = false;
            this.colGittigiOkulAdi.OptionsColumn.AllowMove = false;
            this.colGittigiOkulAdi.OptionsColumn.AllowShowHide = false;
            this.colGittigiOkulAdi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colGittigiOkulAdi.OptionsFilter.AllowAutoFilter = false;
            this.colGittigiOkulAdi.OptionsFilter.AllowFilter = false;
            this.colGittigiOkulAdi.StatusBarAciklama = null;
            this.colGittigiOkulAdi.StatusBarKisayol = null;
            this.colGittigiOkulAdi.StatusBarKisayolAciklama = null;
            this.colGittigiOkulAdi.Visible = true;
            this.colGittigiOkulAdi.VisibleIndex = 11;
            this.colGittigiOkulAdi.Width = 200;
            // 
            // repositoryGittigiOKul
            // 
            this.repositoryGittigiOKul.AutoHeight = false;
            this.repositoryGittigiOKul.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryGittigiOKul.Name = "repositoryGittigiOKul";
            this.repositoryGittigiOKul.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // colIptalAciklama
            // 
            this.colIptalAciklama.Caption = "İptal  Açıklama";
            this.colIptalAciklama.FieldName = "IptalAciklama";
            this.colIptalAciklama.Name = "colIptalAciklama";
            this.colIptalAciklama.OptionsColumn.AllowEdit = false;
            this.colIptalAciklama.OptionsColumn.AllowMove = false;
            this.colIptalAciklama.OptionsColumn.AllowShowHide = false;
            this.colIptalAciklama.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colIptalAciklama.OptionsFilter.AllowAutoFilter = false;
            this.colIptalAciklama.OptionsFilter.AllowFilter = false;
            this.colIptalAciklama.StatusBarAciklama = null;
            this.colIptalAciklama.StatusBarKisayol = null;
            this.colIptalAciklama.StatusBarKisayolAciklama = null;
            this.colIptalAciklama.Visible = true;
            this.colIptalAciklama.VisibleIndex = 12;
            this.colIptalAciklama.Width = 350;
            // 
            // HizmetBilgileriTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid);
            this.Name = "HizmetBilgileriTable";
            this.Controls.SetChildIndex(this.insUptNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryTarih.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryTarih)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDecimal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryIptalTarihi.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryIptalTarihi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryIptalNedeni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryGittigiOKul)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Grid.MyGridControl grid;
        private Grid.MyGridView tablo;
        private Grid.MyGridColumn colHizmetId;
        private Grid.MyGridColumn colHizmetAdi;
        private Grid.MyGridColumn colHizmetTuruId;
        private Grid.MyGridColumn colServisId;
        private Grid.MyGridColumn colServisYeriAdi;
        private Grid.MyGridColumn colIslemTarihi;
        private Grid.MyGridColumn colBaslamaTarihi;
        private Grid.MyGridColumn colBrutUcret;
        private Grid.MyGridColumn colKistDonemDusulenUcret;
        private Grid.MyGridColumn colNetUcret;
        private Grid.MyGridColumn colIptalEdildi;
        private Grid.MyGridColumn colEgitimDonemiGunSayisi;
        private Grid.MyGridColumn colAlinanHizmetGunSayisi;
        private Grid.MyGridColumn colGunlukUcret;
        private Grid.MyGridColumn colIptalTarihi;
        private Grid.MyGridColumn colIptalNedeniId;
        private Grid.MyGridColumn colIptalNedeniAdi;
        private Grid.MyGridColumn colGittigiOkulId;
        private Grid.MyGridColumn colGittigiOkulAdi;
        private Grid.MyGridColumn colIptalAciklama;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryTarih;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryDecimal;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryIptalNedeni;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryGittigiOKul;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryIptalTarihi;
    }
}
