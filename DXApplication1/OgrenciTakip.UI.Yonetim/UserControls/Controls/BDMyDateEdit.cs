using OgrenciTakip.UI.Yonetim.Interfaces;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Mask;
using System.Drawing;
using System.ComponentModel;

namespace OgrenciTakip.UI.Yonetim.UserControls.Controls
{
    [ToolboxItem(true)]
    public class BDMyDateEdit : DateEdit, IStatusBarKisayol
    {
        public BDMyDateEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.LightCyan;
            //Tarih alanı null geçilmeyek
            Properties.AllowNullInput = DefaultBoolean.False;
            Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Center;
            //Tarih yazıldıkça gün -ay -yıl kısmına otomatik geçiş yapılmasını sağlar
            Properties.Mask.MaskType = MaskType.DateTimeAdvancingCaret;
        }
        public override bool EnterMoveNextControl { get; set; } = true;

        public string StatusBarAciklama { get; set; }

        public string StatusBarKisayol { get; set; } = "F4 :";

        public string StatusBarKisayolAciklama { get; set; } = "Tarih Seç";
    }
}
