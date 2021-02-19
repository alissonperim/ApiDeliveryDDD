using ApiDeliveryDDD.Domain.Interfaces.Repositories;
using ApiDeliveryDDD.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiDeliveryDDD.Domain.Services.Services
{
    public class ServiceBase<T> : IServiceBase<T> where T : class
    {
        private readonly IRepositoryBase<T> _repository;

        public ServiceBase(IRepositoryBase<T> repository)
        {
            _repository = repository;
        }
        public async Task<T> Add(T obj)
        {
            try
            {
                var response = await _repository.Add(obj);
                return obj;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return  await _repository.GetAll();
        }

        public async Task<T> GetById(int id)
        {
            return await _repository.GetById(id);
        }

        public async Task<bool> Remove(T obj)
        {
            try
            {
                return await _repository.Remove(obj);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public async Task<T> Update(T obj)
        {
            try
            {
                await _repository.Update(obj);
                return obj;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
