using ApiDeliveryDDD.Application.Dtos;
using ApiDeliveryDDD.Application.Interfaces;
using ApiDeliveryDDD.Domain.Entities;
using ApiDeliveryDDD.Domain.Interfaces.Services;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

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

        public ClientDto Add(ClientDto clientDto)
        {
            try
            {
                var client = _mapper.Map<Client>(clientDto);
                var result = _serviceClient.Add(client);
                return _mapper.Map<ClientDto>(result);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<ClientDto> GetAll()
        {
            return _mapper.Map<IEnumerable<ClientDto>>(_serviceClient.GetAll());
        }

        public ClientDto GetById(int id)
        {
            return _mapper.Map<ClientDto>(_serviceClient.GetById(id));
        }

        public bool Remove(int id)
        {
            try
            {
                return _serviceClient.Remove(id);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public ClientDto Update(ClientDto clientDto)
        {
            try
            {
                var client = _mapper.Map<Client>(clientDto);
                var result =_serviceClient.Update(client);

                return _mapper.Map<ClientDto>(result);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
