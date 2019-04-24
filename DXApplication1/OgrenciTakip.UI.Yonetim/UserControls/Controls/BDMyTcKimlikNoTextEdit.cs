using DevExpress.Utils;
using DevExpress.XtraEditors.Mask;
using System.ComponentModel;
namespace OgrenciTakip.UI.Yonetim.UserControls.Controls
{
    [ToolboxItem(true)]
    public class BDMyTcKimlikNoTextEdit : BDMyTextEdit
    {
        public BDMyTcKimlikNoTextEdit()
        {
            Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Center;
            Properties.Mask.MaskType = MaskType.Regular;
            Properties.Mask.EditMask = @"\d?\d?\d? \d?\d?\d? \d?\d?\d? \d?\d?";
            Properties.Mask.AutoComplete = AutoCompleteType.None;
            StatusBarAciklama = "Tc Kimlik No Giriniz.";
        }
    }
}
