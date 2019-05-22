using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using OgrenciTakip.UI.Win.Interfaces;
using System.ComponentModel;
using System.Drawing;

namespace OgrenciTakip.UI.Win.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MyLookUpEdit : LookUpEdit, IStatusBarKisayol
    {
        public MyLookUpEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.LightCyan;
            Properties.HeaderClickMode = HeaderClickMode.AutoSearch;
            Properties.ShowFooter = false;
        }

        public override bool EnterMoveNextControl { get; set; } = true;
        public string StatusBarAciklama { get; set; }
        public string StatusBarKisayol { get; set; } = "F4 :";
        public string StatusBarKisayolAciklama { get; set; } = "Seçim Yap.";
    }
}
