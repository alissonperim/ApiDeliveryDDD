using ApiDeliveryDDD.Domain.Entities;
using ApiDeliveryDDD.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ApiDeliveryDDD.Infrastructure.Data.Repositories
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : BaseClass
    {
        private readonly SqlContext _sqlContext;
        protected Func<IQueryable<T>, IIncludableQueryable<T, object>> Include;

        public RepositoryBase(SqlContext sqlContext)
        {
            _sqlContext = sqlContext;
        }

        public virtual void SetInclude(Func<IQueryable<T>, IIncludableQueryable<T, object>> include)
        {
            Include = include;
        }

        public T Add(T obj)
        {
            try
            {
                _sqlContext.Set<T>().Add(obj);
                _sqlContext.SaveChanges();
                return obj;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public virtual IEnumerable<T> GetAll()
        {
            var query = _sqlContext.Set<T>().AsQueryable();
            if (Include != null)
            {
                query = Include(query);
            }
            return query.ToList();
        }

        public virtual T GetById(int id)
        {
            var query = _sqlContext.Set<T>().Where(w => w.Id == id);
            if (Include != null)
            {
                query = Include(query);
            }
            return query.SingleOrDefault();
        }

        public bool Remove(int id)
        {
            try
            {
                var entity = GetById(id);
                if (entity == null)
                    return false;
                _sqlContext.Set<T>().Remove(entity);
                return _sqlContext.SaveChanges() > 0;
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
                _sqlContext.Entry(obj).State = EntityState.Modified;
                _sqlContext.SaveChanges();
                return obj;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
