using ApiDeliveryDDD.Application.Dtos;
using ApiDeliveryDDD.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiDeliveryDDD.Application.Interfaces
{
    public interface IApplicationServiceCompany
    {
        Task<CompanyDto> Add(CompanyDto companyDto);
        Task<CompanyDto> Update(CompanyDto companyDto);
        Task<bool> Remove(CompanyDto companyDto);
        Task<IEnumerable<CompanyDto>> GetAll();
        Task<CompanyDto> GetById(int id);
    }
}
