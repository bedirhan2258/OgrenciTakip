namespace OgrenciTakip.UI.Win.Forms.SchoolForms
{
    partial class OkulKartlari
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
            this.barInsert = new DevExpress.XtraBars.BarStaticItem();
            this.barInsertAciklama = new DevExpress.XtraBars.BarStaticItem();
            this.barDelete = new DevExpress.XtraBars.BarStaticItem();
            this.barDeleteAciklama = new DevExpress.XtraBars.BarStaticItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barInsert,
            this.barInsertAciklama,
            this.barDelete,
            this.barDeleteAciklama});
            this.ribbonControl.MaxItemId = 16;
            this.ribbonControl.Size = new System.Drawing.Size(1122, 102);
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // barInsert
            // 
            this.barInsert.Caption = "Insert :";
            this.barInsert.Id = 12;
            this.barInsert.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.barInsert.ItemAppearance.Normal.ForeColor = System.Drawing.Color.DarkBlue;
            this.barInsert.ItemAppearance.Normal.Options.UseFont = true;
            this.barInsert.ItemAppearance.Normal.Options.UseForeColor = true;
            this.barInsert.Name = "barInsert";
            // 
            // barInsertAciklama
            // 
            this.barInsertAciklama.Caption = "Yeni";
            this.barInsertAciklama.Id = 13;
            this.barInsertAciklama.Name = "barInsertAciklama";
            // 
            // barDelete
            // 
            this.barDelete.Caption = "Delete :";
            this.barDelete.Id = 14;
            this.barDelete.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.barDelete.ItemAppearance.Normal.ForeColor = System.Drawing.Color.DarkBlue;
            this.barDelete.ItemAppearance.Normal.Options.UseFont = true;
            this.barDelete.ItemAppearance.Normal.Options.UseForeColor = true;
            this.barDelete.Name = "barDelete";
            // 
            // barDeleteAciklama
            // 
            this.barDeleteAciklama.Caption = "Sil";
            this.barDeleteAciklama.Id = 15;
            this.barDeleteAciklama.Name = "barDeleteAciklama";
            // 
            // OkulKartlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1122, 412);
            this.Name = "OkulKartlari";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Grid.MyGridControl grid;
        private UserControls.Grid.MyGridView tablo;
        private UserControls.Grid.MyGridColumn colId;
        private UserControls.Grid.MyGridColumn colKod;
        private UserControls.Navigators.LongNavigator longNavigator1;
        private UserControls.Grid.MyGridColumn colOkulAdi;
        private UserControls.Grid.MyGridColumn colIlAdi;
        private UserControls.Grid.MyGridColumn colIlce;
        private UserControls.Grid.MyGridColumn colAciklama;
        private DevExpress.XtraBars.BarStaticItem barInsert;
        private DevExpress.XtraBars.BarStaticItem barInsertAciklama;
        private DevExpress.XtraBars.BarStaticItem barDelete;
        private DevExpress.XtraBars.BarStaticItem barDeleteAciklama;
    }
}