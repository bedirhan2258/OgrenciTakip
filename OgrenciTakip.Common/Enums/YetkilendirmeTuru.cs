
using System.ComponentModel;

namespace OgrenciTakip.Common.Enums
{
    public enum YetkilendirmeTuru : byte
    {
        [Description("Sql Server Yetkilendirmesi")]
        SqlServer = 1,
        [Description("Windows Yetkilendirmesi")]
        Windows = 2
    }
}
