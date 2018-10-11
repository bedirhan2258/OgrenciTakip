
using System;
using DevExpress.XtraEditors;
using OgrenciTakip.UI.Win.Interfaces;
using System.ComponentModel;

namespace OgrenciTakip.UI.Win.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MyFilterControl : FilterControl, IStatusBarAciklama
    {
        public MyFilterControl()
        {
            //Grupladığımızda icon çıkması için
            ShowGroupCommandsIcon = true;
        }

        public string StatusBarAciklama { get; set; } = "Filtre metni giriniz";
    }
}
