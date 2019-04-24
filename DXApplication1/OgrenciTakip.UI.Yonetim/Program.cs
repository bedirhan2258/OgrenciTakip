using System;
using System.Windows.Forms;
using DevExpress.UserSkins;
using OgrenciTakip.UI.Yonetim.GeneralForms;

namespace OgrenciTakip.UI.Yonetim
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            BonusSkins.Register();
            Application.Run(new AnaForm());
        }
    }
}
