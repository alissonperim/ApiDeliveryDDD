using ApiDeliveryDDD.Domain.Interfaces.Repositories;
using ApiDeliveryDDD.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace ApiDeliveryDDD.Domain.Services.Services
{
    public class ServiceBase<T> : IServiceBase<T> where T : class
    {
        private readonly IRepositoryBase<T> _repository;

        public ServiceBase(IRepositoryBase<T> repository)
        {
            _repository = repository;
        }
        public T Add(T obj)
        {
            try
            {
                _repository.Add(obj);
                return obj;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<T> GetAll()
        {
            return _repository.GetAll();
        }

        public T GetById(int id)
        {
            return _repository.GetById(id);
        }

        public bool Remove(int id)
        {
            try
            {
                return _repository.Remove(id);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public T Update(T obj)
        {
            try
            {
                _repository.Update(obj);
                return obj;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
