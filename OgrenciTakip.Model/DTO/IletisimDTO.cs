
using OgrenciTakip.Model.Entities;
using OgrenciTakip.Model.Entities.Base;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace OgrenciTakip.Model.DTO
{
    [NotMapped]
    public class IletisimS : Iletisim
    {
        public string KimlikIlAdi { get; set; }
        public string KimlikIlceAdi { get; set; }
        public string EvAdresiIlAdi { get; set; }
        public string EvAdresIlceAdi { get; set; }
        public string IsAdresIlAdi { get; set; }
        public string IsAdresIlceAdi { get; set; }
        public string MeslekAdi { get; set; }
        public string IsyeriAdi { get; set; }
        public string GorevAdi { get; set; }
        public string OzelKod1Adi { get; set; }
        public string OzelKod2Adi { get; set; }
    }

    public class IletisimL : BaseEntity
    {
        public string TcKimlikNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string BabaAdi { get; set; }
        public string AnaAdi { get; set; }
        public string DogumYeri { get; set; }
        public DateTime? DogumTarihi { get; set; }
        public string KanGrubu { get; set; }
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
        public string EvTelefonu { get; set; }
        public string IsTelefonu1 { get; set; }
        public string IsTelefonu2 { get; set; }
        public string Dahili1 { get; set; }
        public string Dahili2 { get; set; }
        public string CepTelefonu1 { get; set; }
        public string CepTelefonu2 { get; set; }
        public string Web { get; set; }
        public string Email { get; set; }
        public string EvAdres { get; set; }
        public string EvAdresiIlAdi { get; set; }
        public string EvAdresIlceAdi { get; set; }
        public string IsAdres { get; set; }
        public string IsAdresIlAdi { get; set; }
        public string IsAdresIlceAdi { get; set; }
        public string MeslekAdi { get; set; }
        public string IsyeriAdi { get; set; }
        public string GorevAdi { get; set; }
        public string IbanNo { get; set; }
        public string KartNo { get; set; }
        public string OzelKod1Adi { get; set; }
        public string OzelKod2Adi { get; set; }
        public string Aciklama { get; set; }

    }
}
