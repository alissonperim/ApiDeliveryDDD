using ApiDeliveryDDD.Domain.Entities;
using ApiDeliveryDDD.Domain.Interfaces.Repositories;
using ApiDeliveryDDD.Domain.Interfaces.Services;

namespace ApiDeliveryDDD.Domain.Services.Services
{
    public class ServiceClient : ServiceBase<Client>, IServiceClient
    {
        private readonly IRepositoryClient _repositoryClient;

        public ServiceClient(IRepositoryClient repositoryClient) : base(repositoryClient)
        {
            _repositoryClient = repositoryClient;
        }
    }
}
