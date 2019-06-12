using DevExpress.XtraEditors;
using OgrenciTakip.UI.Yonetim.Interfaces;
using System.ComponentModel;
using System.Drawing;

namespace OgrenciTakip.UI.Yonetim.UserControls.Controls
{
    [ToolboxItem(true)]
    class MySimpleButton : SimpleButton, IStatusBarAciklama
    {
        public MySimpleButton()
        {

            Appearance.ForeColor = Color.Maroon;
        }

        public string StatusBarAciklama { get; set; }
    }
}
