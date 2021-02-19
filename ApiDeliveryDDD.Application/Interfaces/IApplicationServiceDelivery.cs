using ApiDeliveryDDD.Application.Dtos;
using ApiDeliveryDDD.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiDeliveryDDD.Application.Interfaces
{
    public interface IApplicationServiceDelivery
    {
        Task<DeliveryDto> Add(DeliveryDto deliveryDto);
        Task<DeliveryDto> Update(DeliveryDto deliveryDto);
        Task<bool> Remove(DeliveryDto deliveryDto);
        Task<IEnumerable<DeliveryDto>> GetAll();
        Task<DeliveryDto> GetById(int id);
    }
}
