
using OgrenciTakip.Model.Attributes;
using OgrenciTakip.Model.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OgrenciTakip.Model.Entities
{
    public class Kasa : BaseEntityDurum
    {

        [Index("IX_kod", IsUnique = false)]
        public override string Kod { get; set; }

        [Required, StringLength(50), ZorunluAlan("Kasa Adı", "txtKasaAdi")]
        public string KasaAdi { get; set; }

        [StringLength(500)]
        public string Aciklama { get; set; }

        public long? OzelKod1Id { get; set; }
        public long? OzelKod2Id { get; set; }

        public long SubeId { get; set; }
        public long DonemId { get; set; }

        public OzelKod OzelKod1 { get; set; }
        public OzelKod OzelKod2 { get; set; }
        public Sube Sube { get; set; }
        public Donem Donem { get; set; }
    }
}
