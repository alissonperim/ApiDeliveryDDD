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
    public class ApplicationServiceEmployee : IApplicationServiceEmployee
    {
        private readonly IServiceEmployee _service;
        private readonly IMapper _mapper;

        public ApplicationServiceEmployee(IServiceEmployee service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public EmployeeDto Add(EmployeeDto employeeDto)
        {
            try
            {
                var employee = _mapper.Map<Employee>(employeeDto);
                var result = _service.Add(employee);
                return _mapper.Map<EmployeeDto>(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<EmployeeDto> GetAll()
        {
            return _mapper.Map<IEnumerable<EmployeeDto>>(_service.GetAll());
        }

        public EmployeeDto GetById(int id)
        {
            return _mapper.Map<EmployeeDto>(_service.GetById(id));
        }

        public bool Remove(int id)
        {
            try
            {
                return _service.Remove(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public EmployeeDto Update(EmployeeDto employeeDto)
        {
            try
            {
                var client = _mapper.Map<Employee>(employeeDto);
                var result = _service.Update(client);

                return _mapper.Map<EmployeeDto>(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
