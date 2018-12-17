

using OgrenciTakip.Model.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace OgrenciTakip.Model.Entities
{
    public class IndiriminUygulanacagiHizmetBilgileri : BaseHareketEntity
    {
        public long IndirimId { get; set; }
        public long HizmetId { get; set; }
        [Column(TypeName = "money")]
        public decimal IndirimTutari { get; set; }
        public byte IndirimOrani { get; set; }
        public long SubeId { get; set; }
        public long DonemId { get; set; }

        public Indirim Indirim { get; set; }
        public Hizmet Hizmet { get; set; }
        public Donem Donem { get; set; }
        public Sube Sube { get; set; }
    }
}
