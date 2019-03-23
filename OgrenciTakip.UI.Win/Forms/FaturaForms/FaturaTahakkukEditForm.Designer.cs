namespace OgrenciTakip.UI.Win.Forms.FaturaForms
{
    partial class FaturaTahakkukEditForm
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
            DevExpress.XtraLayout.ColumnDefinition columnDefinition4 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition5 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition6 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition5 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition6 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition1 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition2 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition1 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition2 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition3 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition3 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition4 = new DevExpress.XtraLayout.RowDefinition();
            this.myDataLayoutControl = new OgrenciTakip.UI.Win.UserControls.Controls.MyDataLayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.txtKdvSekli = new OgrenciTakip.UI.Win.UserControls.Controls.MyComboBoxEdit();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.txtFaturaAdresi = new OgrenciTakip.UI.Win.UserControls.Controls.MyComboBoxEdit();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtKdvOrani = new OgrenciTakip.UI.Win.UserControls.Controls.MySpinEdit();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtSonFaturaNo = new OgrenciTakip.UI.Win.UserControls.Controls.MySpinEdit();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtFaturaDonemi = new OgrenciTakip.UI.Win.UserControls.Controls.MyComboBoxEdit();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.txtFaturaNo = new OgrenciTakip.UI.Win.UserControls.Controls.MySpinEdit();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resimMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl)).BeginInit();
            this.myDataLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKdvSekli.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFaturaAdresi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKdvOrani.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSonFaturaNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFaturaDonemi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFaturaNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Size = new System.Drawing.Size(990, 102);
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // myDataLayoutControl
            // 
            this.myDataLayoutControl.Controls.Add(this.txtFaturaNo);
            this.myDataLayoutControl.Controls.Add(this.txtFaturaDonemi);
            this.myDataLayoutControl.Controls.Add(this.txtSonFaturaNo);
            this.myDataLayoutControl.Controls.Add(this.txtKdvOrani);
            this.myDataLayoutControl.Controls.Add(this.txtFaturaAdresi);
            this.myDataLayoutControl.Controls.Add(this.txtKdvSekli);
            this.myDataLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myDataLayoutControl.Location = new System.Drawing.Point(0, 102);
            this.myDataLayoutControl.Name = "myDataLayoutControl";
            this.myDataLayoutControl.OptionsFocus.EnableAutoTabOrder = false;
            this.myDataLayoutControl.Root = this.layoutControlGroup1;
            this.myDataLayoutControl.Size = new System.Drawing.Size(990, 366);
            this.myDataLayoutControl.TabIndex = 2;
            this.myDataLayoutControl.Text = "myDataLayoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2,
            this.layoutControlGroup3});
            this.layoutControlGroup1.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            columnDefinition4.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition4.Width = 340D;
            columnDefinition5.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition5.Width = 200D;
            columnDefinition6.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition6.Width = 100D;
            this.layoutControlGroup1.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition4,
            columnDefinition5,
            columnDefinition6});
            rowDefinition5.Height = 92D;
            rowDefinition5.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition6.Height = 100D;
            rowDefinition6.SizeType = System.Windows.Forms.SizeType.Percent;
            this.layoutControlGroup1.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition5,
            rowDefinition6});
            this.layoutControlGroup1.Size = new System.Drawing.Size(990, 366);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // txtKdvSekli
            // 
            this.txtKdvSekli.EnterMoveNextControl = true;
            this.txtKdvSekli.Location = new System.Drawing.Point(98, 42);
            this.txtKdvSekli.MenuManager = this.ribbonControl;
            this.txtKdvSekli.Name = "txtKdvSekli";
            this.txtKdvSekli.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtKdvSekli.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtKdvSekli.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtKdvSekli.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txtKdvSekli.Size = new System.Drawing.Size(62, 20);
            this.txtKdvSekli.StatusBarAciklama = "Kdb Hesaplama Şekli Seçiniz.";
            this.txtKdvSekli.StatusBarKisayol = "F4 :";
            this.txtKdvSekli.StatusBarKisayolAciklama = "Seçim Yap.";
            this.txtKdvSekli.StyleController = this.myDataLayoutControl;
            this.txtKdvSekli.TabIndex = 4;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem1.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem1.Control = this.txtKdvSekli;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(140, 24);
            this.layoutControlItem1.Text = "Kdv Şekli";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(70, 13);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AppearanceGroup.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.layoutControlGroup2.AppearanceGroup.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlGroup2.AppearanceGroup.Options.UseFont = true;
            this.layoutControlGroup2.AppearanceGroup.Options.UseForeColor = true;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4});
            this.layoutControlGroup2.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            columnDefinition1.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition1.Width = 140D;
            columnDefinition2.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition2.Width = 170D;
            this.layoutControlGroup2.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition1,
            columnDefinition2});
            rowDefinition1.Height = 24D;
            rowDefinition1.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition2.Height = 24D;
            rowDefinition2.SizeType = System.Windows.Forms.SizeType.Absolute;
            this.layoutControlGroup2.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition1,
            rowDefinition2});
            this.layoutControlGroup2.Size = new System.Drawing.Size(340, 92);
            this.layoutControlGroup2.Text = "Tahakkuk Bilgileri";
            // 
            // txtFaturaAdresi
            // 
            this.txtFaturaAdresi.EnterMoveNextControl = true;
            this.txtFaturaAdresi.Location = new System.Drawing.Point(251, 42);
            this.txtFaturaAdresi.MenuManager = this.ribbonControl;
            this.txtFaturaAdresi.Name = "txtFaturaAdresi";
            this.txtFaturaAdresi.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtFaturaAdresi.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtFaturaAdresi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtFaturaAdresi.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txtFaturaAdresi.Size = new System.Drawing.Size(85, 20);
            this.txtFaturaAdresi.StatusBarAciklama = "Faturanın Kesileceği Adresi Seçiniz.";
            this.txtFaturaAdresi.StatusBarKisayol = "F4 :";
            this.txtFaturaAdresi.StatusBarKisayolAciklama = "Seçim Yap.";
            this.txtFaturaAdresi.StyleController = this.myDataLayoutControl;
            this.txtFaturaAdresi.TabIndex = 5;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem2.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem2.Control = this.txtFaturaAdresi;
            this.layoutControlItem2.Location = new System.Drawing.Point(140, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.OptionsTableLayoutItem.ColumnIndex = 1;
            this.layoutControlItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(15, 2, 2, 2);
            this.layoutControlItem2.Size = new System.Drawing.Size(176, 24);
            this.layoutControlItem2.Text = "Fatura Adresi";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(70, 13);
            // 
            // txtKdvOrani
            // 
            this.txtKdvOrani.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtKdvOrani.EnterMoveNextControl = true;
            this.txtKdvOrani.Location = new System.Drawing.Point(98, 66);
            this.txtKdvOrani.MenuManager = this.ribbonControl;
            this.txtKdvOrani.Name = "txtKdvOrani";
            this.txtKdvOrani.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtKdvOrani.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtKdvOrani.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtKdvOrani.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtKdvOrani.Properties.Mask.EditMask = "d";
            this.txtKdvOrani.Properties.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.txtKdvOrani.Size = new System.Drawing.Size(62, 20);
            this.txtKdvOrani.StatusBarAciklama = "Kdv Oranını Giriniz.";
            this.txtKdvOrani.StyleController = this.myDataLayoutControl;
            this.txtKdvOrani.TabIndex = 6;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem3.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem3.Control = this.txtKdvOrani;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlItem3.Size = new System.Drawing.Size(140, 26);
            this.layoutControlItem3.Text = "Kdv Oranı";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(70, 13);
            // 
            // txtSonFaturaNo
            // 
            this.txtSonFaturaNo.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtSonFaturaNo.EnterMoveNextControl = true;
            this.txtSonFaturaNo.Location = new System.Drawing.Point(251, 66);
            this.txtSonFaturaNo.MenuManager = this.ribbonControl;
            this.txtSonFaturaNo.Name = "txtSonFaturaNo";
            this.txtSonFaturaNo.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtSonFaturaNo.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtSonFaturaNo.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtSonFaturaNo.Properties.Mask.EditMask = "d";
            this.txtSonFaturaNo.Size = new System.Drawing.Size(85, 20);
            this.txtSonFaturaNo.StatusBarAciklama = null;
            this.txtSonFaturaNo.StyleController = this.myDataLayoutControl;
            this.txtSonFaturaNo.TabIndex = 7;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem4.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem4.Control = this.txtSonFaturaNo;
            this.layoutControlItem4.Enabled = false;
            this.layoutControlItem4.Location = new System.Drawing.Point(140, 24);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.OptionsTableLayoutItem.ColumnIndex = 1;
            this.layoutControlItem4.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlItem4.Padding = new DevExpress.XtraLayout.Utils.Padding(15, 2, 2, 2);
            this.layoutControlItem4.Size = new System.Drawing.Size(176, 26);
            this.layoutControlItem4.Text = "Son Fatura No";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(70, 13);
            // 
            // txtFaturaDonemi
            // 
            this.txtFaturaDonemi.EnterMoveNextControl = true;
            this.txtFaturaDonemi.Location = new System.Drawing.Point(438, 42);
            this.txtFaturaDonemi.MenuManager = this.ribbonControl;
            this.txtFaturaDonemi.Name = "txtFaturaDonemi";
            this.txtFaturaDonemi.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtFaturaDonemi.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtFaturaDonemi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtFaturaDonemi.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txtFaturaDonemi.Size = new System.Drawing.Size(98, 20);
            this.txtFaturaDonemi.StatusBarAciklama = "Fatura Dönemini Seçiniz.";
            this.txtFaturaDonemi.StatusBarKisayol = "F4 :";
            this.txtFaturaDonemi.StatusBarKisayolAciklama = "Seçim Yap.";
            this.txtFaturaDonemi.StyleController = this.myDataLayoutControl;
            this.txtFaturaDonemi.TabIndex = 8;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem5.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem5.Control = this.txtFaturaDonemi;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(176, 24);
            this.layoutControlItem5.Text = "Fatura Dönemi";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(70, 13);
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.AppearanceGroup.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.layoutControlGroup3.AppearanceGroup.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlGroup3.AppearanceGroup.Options.UseFont = true;
            this.layoutControlGroup3.AppearanceGroup.Options.UseForeColor = true;
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem5,
            this.layoutControlItem6});
            this.layoutControlGroup3.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
            this.layoutControlGroup3.Location = new System.Drawing.Point(340, 0);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            columnDefinition3.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition3.Width = 100D;
            this.layoutControlGroup3.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition3});
            rowDefinition3.Height = 24D;
            rowDefinition3.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition4.Height = 24D;
            rowDefinition4.SizeType = System.Windows.Forms.SizeType.Absolute;
            this.layoutControlGroup3.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition3,
            rowDefinition4});
            this.layoutControlGroup3.OptionsTableLayoutItem.ColumnIndex = 1;
            this.layoutControlGroup3.Size = new System.Drawing.Size(200, 92);
            this.layoutControlGroup3.Text = "Fatura Dönemi";
            // 
            // txtFaturaNo
            // 
            this.txtFaturaNo.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtFaturaNo.EnterMoveNextControl = true;
            this.txtFaturaNo.Location = new System.Drawing.Point(438, 66);
            this.txtFaturaNo.MenuManager = this.ribbonControl;
            this.txtFaturaNo.Name = "txtFaturaNo";
            this.txtFaturaNo.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtFaturaNo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtFaturaNo.Properties.Appearance.Options.UseFont = true;
            this.txtFaturaNo.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtFaturaNo.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtFaturaNo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtFaturaNo.Properties.Mask.EditMask = "d";
            this.txtFaturaNo.Size = new System.Drawing.Size(98, 20);
            this.txtFaturaNo.StatusBarAciklama = "Fatura No Giriniz.";
            this.txtFaturaNo.StyleController = this.myDataLayoutControl;
            this.txtFaturaNo.TabIndex = 9;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem6.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem6.Control = this.txtFaturaNo;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlItem6.Size = new System.Drawing.Size(176, 26);
            this.layoutControlItem6.Text = "Fatura No";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(70, 13);
            // 
            // FaturaTahakkukEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 499);
            this.Controls.Add(this.myDataLayoutControl);
            this.Name = "FaturaTahakkukEditForm";
            this.Text = "Fatura Tahakkuk Kartı";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.myDataLayoutControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resimMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl)).EndInit();
            this.myDataLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKdvSekli.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFaturaAdresi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKdvOrani.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSonFaturaNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFaturaDonemi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFaturaNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Controls.MyDataLayoutControl myDataLayoutControl;
        private UserControls.Controls.MySpinEdit txtSonFaturaNo;
        private UserControls.Controls.MySpinEdit txtKdvOrani;
        private UserControls.Controls.MyComboBoxEdit txtFaturaAdresi;
        private UserControls.Controls.MyComboBoxEdit txtKdvSekli;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private UserControls.Controls.MySpinEdit txtFaturaNo;
        private UserControls.Controls.MyComboBoxEdit txtFaturaDonemi;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
    }
}