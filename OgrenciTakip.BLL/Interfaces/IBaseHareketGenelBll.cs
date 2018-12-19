
using OgrenciTakip.Model.Entities.Base;
using System.Collections.Generic;

namespace OgrenciTakip.BLL.Interfaces
{
    public interface IBaseHareketGenelBll
    {
        bool Insert(IList<BaseHareketEntity> entities);
        bool Update(IList<BaseHareketEntity> entities);
        bool Delete(IList<BaseHareketEntity> entities);
    }
}
