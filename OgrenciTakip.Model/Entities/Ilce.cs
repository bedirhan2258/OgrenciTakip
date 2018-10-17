
using OgrenciTakip.Model.Entities.Base;

namespace OgrenciTakip.Model.Entities
{
    public class Ilce : BaseEntityDurum
    {
        public string IlceAdi { get; set; }
        public string Aciklama { get; set; }
        public long IlId { get; set; }
        public Il Il { get; set; }
    }
}
