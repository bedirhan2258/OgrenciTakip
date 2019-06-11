
using OgrenciTakip.BLL.Base;
using OgrenciTakip.BLL.Interfaces;
using OgrenciTakip.Common.Functions;
using OgrenciTakip.Data.Context;
using OgrenciTakip.Model.DTO;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace OgrenciTakip.BLL.General
{
    public class RolYetkileriBll : BaseHareketBll<RolYetkileri, OgrenciTakipContext>, IBaseHareketSelectBll<RolYetkileri>
    {

        public BaseHareketEntity Single(Expression<Func<RolYetkileri, bool>> filter)
        {
            return Single(filter, x => x);
        }

        public IEnumerable<BaseHareketEntity> List(Expression<Func<RolYetkileri, bool>> filter)
        {
            return List(filter, x => new RolYetkileriL
            {
                Id = x.Id,
                RolId = x.RolId,
                KartTuru = x.KartTuru,
                Gorebilir = x.Gorebilir,
                Ekleyebilir = x.Ekleyebilir,
                Degistirebilir = x.Degistirebilir,
                Silebilir = x.Silebilir
            }).AsEnumerable().OrderBy(x => x.KartTuru.ToName()).ToList();
        }
    }
}
