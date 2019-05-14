using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities.Base;

namespace OgrenciTakip.Model.Entities
{
    public class RolYetkileri : BaseHareketEntity
    {
        public long RolId { get; set; }
        public KartTuru KartTuru { get; set; }
        public byte Gorebilir { get; set; }
        public byte Ekleyebilir { get; set; }
        public byte Degistirebilir { get; set; }
        public byte Silebilir { get; set; }

        public Rol Rol { get; set; }
    }
}
