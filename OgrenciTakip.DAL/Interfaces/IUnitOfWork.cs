

using System;

namespace OgrenciTakip.DAL.Interfaces
{
    public interface IUnitOfWork<T> : IDisposable where T : class
    {
        IRepository<T> Rep { get; }
        bool Save();
    }
}
