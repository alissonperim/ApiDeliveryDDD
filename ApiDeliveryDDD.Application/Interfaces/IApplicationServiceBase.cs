using System;
using System.Collections.Generic;
using System.Text;

namespace ApiDeliveryDDD.Application.Interfaces
{
    public interface IApplicationServiceBase<T> where T : class
    {
        T Add(T obj);
        T Update(T obj);
        T Remove(T obj);
        IEnumerable<T> GetAll();
        T GetById(int id);
    }
}
