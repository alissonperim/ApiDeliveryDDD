using ApiDeliveryDDD.Application.Dtos;
using ApiDeliveryDDD.Domain.Entities;
using System.Collections.Generic;

namespace ApiDeliveryDDD.Application.Interfaces
{
    public interface IApplicationServiceClient
    {
        ClientDto Add(ClientDto clientDto);
        ClientDto Update(ClientDto clientDto);
        bool Remove(int id);
        IEnumerable<ClientDto> GetAll();
        ClientDto GetById(int id);
    }
}
