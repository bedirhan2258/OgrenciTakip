
using System.ComponentModel;

namespace OgrenciTakip.Common.Enums
{
    public enum SonrakiDonemKayitDurumu : byte
    {
        [Description("Kayıt Yenileyecek")]
        KayitYenileyecek = 1,
        [Description("Şartlı Kayıt Yenileyecek")]
        SartliKayitYenileyecek = 2,
        [Description("Kayıt Yenilemeyecek")]
        KayitYenilemeyecek = 3,
        [Description("Kurum Tarafından Kaydı Yenilenmeyecek")]
        KurumTarafindanKaydiYenilenmeyecek = 4
    }
}
