
using OgrenciTakip.Model.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OgrenciTakip.Model.Entities
{
    public class Il : BaseEntityDurum
    {
        [Index("IX_Kod", IsUnique = true)]
        public override string Kod { get; set; }
        [Required, StringLength(50)]
        public string IlAdi { get; set; }
        [StringLength(500)]
        public string Aciklama { get; set; }
    }
}
