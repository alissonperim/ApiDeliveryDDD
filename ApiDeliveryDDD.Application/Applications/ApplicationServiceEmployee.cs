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
    public class ApplicationServiceEmployee : IApplicationServiceEmployee
    {
        private readonly IServiceEmployee _service;
        private readonly IMapper _mapper;

        public ApplicationServiceEmployee(IServiceEmployee service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public async Task<EmployeeDto> Add(EmployeeDto employeeDto)
        {
            try
            {
                var employee = _mapper.Map<Employee>(employeeDto);
                var result = await _service.Add(employee);
                return _mapper.Map<EmployeeDto>(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<EmployeeDto>> GetAll()
        {
            var result = await _service.GetAll();
            return _mapper.Map<IEnumerable<EmployeeDto>>(result);
        }

        public async Task<EmployeeDto> GetById(int id)
        {
            var result = await _service.GetById(id);
            return _mapper.Map<EmployeeDto>(result);
        }

        public async Task<bool> Remove(EmployeeDto employeeDto)
        {
            try
            {
                var employee = _mapper.Map<Employee>(employeeDto);
                return await _service.Remove(employee);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<EmployeeDto> Update(EmployeeDto employeeDto)
        {
            try
            {
                var client = _mapper.Map<Employee>(employeeDto);
                var result = await _service.Update(client);

                return _mapper.Map<EmployeeDto>(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
