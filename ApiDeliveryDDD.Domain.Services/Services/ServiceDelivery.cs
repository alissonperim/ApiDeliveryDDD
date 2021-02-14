using ApiDeliveryDDD.Domain.Entities;
using ApiDeliveryDDD.Domain.Interfaces.Repositories;
using ApiDeliveryDDD.Domain.Interfaces.Services;

namespace ApiDeliveryDDD.Domain.Services.Services
{
    public class ServiceDelivery : ServiceBase<Delivery>, IServiceDelivery
    {
        private readonly IRepositoryDelivery _repositoryDelivery;

        public ServiceDelivery(IRepositoryDelivery repositoryDelivery) : base(repositoryDelivery)
        {
            _repositoryDelivery = repositoryDelivery;
        }
    }
}
