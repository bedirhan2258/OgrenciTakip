

using OgrenciTakip.Model.Entities;
using OgrenciTakip.Model.Entities.Base.Interfaces;

namespace OgrenciTakip.Model.DTO
{
    public class IndiriminUygulanacagiHizmetBilgileriL : IndiriminUygulanacagiHizmetBilgileri, IBaseHareketEntity
    {
        public string HizmetAdi { get; set; }
        public bool Insert { get; set; }
        public bool Update { get; set; }
        public bool Delete { get; set; }
    }
}
