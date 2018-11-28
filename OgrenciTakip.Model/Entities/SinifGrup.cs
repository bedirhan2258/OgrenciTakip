
using OgrenciTakip.Model.Attributes;
using OgrenciTakip.Model.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OgrenciTakip.Model.Entities
{
    public class SinifGrup : BaseEntityDurum
    {
        [Index("IX_kod", IsUnique = true)]
        public override string Kod { get; set; }
        [Required, StringLength(50), ZorunluAlan("Grup Adı", "txtGrupAdi")]
        public string GrupAdi { get; set; }
        [StringLength(500)]
        public string Aciklama { get; set; }
    }
}
