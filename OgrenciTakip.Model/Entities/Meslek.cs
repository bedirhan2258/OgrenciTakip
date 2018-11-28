using OgrenciTakip.Model.Attributes;
using OgrenciTakip.Model.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OgrenciTakip.Model.Entities
{
    public class Meslek : BaseEntityDurum
    {
        [Index("IX_kod", IsUnique = true)]
        public override string Kod { get; set; }
        [Required, StringLength(50), ZorunluAlan("Meslek Adı", "txtMeslekAdi")]
        public string MeslekAdi { get; set; }
        [StringLength(500)]
        public string Aciklama { get; set; }
    }
}
