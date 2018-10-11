
using DevExpress.Utils;
using DevExpress.XtraEditors.Mask;
using System.ComponentModel;

namespace OgrenciTakip.UI.Win.UserControls.Controls
{
    public class MyCardEdit : MyTextEdit
    {
        [ToolboxItem(true)]
        public MyCardEdit()
        {
            Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Center;
            Properties.Mask.MaskType = MaskType.Regular;

            // Başına \ işareti koyarsak özel karakter olan normal slaşı koyabiliriz.Bunun anlamı değer girilebilir ve null olabilir.
            // d'lerin her biri bir rakamı temsil ediyor. 4 haneden sonra araya - koyarak 16 haneli rakamlar koymamızı sağlıyor.
            // Bu kodda 8 karakter yazarsak geri kalan rakamları kendisi otomatik olarak sıfır atar bunun önüne geçmek için kod yazmamız gerekli
            Properties.Mask.EditMask = @"\d?\d?\d?\d?-\d?\d?\d?\d?-\d?\d?\d?\d-\d?\d?\d?\d";

            //Bu kodu yazdığımızda kendisinin otomatik tamamlama özelliğini kaldırmış oluyoruz.
            Properties.Mask.AutoComplete = AutoCompleteType.None;
            StatusBarAciklama = "Kart No Giriniz";
        }
    }
}
