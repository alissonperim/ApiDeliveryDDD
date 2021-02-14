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
    public class ApplicationServiceDelivery : IApplicationServiceDelivery
    {
        private readonly IServiceDelivery _service;
        private readonly IMapper _mapper;

        public ApplicationServiceDelivery(IServiceDelivery service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        public DeliveryDto Add(DeliveryDto deliveryDto)
        {
            try
            {
                var delivery = _mapper.Map<Delivery>(deliveryDto);
                var result = _service.Add(delivery);
                return _mapper.Map<DeliveryDto>(result);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<DeliveryDto> GetAll()
        {
            var result = _service.GetAll();
            return _mapper.Map<IEnumerable<DeliveryDto>>(result);
        }

        public DeliveryDto GetById(int id)
        {
            var result = _service.GetById(id);
            return _mapper.Map<DeliveryDto>(result);
        }

        public bool Remove(int id)
        {
            try
            {
                return _service.Remove(id);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public DeliveryDto Update(DeliveryDto deliveryDto)
        {
            try
            {
                var delivery = _mapper.Map<Delivery>(deliveryDto);
                var result = _service.Update(delivery);
                return _mapper.Map<DeliveryDto>(result);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
