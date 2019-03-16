
using OgrenciTakip.Model.Attributes;
using OgrenciTakip.Model.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OgrenciTakip.Model.Entities
{
    public class Sube : BaseEntityDurum
    {
        public override string Kod { get; set; }

        [Required, StringLength(50), ZorunluAlan("Şube Adı", "txtSubeAdi")]
        public string SubeAdi { get; set; }

        [StringLength(255)]
        public string Adres { get; set; }

        [ZorunluAlan("İl Adi", "txtAdresIl")]
        public long AdresIlId { get; set; }

        [ZorunluAlan("İlçe Adi", "txtAdresIlce")]
        public long AdresIlceId { get; set; }

        public string AdresIlAdi { get; set; }

        [StringLength(17)]
        public string Telefon { get; set; }

        [StringLength(17)]
        public string Fax { get; set; }

        [StringLength(32)]
        public string IbanNo { get; set; }

        [Column(TypeName = "image")]
        public byte[] Logo { get; set; }

        [StringLength(30)]
        public string GrupAdi { get; set; }

        public int? SiraNo { get; set; }

        public Il AdresIl { get; set; }
        public Ilce AdresIlce { get; set; }
    }
}
