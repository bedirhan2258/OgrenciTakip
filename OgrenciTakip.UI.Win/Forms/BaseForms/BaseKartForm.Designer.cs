namespace OgrenciTakip.UI.Win.Forms.BaseForms
{
    partial class BaseKartForm
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
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.btnYeni = new DevExpress.XtraBars.BarButtonItem();
            this.btnKaydet = new DevExpress.XtraBars.BarButtonItem();
            this.btnGeriAl = new DevExpress.XtraBars.BarButtonItem();
            this.btnSil = new DevExpress.XtraBars.BarButtonItem();
            this.btnCikis = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.DrawGroupCaptions = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.DrawGroupsBorderMode = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.btnYeni,
            this.btnKaydet,
            this.btnGeriAl,
            this.btnSil,
            this.btnCikis});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 6;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.ShowCategoryInCaption = false;
            this.ribbonControl.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl.ShowQatLocationSelector = false;
            this.ribbonControl.ShowToolbarCustomizeItem = false;
            this.ribbonControl.Size = new System.Drawing.Size(849, 102);
            this.ribbonControl.StatusBar = this.ribbonStatusBar1;
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            this.ribbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnYeni);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnKaydet);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnGeriAl);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnSil);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnCikis);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 472);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(849, 31);
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // btnYeni
            // 
            this.btnYeni.Caption = "Yeni";
            this.btnYeni.Id = 1;
            this.btnYeni.ImageOptions.Image = global::OgrenciTakip.UI.Win.Properties.Resources.addfile_16x16;
            this.btnYeni.ImageOptions.LargeImage = global::OgrenciTakip.UI.Win.Properties.Resources.addfile_32x32;
            this.btnYeni.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Insert));
            this.btnYeni.Name = "btnYeni";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Caption = "Kaydet";
            this.btnKaydet.Id = 2;
            this.btnKaydet.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F2);
            this.btnKaydet.Name = "btnKaydet";
            // 
            // btnGeriAl
            // 
            this.btnGeriAl.Caption = "Geri Al";
            this.btnGeriAl.Id = 3;
            this.btnGeriAl.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z));
            this.btnGeriAl.Name = "btnGeriAl";
            // 
            // btnSil
            // 
            this.btnSil.Caption = "Sil";
            this.btnSil.Id = 4;
            this.btnSil.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Delete));
            this.btnSil.Name = "btnSil";
            // 
            // btnCikis
            // 
            this.btnCikis.Caption = "Çıkış";
            this.btnCikis.Id = 5;
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.ShortcutKeyDisplayString = "Esc";
            // 
            // BaseKartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 503);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl);
            this.MaximizeBox = false;
            this.Name = "BaseKartForm";
            this.Ribbon = this.ribbonControl;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StatusBar = this.ribbonStatusBar1;
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.BarButtonItem btnYeni;
        private DevExpress.XtraBars.BarButtonItem btnKaydet;
        private DevExpress.XtraBars.BarButtonItem btnGeriAl;
        private DevExpress.XtraBars.BarButtonItem btnSil;
        private DevExpress.XtraBars.BarButtonItem btnCikis;
    }
}