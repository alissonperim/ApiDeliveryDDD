using ApiDeliveryDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiDeliveryDDD.Application.Dtos
{
    public class CompanyDto
    {
        public int Id { get; set; }
        public string Cnpj { get; set; }
        public string FantasyName { get; set; }
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; } = true;
        public ICollection<EmployeeDto> Employees { get; set; }
    }
}
