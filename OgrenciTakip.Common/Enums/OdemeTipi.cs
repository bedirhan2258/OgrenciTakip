

using System.ComponentModel;

namespace OgrenciTakip.Common.Enums
{
    public enum OdemeTipi : byte
    {
        [Description("Açık")]
        Acik = 1,
        [Description("Çek")]
        Cek = 2,
        [Description("Elden")]
        Elden = 3,
        [Description("Epos")]
        Epos = 4,
        [Description("Ots")]
        Ots = 5,
        [Description("Pos")]
        Pos = 6,
        [Description("Senet")]
        Senet = 7
    }
}
