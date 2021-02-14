using System;
using System.Collections.Generic;

namespace ApiDeliveryDDD.Domain.Entities
{
    public class Company : BaseClass
    {
        public string Cnpj { get; set; }
        public string FantasyName { get; set; }
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public Company()
        {
        }

        public Company(string cnpj, string fantasyName, string companyName, string address, string phoneNumber, string email, int id,
                        DateTime registrationDate, DateTime alterationDate, bool isActive) : base(id, registrationDate, alterationDate, isActive)
        {
            Cnpj = cnpj;
            FantasyName = fantasyName;
            CompanyName = companyName;
            Address = address;
            PhoneNumber = phoneNumber;
            Email = email;
        }
    }
}
