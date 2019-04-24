using OgrenciTakip.UI.Yonetim.Interfaces;
using DevExpress.XtraEditors;
using System.ComponentModel;

namespace OgrenciTakip.UI.Yonetim.UserControls.Controls
{
    [ToolboxItem(true)]
    public class BDMyFilterControl : FilterControl, IStatusBarAciklama
    {
        public BDMyFilterControl()
        {
            //Grupladığımızda icon çıkması için
            ShowGroupCommandsIcon = true;
        }

        public string StatusBarAciklama { get; set; } = "Filtre metni giriniz";
    }
}
