using OgrenciTakip.UI.Yonetim.Interfaces;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System.Drawing;
using System.ComponentModel;

namespace OgrenciTakip.UI.Yonetim.UserControls.Controls
{
    [ToolboxItem(true)]
    public class BDMyComboBoxEdit : ComboBoxEdit, IStatusBarKisayol
    {
        public BDMyComboBoxEdit()
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
