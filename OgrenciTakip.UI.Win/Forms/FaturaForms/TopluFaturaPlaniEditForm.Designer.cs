namespace OgrenciTakip.UI.Win.Forms.FaturaForms
{
    partial class TopluFaturaPlaniEditForm
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
            this.myDataLayoutControl = new OgrenciTakip.UI.Win.UserControls.Controls.MyDataLayoutControl();
            this.progressBarControl = new DevExpress.XtraEditors.ProgressBarControl();
            this.txtAyBilgisi = new OgrenciTakip.UI.Win.UserControls.Controls.MyComboBoxEdit();
            this.txtOzetTahakkukAciklama = new OgrenciTakip.UI.Win.UserControls.Controls.MyTextEdit();
            this.txtOzetTahakkuk = new OgrenciTakip.UI.Win.UserControls.Controls.MyComboBoxEdit();
            this.txtSabitTutar = new OgrenciTakip.UI.Win.UserControls.Controls.MyCalcEdit();
            this.txtAdet = new OgrenciTakip.UI.Win.UserControls.Controls.MySpinEdit();
            this.txtIlkFaturaTarih = new OgrenciTakip.UI.Win.UserControls.Controls.MyDateEdit();
            this.layoutControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlProgress = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resimMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl)).BeginInit();
            this.myDataLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAyBilgisi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOzetTahakkukAciklama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOzetTahakkuk.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSabitTutar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIlkFaturaTarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIlkFaturaTarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlProgress)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Size = new System.Drawing.Size(465, 102);
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // myDataLayoutControl
            // 
            this.myDataLayoutControl.Controls.Add(this.progressBarControl);
            this.myDataLayoutControl.Controls.Add(this.txtAyBilgisi);
            this.myDataLayoutControl.Controls.Add(this.txtOzetTahakkukAciklama);
            this.myDataLayoutControl.Controls.Add(this.txtOzetTahakkuk);
            this.myDataLayoutControl.Controls.Add(this.txtSabitTutar);
            this.myDataLayoutControl.Controls.Add(this.txtAdet);
            this.myDataLayoutControl.Controls.Add(this.txtIlkFaturaTarih);
            this.myDataLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myDataLayoutControl.Location = new System.Drawing.Point(0, 102);
            this.myDataLayoutControl.Name = "myDataLayoutControl";
            this.myDataLayoutControl.OptionsFocus.EnableAutoTabOrder = false;
            this.myDataLayoutControl.Root = this.layoutControlGroup;
            this.myDataLayoutControl.Size = new System.Drawing.Size(465, 146);
            this.myDataLayoutControl.TabIndex = 0;
            this.myDataLayoutControl.Text = "myDataLayoutControl1";
            // 
            // progressBarControl
            // 
            this.progressBarControl.Location = new System.Drawing.Point(12, 108);
            this.progressBarControl.MenuManager = this.ribbonControl;
            this.progressBarControl.Name = "progressBarControl";
            this.progressBarControl.Properties.ShowTitle = true;
            this.progressBarControl.Size = new System.Drawing.Size(441, 26);
            this.progressBarControl.StyleController = this.myDataLayoutControl;
            this.progressBarControl.TabIndex = 6;
            // 
            // txtAyBilgisi
            // 
            this.txtAyBilgisi.EnterMoveNextControl = true;
            this.txtAyBilgisi.Location = new System.Drawing.Point(155, 84);
            this.txtAyBilgisi.MenuManager = this.ribbonControl;
            this.txtAyBilgisi.Name = "txtAyBilgisi";
            this.txtAyBilgisi.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtAyBilgisi.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtAyBilgisi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtAyBilgisi.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txtAyBilgisi.Size = new System.Drawing.Size(53, 20);
            this.txtAyBilgisi.StatusBarAciklama = "Ay Bilgisi.";
            this.txtAyBilgisi.StatusBarKisayol = "F4 :";
            this.txtAyBilgisi.StatusBarKisayolAciklama = "Seçim Yap.";
            this.txtAyBilgisi.StyleController = this.myDataLayoutControl;
            this.txtAyBilgisi.TabIndex = 5;
            // 
            // txtOzetTahakkukAciklama
            // 
            this.txtOzetTahakkukAciklama.EnterMoveNextControl = true;
            this.txtOzetTahakkukAciklama.Location = new System.Drawing.Point(212, 60);
            this.txtOzetTahakkukAciklama.MenuManager = this.ribbonControl;
            this.txtOzetTahakkukAciklama.Name = "txtOzetTahakkukAciklama";
            this.txtOzetTahakkukAciklama.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtOzetTahakkukAciklama.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtOzetTahakkukAciklama.Properties.MaxLength = 50;
            this.txtOzetTahakkukAciklama.Size = new System.Drawing.Size(241, 20);
            this.txtOzetTahakkukAciklama.StatusBarAciklama = "Açıklama Giriniz.";
            this.txtOzetTahakkukAciklama.StyleController = this.myDataLayoutControl;
            this.txtOzetTahakkukAciklama.TabIndex = 4;
            // 
            // txtOzetTahakkuk
            // 
            this.txtOzetTahakkuk.EnterMoveNextControl = true;
            this.txtOzetTahakkuk.Location = new System.Drawing.Point(155, 60);
            this.txtOzetTahakkuk.MenuManager = this.ribbonControl;
            this.txtOzetTahakkuk.Name = "txtOzetTahakkuk";
            this.txtOzetTahakkuk.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtOzetTahakkuk.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtOzetTahakkuk.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtOzetTahakkuk.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txtOzetTahakkuk.Size = new System.Drawing.Size(53, 20);
            this.txtOzetTahakkuk.StatusBarAciklama = "Özet Tahakkuk.";
            this.txtOzetTahakkuk.StatusBarKisayol = "F4 :";
            this.txtOzetTahakkuk.StatusBarKisayolAciklama = "Seçim Yap.";
            this.txtOzetTahakkuk.StyleController = this.myDataLayoutControl;
            this.txtOzetTahakkuk.TabIndex = 3;
            // 
            // txtSabitTutar
            // 
            this.txtSabitTutar.EnterMoveNextControl = true;
            this.txtSabitTutar.Location = new System.Drawing.Point(212, 36);
            this.txtSabitTutar.MenuManager = this.ribbonControl;
            this.txtSabitTutar.Name = "txtSabitTutar";
            this.txtSabitTutar.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtSabitTutar.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtSabitTutar.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtSabitTutar.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtSabitTutar.Properties.DisplayFormat.FormatString = "n2";
            this.txtSabitTutar.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtSabitTutar.Properties.Mask.EditMask = "n2";
            this.txtSabitTutar.Size = new System.Drawing.Size(91, 20);
            this.txtSabitTutar.StatusBarAciklama = "Tutar Giriniz.";
            this.txtSabitTutar.StatusBarKisayol = "F4 :";
            this.txtSabitTutar.StatusBarKisayolAciklama = "Hesap Makinesi";
            this.txtSabitTutar.StyleController = this.myDataLayoutControl;
            this.txtSabitTutar.TabIndex = 2;
            // 
            // txtAdet
            // 
            this.txtAdet.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtAdet.EnterMoveNextControl = true;
            this.txtAdet.Location = new System.Drawing.Point(155, 36);
            this.txtAdet.MenuManager = this.ribbonControl;
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtAdet.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtAdet.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtAdet.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtAdet.Properties.Mask.EditMask = "d";
            this.txtAdet.Properties.MaxValue = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.txtAdet.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtAdet.Size = new System.Drawing.Size(53, 20);
            this.txtAdet.StatusBarAciklama = "Adet Giriniz.";
            this.txtAdet.StyleController = this.myDataLayoutControl;
            this.txtAdet.TabIndex = 1;
            // 
            // txtIlkFaturaTarih
            // 
            this.txtIlkFaturaTarih.EditValue = null;
            this.txtIlkFaturaTarih.EnterMoveNextControl = true;
            this.txtIlkFaturaTarih.Location = new System.Drawing.Point(155, 12);
            this.txtIlkFaturaTarih.MenuManager = this.ribbonControl;
            this.txtIlkFaturaTarih.Name = "txtIlkFaturaTarih";
            this.txtIlkFaturaTarih.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtIlkFaturaTarih.Properties.Appearance.Options.UseTextOptions = true;
            this.txtIlkFaturaTarih.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtIlkFaturaTarih.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtIlkFaturaTarih.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtIlkFaturaTarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtIlkFaturaTarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtIlkFaturaTarih.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtIlkFaturaTarih.Size = new System.Drawing.Size(88, 20);
            this.txtIlkFaturaTarih.StatusBarAciklama = "Tarih Seçiniz.";
            this.txtIlkFaturaTarih.StatusBarKisayol = "F4 :";
            this.txtIlkFaturaTarih.StatusBarKisayolAciklama = "Tarih Seç";
            this.txtIlkFaturaTarih.StyleController = this.myDataLayoutControl;
            this.txtIlkFaturaTarih.TabIndex = 0;
            // 
            // layoutControlGroup
            // 
            this.layoutControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup.GroupBordersVisible = false;
            this.layoutControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlProgress});
            this.layoutControlGroup.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
            this.layoutControlGroup.Name = "layoutControlGroup";
            columnDefinition1.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition1.Width = 200D;
            columnDefinition2.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition2.Width = 35D;
            columnDefinition3.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition3.Width = 60D;
            columnDefinition4.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition4.Width = 150D;
            this.layoutControlGroup.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
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
            rowDefinition5.Height = 30D;
            rowDefinition5.SizeType = System.Windows.Forms.SizeType.Absolute;
            this.layoutControlGroup.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition1,
            rowDefinition2,
            rowDefinition3,
            rowDefinition4,
            rowDefinition5});
            this.layoutControlGroup.Size = new System.Drawing.Size(465, 146);
            this.layoutControlGroup.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem1.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem1.Control = this.txtIlkFaturaTarih;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.OptionsTableLayoutItem.ColumnSpan = 2;
            this.layoutControlItem1.Size = new System.Drawing.Size(235, 24);
            this.layoutControlItem1.Text = "İlk Fatura Tarih";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(140, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem2.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem2.Control = this.txtAdet;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlItem2.Size = new System.Drawing.Size(200, 24);
            this.layoutControlItem2.Text = "Adet / Sabit Tutar";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(140, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem3.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem3.Control = this.txtSabitTutar;
            this.layoutControlItem3.Location = new System.Drawing.Point(200, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.OptionsTableLayoutItem.ColumnIndex = 1;
            this.layoutControlItem3.OptionsTableLayoutItem.ColumnSpan = 2;
            this.layoutControlItem3.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlItem3.Size = new System.Drawing.Size(95, 24);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem4.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem4.Control = this.txtOzetTahakkuk;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.OptionsTableLayoutItem.RowIndex = 2;
            this.layoutControlItem4.Size = new System.Drawing.Size(200, 24);
            this.layoutControlItem4.Text = "Özet Tahakkuk / Açıklama";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(140, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem5.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem5.Control = this.txtOzetTahakkukAciklama;
            this.layoutControlItem5.Location = new System.Drawing.Point(200, 48);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.OptionsTableLayoutItem.ColumnIndex = 1;
            this.layoutControlItem5.OptionsTableLayoutItem.ColumnSpan = 3;
            this.layoutControlItem5.OptionsTableLayoutItem.RowIndex = 2;
            this.layoutControlItem5.Size = new System.Drawing.Size(245, 24);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem6.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem6.Control = this.txtAyBilgisi;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.OptionsTableLayoutItem.RowIndex = 3;
            this.layoutControlItem6.Size = new System.Drawing.Size(200, 24);
            this.layoutControlItem6.Text = "Açıklama Bölümünde Ay Bilgisi";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(140, 13);
            // 
            // layoutControlProgress
            // 
            this.layoutControlProgress.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlProgress.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlProgress.Control = this.progressBarControl;
            this.layoutControlProgress.Location = new System.Drawing.Point(0, 96);
            this.layoutControlProgress.MinSize = new System.Drawing.Size(197, 18);
            this.layoutControlProgress.Name = "layoutControlProgress";
            this.layoutControlProgress.OptionsTableLayoutItem.ColumnSpan = 4;
            this.layoutControlProgress.OptionsTableLayoutItem.RowIndex = 4;
            this.layoutControlProgress.Size = new System.Drawing.Size(445, 30);
            this.layoutControlProgress.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlProgress.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlProgress.TextVisible = false;
            // 
            // TopluFaturaPlaniEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 279);
            this.Controls.Add(this.myDataLayoutControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "TopluFaturaPlaniEditForm";
            this.Text = "Fatura Planı Oluştur";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.myDataLayoutControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resimMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl)).EndInit();
            this.myDataLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAyBilgisi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOzetTahakkukAciklama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOzetTahakkuk.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSabitTutar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIlkFaturaTarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIlkFaturaTarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlProgress)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Controls.MyDataLayoutControl myDataLayoutControl;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup;
        private UserControls.Controls.MySpinEdit txtAdet;
        private UserControls.Controls.MyDateEdit txtIlkFaturaTarih;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private UserControls.Controls.MyComboBoxEdit txtOzetTahakkuk;
        private UserControls.Controls.MyCalcEdit txtSabitTutar;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private UserControls.Controls.MyComboBoxEdit txtAyBilgisi;
        private UserControls.Controls.MyTextEdit txtOzetTahakkukAciklama;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraEditors.ProgressBarControl progressBarControl;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlProgress;
    }
}