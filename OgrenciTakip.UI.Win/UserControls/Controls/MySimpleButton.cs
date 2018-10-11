
using DevExpress.XtraEditors;
using OgrenciTakip.UI.Win.Interfaces;
using System.Drawing;
using System;
using System.ComponentModel;

namespace OgrenciTakip.UI.Win.UserControls.Controls
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
