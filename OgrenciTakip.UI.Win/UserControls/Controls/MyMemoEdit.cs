
using DevExpress.XtraEditors;
using OgrenciTakip.UI.Win.Interfaces;
using System.Drawing;
using System;
using System.ComponentModel;

namespace OgrenciTakip.UI.Win.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MyMemoEdit : MemoEdit,IStatusBarAciklama
    {
        public MyMemoEdit()
        {
            Properties.Appearance.BackColor = Color.LightCyan;
            Properties.MaxLength = 500;

        }
        public override bool EnterMoveNextControl { get; set; } = true;

        public string StatusBarAciklama { get; set; } = "Açıklama Giriniz.";
    }
}
