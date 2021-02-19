using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiDeliveryDDD.Domain.Interfaces.Repositories
{
    public interface IRepositoryBase<T> where T : class
    {
        Task<T> Add(T obj);
        Task<T> Update(T obj);
        Task<bool> Remove(T obj);
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(int id);
    }
}
