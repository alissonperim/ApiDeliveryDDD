using System;
using System.Collections.Generic;
using System.Text;

namespace ApiDeliveryDDD.Application.Dtos
{
    public class EmployeeDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Cpf { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int CompanyId { get; set; }
        public CompanyDto Company { get; set; }
    }
}
