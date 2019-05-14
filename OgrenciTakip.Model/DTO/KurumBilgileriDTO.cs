
using OgrenciTakip.Model.Entities;
using OgrenciTakip.Model.Entities.Base.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace OgrenciTakip.Model.DTO
{
    [NotMapped]
    public class KurumBilgileriS : KurumBilgileri
    {

        public string IlAdi { get; set; }
        public string IlceAdi { get; set; }

    }
}
