
using OgrenciTakip.Model.Entities;
using OgrenciTakip.Model.Entities.Base.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace OgrenciTakip.Model.DTO
{
    [NotMapped]
    public class PromosyonBilgileriL : PromosyonBilgileri, IBaseHareketEntity
    {
        public string Kod { get; set; }
        public string PromosyonAdi { get; set; }
        public bool Insert { get; set; }
        public bool Update { get; set; }
        public bool Delete { get; set; }
    }
}
