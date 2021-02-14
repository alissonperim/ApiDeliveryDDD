using System;
using System.Collections.Generic;

namespace ApiDeliveryDDD.Domain.Entities
{
    public class Client : BaseClass
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public ICollection<Delivery> Deliveries{ get; set; }

        public Client()
        {
        }

        public Client(string name, string lastName, string address, string phoneNumber, string email, int id, DateTime registrationDate,
                      DateTime alterationDate, bool isActive) : base(id, registrationDate, alterationDate, isActive)
        {
            Name = name;
            LastName = lastName;
            Address = address;
            PhoneNumber = phoneNumber;
            Email = email;
        }
    }
}
