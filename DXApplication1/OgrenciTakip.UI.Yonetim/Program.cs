using System;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.Skins;
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
            SkinManager.EnableFormSkins();
            UserLookAndFeel.Default.SetSkinStyle("DevExpress Style");
                Application.Run(new GirisForm());
        }
    }
}
