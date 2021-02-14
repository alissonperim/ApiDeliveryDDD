using ApiDeliveryDDD.Application.Dtos;
using ApiDeliveryDDD.Domain.Entities;
using System.Collections.Generic;

namespace ApiDeliveryDDD.Application.Interfaces
{
    public interface IApplicationServiceEmployee
    {
        EmployeeDto Add(EmployeeDto companyDto);
        EmployeeDto Update(EmployeeDto companyDto);
        bool Remove(int id);
        IEnumerable<EmployeeDto> GetAll();
        EmployeeDto GetById(int id);
    }
}
