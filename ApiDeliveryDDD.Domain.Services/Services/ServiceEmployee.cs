using ApiDeliveryDDD.Domain.Entities;
using ApiDeliveryDDD.Domain.Interfaces.Repositories;
using ApiDeliveryDDD.Domain.Interfaces.Services;

namespace ApiDeliveryDDD.Domain.Services.Services
{
    public class ServiceEmployee : ServiceBase<Employee>, IServiceEmployee
    {
        private readonly IRepositoryEmployee _repositoryEmployee;

        public ServiceEmployee(IRepositoryEmployee repositoryEmployee) : base(repositoryEmployee)
        {
            _repositoryEmployee = repositoryEmployee;
        }
    }
}
