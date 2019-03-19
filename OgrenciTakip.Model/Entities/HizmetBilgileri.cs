
using OgrenciTakip.Model.Entities.Base;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OgrenciTakip.Model.Entities
{
    public class HizmetBilgileri : BaseHareketEntity
    {
        public long TahakkukId { get; set; }
        public long HizmetId { get; set; }
        public long HizmetTuruId { get; set; }
        public long? ServisId { get; set; }

        [Column(TypeName = "date")]
        public DateTime IslemTarihi { get; set; }

        [Column(TypeName = "date")]
        public DateTime BaslamaTarihi { get; set; }

        [Column(TypeName = "money")]
        public decimal BrutUcret { get; set; }

        [Column(TypeName = "money")]
        public decimal KistDonemDusulenUcret { get; set; }

        [Column(TypeName = "money")]
        public decimal NetUcret { get; set; }

        public bool IptalEdildi { get; set; }
        public int EgitimDonemiGunSayisi { get; set; }
        public int AlinanHizmetGunSayisi { get; set; }

        [Column(TypeName = "money")]
        public decimal GunlukUcret { get; set; }

        [Column(TypeName = "date")]
        public DateTime? IptalTarihi { get; set; }

        public long? IptalNedeniId { get; set; }
        public long? GittigiOkulId { get; set; }
        [StringLength(1000)]
        public string IptalAciklama { get; set; }

    
        public Tahakkuk Tahakkuk { get; set; }
        public Hizmet Hizmet { get; set; }
        public HizmetTuru HizmetTuru { get; set; }
        public Servis Servis { get; set; }
        public IptalNedeni IptalNedeni { get; set; }
        public Okul GittigiOkul { get; set; }
    }
}
