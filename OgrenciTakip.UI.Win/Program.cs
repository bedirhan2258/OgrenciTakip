using DevExpress.LookAndFeel;
using DevExpress.UserSkins;
using OgrenciTakip.UI.Win.GeneralForms;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace OgrenciTakip.UI.Win
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
            
            
            UserLookAndFeel.Default.SetSkinStyle(ConfigurationManager.AppSettings["Skin"], ConfigurationManager.AppSettings["Palette"]);
            Application.Run(new AnaForm());
        }
    }
}
