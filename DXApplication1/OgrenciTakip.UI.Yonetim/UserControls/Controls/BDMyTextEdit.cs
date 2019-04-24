using OgrenciTakip.UI.Yonetim.Interfaces;
using DevExpress.XtraEditors;
using System.Drawing;
using System;
using System.ComponentModel;

namespace OgrenciTakip.UI.Yonetim.UserControls.Controls
{
    [ToolboxItem(true)]
    public class BDMyTextEdit : TextEdit, IStatusBarAciklama
    {
        public BDMyTextEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.LightCyan;
            Properties.MaxLength = 50;
        }

        public override bool EnterMoveNextControl { get; set; } = true;

        public string StatusBarAciklama { get; set; }
    }
}
