using OgrenciTakip.BLL.Base;
using OgrenciTakip.BLL.Interfaces;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities;
using System.Windows.Forms;
using OgrenciTakip.Model.Entities.Base;
using System;
using System.Linq.Expressions;
using OgrenciTakip.Model.DTO;
using System.Collections.Generic;
using System.Linq;

namespace OgrenciTakip.BLL.General
{
    public class KasaBll : BaseGenelBll<Kasa>, IBaseCommonBll
    {
        public KasaBll() : base(KartTuru.Kasa) { }
        public KasaBll(Control ctrl) : base(ctrl, KartTuru.Kasa) { }

        public override BaseEntity Single(Expression<Func<Kasa, bool>> filter)
        {
            return BaseSingle(filter, x => new KasaS
            {
                Id = x.Id,
                Kod = x.Kod,
                KasaAdi = x.KasaAdi,
                OzelKod1Id = x.OzelKod1Id,
                OzelKod1Adi = x.OzelKod1.OzelKodAdi,
                OzelKod2Id = x.OzelKod2Id,
                OzelKod2Adi = x.OzelKod2.OzelKodAdi,
                SubeId = x.SubeId,
                DonemId = x.DonemId,
                Aciklama = x.Aciklama,
                Durum = x.Durum
            });
        }
        public override IEnumerable<BaseEntity> List(Expression<Func<Kasa, bool>> filter)
        {
            return BaseList(filter, x => new KasaL
            {
                Id = x.Id,
                Kod = x.Kod,
                KasaAdi = x.KasaAdi,
                OzelKod1Adi = x.OzelKod1.OzelKodAdi,
                OzelKod2Adi = x.OzelKod2.OzelKodAdi,
                Aciklama = x.Aciklama
            }).OrderBy(x => x.Kod).ToList();
        }
    }
}
