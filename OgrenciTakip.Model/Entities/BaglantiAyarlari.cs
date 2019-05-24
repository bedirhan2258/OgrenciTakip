
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities.Base;
using System.Security;

namespace OgrenciTakip.Model.Entities
{
    public class BaglantiAyarlari : BaseEntity
    {
        public string Server { get; set; }
        public YetkilendirmeTuru YetkilendirmeTuru { get; set; }
        public SecureString KullaniciAdi { get; set; }
        public SecureString Sifre { get; set; }
    }
}
