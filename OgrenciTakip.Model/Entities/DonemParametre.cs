using OgrenciTakip.Model.Entities.Base;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace OgrenciTakip.Model.Entities
{
    public class DonemParametre : BaseEntity
    {
        public long SubeId { get; set; }
        public long DonemId { get; set; }

        [Column(TypeName = "date")]
        public DateTime DonemBaslamaTarihi { get; set; } = DateTime.Now.Date;

        [Column(TypeName = "date")]
        public DateTime DonemBitisTarihi { get; set; } = DateTime.Now.Date;

        [Column(TypeName = "date")]
        public DateTime EgitimBaslamaTarihi { get; set; } = DateTime.Now.Date;

        [Column(TypeName = "date")]
        public DateTime EgitimBitisTarihi { get; set; } = DateTime.Now.Date;


        public bool GunTarihininOncesineHizmetBaslamaTarihiGirilebilir { get; set; }
        public bool GunTarihininSonrasinaHizmetBaslamaTarihiGirilebilir { get; set; }
        public bool GunTarihininOncesineIptalTarihiGirilebilir { get; set; } = true;
        public bool GunTarihininSonrasinaIptalTarihiGirilebilir { get; set; } = true;
        public bool GunTarihininOncesineMakbuzTarihiGirilebilir { get; set; }
        public bool GunTarihininSonrasinaMakbuzTarihiGirilebilir { get; set; }

        [Column(TypeName = "date")]
        public DateTime MaksimumTaksitTarihi { get; set; } = DateTime.Now.Date;

        public byte MaksimumTaksitSayisi { get; set; } = 12;
        public bool GittigiOkulZorunlu { get; set; } = true;
        public bool HizmetTahakkukKurusKullan { get; set; }
        public bool IndirimTahakkukKurusKullan { get; set; }
        public bool OdemePlaniKurusKullan { get; set; }
        public bool FaturaTahakkukKurusKullan { get; set; }
        public bool YetkiKontroluAnlikYapilacak { get; set; }
        public Sube Sube { get; set; }
        public Donem Donem { get; set; }

    }
}
