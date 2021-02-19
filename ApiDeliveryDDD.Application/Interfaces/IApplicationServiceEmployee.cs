using ApiDeliveryDDD.Application.Dtos;
using ApiDeliveryDDD.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiDeliveryDDD.Application.Interfaces
{
    public interface IApplicationServiceEmployee
    {
        Task<EmployeeDto> Add(EmployeeDto companyDto);
        Task<EmployeeDto> Update(EmployeeDto companyDto);
        Task<bool> Remove(EmployeeDto companyDto);
        Task<IEnumerable<EmployeeDto>> GetAll();
        Task<EmployeeDto> GetById(int id);
    }
}
