using OgrenciTakip.Model.Entities.Base;

namespace OgrenciTakip.BLL.Interfaces
{
    public interface IBaseGenelBll
    {
        bool Insert(BaseEntity entity);
        bool Update(BaseEntity oldEntity, BaseEntity currentEntity);

        string YeniKodVer();
    }
}
