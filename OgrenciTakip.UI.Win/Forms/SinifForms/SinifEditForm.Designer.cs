namespace OgrenciTakip.UI.Win.Forms.SinifForms
{
    partial class SinifEditForm
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
            DevExpress.XtraLayout.ColumnDefinition columnDefinition4 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition1 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition2 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition3 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition4 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition5 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition6 = new DevExpress.XtraLayout.RowDefinition();
            this.myDataLayoutControl = new OgrenciTakip.UI.Win.UserControls.Controls.MyDataLayoutControl();
            this.tglDurum = new OgrenciTakip.UI.Win.UserControls.Controls.MyToggleSwitch();
            this.txtAciklama = new OgrenciTakip.UI.Win.UserControls.Controls.MyMemoEdit();
            this.txtHedefCiro = new OgrenciTakip.UI.Win.UserControls.Controls.MyCalcEdit();
            this.txtHedefOgrenciSayisi = new OgrenciTakip.UI.Win.UserControls.Controls.MySpinEdit();
            this.txtGrup = new OgrenciTakip.UI.Win.UserControls.Controls.MyButtonEdit();
            this.txtSinifAdi = new OgrenciTakip.UI.Win.UserControls.Controls.MyTextEdit();
            this.txtKod = new OgrenciTakip.UI.Win.UserControls.Controls.MyKodTextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl)).BeginInit();
            this.myDataLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tglDurum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHedefCiro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHedefOgrenciSayisi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGrup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSinifAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Size = new System.Drawing.Size(415, 102);
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // myDataLayoutControl
            // 
            this.myDataLayoutControl.Controls.Add(this.tglDurum);
            this.myDataLayoutControl.Controls.Add(this.txtAciklama);
            this.myDataLayoutControl.Controls.Add(this.txtHedefCiro);
            this.myDataLayoutControl.Controls.Add(this.txtHedefOgrenciSayisi);
            this.myDataLayoutControl.Controls.Add(this.txtGrup);
            this.myDataLayoutControl.Controls.Add(this.txtSinifAdi);
            this.myDataLayoutControl.Controls.Add(this.txtKod);
            this.myDataLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myDataLayoutControl.Location = new System.Drawing.Point(0, 102);
            this.myDataLayoutControl.Name = "myDataLayoutControl";
            this.myDataLayoutControl.OptionsFocus.EnableAutoTabOrder = false;
            this.myDataLayoutControl.Root = this.layoutControlGroup1;
            this.myDataLayoutControl.Size = new System.Drawing.Size(415, 186);
            this.myDataLayoutControl.TabIndex = 0;
            this.myDataLayoutControl.Text = "myDataLayoutControl1";
            // 
            // tglDurum
            // 
            this.tglDurum.EnterMoveNextControl = true;
            this.tglDurum.Location = new System.Drawing.Point(308, 12);
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
            this.tglDurum.TabIndex = 5;
            // 
            // txtAciklama
            // 
            this.txtAciklama.EnterMoveNextControl = true;
            this.txtAciklama.Location = new System.Drawing.Point(99, 132);
            this.txtAciklama.MenuManager = this.ribbonControl;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Properties.Appearance.BackColor = System.Drawing.Color.LightCyan;
            this.txtAciklama.Properties.Appearance.Options.UseBackColor = true;
            this.txtAciklama.Properties.MaxLength = 500;
            this.txtAciklama.Size = new System.Drawing.Size(304, 42);
            this.txtAciklama.StatusBarAciklama = "Açıklama Giriniz.";
            this.txtAciklama.StyleController = this.myDataLayoutControl;
            this.txtAciklama.TabIndex = 4;
            // 
            // txtHedefCiro
            // 
            this.txtHedefCiro.EnterMoveNextControl = true;
            this.txtHedefCiro.Location = new System.Drawing.Point(99, 108);
            this.txtHedefCiro.MenuManager = this.ribbonControl;
            this.txtHedefCiro.Name = "txtHedefCiro";
            this.txtHedefCiro.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtHedefCiro.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.LightCyan;
            this.txtHedefCiro.Properties.AppearanceFocused.Options.UseForeColor = true;
            this.txtHedefCiro.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtHedefCiro.Properties.DisplayFormat.FormatString = "n2";
            this.txtHedefCiro.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtHedefCiro.Properties.Mask.EditMask = "n2";
            this.txtHedefCiro.Size = new System.Drawing.Size(129, 20);
            this.txtHedefCiro.StatusBarAciklama = "Hedef Ciroyu Giriniz.";
            this.txtHedefCiro.StatusBarKisayol = "F4 :";
            this.txtHedefCiro.StatusBarKisayolAciklama = "Hesap Makinesi";
            this.txtHedefCiro.StyleController = this.myDataLayoutControl;
            this.txtHedefCiro.TabIndex = 3;
            // 
            // txtHedefOgrenciSayisi
            // 
            this.txtHedefOgrenciSayisi.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtHedefOgrenciSayisi.EnterMoveNextControl = true;
            this.txtHedefOgrenciSayisi.Location = new System.Drawing.Point(99, 84);
            this.txtHedefOgrenciSayisi.MenuManager = this.ribbonControl;
            this.txtHedefOgrenciSayisi.Name = "txtHedefOgrenciSayisi";
            this.txtHedefOgrenciSayisi.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtHedefOgrenciSayisi.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtHedefOgrenciSayisi.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtHedefOgrenciSayisi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtHedefOgrenciSayisi.Properties.Mask.EditMask = "d";
            this.txtHedefOgrenciSayisi.Size = new System.Drawing.Size(59, 20);
            this.txtHedefOgrenciSayisi.StatusBarAciklama = "Bu Sınıf İçin Hedeflenen Öğrenci Sayısını Giriniz.";
            this.txtHedefOgrenciSayisi.StyleController = this.myDataLayoutControl;
            this.txtHedefOgrenciSayisi.TabIndex = 2;
            // 
            // txtGrup
            // 
            this.txtGrup.EnterMoveNextControl = true;
            this.txtGrup.Id = null;
            this.txtGrup.Location = new System.Drawing.Point(99, 60);
            this.txtGrup.MenuManager = this.ribbonControl;
            this.txtGrup.Name = "txtGrup";
            this.txtGrup.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtGrup.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtGrup.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtGrup.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txtGrup.Size = new System.Drawing.Size(129, 20);
            this.txtGrup.StatusBarAciklama = "Sınıf Grup Adı Seçiniz.";
            this.txtGrup.StatusBarKisayol = "F4 :";
            this.txtGrup.StatusBarKisayolAciklama = "Seçim Yap";
            this.txtGrup.StyleController = this.myDataLayoutControl;
            this.txtGrup.TabIndex = 1;
            // 
            // txtSinifAdi
            // 
            this.txtSinifAdi.EnterMoveNextControl = true;
            this.txtSinifAdi.Location = new System.Drawing.Point(99, 36);
            this.txtSinifAdi.MenuManager = this.ribbonControl;
            this.txtSinifAdi.Name = "txtSinifAdi";
            this.txtSinifAdi.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtSinifAdi.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtSinifAdi.Properties.MaxLength = 50;
            this.txtSinifAdi.Size = new System.Drawing.Size(304, 20);
            this.txtSinifAdi.StatusBarAciklama = "Sinif Adı Giriniz.";
            this.txtSinifAdi.StyleController = this.myDataLayoutControl;
            this.txtSinifAdi.TabIndex = 0;
            // 
            // txtKod
            // 
            this.txtKod.EnterMoveNextControl = true;
            this.txtKod.Location = new System.Drawing.Point(99, 12);
            this.txtKod.MenuManager = this.ribbonControl;
            this.txtKod.Name = "txtKod";
            this.txtKod.Properties.Appearance.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txtKod.Properties.Appearance.Options.UseBackColor = true;
            this.txtKod.Properties.Appearance.Options.UseTextOptions = true;
            this.txtKod.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtKod.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtKod.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtKod.Properties.MaxLength = 30;
            this.txtKod.Size = new System.Drawing.Size(129, 20);
            this.txtKod.StatusBarAciklama = "Kod Giriniz";
            this.txtKod.StyleController = this.myDataLayoutControl;
            this.txtKod.TabIndex = 6;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7});
            this.layoutControlGroup1.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            columnDefinition1.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition1.Width = 150D;
            columnDefinition2.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition2.Width = 70D;
            columnDefinition3.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition3.Width = 100D;
            columnDefinition4.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition4.Width = 99D;
            this.layoutControlGroup1.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition1,
            columnDefinition2,
            columnDefinition3,
            columnDefinition4});
            rowDefinition1.Height = 24D;
            rowDefinition1.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition2.Height = 24D;
            rowDefinition2.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition3.Height = 24D;
            rowDefinition3.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition4.Height = 24D;
            rowDefinition4.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition5.Height = 24D;
            rowDefinition5.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition6.Height = 100D;
            rowDefinition6.SizeType = System.Windows.Forms.SizeType.Percent;
            this.layoutControlGroup1.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition1,
            rowDefinition2,
            rowDefinition3,
            rowDefinition4,
            rowDefinition5,
            rowDefinition6});
            this.layoutControlGroup1.Size = new System.Drawing.Size(415, 186);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem1.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem1.Control = this.txtKod;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.OptionsTableLayoutItem.ColumnSpan = 2;
            this.layoutControlItem1.Size = new System.Drawing.Size(220, 24);
            this.layoutControlItem1.Text = "Kod";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(84, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem2.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem2.Control = this.txtSinifAdi;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.OptionsTableLayoutItem.ColumnSpan = 4;
            this.layoutControlItem2.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlItem2.Size = new System.Drawing.Size(395, 24);
            this.layoutControlItem2.Text = "Sınıf Adı";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(84, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem3.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem3.Control = this.txtGrup;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.OptionsTableLayoutItem.ColumnSpan = 2;
            this.layoutControlItem3.OptionsTableLayoutItem.RowIndex = 2;
            this.layoutControlItem3.Size = new System.Drawing.Size(220, 24);
            this.layoutControlItem3.Text = "Grup Adı";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(84, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem4.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem4.Control = this.txtHedefOgrenciSayisi;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.OptionsTableLayoutItem.RowIndex = 3;
            this.layoutControlItem4.Size = new System.Drawing.Size(150, 24);
            this.layoutControlItem4.Text = "Hedef Ögr. Sayısı";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(84, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem5.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem5.Control = this.txtHedefCiro;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.OptionsTableLayoutItem.ColumnSpan = 2;
            this.layoutControlItem5.OptionsTableLayoutItem.RowIndex = 4;
            this.layoutControlItem5.Size = new System.Drawing.Size(220, 24);
            this.layoutControlItem5.Text = "Hedef Ciro";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(84, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem6.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem6.Control = this.txtAciklama;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 120);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.OptionsTableLayoutItem.ColumnSpan = 4;
            this.layoutControlItem6.OptionsTableLayoutItem.RowIndex = 5;
            this.layoutControlItem6.Size = new System.Drawing.Size(395, 46);
            this.layoutControlItem6.Text = "Açıklama";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(84, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem7.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem7.Control = this.tglDurum;
            this.layoutControlItem7.Location = new System.Drawing.Point(296, 0);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.OptionsTableLayoutItem.ColumnIndex = 3;
            this.layoutControlItem7.Size = new System.Drawing.Size(99, 24);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // SinifEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 319);
            this.Controls.Add(this.myDataLayoutControl);
            this.MinimumSize = new System.Drawing.Size(425, 320);
            this.Name = "SinifEditForm";
            this.Text = "Sınıf Kartı";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.myDataLayoutControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl)).EndInit();
            this.myDataLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tglDurum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHedefCiro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHedefOgrenciSayisi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGrup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSinifAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Controls.MyDataLayoutControl myDataLayoutControl;
        private UserControls.Controls.MyToggleSwitch tglDurum;
        private UserControls.Controls.MyMemoEdit txtAciklama;
        private UserControls.Controls.MyCalcEdit txtHedefCiro;
        private UserControls.Controls.MySpinEdit txtHedefOgrenciSayisi;
        private UserControls.Controls.MyButtonEdit txtGrup;
        private UserControls.Controls.MyTextEdit txtSinifAdi;
        private UserControls.Controls.MyKodTextEdit txtKod;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
    }
}