using OgrenciTakip.Model.Entities;
using OgrenciTakip.Model.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace OgrenciTakip.Model.DTO
{
    [NotMapped]
    public class KullaniciS : Kullanici
    {
        public string RolAdi { get; set; }
    }

    public class KullaniciL : BaseEntity
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string Email { get; set; }
        public string RolAdi { get; set; }
        public string Aciklama { get; set; }
    }

}
