namespace OgrenciTakip.UI.Win.UserControls.UserControl.TahakkukEditFormTable
{
    partial class EposBilgileriTable
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
            this.colAdi = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colSoyadi = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colBankaId = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colBankaAdi = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.repositoryBanka = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colKartTuru = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.repositoryKartTuru = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.colKartNo = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.repositoryKartNo = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colSonKullanmaTarihi = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.repositorySonKullanmaTarihi = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colGuvenlikKodu = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.repositoryGuvenlikKodu = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryBanka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryKartTuru)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryKartNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositorySonKullanmaTarihi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryGuvenlikKodu)).BeginInit();
            this.SuspendLayout();
            // 
            // insUptNavigator
            // 
            this.insUptNavigator.Location = new System.Drawing.Point(0, 318);
            this.insUptNavigator.Size = new System.Drawing.Size(708, 24);
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 0);
            this.grid.MainView = this.tablo;
            this.grid.Name = "grid";
            this.grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryBanka,
            this.repositoryKartTuru,
            this.repositoryKartNo,
            this.repositorySonKullanmaTarihi,
            this.repositoryGuvenlikKodu});
            this.grid.Size = new System.Drawing.Size(708, 318);
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
            this.colAdi,
            this.colSoyadi,
            this.colBankaId,
            this.colBankaAdi,
            this.colKartTuru,
            this.colKartNo,
            this.colSonKullanmaTarihi,
            this.colGuvenlikKodu});
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
            this.tablo.StatusBarAciklama = "Epos Bilgileri Giriniz.";
            this.tablo.StatusBarKisayol = "Shift + Insert";
            this.tablo.StatusBarKisayolAciklama = "Bilgi Giriniz.";
            this.tablo.ViewCaption = "Epos Bilgileri";
            // 
            // colAdi
            // 
            this.colAdi.Caption = "Adı";
            this.colAdi.FieldName = "Adi";
            this.colAdi.Name = "colAdi";
            this.colAdi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colAdi.OptionsFilter.AllowAutoFilter = false;
            this.colAdi.OptionsFilter.AllowFilter = false;
            this.colAdi.StatusBarAciklama = "Kart Sahibinin Adını Giriniz.";
            this.colAdi.StatusBarKisayol = null;
            this.colAdi.StatusBarKisayolAciklama = null;
            this.colAdi.Visible = true;
            this.colAdi.VisibleIndex = 0;
            this.colAdi.Width = 110;
            // 
            // colSoyadi
            // 
            this.colSoyadi.Caption = "Soyadi";
            this.colSoyadi.FieldName = "Soyadi";
            this.colSoyadi.Name = "colSoyadi";
            this.colSoyadi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colSoyadi.OptionsFilter.AllowAutoFilter = false;
            this.colSoyadi.OptionsFilter.AllowFilter = false;
            this.colSoyadi.StatusBarAciklama = "Kart Sahibinin Soyadını Giriniz.";
            this.colSoyadi.StatusBarKisayol = null;
            this.colSoyadi.StatusBarKisayolAciklama = null;
            this.colSoyadi.Visible = true;
            this.colSoyadi.VisibleIndex = 1;
            this.colSoyadi.Width = 110;
            // 
            // colBankaId
            // 
            this.colBankaId.Caption = "BankaId";
            this.colBankaId.FieldName = "BankaId";
            this.colBankaId.Name = "colBankaId";
            this.colBankaId.OptionsColumn.AllowEdit = false;
            this.colBankaId.OptionsColumn.ShowInCustomizationForm = false;
            this.colBankaId.StatusBarAciklama = null;
            this.colBankaId.StatusBarKisayol = null;
            this.colBankaId.StatusBarKisayolAciklama = null;
            // 
            // colBankaAdi
            // 
            this.colBankaAdi.Caption = "Banka";
            this.colBankaAdi.ColumnEdit = this.repositoryBanka;
            this.colBankaAdi.FieldName = "BankaAdi";
            this.colBankaAdi.Name = "colBankaAdi";
            this.colBankaAdi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colBankaAdi.OptionsFilter.AllowAutoFilter = false;
            this.colBankaAdi.OptionsFilter.AllowFilter = false;
            this.colBankaAdi.StatusBarAciklama = "Banka Seçiniz.";
            this.colBankaAdi.StatusBarKisayol = "F4 :";
            this.colBankaAdi.StatusBarKisayolAciklama = "Seçim Yap.";
            this.colBankaAdi.Visible = true;
            this.colBankaAdi.VisibleIndex = 2;
            this.colBankaAdi.Width = 150;
            // 
            // repositoryBanka
            // 
            this.repositoryBanka.AutoHeight = false;
            this.repositoryBanka.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryBanka.Name = "repositoryBanka";
            this.repositoryBanka.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // colKartTuru
            // 
            this.colKartTuru.AppearanceCell.Options.UseTextOptions = true;
            this.colKartTuru.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKartTuru.Caption = "Kart Türü";
            this.colKartTuru.ColumnEdit = this.repositoryKartTuru;
            this.colKartTuru.FieldName = "KartTuru";
            this.colKartTuru.Name = "colKartTuru";
            this.colKartTuru.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colKartTuru.OptionsFilter.AllowAutoFilter = false;
            this.colKartTuru.OptionsFilter.AllowFilter = false;
            this.colKartTuru.StatusBarAciklama = "Kart Türü Seçiniz.";
            this.colKartTuru.StatusBarKisayol = "F4 :";
            this.colKartTuru.StatusBarKisayolAciklama = "Seçim Yap.";
            this.colKartTuru.Visible = true;
            this.colKartTuru.VisibleIndex = 3;
            this.colKartTuru.Width = 110;
            // 
            // repositoryKartTuru
            // 
            this.repositoryKartTuru.AutoHeight = false;
            this.repositoryKartTuru.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryKartTuru.Name = "repositoryKartTuru";
            // 
            // colKartNo
            // 
            this.colKartNo.Caption = "Kart No";
            this.colKartNo.ColumnEdit = this.repositoryKartNo;
            this.colKartNo.FieldName = "KartNo";
            this.colKartNo.Name = "colKartNo";
            this.colKartNo.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colKartNo.OptionsFilter.AllowAutoFilter = false;
            this.colKartNo.OptionsFilter.AllowFilter = false;
            this.colKartNo.StatusBarAciklama = "Kart Numarasını Giriniz.";
            this.colKartNo.StatusBarKisayol = null;
            this.colKartNo.StatusBarKisayolAciklama = null;
            this.colKartNo.Visible = true;
            this.colKartNo.VisibleIndex = 4;
            this.colKartNo.Width = 130;
            // 
            // repositoryKartNo
            // 
            this.repositoryKartNo.AutoHeight = false;
            this.repositoryKartNo.Mask.EditMask = "\\d?\\d?\\d?\\d?-\\d?\\d?\\d?\\d?-\\d?\\d?\\d?\\d?-\\d?\\d?\\d?\\d?";
            this.repositoryKartNo.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
            this.repositoryKartNo.Name = "repositoryKartNo";
            // 
            // colSonKullanmaTarihi
            // 
            this.colSonKullanmaTarihi.AppearanceCell.Options.UseTextOptions = true;
            this.colSonKullanmaTarihi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSonKullanmaTarihi.Caption = "Son Kullanma Tarihi";
            this.colSonKullanmaTarihi.ColumnEdit = this.repositorySonKullanmaTarihi;
            this.colSonKullanmaTarihi.FieldName = "SonKullanmaTarihi";
            this.colSonKullanmaTarihi.Name = "colSonKullanmaTarihi";
            this.colSonKullanmaTarihi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colSonKullanmaTarihi.OptionsFilter.AllowAutoFilter = false;
            this.colSonKullanmaTarihi.OptionsFilter.AllowFilter = false;
            this.colSonKullanmaTarihi.StatusBarAciklama = "Son Kullanma Tarihini Giriniz.";
            this.colSonKullanmaTarihi.StatusBarKisayol = null;
            this.colSonKullanmaTarihi.StatusBarKisayolAciklama = null;
            this.colSonKullanmaTarihi.Visible = true;
            this.colSonKullanmaTarihi.VisibleIndex = 5;
            this.colSonKullanmaTarihi.Width = 110;
            // 
            // repositorySonKullanmaTarihi
            // 
            this.repositorySonKullanmaTarihi.AutoHeight = false;
            this.repositorySonKullanmaTarihi.Mask.EditMask = "(0?[1-9]|1[012])/([123][0-9])?[0-9][0-9]";
            this.repositorySonKullanmaTarihi.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.repositorySonKullanmaTarihi.Name = "repositorySonKullanmaTarihi";
            // 
            // colGuvenlikKodu
            // 
            this.colGuvenlikKodu.Caption = "GüvenlikKodu";
            this.colGuvenlikKodu.ColumnEdit = this.repositoryGuvenlikKodu;
            this.colGuvenlikKodu.FieldName = "GuvenlikKodu";
            this.colGuvenlikKodu.Name = "colGuvenlikKodu";
            this.colGuvenlikKodu.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colGuvenlikKodu.OptionsFilter.AllowAutoFilter = false;
            this.colGuvenlikKodu.OptionsFilter.AllowFilter = false;
            this.colGuvenlikKodu.StatusBarAciklama = null;
            this.colGuvenlikKodu.StatusBarKisayol = null;
            this.colGuvenlikKodu.StatusBarKisayolAciklama = null;
            this.colGuvenlikKodu.Visible = true;
            this.colGuvenlikKodu.VisibleIndex = 6;
            this.colGuvenlikKodu.Width = 90;
            // 
            // repositoryGuvenlikKodu
            // 
            this.repositoryGuvenlikKodu.AutoHeight = false;
            this.repositoryGuvenlikKodu.Mask.EditMask = "\\d\\d\\d";
            this.repositoryGuvenlikKodu.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.repositoryGuvenlikKodu.Name = "repositoryGuvenlikKodu";
            // 
            // EposBilgileriTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid);
            this.Name = "EposBilgileriTable";
            this.Size = new System.Drawing.Size(708, 342);
            this.Controls.SetChildIndex(this.insUptNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryBanka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryKartTuru)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryKartNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositorySonKullanmaTarihi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryGuvenlikKodu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Grid.MyGridControl grid;
        private Grid.MyGridView tablo;
        private Grid.MyGridColumn colAdi;
        private Grid.MyGridColumn colSoyadi;
        private Grid.MyGridColumn colBankaId;
        private Grid.MyGridColumn colBankaAdi;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryBanka;
        private Grid.MyGridColumn colKartTuru;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryKartTuru;
        private Grid.MyGridColumn colKartNo;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryKartNo;
        private Grid.MyGridColumn colSonKullanmaTarihi;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositorySonKullanmaTarihi;
        protected internal DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryGuvenlikKodu;
        private Grid.MyGridColumn colGuvenlikKodu;
    }
}
