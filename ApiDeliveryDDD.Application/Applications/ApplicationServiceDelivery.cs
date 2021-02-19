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
    public class ApplicationServiceDelivery : IApplicationServiceDelivery
    {
        private readonly IServiceDelivery _service;
        private readonly IMapper _mapper;

        public ApplicationServiceDelivery(IServiceDelivery service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        public async Task<DeliveryDto> Add(DeliveryDto deliveryDto)
        {
            try
            {
                var delivery = _mapper.Map<Delivery>(deliveryDto);
                var result = await _service.Add(delivery);
                return _mapper.Map<DeliveryDto>(result);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<DeliveryDto>> GetAll()
        {
            var result = await _service.GetAll();
            return _mapper.Map<IEnumerable<DeliveryDto>>(result);
        }

        public async Task<DeliveryDto> GetById(int id)
        {
            var result = await _service.GetById(id);
            return _mapper.Map<DeliveryDto>(result);
        }

        public async Task<bool> Remove(DeliveryDto deliveryDto)
        {
            try
            {
                var delivery = _mapper.Map<Delivery>(deliveryDto);
                return await _service.Remove(delivery);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public async Task<DeliveryDto> Update(DeliveryDto deliveryDto)
        {
            try
            {
                var delivery = _mapper.Map<Delivery>(deliveryDto);
                var result = await _service.Update(delivery);
                return _mapper.Map<DeliveryDto>(result);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
