using OgrenciTakip.UI.Yonetim.Interfaces;
using DevExpress.XtraEditors;
using System.Drawing;
using System.ComponentModel;

namespace OgrenciTakip.UI.Yonetim.UserControls.Controls
{
    [ToolboxItem(true)]
    public class BDMyMemoEdit : MemoEdit, IStatusBarAciklama
    {
        public BDMyMemoEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.LightCyan;
            Properties.MaxLength = 500;

        }
        public override bool EnterMoveNextControl { get; set; } = true;

        public string StatusBarAciklama { get; set; } = "Açıklama Giriniz.";
    }
}
