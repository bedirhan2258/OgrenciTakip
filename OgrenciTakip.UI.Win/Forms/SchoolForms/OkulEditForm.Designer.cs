namespace OgrenciTakip.UI.Win.Forms.SchoolForms
{
    partial class OkulEditForm
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
            DevExpress.XtraLayout.ColumnDefinition columnDefinition1 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition2 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition3 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition1 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition2 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition3 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition4 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition5 = new DevExpress.XtraLayout.RowDefinition();
            this.myDataLayoutControl = new OgrenciTakip.UI.Win.UserControls.Controls.MyDataLayoutControl();
            this.tglDurum = new OgrenciTakip.UI.Win.UserControls.Controls.MyToggleSwitch();
            this.memoAciklama = new OgrenciTakip.UI.Win.UserControls.Controls.MyMemoEdit();
            this.btnIlce = new OgrenciTakip.UI.Win.UserControls.Controls.MyButtonEdit();
            this.btnIl = new OgrenciTakip.UI.Win.UserControls.Controls.MyButtonEdit();
            this.txtOkulAdi = new OgrenciTakip.UI.Win.UserControls.Controls.MyTextEdit();
            this.txtKod = new OgrenciTakip.UI.Win.UserControls.Controls.MyKodTextEdit();
            this.layoutControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtIl = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtAciklama = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl)).BeginInit();
            this.myDataLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tglDurum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoAciklama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnIlce.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnIl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOkulAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Size = new System.Drawing.Size(390, 102);
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // myDataLayoutControl
            // 
            this.myDataLayoutControl.Controls.Add(this.tglDurum);
            this.myDataLayoutControl.Controls.Add(this.memoAciklama);
            this.myDataLayoutControl.Controls.Add(this.btnIlce);
            this.myDataLayoutControl.Controls.Add(this.btnIl);
            this.myDataLayoutControl.Controls.Add(this.txtOkulAdi);
            this.myDataLayoutControl.Controls.Add(this.txtKod);
            this.myDataLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myDataLayoutControl.Location = new System.Drawing.Point(0, 102);
            this.myDataLayoutControl.Name = "myDataLayoutControl";
            this.myDataLayoutControl.OptionsFocus.EnableAutoTabOrder = false;
            this.myDataLayoutControl.Root = this.layoutControlGroup;
            this.myDataLayoutControl.Size = new System.Drawing.Size(390, 176);
            this.myDataLayoutControl.TabIndex = 0;
            this.myDataLayoutControl.Text = "myDataLayoutControl1";
            // 
            // tglDurum
            // 
            this.tglDurum.EnterMoveNextControl = true;
            this.tglDurum.Location = new System.Drawing.Point(283, 12);
            this.tglDurum.MenuManager = this.ribbonControl;
            this.tglDurum.Name = "tglDurum";
            this.tglDurum.Properties.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.tglDurum.Properties.Appearance.Options.UseForeColor = true;
            this.tglDurum.Properties.AutoHeight = false;
            this.tglDurum.Properties.AutoWidth = true;
            this.tglDurum.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.tglDurum.Properties.OffText = "Pasif";
            this.tglDurum.Properties.OnText = "Aktif";
            this.tglDurum.Size = new System.Drawing.Size(97, 20);
            this.tglDurum.StatusBarAciklama = "Kartın Kullanım Durumunu Seçiniz.";
            this.tglDurum.StyleController = this.myDataLayoutControl;
            this.tglDurum.TabIndex = 4;
            // 
            // memoAciklama
            // 
            this.memoAciklama.EnterMoveNextControl = true;
            this.memoAciklama.Location = new System.Drawing.Point(63, 108);
            this.memoAciklama.MenuManager = this.ribbonControl;
            this.memoAciklama.Name = "memoAciklama";
            this.memoAciklama.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.memoAciklama.Properties.Appearance.Options.UseBackColor = true;
            this.memoAciklama.Properties.MaxLength = 500;
            this.memoAciklama.Size = new System.Drawing.Size(315, 56);
            this.memoAciklama.StatusBarAciklama = "Aciklama Griniz.";
            this.memoAciklama.StyleController = this.myDataLayoutControl;
            this.memoAciklama.TabIndex = 3;
            // 
            // btnIlce
            // 
            this.btnIlce.EnterMoveNextControl = true;
            this.btnIlce.Id = null;
            this.btnIlce.Location = new System.Drawing.Point(63, 84);
            this.btnIlce.MenuManager = this.ribbonControl;
            this.btnIlce.Name = "btnIlce";
            this.btnIlce.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.btnIlce.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.btnIlce.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnIlce.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.btnIlce.Size = new System.Drawing.Size(145, 20);
            this.btnIlce.StatusBarAciklama = "İlçe Seçiniz.";
            this.btnIlce.StatusBarKisayol = "F4 :";
            this.btnIlce.StatusBarKisayolAciklama = "İlçe Seç";
            this.btnIlce.StyleController = this.myDataLayoutControl;
            this.btnIlce.TabIndex = 2;
            // 
            // btnIl
            // 
            this.btnIl.EnterMoveNextControl = true;
            this.btnIl.Id = null;
            this.btnIl.Location = new System.Drawing.Point(63, 60);
            this.btnIl.MenuManager = this.ribbonControl;
            this.btnIl.Name = "btnIl";
            this.btnIl.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.btnIl.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.btnIl.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnIl.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.btnIl.Size = new System.Drawing.Size(145, 20);
            this.btnIl.StatusBarAciklama = "İl Seçiniz";
            this.btnIl.StatusBarKisayol = "F4 :";
            this.btnIl.StatusBarKisayolAciklama = "İl Seç";
            this.btnIl.StyleController = this.myDataLayoutControl;
            this.btnIl.TabIndex = 1;
            // 
            // txtOkulAdi
            // 
            this.txtOkulAdi.EnterMoveNextControl = true;
            this.txtOkulAdi.Location = new System.Drawing.Point(63, 36);
            this.txtOkulAdi.MenuManager = this.ribbonControl;
            this.txtOkulAdi.Name = "txtOkulAdi";
            this.txtOkulAdi.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtOkulAdi.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtOkulAdi.Properties.MaxLength = 50;
            this.txtOkulAdi.Size = new System.Drawing.Size(315, 20);
            this.txtOkulAdi.StatusBarAciklama = "Okul Adi Giriniz.";
            this.txtOkulAdi.StyleController = this.myDataLayoutControl;
            this.txtOkulAdi.TabIndex = 0;
            // 
            // txtKod
            // 
            this.txtKod.EnterMoveNextControl = true;
            this.txtKod.Location = new System.Drawing.Point(63, 12);
            this.txtKod.MenuManager = this.ribbonControl;
            this.txtKod.Name = "txtKod";
            this.txtKod.Properties.Appearance.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txtKod.Properties.Appearance.Options.UseBackColor = true;
            this.txtKod.Properties.Appearance.Options.UseTextOptions = true;
            this.txtKod.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtKod.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtKod.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtKod.Properties.MaxLength = 30;
            this.txtKod.Size = new System.Drawing.Size(145, 20);
            this.txtKod.StatusBarAciklama = "Kod Giriniz";
            this.txtKod.StyleController = this.myDataLayoutControl;
            this.txtKod.TabIndex = 5;
            // 
            // layoutControlGroup
            // 
            this.layoutControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup.GroupBordersVisible = false;
            this.layoutControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.txtIl,
            this.layoutControlItem4,
            this.layoutControlItem6,
            this.txtAciklama});
            this.layoutControlGroup.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
            this.layoutControlGroup.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup.Name = "layoutControlGroup";
            columnDefinition1.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition1.Width = 200D;
            columnDefinition2.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition2.Width = 100D;
            columnDefinition3.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition3.Width = 99D;
            this.layoutControlGroup.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition1,
            columnDefinition2,
            columnDefinition3});
            rowDefinition1.Height = 24D;
            rowDefinition1.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition2.Height = 24D;
            rowDefinition2.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition3.Height = 24D;
            rowDefinition3.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition4.Height = 24D;
            rowDefinition4.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition5.Height = 100D;
            rowDefinition5.SizeType = System.Windows.Forms.SizeType.Percent;
            this.layoutControlGroup.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition1,
            rowDefinition2,
            rowDefinition3,
            rowDefinition4,
            rowDefinition5});
            this.layoutControlGroup.Size = new System.Drawing.Size(390, 176);
            this.layoutControlGroup.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem1.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem1.Control = this.txtKod;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(200, 24);
            this.layoutControlItem1.Text = "Kod";
            this.layoutControlItem1.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(41, 13);
            this.layoutControlItem1.TextToControlDistance = 10;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem2.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem2.Control = this.txtOkulAdi;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.OptionsTableLayoutItem.ColumnSpan = 3;
            this.layoutControlItem2.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlItem2.Size = new System.Drawing.Size(370, 24);
            this.layoutControlItem2.Text = "Okul Adı";
            this.layoutControlItem2.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(41, 13);
            this.layoutControlItem2.TextToControlDistance = 10;
            // 
            // txtIl
            // 
            this.txtIl.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.txtIl.AppearanceItemCaption.Options.UseForeColor = true;
            this.txtIl.Control = this.btnIl;
            this.txtIl.Location = new System.Drawing.Point(0, 48);
            this.txtIl.Name = "txtIl";
            this.txtIl.OptionsTableLayoutItem.RowIndex = 2;
            this.txtIl.Size = new System.Drawing.Size(200, 24);
            this.txtIl.Text = "İl";
            this.txtIl.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.txtIl.TextSize = new System.Drawing.Size(41, 13);
            this.txtIl.TextToControlDistance = 10;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem4.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem4.Control = this.btnIlce;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.OptionsTableLayoutItem.RowIndex = 3;
            this.layoutControlItem4.Size = new System.Drawing.Size(200, 24);
            this.layoutControlItem4.Text = "İlçe";
            this.layoutControlItem4.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(41, 13);
            this.layoutControlItem4.TextToControlDistance = 10;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem6.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem6.Control = this.tglDurum;
            this.layoutControlItem6.Location = new System.Drawing.Point(271, 0);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.OptionsTableLayoutItem.ColumnIndex = 2;
            this.layoutControlItem6.Size = new System.Drawing.Size(99, 24);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // txtAciklama
            // 
            this.txtAciklama.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.txtAciklama.AppearanceItemCaption.Options.UseForeColor = true;
            this.txtAciklama.Control = this.memoAciklama;
            this.txtAciklama.Location = new System.Drawing.Point(0, 96);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.OptionsTableLayoutItem.ColumnSpan = 3;
            this.txtAciklama.OptionsTableLayoutItem.RowIndex = 4;
            this.txtAciklama.Size = new System.Drawing.Size(370, 60);
            this.txtAciklama.Text = "Açıklama";
            this.txtAciklama.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.txtAciklama.TextSize = new System.Drawing.Size(41, 13);
            this.txtAciklama.TextToControlDistance = 10;
            // 
            // OkulEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 309);
            this.Controls.Add(this.myDataLayoutControl);
            this.MinimumSize = new System.Drawing.Size(400, 310);
            this.Name = "OkulEditForm";
            this.Text = "Okul Kartı";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.myDataLayoutControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl)).EndInit();
            this.myDataLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tglDurum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoAciklama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnIlce.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnIl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOkulAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private UserControls.Controls.MyToggleSwitch tglDurum;
        private UserControls.Controls.MyMemoEdit memoAciklama;
        private UserControls.Controls.MyButtonEdit btnIlce;
        private UserControls.Controls.MyButtonEdit btnIl;
        private UserControls.Controls.MyTextEdit txtOkulAdi;
        private UserControls.Controls.MyKodTextEdit txtKod;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem txtAciklama;
        public UserControls.Controls.MyDataLayoutControl myDataLayoutControl;
        public DevExpress.XtraLayout.LayoutControlItem txtIl;
    }
}