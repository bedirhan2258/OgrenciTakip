

using OgrenciTakip.Model.Entities.Base;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OgrenciTakip.Model.Entities
{
    public class IndirimBilgileri : BaseHareketEntity
    {
        public long TahakkukId { get; set; }
        public long IndirimId { get; set; }
        public long HizmetId { get; set; }
        public int? HizmetHareketId { get; set; }

        [Column(TypeName = "date")]
        public DateTime IslemTarihi { get; set; }
        [Column(TypeName = "date")]
        public DateTime? IptalTarihi { get; set; }
        [Column(TypeName = "money")]
        public decimal BrutIndirim { get; set; }
        [Column(TypeName = "money")]
        public decimal KistDonemDusulenIndirim { get; set; }
        [Column(TypeName = "money")]
        public decimal NetIndirim { get; set; }

        public bool IptalEdildi { get; set; }
        public bool OranliIndirim { get; set; }
        public bool ManuelGirilenTutar { get; set; }
        public long? IptalNedeniId { get; set; }

        [StringLength(1000)]
        public string IptalAciklama { get; set; }

        public Tahakkuk Tahakkuk { get; set; }
        public Indirim Indirim { get; set; }
        public Hizmet Hizmet { get; set; }
        public IptalNedeni IptalNedeni { get; set; }
    }
}
