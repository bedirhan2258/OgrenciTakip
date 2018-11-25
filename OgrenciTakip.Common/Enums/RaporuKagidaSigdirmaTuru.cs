using System;
using System.ComponentModel;

namespace OgrenciTakip.Common.Enums
{
    public enum RaporuKagidaSigdirmaTuru : Byte
    {
        [Description("Sütünları Daraltarak Sığdır")]
        SutunlariDaraltarakSigdir = 1,
        [Description("Yazı Boyutunu Küçülterek Sığdır")]
        YaziBoyutunuKuculterekSigdir = 2,
        [Description("İşlem Yapma")]
        IslemYapma = 3
    }
}
