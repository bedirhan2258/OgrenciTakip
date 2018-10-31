
using OgrenciTakip.Model.Entities.Base;
using System;
using System.Linq.Expressions;

namespace OgrenciTakip.UI.Win.Functions
{
    public class FilterFunctions
    {
        public static Expression<Func<T, bool>> Filter<T>(bool aktifKartlariGoster) where T : BaseEntityDurum
        {
            return x => x.Durum == aktifKartlariGoster;
        }
        public static Expression<Func<T,bool>> Filter<T>(long id) where T : BaseEntityDurum
        {
            return x => x.Id == id;
        }
    }
}
