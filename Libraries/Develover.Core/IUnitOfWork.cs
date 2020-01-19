using Develover.Core.Entities;

namespace Develover.Core
{
    public interface IUnitOfWork
    {
        IRepository<T> GetRepository<T>() where T : class;
        void Save();
    }
}
