using ApiDeliveryDDD.Domain.Entities;
using System.Collections.Generic;

namespace ApiDeliveryDDD.Application.Dtos
{
    public class ClientDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public IEnumerable<Delivery> Deliveries { get; set; }
    }
}
