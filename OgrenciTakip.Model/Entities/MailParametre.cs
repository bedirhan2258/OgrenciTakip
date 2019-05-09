
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Attributes;
using OgrenciTakip.Model.Entities.Base;
using System.ComponentModel.DataAnnotations;

namespace OgrenciTakip.Model.Entities
{
    public class MailParametre : BaseEntity
    {

        [Required, StringLength(50), ZorunluAlan("Email", "txtEmail")]
        public string Email { get; set; }

        [Required, StringLength(50), ZorunluAlan("Email Şifre", "txtSifre")]
        public string Sifre { get; set; }

        [ZorunluAlan("Por tNo", "txtPortNo")]
        public int PortNo { get; set; }

        [Required, StringLength(50), ZorunluAlan("Host", "txtHost")]
        public string Host { get; set; }
        public EvetHayir SslKullan { get; set; } = EvetHayir.Evet;
    }
}
