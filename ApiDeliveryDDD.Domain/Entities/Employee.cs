using System;

namespace ApiDeliveryDDD.Domain.Entities
{
    public class Employee : BaseClass
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Cpf { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int CompanyId { get; set; }

        public Employee()
        {
        }

        public Employee(string name, string lastName, string cpf, string address, string phoneNumber, string email, int id,
                        DateTime registrationDate, DateTime alterationDate, bool isActive) : base(id, registrationDate, alterationDate, isActive)
        {
            Name = name;
            LastName = lastName;
            Cpf = cpf;
            Address = address;
            PhoneNumber = phoneNumber;
            Email = email;
        }
    }
}
