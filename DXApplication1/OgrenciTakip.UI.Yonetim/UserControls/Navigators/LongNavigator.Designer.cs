namespace OgrenciTakip.UI.Yonetim.UserControls.Navigators
{
    partial class LongNavigator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LongNavigator));
            this.imageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.Navigator = new DevExpress.XtraEditors.ControlNavigator();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).BeginInit();
            this.SuspendLayout();
            // 
            // imageCollection
            // 
            this.imageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection.ImageStream")));
            this.imageCollection.InsertImage(global::OgrenciTakip.UI.Yonetim.Properties.Resources.first_16x166, "first_16x166", typeof(global::OgrenciTakip.UI.Yonetim.Properties.Resources), 0);
            this.imageCollection.Images.SetKeyName(0, "first_16x166");
            this.imageCollection.InsertImage(global::OgrenciTakip.UI.Yonetim.Properties.Resources.doubleprev_16x164, "doubleprev_16x164", typeof(global::OgrenciTakip.UI.Yonetim.Properties.Resources), 1);
            this.imageCollection.Images.SetKeyName(1, "doubleprev_16x164");
            this.imageCollection.InsertImage(global::OgrenciTakip.UI.Yonetim.Properties.Resources.prev_16x165, "prev_16x165", typeof(global::OgrenciTakip.UI.Yonetim.Properties.Resources), 2);
            this.imageCollection.Images.SetKeyName(2, "prev_16x165");
            this.imageCollection.InsertImage(global::OgrenciTakip.UI.Yonetim.Properties.Resources.next_16x165, "next_16x165", typeof(global::OgrenciTakip.UI.Yonetim.Properties.Resources), 3);
            this.imageCollection.Images.SetKeyName(3, "next_16x165");
            this.imageCollection.InsertImage(global::OgrenciTakip.UI.Yonetim.Properties.Resources.doublenext_16x164, "doublenext_16x164", typeof(global::OgrenciTakip.UI.Yonetim.Properties.Resources), 4);
            this.imageCollection.Images.SetKeyName(4, "doublenext_16x164");
            this.imageCollection.InsertImage(global::OgrenciTakip.UI.Yonetim.Properties.Resources.last_16x165, "last_16x165", typeof(global::OgrenciTakip.UI.Yonetim.Properties.Resources), 5);
            this.imageCollection.Images.SetKeyName(5, "last_16x165");
            this.imageCollection.InsertImage(global::OgrenciTakip.UI.Yonetim.Properties.Resources.print_16x16, "print_16x16", typeof(global::OgrenciTakip.UI.Yonetim.Properties.Resources), 6);
            this.imageCollection.Images.SetKeyName(6, "print_16x16");
            this.imageCollection.InsertImage(global::OgrenciTakip.UI.Yonetim.Properties.Resources.saveall_16x16, "saveall_16x16", typeof(global::OgrenciTakip.UI.Yonetim.Properties.Resources), 7);
            this.imageCollection.Images.SetKeyName(7, "saveall_16x16");
            this.imageCollection.InsertImage(global::OgrenciTakip.UI.Yonetim.Properties.Resources.printpreview_16x16, "printpreview_16x16", typeof(global::OgrenciTakip.UI.Yonetim.Properties.Resources), 8);
            this.imageCollection.Images.SetKeyName(8, "printpreview_16x16");
            this.imageCollection.InsertImage(global::OgrenciTakip.UI.Yonetim.Properties.Resources.insertrangefilter_16x16, "insertrangefilter_16x16", typeof(global::OgrenciTakip.UI.Yonetim.Properties.Resources), 9);
            this.imageCollection.Images.SetKeyName(9, "insertrangefilter_16x16");
            this.imageCollection.InsertImage(global::OgrenciTakip.UI.Yonetim.Properties.Resources.saveall_32x32, "saveall_32x32", typeof(global::OgrenciTakip.UI.Yonetim.Properties.Resources), 10);
            this.imageCollection.Images.SetKeyName(10, "saveall_32x32");
            this.imageCollection.InsertImage(global::OgrenciTakip.UI.Yonetim.Properties.Resources.print_32x32, "print_32x32", typeof(global::OgrenciTakip.UI.Yonetim.Properties.Resources), 11);
            this.imageCollection.Images.SetKeyName(11, "print_32x32");
            this.imageCollection.InsertImage(global::OgrenciTakip.UI.Yonetim.Properties.Resources.printpreview_32x32, "printpreview_32x32", typeof(global::OgrenciTakip.UI.Yonetim.Properties.Resources), 12);
            this.imageCollection.Images.SetKeyName(12, "printpreview_32x32");
            this.imageCollection.InsertImage(global::OgrenciTakip.UI.Yonetim.Properties.Resources.insertrangefilter_32x32, "insertrangefilter_32x32", typeof(global::OgrenciTakip.UI.Yonetim.Properties.Resources), 13);
            this.imageCollection.Images.SetKeyName(13, "insertrangefilter_32x32");
            // 
            // Navigator
            // 
            this.Navigator.Appearance.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Navigator.Appearance.Options.UseForeColor = true;
            this.Navigator.Buttons.Append.Visible = false;
            this.Navigator.Buttons.CancelEdit.Visible = false;
            this.Navigator.Buttons.Edit.Visible = false;
            this.Navigator.Buttons.EndEdit.Visible = false;
            this.Navigator.Buttons.First.ImageIndex = 0;
            this.Navigator.Buttons.ImageList = this.imageCollection;
            this.Navigator.Buttons.Last.ImageIndex = 5;
            this.Navigator.Buttons.Next.ImageIndex = 3;
            this.Navigator.Buttons.NextPage.ImageIndex = 4;
            this.Navigator.Buttons.Prev.ImageIndex = 2;
            this.Navigator.Buttons.PrevPage.ImageIndex = 1;
            this.Navigator.Buttons.Remove.Visible = false;
            this.Navigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Navigator.Location = new System.Drawing.Point(0, 0);
            this.Navigator.Name = "Navigator";
            this.Navigator.Size = new System.Drawing.Size(579, 24);
            this.Navigator.TabIndex = 0;
            this.Navigator.Text = "controlNavigator1";
            this.Navigator.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Begin;
            this.Navigator.TextStringFormat = "Kartlar ( {0} / {1} )";
            // 
            // LongNavigator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Navigator);
            this.Name = "LongNavigator";
            this.Size = new System.Drawing.Size(579, 24);
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.ImageCollection imageCollection;
        protected internal DevExpress.XtraEditors.ControlNavigator Navigator;
    }
}
