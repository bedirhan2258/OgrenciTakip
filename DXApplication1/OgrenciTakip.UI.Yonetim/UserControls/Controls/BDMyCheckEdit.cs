using OgrenciTakip.UI.Yonetim.Interfaces;
using DevExpress.XtraEditors;
using System.Drawing;
using System;
using System.ComponentModel;

namespace OgrenciTakip.UI.Yonetim.UserControls.Controls
{
    [ToolboxItem(true)]
    public class BDMyCheckEdit : CheckEdit, IStatusBarAciklama
    {
        public BDMyCheckEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.Transparent;
        }
        public override bool EnterMoveNextControl { get; set; } = true;

        public string StatusBarAciklama { get; set; }
    }
}
