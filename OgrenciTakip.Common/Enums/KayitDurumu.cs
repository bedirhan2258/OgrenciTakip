
using System.ComponentModel;

namespace OgrenciTakip.Common.Enums
{
    public enum KayitDurumu : byte
    {
        [Description("Ön Kayıt")]
        OnKayit = 1,
        [Description("Kesin Kayıt")]
        KesinKayit = 2,
        [Description("Kayıtsız")]
        Kayitsiz = 3
    }
}
