using ApiDeliveryDDD.Domain.Entities;
using ApiDeliveryDDD.Domain.Interfaces.Repositories;
using ApiDeliveryDDD.Domain.Interfaces.Services;

namespace ApiDeliveryDDD.Domain.Services.Services
{
    public class ServiceCompany : ServiceBase<Company>, IServiceCompany
    {
        private readonly IRepositoryCompany _repositoryCompany;

        public ServiceCompany(IRepositoryCompany repositoryCompany) : base(repositoryCompany)
        {
            _repositoryCompany = repositoryCompany;
        }
    }
}
