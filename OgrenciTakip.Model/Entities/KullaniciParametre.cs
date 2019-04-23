
using OgrenciTakip.Model.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

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
        public int TableViewCaptionForeColor { get; set; } = Color.Maroon.ToArgb();
        public int TableColumnHeaderForeColor { get; set; } = Color.Maroon.ToArgb();
        public int TableBandPanelForeColor { get; set; } = Color.DarkBlue.ToArgb();

        [Column(TypeName = "image")]
        public byte[] ArkaPlanResim { get; set; }

        public Kullanici Kullanici { get; set; }
        public Avukat DefaultAvukatHesap { get; set; }
        public BankaHesap DefaultBankaHesap { get; set; }
        public Kasa DefaultKasaHesap { get; set; }
    }

}
