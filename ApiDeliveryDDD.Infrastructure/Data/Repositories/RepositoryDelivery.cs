using ApiDeliveryDDD.Domain.Entities;
using ApiDeliveryDDD.Domain.Interfaces.Repositories;

namespace ApiDeliveryDDD.Infrastructure.Data.Repositories
{
    public class RepositoryDelivery : RepositoryBase<Delivery>, IRepositoryDelivery
    {
        private readonly SqlContext _sqlContext;

        public RepositoryDelivery(SqlContext sqlContext) : base(sqlContext)
        {
            _sqlContext = sqlContext;
        }
    }
}
