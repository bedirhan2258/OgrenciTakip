
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using OgrenciTakip.UI.Win.Interfaces;
using System.Drawing;
using System;
using System.ComponentModel;

namespace OgrenciTakip.UI.Win.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MyComboBoxEdit : ComboBoxEdit, IStatusBarKisayol
    {
        public MyComboBoxEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.LightCyan;
            //Yazı yazılamamsını sağlar
            Properties.TextEditStyle = TextEditStyles.DisableTextEditor;
        }

        public override bool EnterMoveNextControl { get; set; } = true;

        public string StatusBarAciklama { get; set; } 

        public string StatusBarKisayol { get; set; } = "F4 :";

        public string StatusBarKisayolAciklama { get; set; }
    }
}
