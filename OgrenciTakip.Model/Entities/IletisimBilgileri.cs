
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities.Base;

namespace OgrenciTakip.Model.Entities
{
    public class IletisimBilgileri : BaseHareketEntity
    {
        public long TahakkukId { get; set; }
        public long IletisimId { get; set; }
        public long YakinlikId { get; set; }
        public bool Veli { get; set; }
        public AdresTuru? FaturaAdresi { get; set; }

        public Iletisim Iletisim { get; set; }
        public Yakinlik Yakinlik { get; set; }
    }
}
