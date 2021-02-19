using ApiDeliveryDDD.Application.Dtos;
using ApiDeliveryDDD.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiDeliveryDDD.Application.Interfaces
{
    public interface IApplicationServiceClient
    {
        Task<ClientDto> Add(ClientDto clientDto);
        Task<ClientDto> Update(ClientDto clientDto);
        Task<bool> Remove(ClientDto clientDto);
        Task<IEnumerable<ClientDto>> GetAll();
        Task<ClientDto> GetById(int id);
    }
}
