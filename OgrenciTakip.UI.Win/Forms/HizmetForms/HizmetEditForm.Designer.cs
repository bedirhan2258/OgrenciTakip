namespace OgrenciTakip.UI.Win.Forms.HizmetForms
{
    partial class HizmetEditForm
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
            DevExpress.XtraLayout.RowDefinition rowDefinition6 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition7 = new DevExpress.XtraLayout.RowDefinition();
            this.myDataLayoutControl = new OgrenciTakip.UI.Win.UserControls.Controls.MyDataLayoutControl();
            this.txtUcret = new OgrenciTakip.UI.Win.UserControls.Controls.MyCalcEdit();
            this.tglDurum = new OgrenciTakip.UI.Win.UserControls.Controls.MyToggleSwitch();
            this.txtAciklama = new OgrenciTakip.UI.Win.UserControls.Controls.MyMemoEdit();
            this.txtBitisTarihi = new OgrenciTakip.UI.Win.UserControls.Controls.MyDateEdit();
            this.txtBaslamaTarihi = new OgrenciTakip.UI.Win.UserControls.Controls.MyDateEdit();
            this.txtHizmetTuru = new OgrenciTakip.UI.Win.UserControls.Controls.MyButtonEdit();
            this.txtHizmetAdi = new OgrenciTakip.UI.Win.UserControls.Controls.MyTextEdit();
            this.txtKod = new OgrenciTakip.UI.Win.UserControls.Controls.MyKodTextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl)).BeginInit();
            this.myDataLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUcret.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tglDurum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBitisTarihi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBitisTarihi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBaslamaTarihi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBaslamaTarihi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHizmetTuru.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHizmetAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Size = new System.Drawing.Size(380, 102);
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // myDataLayoutControl
            // 
            this.myDataLayoutControl.Controls.Add(this.txtUcret);
            this.myDataLayoutControl.Controls.Add(this.tglDurum);
            this.myDataLayoutControl.Controls.Add(this.txtAciklama);
            this.myDataLayoutControl.Controls.Add(this.txtBitisTarihi);
            this.myDataLayoutControl.Controls.Add(this.txtBaslamaTarihi);
            this.myDataLayoutControl.Controls.Add(this.txtHizmetTuru);
            this.myDataLayoutControl.Controls.Add(this.txtHizmetAdi);
            this.myDataLayoutControl.Controls.Add(this.txtKod);
            this.myDataLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myDataLayoutControl.Location = new System.Drawing.Point(0, 102);
            this.myDataLayoutControl.Name = "myDataLayoutControl";
            this.myDataLayoutControl.OptionsFocus.EnableAutoTabOrder = false;
            this.myDataLayoutControl.Root = this.layoutControlGroup1;
            this.myDataLayoutControl.Size = new System.Drawing.Size(380, 211);
            this.myDataLayoutControl.TabIndex = 0;
            this.myDataLayoutControl.Text = "myDataLayoutControl1";
            // 
            // txtUcret
            // 
            this.txtUcret.EnterMoveNextControl = true;
            this.txtUcret.Location = new System.Drawing.Point(83, 132);
            this.txtUcret.MenuManager = this.ribbonControl;
            this.txtUcret.Name = "txtUcret";
            this.txtUcret.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtUcret.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.LightCyan;
            this.txtUcret.Properties.AppearanceFocused.Options.UseForeColor = true;
            this.txtUcret.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtUcret.Properties.DisplayFormat.FormatString = "n2";
            this.txtUcret.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtUcret.Properties.Mask.EditMask = "n2";
            this.txtUcret.Size = new System.Drawing.Size(125, 20);
            this.txtUcret.StatusBarAciklama = "Ücret Giriniz.";
            this.txtUcret.StatusBarKisayol = "F4 :";
            this.txtUcret.StatusBarKisayolAciklama = "Hesap Makinesi";
            this.txtUcret.StyleController = this.myDataLayoutControl;
            this.txtUcret.TabIndex = 4;
            // 
            // tglDurum
            // 
            this.tglDurum.EnterMoveNextControl = true;
            this.tglDurum.Location = new System.Drawing.Point(273, 12);
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
            this.tglDurum.TabIndex = 6;
            // 
            // txtAciklama
            // 
            this.txtAciklama.EnterMoveNextControl = true;
            this.txtAciklama.Location = new System.Drawing.Point(83, 156);
            this.txtAciklama.MenuManager = this.ribbonControl;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Properties.Appearance.BackColor = System.Drawing.Color.LightCyan;
            this.txtAciklama.Properties.Appearance.Options.UseBackColor = true;
            this.txtAciklama.Properties.MaxLength = 500;
            this.txtAciklama.Size = new System.Drawing.Size(285, 43);
            this.txtAciklama.StatusBarAciklama = "Açıklama Giriniz.";
            this.txtAciklama.StyleController = this.myDataLayoutControl;
            this.txtAciklama.TabIndex = 5;
            // 
            // txtBitisTarihi
            // 
            this.txtBitisTarihi.EditValue = null;
            this.txtBitisTarihi.EnterMoveNextControl = true;
            this.txtBitisTarihi.Location = new System.Drawing.Point(83, 108);
            this.txtBitisTarihi.MenuManager = this.ribbonControl;
            this.txtBitisTarihi.Name = "txtBitisTarihi";
            this.txtBitisTarihi.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtBitisTarihi.Properties.Appearance.Options.UseTextOptions = true;
            this.txtBitisTarihi.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtBitisTarihi.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtBitisTarihi.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtBitisTarihi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtBitisTarihi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtBitisTarihi.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtBitisTarihi.Size = new System.Drawing.Size(125, 20);
            this.txtBitisTarihi.StatusBarAciklama = "Bitiş Tarihi Giriniz.";
            this.txtBitisTarihi.StatusBarKisayol = "F4 :";
            this.txtBitisTarihi.StatusBarKisayolAciklama = "Tarih Seç";
            this.txtBitisTarihi.StyleController = this.myDataLayoutControl;
            this.txtBitisTarihi.TabIndex = 3;
            // 
            // txtBaslamaTarihi
            // 
            this.txtBaslamaTarihi.EditValue = null;
            this.txtBaslamaTarihi.EnterMoveNextControl = true;
            this.txtBaslamaTarihi.Location = new System.Drawing.Point(83, 84);
            this.txtBaslamaTarihi.MenuManager = this.ribbonControl;
            this.txtBaslamaTarihi.Name = "txtBaslamaTarihi";
            this.txtBaslamaTarihi.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtBaslamaTarihi.Properties.Appearance.Options.UseTextOptions = true;
            this.txtBaslamaTarihi.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtBaslamaTarihi.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtBaslamaTarihi.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtBaslamaTarihi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtBaslamaTarihi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtBaslamaTarihi.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtBaslamaTarihi.Size = new System.Drawing.Size(125, 20);
            this.txtBaslamaTarihi.StatusBarAciklama = "Başlama Tarihi Giriniz.";
            this.txtBaslamaTarihi.StatusBarKisayol = "F4 :";
            this.txtBaslamaTarihi.StatusBarKisayolAciklama = "Tarih Seç";
            this.txtBaslamaTarihi.StyleController = this.myDataLayoutControl;
            this.txtBaslamaTarihi.TabIndex = 2;
            // 
            // txtHizmetTuru
            // 
            this.txtHizmetTuru.EnterMoveNextControl = true;
            this.txtHizmetTuru.Id = null;
            this.txtHizmetTuru.Location = new System.Drawing.Point(83, 60);
            this.txtHizmetTuru.MenuManager = this.ribbonControl;
            this.txtHizmetTuru.Name = "txtHizmetTuru";
            this.txtHizmetTuru.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtHizmetTuru.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtHizmetTuru.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtHizmetTuru.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txtHizmetTuru.Size = new System.Drawing.Size(125, 20);
            this.txtHizmetTuru.StatusBarAciklama = "Hizmet Türü Seçiniz.";
            this.txtHizmetTuru.StatusBarKisayol = "F4 :";
            this.txtHizmetTuru.StatusBarKisayolAciklama = "Seçim Yap";
            this.txtHizmetTuru.StyleController = this.myDataLayoutControl;
            this.txtHizmetTuru.TabIndex = 1;
            // 
            // txtHizmetAdi
            // 
            this.txtHizmetAdi.EnterMoveNextControl = true;
            this.txtHizmetAdi.Location = new System.Drawing.Point(83, 36);
            this.txtHizmetAdi.MenuManager = this.ribbonControl;
            this.txtHizmetAdi.Name = "txtHizmetAdi";
            this.txtHizmetAdi.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtHizmetAdi.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtHizmetAdi.Properties.MaxLength = 50;
            this.txtHizmetAdi.Size = new System.Drawing.Size(285, 20);
            this.txtHizmetAdi.StatusBarAciklama = "Hizmet Adı Giriniz.";
            this.txtHizmetAdi.StyleController = this.myDataLayoutControl;
            this.txtHizmetAdi.TabIndex = 0;
            // 
            // txtKod
            // 
            this.txtKod.EnterMoveNextControl = true;
            this.txtKod.Location = new System.Drawing.Point(83, 12);
            this.txtKod.MenuManager = this.ribbonControl;
            this.txtKod.Name = "txtKod";
            this.txtKod.Properties.Appearance.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txtKod.Properties.Appearance.Options.UseBackColor = true;
            this.txtKod.Properties.Appearance.Options.UseTextOptions = true;
            this.txtKod.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtKod.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtKod.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtKod.Properties.MaxLength = 30;
            this.txtKod.Size = new System.Drawing.Size(125, 20);
            this.txtKod.StatusBarAciklama = "Kod Giriniz";
            this.txtKod.StyleController = this.myDataLayoutControl;
            this.txtKod.TabIndex = 7;
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
            this.layoutControlItem7,
            this.layoutControlItem8});
            this.layoutControlGroup1.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            columnDefinition1.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition1.Width = 200D;
            columnDefinition2.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition2.Width = 100D;
            columnDefinition3.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition3.Width = 99D;
            this.layoutControlGroup1.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
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
            rowDefinition5.Height = 24D;
            rowDefinition5.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition6.Height = 24D;
            rowDefinition6.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition7.Height = 100D;
            rowDefinition7.SizeType = System.Windows.Forms.SizeType.Percent;
            this.layoutControlGroup1.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition1,
            rowDefinition2,
            rowDefinition3,
            rowDefinition4,
            rowDefinition5,
            rowDefinition6,
            rowDefinition7});
            this.layoutControlGroup1.Size = new System.Drawing.Size(380, 211);
            this.layoutControlGroup1.TextVisible = false;
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
            this.layoutControlItem1.TextSize = new System.Drawing.Size(68, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem2.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem2.Control = this.txtHizmetAdi;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.OptionsTableLayoutItem.ColumnSpan = 3;
            this.layoutControlItem2.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlItem2.Size = new System.Drawing.Size(360, 24);
            this.layoutControlItem2.Text = "Hizmet Adı";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(68, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem3.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem3.Control = this.txtHizmetTuru;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.OptionsTableLayoutItem.RowIndex = 2;
            this.layoutControlItem3.Size = new System.Drawing.Size(200, 24);
            this.layoutControlItem3.Text = "Hizmet Türü";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(68, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem4.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem4.Control = this.txtBaslamaTarihi;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.OptionsTableLayoutItem.RowIndex = 3;
            this.layoutControlItem4.Size = new System.Drawing.Size(200, 24);
            this.layoutControlItem4.Text = "Başlama Tarihi";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(68, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem5.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem5.Control = this.txtBitisTarihi;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.OptionsTableLayoutItem.RowIndex = 4;
            this.layoutControlItem5.Size = new System.Drawing.Size(200, 24);
            this.layoutControlItem5.Text = "Bitiş Tarihi";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(68, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem6.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem6.Control = this.txtAciklama;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 144);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.OptionsTableLayoutItem.ColumnSpan = 3;
            this.layoutControlItem6.OptionsTableLayoutItem.RowIndex = 6;
            this.layoutControlItem6.Size = new System.Drawing.Size(360, 47);
            this.layoutControlItem6.Text = "Açıklama";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(68, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem7.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem7.Control = this.tglDurum;
            this.layoutControlItem7.Location = new System.Drawing.Point(261, 0);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.OptionsTableLayoutItem.ColumnIndex = 2;
            this.layoutControlItem7.Size = new System.Drawing.Size(99, 24);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem8.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem8.Control = this.txtUcret;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 120);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.OptionsTableLayoutItem.RowIndex = 5;
            this.layoutControlItem8.Size = new System.Drawing.Size(200, 24);
            this.layoutControlItem8.Text = "Ücret";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(68, 13);
            // 
            // HizmetEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 344);
            this.Controls.Add(this.myDataLayoutControl);
            this.MinimumSize = new System.Drawing.Size(390, 345);
            this.Name = "HizmetEditForm";
            this.Text = "Hizmet Kartı";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.myDataLayoutControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl)).EndInit();
            this.myDataLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtUcret.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tglDurum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBitisTarihi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBitisTarihi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBaslamaTarihi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBaslamaTarihi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHizmetTuru.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHizmetAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Controls.MyDataLayoutControl myDataLayoutControl;
        private UserControls.Controls.MyCalcEdit txtUcret;
        private UserControls.Controls.MyToggleSwitch tglDurum;
        private UserControls.Controls.MyMemoEdit txtAciklama;
        private UserControls.Controls.MyDateEdit txtBitisTarihi;
        private UserControls.Controls.MyDateEdit txtBaslamaTarihi;
        private UserControls.Controls.MyButtonEdit txtHizmetTuru;
        private UserControls.Controls.MyTextEdit txtHizmetAdi;
        private UserControls.Controls.MyKodTextEdit txtKod;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
    }
}