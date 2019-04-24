namespace OgrenciTakip.UI.Yonetim.UserControls.Navigators
{
    partial class InsUptNavigator
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsUptNavigator));
            this.Navigator = new DevExpress.XtraEditors.ControlNavigator();
            this.imageCollection = new DevExpress.Utils.ImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).BeginInit();
            this.SuspendLayout();
            // 
            // Navigator
            // 
            this.Navigator.Buttons.Append.ImageIndex = 6;
            this.Navigator.Buttons.CancelEdit.Visible = false;
            this.Navigator.Buttons.Edit.Visible = false;
            this.Navigator.Buttons.EndEdit.Visible = false;
            this.Navigator.Buttons.First.ImageIndex = 0;
            this.Navigator.Buttons.ImageList = this.imageCollection;
            this.Navigator.Buttons.Last.ImageIndex = 5;
            this.Navigator.Buttons.Next.ImageIndex = 3;
            this.Navigator.Buttons.NextPage.ImageIndex = 4;
            this.Navigator.Buttons.NextPage.Visible = false;
            this.Navigator.Buttons.Prev.ImageIndex = 2;
            this.Navigator.Buttons.PrevPage.ImageIndex = 1;
            this.Navigator.Buttons.PrevPage.Visible = false;
            this.Navigator.Buttons.Remove.ImageIndex = 7;
            this.Navigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Navigator.Location = new System.Drawing.Point(0, 0);
            this.Navigator.Name = "Navigator";
            this.Navigator.Size = new System.Drawing.Size(594, 24);
            this.Navigator.TabIndex = 0;
            this.Navigator.Text = "controlNavigator1";
            // 
            // imageCollection
            // 
            this.imageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection.ImageStream")));
            this.imageCollection.InsertImage(global::OgrenciTakip.UI.Yonetim.Properties.Resources.first_16x168, "first_16x168", typeof(global::OgrenciTakip.UI.Yonetim.Properties.Resources), 0);
            this.imageCollection.Images.SetKeyName(0, "first_16x168");
            this.imageCollection.InsertImage(global::OgrenciTakip.UI.Yonetim.Properties.Resources.doubleprev_16x165, "doubleprev_16x165", typeof(global::OgrenciTakip.UI.Yonetim.Properties.Resources), 1);
            this.imageCollection.Images.SetKeyName(1, "doubleprev_16x165");
            this.imageCollection.InsertImage(global::OgrenciTakip.UI.Yonetim.Properties.Resources.prev_16x167, "prev_16x167", typeof(global::OgrenciTakip.UI.Yonetim.Properties.Resources), 2);
            this.imageCollection.Images.SetKeyName(2, "prev_16x167");
            this.imageCollection.InsertImage(global::OgrenciTakip.UI.Yonetim.Properties.Resources.next_16x167, "next_16x167", typeof(global::OgrenciTakip.UI.Yonetim.Properties.Resources), 3);
            this.imageCollection.Images.SetKeyName(3, "next_16x167");
            this.imageCollection.InsertImage(global::OgrenciTakip.UI.Yonetim.Properties.Resources.doublenext_16x165, "doublenext_16x165", typeof(global::OgrenciTakip.UI.Yonetim.Properties.Resources), 4);
            this.imageCollection.Images.SetKeyName(4, "doublenext_16x165");
            this.imageCollection.InsertImage(global::OgrenciTakip.UI.Yonetim.Properties.Resources.last_16x167, "last_16x167", typeof(global::OgrenciTakip.UI.Yonetim.Properties.Resources), 5);
            this.imageCollection.Images.SetKeyName(5, "last_16x167");
            this.imageCollection.InsertImage(global::OgrenciTakip.UI.Yonetim.Properties.Resources.addfile_16x16, "addfile_16x16", typeof(global::OgrenciTakip.UI.Yonetim.Properties.Resources), 6);
            this.imageCollection.Images.SetKeyName(6, "addfile_16x16");
            this.imageCollection.InsertImage(global::OgrenciTakip.UI.Yonetim.Properties.Resources.deletelist_16x16, "deletelist_16x16", typeof(global::OgrenciTakip.UI.Yonetim.Properties.Resources), 7);
            this.imageCollection.Images.SetKeyName(7, "deletelist_16x16");
            // 
            // InsUptNavigator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Navigator);
            this.Name = "InsUptNavigator";
            this.Size = new System.Drawing.Size(594, 24);
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.ControlNavigator Navigator;
        private DevExpress.Utils.ImageCollection imageCollection;
    }
}
