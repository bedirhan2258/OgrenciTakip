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
            this.grid = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridControl();
            this.tablo = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridView();
            this.colHizmetId = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colHizmetAdi = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colHizmetTuruId = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colServisId = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colServisYeriAdi = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colIslemTarihi = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colBaslamaTarihi = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colBrutUcret = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colKistDusulenUcret = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colNetUcret = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colIptalEdildi = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colEgitimDonemiGunSayisi = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colAlinanHizmetGunSayisi = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colGunlukUcret = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colIptalTarihi = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colIptalNedeniId = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colNedeniAdi = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colGittigiOkulId = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colGittigiOkulAdi = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colIptalAciklama = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 0);
            this.grid.MainView = this.tablo;
            this.grid.Name = "grid";
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
            this.colKistDusulenUcret,
            this.colNetUcret,
            this.colIptalEdildi,
            this.colEgitimDonemiGunSayisi,
            this.colAlinanHizmetGunSayisi,
            this.colGunlukUcret,
            this.colIptalTarihi,
            this.colIptalNedeniId,
            this.colNedeniAdi,
            this.colGittigiOkulId,
            this.colGittigiOkulAdi,
            this.colIptalAciklama});
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
            this.colIslemTarihi.Caption = "İşlem Tarihi";
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
            this.colIslemTarihi.VisibleIndex = 1;
            this.colIslemTarihi.Width = 100;
            // 
            // colBaslamaTarihi
            // 
            this.colBaslamaTarihi.Caption = "Başlama Tarihi";
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
            this.colBaslamaTarihi.VisibleIndex = 2;
            this.colBaslamaTarihi.Width = 100;
            // 
            // colBrutUcret
            // 
            this.colBrutUcret.Caption = "Brüt Ücret";
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
            this.colBrutUcret.VisibleIndex = 3;
            this.colBrutUcret.Width = 100;
            // 
            // colKistDusulenUcret
            // 
            this.colKistDusulenUcret.Caption = "Kıst Dönem Düşülen Ücret";
            this.colKistDusulenUcret.FieldName = "KistDusulenUcret";
            this.colKistDusulenUcret.Name = "colKistDusulenUcret";
            this.colKistDusulenUcret.OptionsColumn.AllowEdit = false;
            this.colKistDusulenUcret.OptionsColumn.AllowMove = false;
            this.colKistDusulenUcret.OptionsColumn.AllowShowHide = false;
            this.colKistDusulenUcret.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colKistDusulenUcret.OptionsFilter.AllowAutoFilter = false;
            this.colKistDusulenUcret.OptionsFilter.AllowFilter = false;
            this.colKistDusulenUcret.StatusBarAciklama = null;
            this.colKistDusulenUcret.StatusBarKisayol = null;
            this.colKistDusulenUcret.StatusBarKisayolAciklama = null;
            this.colKistDusulenUcret.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "KistDusulenUcret", "{0:n2}")});
            this.colKistDusulenUcret.Visible = true;
            this.colKistDusulenUcret.VisibleIndex = 4;
            this.colKistDusulenUcret.Width = 100;
            // 
            // colNetUcret
            // 
            this.colNetUcret.Caption = "Net Ücret";
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
            this.colNetUcret.VisibleIndex = 5;
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
            this.colEgitimDonemiGunSayisi.Width = 100;
            // 
            // colAlinanHizmetGunSayisi
            // 
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
            this.colAlinanHizmetGunSayisi.Width = 100;
            // 
            // colGunlukUcret
            // 
            this.colGunlukUcret.Caption = "Günlük Ücret";
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
            this.colGunlukUcret.Width = 100;
            // 
            // colIptalTarihi
            // 
            this.colIptalTarihi.Caption = "İptal Tarihi";
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
            // colNedeniAdi
            // 
            this.colNedeniAdi.Caption = "İptal Nedeni";
            this.colNedeniAdi.FieldName = "IptalNedeniAdi";
            this.colNedeniAdi.Name = "colNedeniAdi";
            this.colNedeniAdi.OptionsColumn.AllowEdit = false;
            this.colNedeniAdi.OptionsColumn.AllowMove = false;
            this.colNedeniAdi.OptionsColumn.AllowShowHide = false;
            this.colNedeniAdi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colNedeniAdi.OptionsFilter.AllowAutoFilter = false;
            this.colNedeniAdi.OptionsFilter.AllowFilter = false;
            this.colNedeniAdi.StatusBarAciklama = null;
            this.colNedeniAdi.StatusBarKisayol = null;
            this.colNedeniAdi.StatusBarKisayolAciklama = null;
            this.colNedeniAdi.Visible = true;
            this.colNedeniAdi.VisibleIndex = 10;
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
            this.colGittigiOkulAdi.Width = 150;
            // 
            // colIptalAciklama
            // 
            this.colIptalAciklama.Caption = "Açıklama";
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
        private Grid.MyGridColumn colKistDusulenUcret;
        private Grid.MyGridColumn colNetUcret;
        private Grid.MyGridColumn colIptalEdildi;
        private Grid.MyGridColumn colEgitimDonemiGunSayisi;
        private Grid.MyGridColumn colAlinanHizmetGunSayisi;
        private Grid.MyGridColumn colGunlukUcret;
        private Grid.MyGridColumn colIptalTarihi;
        private Grid.MyGridColumn colIptalNedeniId;
        private Grid.MyGridColumn colNedeniAdi;
        private Grid.MyGridColumn colGittigiOkulId;
        private Grid.MyGridColumn colGittigiOkulAdi;
        private Grid.MyGridColumn colIptalAciklama;
    }
}
