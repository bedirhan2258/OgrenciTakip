
using DevExpress.XtraEditors.Mask;
using System.ComponentModel;

namespace OgrenciTakip.UI.Yonetim.UserControls.Controls
{
    [ToolboxItem(true)]
    public class BDEmailTextEdit : BDMyTextEdit
    {
        public BDEmailTextEdit()
        {
            Properties.Mask.MaskType = MaskType.RegEx;
            Properties.Mask.EditMask = @"((([0-9a-zA-Z_%-])+[.])+|([0-9a-zA-Z_%-])+)+@((([0-9a-zA-Z_-])+[.])+|([0-9a-zA-Z_-])+)+";
            //Default ile Strong aynı şeydir.Default olarak strong gelir
            Properties.Mask.AutoComplete = AutoCompleteType.Strong;
            StatusBarAciklama = "E-Mail Adresi Giriniz.";
        }
    }
}
