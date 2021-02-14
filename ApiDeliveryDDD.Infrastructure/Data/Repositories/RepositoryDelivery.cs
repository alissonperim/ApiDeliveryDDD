using ApiDeliveryDDD.Domain.Entities;
using ApiDeliveryDDD.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace ApiDeliveryDDD.Infrastructure.Data.Repositories
{
    public class RepositoryDelivery : RepositoryBase<Delivery>, IRepositoryDelivery
    {
        private readonly SqlContext _sqlContext;

        public RepositoryDelivery(SqlContext sqlContext) : base(sqlContext)
        {
            _sqlContext = sqlContext;
            SetInclude(s => s.Include(i => i.Employee));
            SetInclude(s => s.Include(i => i.Company));
            SetInclude(s => s.Include(i => i.Client));
        }
    }
}
