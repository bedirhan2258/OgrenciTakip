
using OgrenciTakip.BLL.Base;
using OgrenciTakip.BLL.Interfaces;
using OgrenciTakip.Model.DTO;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.Model.Entities.Base;
using System;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace OgrenciTakip.BLL.General
{
    public class KurumBilgileriBll : BaseGenelBll<KurumBilgileri>, IBaseGenelBll, IBaseCommonBll
    {

        public KurumBilgileriBll(Control ctrl) : base(ctrl) { }

        public override BaseEntity Single(Expression<Func<KurumBilgileri, bool>> filter)
        {
            return BaseSingle(filter, x => new KurumBilgileriS
            {

                Id = x.Id,
                Kod = x.Kod,
                KurumAdi = x.KurumAdi,
                VergiDairesi = x.VergiDairesi,
                VergiNo = x.VergiNo,
                IlId = x.IlId,
                IlAdi = x.Il.IlAdi,
                IlceId = x.IlceId,
                IlceAdi = x.Ilce.IlceAdi,
               
            });
        }
    }
}
