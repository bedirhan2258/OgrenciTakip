
using DevExpress.Utils;
using DevExpress.XtraEditors;
using OgrenciTakip.UI.Win.Interfaces;
using System.Drawing;
using System;
using System.ComponentModel;

namespace OgrenciTakip.UI.Win.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MySpinEdit : SpinEdit, IStatusBarAciklama
    {
        public MySpinEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.LightCyan;
            Properties.AllowNullInput = DefaultBoolean.False;
            //Basamaklama yapmayacak değeri artacak yada azalıcak
            Properties.EditMask = "d";
        }
        public override bool EnterMoveNextControl { get; set; } = true;

        public string StatusBarAciklama { get; set; }
    }
}
