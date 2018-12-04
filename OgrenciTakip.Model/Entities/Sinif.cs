using OgrenciTakip.Model.Attributes;
using OgrenciTakip.Model.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OgrenciTakip.Model.Entities
{
    public class Sinif : BaseEntityDurum
    {
        [Index("IX_kod", IsUnique = false)]
        public override string Kod { get; set; }

        [Required, StringLength(50), ZorunluAlan("Sınıf Adı", "txtSinifAdi")]
        public string SinifAdi { get; set; }

        [StringLength(500)]
        public string Aciklama { get; set; }

        [ZorunluAlan("Grup Adı", "txtGrup")]
        public long GrupId { get; set; }

        [Column(TypeName = "money")]
        public decimal HedefCiro { get; set; }

        public int HedefOgrenciSayisi { get; set; }
        public long SubeId { get; set; }
        public Sube Sube { get; set; }
        public SinifGrup Grup { get; set; }
    }
}
