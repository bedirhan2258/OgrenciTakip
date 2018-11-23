
using System.ComponentModel;

namespace OgrenciTakip.Common.Enums

{
    //Enumlar varsayılan olarak int olarak kayıt edilir.
    public enum KartTuru : byte
    {
        [Description("Okul Kartı")]
        Okul = 1,
        [Description("İl Kartı")]
        Il = 2,
        [Description("İlçe Kartı")]
        Ilce = 3,
        [Description("Filtre Kartı")]
        Filtre = 4
    }
}
