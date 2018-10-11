
using DevExpress.Utils;
using System.ComponentModel;
using System.Drawing;

namespace OgrenciTakip.UI.Win.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MyKodTextEdit : MyTextEdit
    {
        public MyKodTextEdit()
        {
            Properties.Appearance.BackColor = Color.PaleGoldenrod;
            Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Center;
            Properties.MaxLength = 30;
            StatusBarAciklama = "Kod Giriniz";
        }
    }
}
