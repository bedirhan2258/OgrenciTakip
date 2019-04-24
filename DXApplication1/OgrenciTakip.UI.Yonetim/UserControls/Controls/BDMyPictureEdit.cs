using OgrenciTakip.UI.Yonetim.Interfaces;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System.Drawing;
using System.ComponentModel;

 namespace OgrenciTakip.UI.Yonetim.UserControls.Controls
{
    [ToolboxItem(true)]
    public class BDMyPictureEdit : PictureEdit, IStatusBarKisayol
    {
        public BDMyPictureEdit()
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
