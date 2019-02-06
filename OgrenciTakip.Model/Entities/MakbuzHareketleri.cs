
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace OgrenciTakip.Model.Entities
{
    public class MakbuzHareketleri : BaseHareketEntity
    {
        public long MakbuzId { get; set; }
        public int OdemeBilgileriId { get; set; }

        [Column(TypeName = "money")]
        public decimal IslemOncesiTutar { get; set; }

        [Column(TypeName = "money")]
        public decimal IslemTutari { get; set; }

        public BelgeDurumu BelgeDurumu { get; set; }
        public long KullaniciId { get; set; }
        public long EskiSubeId { get; set; }
        public long? YeniSubeId { get; set; }

        public Makbuz Makbuz { get; set; }
        public OdemeBilgileri OdemeBilgileri { get; set; }
        public Kullanici Kullanici { get; set; }
        public Sube EskiSube { get; set; }
        public Sube YeniSube { get; set; }
    }
}
