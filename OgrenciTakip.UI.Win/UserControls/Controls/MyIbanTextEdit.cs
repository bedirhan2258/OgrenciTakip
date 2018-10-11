


using DevExpress.XtraEditors.Mask;
using System.ComponentModel;

namespace OgrenciTakip.UI.Win.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MyIbanTextEdit : MyTextEdit
    {
        public MyIbanTextEdit()
        {
            Properties.Mask.MaskType = MaskType.Regular;
            Properties.Mask.EditMask = @"TR\d?\d? \d?\d?\d?\d? \d?\d?\d?\d? \d?\d?\d?\d? \d?\d?\d?\d? \d?\d?\d?\d? \d?\d?";
            Properties.Mask.AutoComplete = AutoCompleteType.None;
            StatusBarAciklama = "IBAN No Giriniz";
        }
    }
}
