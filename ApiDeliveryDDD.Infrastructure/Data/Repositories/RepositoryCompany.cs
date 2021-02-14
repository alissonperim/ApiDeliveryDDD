using ApiDeliveryDDD.Domain.Entities;
using ApiDeliveryDDD.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace ApiDeliveryDDD.Infrastructure.Data.Repositories
{
    public class RepositoryCompany : RepositoryBase<Company>, IRepositoryCompany
    {
        private readonly SqlContext _sqlContext;

        public RepositoryCompany(SqlContext sqlContext) : base(sqlContext)
        {
            _sqlContext = sqlContext;
            SetInclude(s => s.Include(i => i.Employees));
        }

    }
}
