﻿using DevExpress.Utils;
using System.ComponentModel;
using System.Drawing;

namespace OgrenciTakip.UI.Yonetim.UserControls.Controls
{
    [ToolboxItem(true)]
    public class BDMyKodTextEdit : BDMyTextEdit
    {
        public BDMyKodTextEdit()
        {
            Properties.Appearance.BackColor = Color.PaleGoldenrod;
            Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Center;
            Properties.MaxLength = 30;
            StatusBarAciklama = "Kod Giriniz";
        }
    }
}
