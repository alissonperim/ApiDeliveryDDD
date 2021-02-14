using ApiDeliveryDDD.Domain.Entities;
using ApiDeliveryDDD.Domain.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace ApiDeliveryDDD.Application.Dtos
{
    public class DeliveryDto
    {
        public int Id { get; set; }
        public decimal DeliveryValue { get; set; }
        public DateTime DeliveryDate { get; set; }
        public Company Company { get; set; }
        public Employee Employee { get; set; }
        public Client Client { get; set; }
        public DeliveryStatus DeliveryStatus { get; set; }
        public PaymentMethod PaymentMethod { get; set; }

    }
}
