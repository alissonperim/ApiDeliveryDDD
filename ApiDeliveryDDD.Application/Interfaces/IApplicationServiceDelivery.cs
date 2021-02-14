using ApiDeliveryDDD.Application.Dtos;
using ApiDeliveryDDD.Domain.Entities;
using System.Collections.Generic;

namespace ApiDeliveryDDD.Application.Interfaces
{
    public interface IApplicationServiceDelivery
    {
        DeliveryDto Add(DeliveryDto deliveryDto);
        DeliveryDto Update(DeliveryDto deliveryDto);
        bool Remove(int id);
        IEnumerable<DeliveryDto> GetAll();
        DeliveryDto GetById(int id);
    }
}
