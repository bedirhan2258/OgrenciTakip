using DevExpress.Utils;
using DevExpress.XtraEditors;
using OgrenciTakip.UI.Win.Interfaces;
using System.Drawing;
using System;
using System.ComponentModel;

namespace OgrenciTakip.UI.Win.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MyCalcEdit : CalcEdit, IStatusBarKisayol
    {
        public MyCalcEdit()
        {
            Properties.AppearanceFocused.ForeColor = Color.LightCyan;
            Properties.AllowNullInput = DefaultBoolean.False;
            Properties.DisplayFormat.FormatType = FormatType.Numeric;
            Properties.DisplayFormat.FormatString = "n2";
            //Bu özellik sayesinde virgülden sonra 2 hane kuruş girmeye olanak sağlıcak.
            Properties.EditMask = "n2";
        }
        public override bool EnterMoveNextControl { get; set; } = true;

        public string StatusBarAciklama { get; set; }

        public string StatusBarKisayol { get; set; } = "F4 :";

        public string StatusBarKisayolAciklama { get; set; } = "Hesap Makinesi";
    }
}
