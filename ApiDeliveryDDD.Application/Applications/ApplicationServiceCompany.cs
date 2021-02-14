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
    public class ApplicationServiceCompany : IApplicationServiceCompany
    {
        private readonly IServiceCompany _service;
        private readonly IMapper _mapper;

        public ApplicationServiceCompany(IServiceCompany service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        public CompanyDto Add(CompanyDto companyDto)
        {
            try
            {
                var company = _mapper.Map<Company>(companyDto);
                var result = _service.Add(company);
                return _mapper.Map<CompanyDto>(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<CompanyDto> GetAll()
        {
            var result = _service.GetAll();
            return _mapper.Map<IEnumerable<CompanyDto>>(result);
        }

        public CompanyDto GetById(int id)
        {
            return _mapper.Map<CompanyDto>(_service.GetById(id));
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

        public CompanyDto Update(CompanyDto companyDto)
        {
            try
            {
                var company = _mapper.Map<Company>(companyDto);
                var result = _service.Update(company);

                return _mapper.Map<CompanyDto>(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
