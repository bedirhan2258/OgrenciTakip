
using System.ComponentModel;

namespace OgrenciTakip.Common.Enums
{
    public enum BelgeDurumu : byte
    {
        [Description("Portfoyde")]
        Portfoyde = 1,
        [Description("Tahsil Etme Kasa")]
        TahsilEtmeKasa = 2,
        [Description("Tahsil Etme Banka")]
        TahsilEtmeBanka = 3,
        [Description("Kısmi Tahsil Edildi")]
        KismiTahsilEdildi = 4,
        [Description("Bankaya Tahsile Gönderme")]
        BankayaTahsileGonderme = 5,
        [Description("Banka Yoluyla Tahsil Etme")]
        BankaYoluylaTahsilEtme = 6,
        [Description("Pörtföye Geri İade")]
        PortfoyeGeriIade = 7,
        [Description("Pörtföye Karşılıksız İade")]
        PortfoyeKarsiliksizIade = 8,
        [Description("Avukata Gönderme")]
        AvukataGonderme = 9,
        [Description("Avukat Yoluyla Tahsil Etme")]
        AvukatYoluylaTahsilEtme = 10,
        [Description("Kismi Avukat Yoluyla Tahsil Etme")]
        KismiAvukatYoluylaTahsilEtme = 11,
        [Description("Blokeye Alma")]
        BlokeyeAlma = 12,
        [Description("Bloke Çözümü")]
        BlokeCozumu = 13,
        [Description("Ciro Etme")]
        CiroEtme = 14,
        [Description("Müşteriye Geri İade")]
        MusteriyeGeriIade = 15,
        [Description("Mahsup Etme")]
        MahsupEtme = 16,
        [Description("Onay Bekliyor")]
        OnayBekliyor = 17,
        [Description("Ödenmiş Olarak İşaretleme")]
        OdenmisOlarakIsaretleme = 18,
        [Description("Karşılıksız Olarak İşaretleme")]
        KarsiliksizOlarakIsaretleme = 19,
        [Description("Tahsili İmkansız Hale Gelme")]
        TahsiliImkansizHaleGelme = 20
    }
}
