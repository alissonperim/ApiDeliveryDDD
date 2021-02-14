using System.Collections.Generic;

namespace ApiDeliveryDDD.Domain.Interfaces.Repositories
{
    public interface IRepositoryBase<T> where T : class
    {
        T Add(T obj);
        T Update(T obj);
        bool Remove(int id);
        IEnumerable<T> GetAll();
        T GetById(int id);
    }
}
