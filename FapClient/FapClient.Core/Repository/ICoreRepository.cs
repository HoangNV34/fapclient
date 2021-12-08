using System.Collections.Generic;

namespace FapClient.Core.Repository
{
    public interface ICoreRepository<T>
    {
        T GetById(int id);

        int Add(T entity);

        bool Delete(T entity);

        bool Update(T entity);

        bool Delete(int id);

        int AddRange(List<T> entities);
    }
}
