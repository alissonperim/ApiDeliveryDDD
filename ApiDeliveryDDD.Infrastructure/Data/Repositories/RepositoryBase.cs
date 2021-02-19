using ApiDeliveryDDD.Domain.Entities;
using ApiDeliveryDDD.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

        public async Task<T> Add(T obj)
        {
            try
            {
                _sqlContext.Set<T>().Add(obj);
                await _sqlContext.SaveChangesAsync();
                return obj;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public virtual async Task<IEnumerable<T>> GetAll()
        {
            var query = _sqlContext.Set<T>().AsQueryable();
            if (Include != null)
            {
                query = Include(query);
            }
            return await query.ToListAsync();
        }

        public virtual async Task<T> GetById(int id)
        {
            var query = _sqlContext.Set<T>().Where(w => w.Id == id);
            if (Include != null)
            {
                query = Include(query);
            }
            return await query.SingleOrDefaultAsync();
        }

        public async Task<bool> Remove(T obj)
        {
            try
            {
                var entity = GetById(obj.Id);
                //var result = await _sqlContext.Set<T>().FindAsync(entity);
                _sqlContext.Remove(entity);
                await _sqlContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<T> Update(T obj)
        {
            try
            {
                _sqlContext.Entry(obj).State = EntityState.Modified;
                await _sqlContext.SaveChangesAsync();
                return obj;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
