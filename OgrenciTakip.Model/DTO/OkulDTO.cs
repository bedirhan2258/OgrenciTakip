
using OgrenciTakip.Model.Entities;
using OgrenciTakip.Model.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace OgrenciTakip.Model.DTO
{
    //NotMapped ile OkulS class'ı 'nın alanları dahil etmiyoruz.

    [NotMapped]
    public class OkulS : Okul
    {
        public string IlAdi { get; set; }
        public string IlceAdi { get; set; }
    }

    public class OkulL : BaseEntity
    {
        public string OkulAdi { get; set; }
        public string IlAdi { get; set; }
        public string IlceAdi { get; set; }
        public string Aciklama { get; set; }
    }
}
