
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using OgrenciTakip.UI.Win.Interfaces;
using System.Drawing;
using System;
using System.ComponentModel;

namespace OgrenciTakip.UI.Win.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MyPictureEdit : PictureEdit,IStatusBarKisayol
    {
        public MyPictureEdit()
        {
            Properties.Appearance.BackColor = Color.LightCyan;
            Properties.Appearance.ForeColor = Color.Maroon;
            //Resim Silindiği zaman ekranda yazıcak yazı anlamına gelmektedir.
            Properties.NullText = "Resim Yok";
            //Seçtiğimiz resmi picture edit içerisine yayar.
            Properties.SizeMode = PictureSizeMode.Stretch;
            Properties.ShowMenu = false;
        }
        public override bool EnterMoveNextControl { get; set; } = true;

        public string StatusBarAciklama { get; set; }

        public string StatusBarKisayol { get; set; } = "F4 :";

        public string StatusBarKisayolAciklama { get; set; }
    }
}
