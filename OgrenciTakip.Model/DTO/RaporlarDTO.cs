
using OgrenciTakip.Common.Enums;
using System;

namespace OgrenciTakip.Model.DTO
{
    public class GenelAmacliRaporL
    {
        public long OgrenciId { get; set; }
        public long TahakkukId { get; set; }
        public long SubeId { get; set; }
        public long DonemId { get; set; }
        public string OgrenciNo { get; set; }
        public string OkulNo { get; set; }
        public string TcKimlikNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public Cinsiyet Cinsiyet { get; set; }
        public int Kiz { get; set; }
        public int Erkek { get; set; }
        public string Telefon { get; set; }
        public KanGrubu? KanGrubu { get; set; }
        public string BabaAdi { get; set; }
        public string AnaAdi { get; set; }
        public string DogumYeri { get; set; }
        public DateTime? DogumTarihi { get; set; }
        public string KimlikSeri { get; set; }
        public string KimlikSiraNo { get; set; }
        public string KimlikIlAdi { get; set; }
        public string KimlikIlceAdi { get; set; }
        public string KimlikMahalleKoy { get; set; }
        public string KimlikCiltNo { get; set; }
        public string KimlikAileSiraNo { get; set; }
        public string KimlikBireySiraNo { get; set; }
        public string KimlikVerildigiYer { get; set; }
        public string KimlikVerilisNedeni { get; set; }
        public string KimlikKayitNo { get; set; }
        public DateTime? KimlikVerilisTarihi { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public KayitSekli KayitSekli { get; set; }
        public KayitDurumu KayitDurumu { get; set; }
        public string SinifAdi { get; set; }
        public string GeldigiOkulAdi { get; set; }
        public string KontenjanAdi { get; set; }
        public string YabanciDilAdi { get; set; }
        public string RehberAdi { get; set; }
        public string TesvikAdi { get; set; }
        public IptalDurumu IptalDurumu { get; set; }
        public string SubeAdi { get; set; }
        public string OzelKod1 { get; set; }
        public string OzelKod2 { get; set; }
        public string OzelKod3 { get; set; }
        public string OzelKod4 { get; set; }
        public string OzelKod5 { get; set; }
        public string VeliTcKimlikNo { get; set; }
        public string VeliAdi { get; set; }
        public string VeliSoyadi { get; set; }
        public string VeliYakinlikAdi { get; set; }
        public string VeliMeslekAdi { get; set; }
        public string VeliIsyeriAdi { get; set; }
        public string VeliGorevAdi { get; set; }
        public string VeliBabaAdi { get; set; }
        public string VeliAnaAdi { get; set; }
        public string VeliDogumYeri { get; set; }
        public DateTime? VeliDogumTarihi { get; set; }
        public KanGrubu? VeliKanGrubu { get; set; }
        public string VeliEvTel { get; set; }
        public string VeliIsTel1 { get; set; }
        public string VeliIsTel2 { get; set; }
        public string VeliCepTel1 { get; set; }
        public string VeliCepTel2 { get; set; }
        public string VeliWeb { get; set; }
        public string VeliEmail { get; set; }
        public string VeliEvAdres { get; set; }
        public string VeliEvAdresIlAdi { get; set; }
        public string VeliEvAdresIlceAdi { get; set; }
        public string VeliIsAdres { get; set; }
        public string VeliIsAdresIlAdi { get; set; }
        public string VeliIsAdresIlceAdi { get; set; }
        public string VeliIbanNo { get; set; }
        public string VeliKartNo { get; set; }
        public decimal BrutHizmet { get; set; }
        public decimal KistDonemDusulenHizmet { get; set; }
        public decimal NetHizmet { get; set; }
        public decimal BrutIndirim { get; set; }
        public decimal KistDonemDusulenIndirim { get; set; }
        public decimal NetIndirim { get; set; }
        public decimal NetUcret { get; set; }
        public decimal IndirimOrani { get; set; }
        public decimal Acik { get; set; }
        public decimal Cek { get; set; }
        public decimal Elden { get; set; }
        public decimal Epos { get; set; }
        public decimal Ots { get; set; }
        public decimal Pos { get; set; }
        public decimal Senet { get; set; }
        public decimal ToplamOdeme { get; set; }
        public decimal Tahsil { get; set; }
        public decimal Tahsilde { get; set; }
        public decimal Iade { get; set; }
        public decimal GeriOdenen { get; set; }
        public decimal Kalan { get; set; }
        public decimal NetOdeme { get; set; }
    }

    public class HizmetAlimRaporuL
    {
        public long OgrenciId { get; set; }
        public long TahakkukId { get; set; }
        public long SubeId { get; set; }
        public long DonemId { get; set; }
        public string OgrenciNo { get; set; }
        public string OkulNo { get; set; }
        public string TcKimlikNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public Cinsiyet Cinsiyet { get; set; }
        public string Telefon { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public KayitSekli KayitSekli { get; set; }
        public KayitDurumu KayitDurumu { get; set; }
        public string SinifAdi { get; set; }
        public string GeldigiOkulAdi { get; set; }
        public string KontenjanAdi { get; set; }
        public string YabanciDilAdi { get; set; }
        public string RehberAdi { get; set; }
        public string TesvikAdi { get; set; }
        public IptalDurumu IptalDurumu { get; set; }
        public string SubeAdi { get; set; }
        public string OzelKod1 { get; set; }
        public string OzelKod2 { get; set; }
        public string OzelKod3 { get; set; }
        public string OzelKod4 { get; set; }
        public string OzelKod5 { get; set; }
        public string VeliAdi { get; set; }
        public string VeliSoyadi { get; set; }
        public string VeliYakinlikAdi { get; set; }
        public string VeliMeslekAdi { get; set; }
        public string VeliIsyeriAdi { get; set; }
        public string VeliGorevAdi { get; set; }
    }

    public class NetUcretRaporuL
    {
        public long OgrenciId { get; set; }
        public long TahakkukId { get; set; }
        public long SubeId { get; set; }
        public long DonemId { get; set; }
        public string OgrenciNo { get; set; }
        public string OkulNo { get; set; }
        public string TcKimlikNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public Cinsiyet Cinsiyet { get; set; }
        public string Telefon { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public KayitSekli KayitSekli { get; set; }
        public KayitDurumu KayitDurumu { get; set; }
        public string SinifAdi { get; set; }
        public string GeldigiOkulAdi { get; set; }
        public string KontenjanAdi { get; set; }
        public string YabanciDilAdi { get; set; }
        public string RehberAdi { get; set; }
        public string TesvikAdi { get; set; }
        public IptalDurumu IptalDurumu { get; set; }
        public string SubeAdi { get; set; }
        public string OzelKod1 { get; set; }
        public string OzelKod2 { get; set; }
        public string OzelKod3 { get; set; }
        public string OzelKod4 { get; set; }
        public string OzelKod5 { get; set; }
        public string VeliAdi { get; set; }
        public string VeliSoyadi { get; set; }
        public string VeliYakinlikAdi { get; set; }
        public string VeliMeslekAdi { get; set; }
        public string VeliIsyeriAdi { get; set; }
        public string VeliGorevAdi { get; set; }
        public decimal BrutHizmet { get; set; }
        public decimal KistDonemDusulenHizmet { get; set; }
        public decimal NetHizmet { get; set; }
        public decimal BrutIndirim { get; set; }
        public decimal KistDonemDusulenIndirim { get; set; }
        public decimal NetIndirim { get; set; }
        public decimal NetUcret { get; set; }
        public decimal IndirimOrani { get; set; }
    }
}
