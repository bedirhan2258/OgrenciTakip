﻿namespace OgrenciTakip.UI.Win.UserControls.UserControl.Base
{
    partial class BaseTablo
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
            this.insUptNavigator = new OgrenciTakip.UI.Win.UserControls.Navigators.InsUptNavigator();
            this.popupMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            this.btnHareketEkle = new DevExpress.XtraBars.BarButtonItem();
            this.btnHareketSil = new DevExpress.XtraBars.BarButtonItem();
            this.btnKartDuzenle = new DevExpress.XtraBars.BarButtonItem();
            this.btnIptalEt = new DevExpress.XtraBars.BarButtonItem();
            this.btnIptalGeriAl = new DevExpress.XtraBars.BarButtonItem();
            this.btnBelgeHareketleri = new DevExpress.XtraBars.BarButtonItem();
            this.btnTumunuSec = new DevExpress.XtraBars.BarButtonItem();
            this.btnTumSecimleriKaldir = new DevExpress.XtraBars.BarButtonItem();
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.bar1 = new DevExpress.XtraBars.Bar();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            this.SuspendLayout();
            // 
            // insUptNavigator
            // 
            this.insUptNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.insUptNavigator.Location = new System.Drawing.Point(0, 265);
            this.insUptNavigator.Name = "insUptNavigator";
            this.insUptNavigator.Size = new System.Drawing.Size(618, 24);
            this.insUptNavigator.TabIndex = 0;
            // 
            // popupMenu
            // 
            this.popupMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnHareketEkle),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnHareketSil),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnKartDuzenle),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnIptalEt),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnIptalGeriAl),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnBelgeHareketleri),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnTumunuSec),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnTumSecimleriKaldir)});
            this.popupMenu.Manager = this.barManager;
            this.popupMenu.Name = "popupMenu";
            // 
            // btnHareketEkle
            // 
            this.btnHareketEkle.Caption = "Hareket Ekle";
            this.btnHareketEkle.Id = 1;
            this.btnHareketEkle.ImageOptions.Image = global::OgrenciTakip.UI.Win.Properties.Resources.addfile_16x16;
            this.btnHareketEkle.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.Insert));
            this.btnHareketEkle.Name = "btnHareketEkle";
            // 
            // btnHareketSil
            // 
            this.btnHareketSil.Caption = "Hareket Sil";
            this.btnHareketSil.Id = 2;
            this.btnHareketSil.ImageOptions.Image = global::OgrenciTakip.UI.Win.Properties.Resources.deletelist_16x16;
            this.btnHareketSil.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.Delete));
            this.btnHareketSil.Name = "btnHareketSil";
            // 
            // btnKartDuzenle
            // 
            this.btnKartDuzenle.Caption = "Kart Duzenle";
            this.btnKartDuzenle.Id = 4;
            this.btnKartDuzenle.ImageOptions.Image = global::OgrenciTakip.UI.Win.Properties.Resources.edit_16x16;
            this.btnKartDuzenle.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F3);
            this.btnKartDuzenle.Name = "btnKartDuzenle";
            this.btnKartDuzenle.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // btnIptalEt
            // 
            this.btnIptalEt.Caption = "Iptal Et";
            this.btnIptalEt.Id = 5;
            this.btnIptalEt.ImageOptions.Image = global::OgrenciTakip.UI.Win.Properties.Resources.removeitem_16x16;
            this.btnIptalEt.ImageOptions.LargeImage = global::OgrenciTakip.UI.Win.Properties.Resources.removeitem_32x32;
            this.btnIptalEt.Name = "btnIptalEt";
            this.btnIptalEt.ShortcutKeyDisplayString = "Ctrl+T";
            this.btnIptalEt.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // btnIptalGeriAl
            // 
            this.btnIptalGeriAl.Caption = "Iptal Geri Al";
            this.btnIptalGeriAl.Id = 6;
            this.btnIptalGeriAl.ImageOptions.Image = global::OgrenciTakip.UI.Win.Properties.Resources.historyitem_16x16;
            this.btnIptalGeriAl.ImageOptions.LargeImage = global::OgrenciTakip.UI.Win.Properties.Resources.historyitem_32x32;
            this.btnIptalGeriAl.Name = "btnIptalGeriAl";
            this.btnIptalGeriAl.ShortcutKeyDisplayString = "Ctrl+R";
            this.btnIptalGeriAl.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // btnBelgeHareketleri
            // 
            this.btnBelgeHareketleri.Caption = "BelgeHareketleri";
            this.btnBelgeHareketleri.Id = 7;
            this.btnBelgeHareketleri.ImageOptions.Image = global::OgrenciTakip.UI.Win.Properties.Resources.documentmap_16x16;
            this.btnBelgeHareketleri.Name = "btnBelgeHareketleri";
            this.btnBelgeHareketleri.ShortcutKeyDisplayString = "F6";
            this.btnBelgeHareketleri.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // btnTumunuSec
            // 
            this.btnTumunuSec.Caption = "Tümünü Seç";
            this.btnTumunuSec.Id = 8;
            this.btnTumunuSec.ImageOptions.Image = global::OgrenciTakip.UI.Win.Properties.Resources.task_16x16;
            this.btnTumunuSec.ImageOptions.LargeImage = global::OgrenciTakip.UI.Win.Properties.Resources.task_32x32;
            this.btnTumunuSec.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A));
            this.btnTumunuSec.Name = "btnTumunuSec";
            this.btnTumunuSec.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // btnTumSecimleriKaldir
            // 
            this.btnTumSecimleriKaldir.Caption = "Tüm Seçimleri Kaldır";
            this.btnTumSecimleriKaldir.Id = 9;
            this.btnTumSecimleriKaldir.ImageOptions.Image = global::OgrenciTakip.UI.Win.Properties.Resources.highlightactiveelements_16x16;
            this.btnTumSecimleriKaldir.ImageOptions.LargeImage = global::OgrenciTakip.UI.Win.Properties.Resources.highlightactiveelements_32x32;
            this.btnTumSecimleriKaldir.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.K));
            this.btnTumSecimleriKaldir.Name = "btnTumSecimleriKaldir";
            this.btnTumSecimleriKaldir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // barManager
            // 
            this.barManager.DockControls.Add(this.barDockControlTop);
            this.barManager.DockControls.Add(this.barDockControlBottom);
            this.barManager.DockControls.Add(this.barDockControlLeft);
            this.barManager.DockControls.Add(this.barDockControlRight);
            this.barManager.Form = this;
            this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnHareketEkle,
            this.btnHareketSil,
            this.btnKartDuzenle,
            this.btnIptalEt,
            this.btnIptalGeriAl,
            this.btnBelgeHareketleri,
            this.btnTumunuSec,
            this.btnTumSecimleriKaldir});
            this.barManager.MaxItemId = 10;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager;
            this.barDockControlTop.Size = new System.Drawing.Size(618, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 289);
            this.barDockControlBottom.Manager = this.barManager;
            this.barDockControlBottom.Size = new System.Drawing.Size(618, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 289);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(618, 0);
            this.barDockControlRight.Manager = this.barManager;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 289);
            // 
            // bar1
            // 
            this.bar1.BarName = "Custom 2";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Custom 2";
            // 
            // BaseTablo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.insUptNavigator);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "BaseTablo";
            this.Size = new System.Drawing.Size(618, 289);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        protected DevExpress.XtraBars.BarButtonItem btnKartDuzenle;
        protected DevExpress.XtraBars.BarButtonItem btnIptalEt;
        protected DevExpress.XtraBars.BarButtonItem btnIptalGeriAl;
        protected DevExpress.XtraBars.BarButtonItem btnHareketSil;
        protected DevExpress.XtraBars.BarButtonItem btnBelgeHareketleri;
        protected internal Navigators.InsUptNavigator insUptNavigator;
        protected DevExpress.XtraBars.BarButtonItem btnHareketEkle;
        protected DevExpress.XtraBars.BarButtonItem btnTumunuSec;
        private DevExpress.XtraBars.Bar bar1;
        protected DevExpress.XtraBars.BarButtonItem btnTumSecimleriKaldir;
        protected DevExpress.XtraBars.PopupMenu popupMenu;
    }
}
