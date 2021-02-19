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
    public class ApplicationServiceCompany : IApplicationServiceCompany
    {
        private readonly IServiceCompany _service;
        private readonly IMapper _mapper;

        public ApplicationServiceCompany(IServiceCompany service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        public async Task<CompanyDto> Add(CompanyDto companyDto)
        {
            try
            {
                var company = _mapper.Map<Company>(companyDto);
                var result = await _service.Add(company);
                return _mapper.Map<CompanyDto>(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<CompanyDto>> GetAll()
        {
            var result = await _service.GetAll();
            return _mapper.Map<IEnumerable<CompanyDto>>(result);
        }

        public async Task<CompanyDto> GetById(int id)
        {
            var result = await _service.GetById(id);
            return _mapper.Map<CompanyDto>(result);
        }

        public async Task<bool> Remove(CompanyDto companyDto)
        {
            try
            {
                var company = _mapper.Map<Company>(companyDto);
                return await _service.Remove(company);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<CompanyDto> Update(CompanyDto companyDto)
        {
            try
            {
                var company = _mapper.Map<Company>(companyDto);
                var result = await _service.Update(company);

                return _mapper.Map<CompanyDto>(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
