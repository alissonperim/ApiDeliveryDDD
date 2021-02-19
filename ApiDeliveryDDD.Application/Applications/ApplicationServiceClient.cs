using ApiDeliveryDDD.Application.Dtos;
using ApiDeliveryDDD.Application.Interfaces;
using ApiDeliveryDDD.Domain.Entities;
using ApiDeliveryDDD.Domain.Interfaces.Services;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApiDeliveryDDD.Application.Applications
{
    public class ApplicationServiceClient : IApplicationServiceClient
    {
        private readonly IServiceClient _serviceClient;
        private readonly IMapper _mapper;

        public ApplicationServiceClient(IServiceClient serviceClient, IMapper mapper)
        {
            _serviceClient = serviceClient;
            _mapper = mapper;
        }

        public async Task<ClientDto> Add(ClientDto clientDto)
        {
            try
            {
                var client = _mapper.Map<Client>(clientDto);
                var result = await _serviceClient.Add(client);
                return _mapper.Map<ClientDto>(result);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<ClientDto>> GetAll()
        {
            var result = await _serviceClient.GetAll();
            return _mapper.Map<IEnumerable<ClientDto>>(result);
        }

        public async Task<ClientDto> GetById(int id)
        {
            var result = await _serviceClient.GetById(id);
            return _mapper.Map<ClientDto>(result);
        }

        public async Task<bool> Remove(ClientDto clientDto)
        {
            try
            {
                var client = _mapper.Map<Client>(clientDto);
                return await _serviceClient.Remove(client);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public async Task<ClientDto> Update(ClientDto clientDto)
        {
            try
            {
                var client = _mapper.Map<Client>(clientDto);
                var result = await _serviceClient.Update(client);

                return _mapper.Map<ClientDto>(result);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
