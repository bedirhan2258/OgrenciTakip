

using OgrenciTakip.Model.Entities.Base;
using System.ComponentModel.DataAnnotations;

namespace OgrenciTakip.Model.Entities
{
    public class AileBilgileri : BaseHareketEntity
    {
        public long TahakkukId { get; set; }

        public long AileBilgiId { get; set; }

        [StringLength(500)]
        public string Aciklama { get; set; }

        public AileBilgi Ailebilgi { get; set; }
    }
}
