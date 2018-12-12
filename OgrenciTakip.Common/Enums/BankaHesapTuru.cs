

using System.ComponentModel;

namespace OgrenciTakip.Common.Enums
{
    public enum BankaHesapTuru : byte
    {
        [Description("Vadesiz Mevduat Hesabı")]
        VadesizMevduatHesabi = 1,
        [Description("Vadeli Mevduat Hesabı")]
        VadeliMevduatHesabi = 2,
        [Description("Kredi Hesabı")]
        KrediHesabi = 3,
        [Description("E post Bloke Hesabı")]
        EpostBlokeHesabi = 4,
        [Description("Ots Bloke Hesabı")]
        OtsBlokeHesabi = 5,
        [Description("Post Bloke Hesabı")]
        PostBlokeHesabi = 6,
        [Description("Bloke Çözüm Hesabı")]
        BlokeCozumHesabi = 7
    }
}
