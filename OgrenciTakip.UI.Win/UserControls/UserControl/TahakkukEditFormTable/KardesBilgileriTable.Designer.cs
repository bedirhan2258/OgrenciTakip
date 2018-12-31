namespace OgrenciTakip.UI.Win.UserControls.UserControl.TahakkukEditFormTable
{
    partial class KardesBilgileriTable
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
            this.colSinifAdi = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colKayitSekli = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colKayitDurumu = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colIptalDurumu = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colSubeAdi = new OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
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
            this.grid.Size = new System.Drawing.Size(830, 304);
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
            this.colSinifAdi,
            this.colKayitSekli,
            this.colKayitDurumu,
            this.colIptalDurumu,
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
            this.tablo.OptionsView.ShowGroupPanel = false;
            this.tablo.OptionsView.ShowViewCaption = true;
            this.tablo.StatusBarAciklama = null;
            this.tablo.StatusBarKisayol = null;
            this.tablo.StatusBarKisayolAciklama = null;
            this.tablo.ViewCaption = "Kardeş Bilgileri";
            // 
            // colAdi
            // 
            this.colAdi.AppearanceCell.Options.UseTextOptions = true;
            this.colAdi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAdi.Caption = "Adı";
            this.colAdi.FieldName = "Adi";
            this.colAdi.Name = "colAdi";
            this.colAdi.OptionsColumn.AllowEdit = false;
            this.colAdi.StatusBarAciklama = null;
            this.colAdi.StatusBarKisayol = null;
            this.colAdi.StatusBarKisayolAciklama = null;
            this.colAdi.Visible = true;
            this.colAdi.VisibleIndex = 0;
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
            this.colSoyadi.VisibleIndex = 1;
            this.colSoyadi.Width = 100;
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
            this.colSinifAdi.VisibleIndex = 2;
            this.colSinifAdi.Width = 100;
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
            this.colKayitSekli.VisibleIndex = 3;
            this.colKayitSekli.Width = 100;
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
            this.colKayitDurumu.VisibleIndex = 4;
            this.colKayitDurumu.Width = 100;
            // 
            // colIptalDurumu
            // 
            this.colIptalDurumu.Caption = "İptal Durumu";
            this.colIptalDurumu.FieldName = "IptalDurumu";
            this.colIptalDurumu.Name = "colIptalDurumu";
            this.colIptalDurumu.OptionsColumn.AllowEdit = false;
            this.colIptalDurumu.StatusBarAciklama = null;
            this.colIptalDurumu.StatusBarKisayol = null;
            this.colIptalDurumu.StatusBarKisayolAciklama = null;
            this.colIptalDurumu.Visible = true;
            this.colIptalDurumu.VisibleIndex = 5;
            this.colIptalDurumu.Width = 100;
            // 
            // colSubeAdi
            // 
            this.colSubeAdi.Caption = "Şube";
            this.colSubeAdi.FieldName = "SubeAdi";
            this.colSubeAdi.Name = "colSubeAdi";
            this.colSubeAdi.OptionsColumn.AllowEdit = false;
            this.colSubeAdi.StatusBarAciklama = null;
            this.colSubeAdi.StatusBarKisayol = null;
            this.colSubeAdi.StatusBarKisayolAciklama = null;
            this.colSubeAdi.Visible = true;
            this.colSubeAdi.VisibleIndex = 6;
            this.colSubeAdi.Width = 200;
            // 
            // KardesBilgileriTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid);
            this.Name = "KardesBilgileriTable";
            this.Size = new System.Drawing.Size(830, 328);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Grid.MyGridControl grid;
        private Grid.MyGridView tablo;
        private Grid.MyGridColumn colAdi;
        private Grid.MyGridColumn colSoyadi;
        private Grid.MyGridColumn colSinifAdi;
        private Grid.MyGridColumn colKayitSekli;
        private Grid.MyGridColumn colKayitDurumu;
        private Grid.MyGridColumn colIptalDurumu;
        private Grid.MyGridColumn colSubeAdi;
    }
}
