
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace OgrenciTakip.Model.Entities
{
    public class RolYetki : BaseEntity
    {
        public KartTuru KartTuru { get; set; }
    }
}
