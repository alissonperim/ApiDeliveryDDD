using ApiDeliveryDDD.Domain.Entities;
using ApiDeliveryDDD.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace ApiDeliveryDDD.Infrastructure.Data.Repositories
{
    public class RepositoryEmployee : RepositoryBase<Employee>, IRepositoryEmployee
    {
        private readonly SqlContext _sqlContext;
        

        public RepositoryEmployee(SqlContext sqlContext) : base(sqlContext)
        {
            _sqlContext = sqlContext;
            SetInclude(s => s.Include(i => i.Company));
        }
    }
}
