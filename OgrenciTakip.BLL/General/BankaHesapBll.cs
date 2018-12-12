
using OgrenciTakip.BLL.Base;
using OgrenciTakip.BLL.Interfaces;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.DTO;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace OgrenciTakip.BLL.General
{
    public class BankaHesapBll : BaseGenelBll<BankaHesap>, IBaseCommonBll
    {
        public BankaHesapBll() : base(KartTuru.BankaHesap) { }
        public BankaHesapBll(Control ctrl) : base(ctrl, KartTuru.BankaHesap) { }


        public override BaseEntity Single(Expression<Func<BankaHesap, bool>> filter)
        {
            return BaseSingle(filter, x => new BankaHesapS
            {
                Id = x.Id,
                Kod = x.Kod,
                HesapAdi = x.HesapAdi,
                HesapTuru=x.HesapTuru,
                BankaId=x.BankaId,
                BankaAdi=x.Banka.BankaAdi,
                BankaSubeId=x.BankaSubeId,
                BankaSubeAdi=x.BankaSube.SubeAdi,
                HesapAcilisTarihi=x.HesapAcilisTarihi,
                BlokeGunSayisi=x.BlokeGunSayisi,
                IsyeriNo=x.IsyeriNo,
                TerminalNo=x.TerminalNo,
                HesapNo =x.HesapNo,
                IbanNo=x.IbanNo,
                OzelKod1Id = x.OzelKod1Id,
                OzelKod1Adi = x.OzelKod1.OzelKodAdi,
                OzelKod2Id = x.OzelKod2Id,
                OzelKod2Adi = x.OzelKod2.OzelKodAdi,
                SubeId = x.SubeId,
                Aciklama = x.Aciklama,
                Durum = x.Durum
            });
        }
        public override IEnumerable<BaseEntity> List(Expression<Func<BankaHesap, bool>> filter)
        {
            return BaseList(filter, x => new BankaHesapL
            {
                Id = x.Id,
                Kod = x.Kod,
                HesapAdi = x.HesapAdi,
                HesapTuru = x.HesapTuru,
                BankaAdi = x.Banka.BankaAdi,  
                BankaSubeAdi = x.BankaSube.SubeAdi,
                HesapAcilisTarihi = x.HesapAcilisTarihi,
                BlokeGunSayisi = x.BlokeGunSayisi,
                IsyeriNo = x.IsyeriNo,
                TerminalNo = x.TerminalNo,
                HesapNo = x.HesapNo,
                IbanNo = x.IbanNo,
                OzelKod1Adi = x.OzelKod1.OzelKodAdi,     
                OzelKod2Adi = x.OzelKod2.OzelKodAdi,
                Aciklama = x.Aciklama
            }).OrderBy(x => x.Kod).ToList();
        }
    }
}
