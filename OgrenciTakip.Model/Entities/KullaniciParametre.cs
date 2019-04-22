
using OgrenciTakip.Model.Attributes;
using OgrenciTakip.Model.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OgrenciTakip.Model.Entities
{
    public class KullaniciParametre : BaseEntity
    {
        [Index("IX_kod", IsUnique = false)]
        public override string Kod { get; set; }

        public long KullaniciId { get; set; }
        public long? DefaultAvukatHesapId { get; set; }
        public long? DefaultBankaHesapId { get; set; }
        public long? DefaultKasaHesapId { get; set; }
        public bool RaporlariOnayAlmadanKapat { get; set; }
        public int TableViewCaptionForeColor { get; set; }
        public int TableColumnHeaderForeColor { get; set; }
        public int TableBandPanelForeColor { get; set; }

        [Column(TypeName = "image")]
        public byte[] ArkaPlanResim { get; set; }

        public Kullanici Kullanici { get; set; }
        public Avukat DefaultAvukatHesap { get; set; }
        public BankaHesap DefaultBankaHesap { get; set; }
        public Kasa DefaultKasaHesap { get; set; }
    }

}
