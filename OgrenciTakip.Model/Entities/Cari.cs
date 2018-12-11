

using OgrenciTakip.Model.Attributes;
using OgrenciTakip.Model.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OgrenciTakip.Model.Entities
{
    public class Cari : BaseEntityDurum
    {
        [Index("IX_kod", IsUnique = false)]
        public override string Kod { get; set; }

        [Required, StringLength(50), ZorunluAlan("Cari Adı", "txtCariAdi")]
        public string CariAdi { get; set; }

        [StringLength(14)]
        public string TcKimlikNo { get; set; }

        [StringLength(17)]
        public string Telefon1 { get; set; }
        [StringLength(17)]
        public string Telefon2 { get; set; }
        [StringLength(17)]
        public string Telefon3 { get; set; }
        [StringLength(17)]
        public string Telefon4 { get; set; }

        [StringLength(17)]
        public string Fax { get; set; }

        [StringLength(50)]
        public string Web { get; set; }

        [StringLength(30)]
        public string Email { get; set; }

        [StringLength(50)]
        public string VergiDairesi { get; set; }

        [StringLength(20)]
        public string VergiNo { get; set; }

        [StringLength(255)]
        public string Adres { get; set; }

        [StringLength(500)]
        public string Aciklama { get; set; }

        public long? OzelKod1Id { get; set; }
        public long? OzelKod2Id { get; set; }

        public OzelKod OzelKod1 { get; set; }
        public OzelKod OzelKod2 { get; set; }

    }
}
