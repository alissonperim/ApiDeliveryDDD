using System.Collections.Generic;

namespace ApiDeliveryDDD.Domain.Interfaces.Services
{
    public interface IServiceBase<T> where T : class
    {
        T Add(T obj);
        T Update(T obj);
        bool Remove(int id);
        IEnumerable<T> GetAll();
        T GetById(int id);
    }
}
