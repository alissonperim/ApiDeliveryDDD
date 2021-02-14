using ApiDeliveryDDD.Application.Dtos;
using ApiDeliveryDDD.Domain.Entities;
using System.Collections.Generic;

namespace ApiDeliveryDDD.Application.Interfaces
{
    public interface IApplicationServiceCompany
    {
        CompanyDto Add(CompanyDto companyDto);
        CompanyDto Update(CompanyDto companyDto);
        bool Remove(int id);
        IEnumerable<CompanyDto> GetAll();
        CompanyDto GetById(int id);
    }
}
