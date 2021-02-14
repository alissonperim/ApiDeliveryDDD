using ApiDeliveryDDD.Domain.Entities.Enums;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiDeliveryDDD.Domain.Entities
{
    public class Delivery : BaseClass
    {
        public decimal Value { get; set; }
        public DateTime Date { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; }
        public int EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }

        public DeliveryStatus Status { get; set; }
        public PaymentMethod PaymentMethod { get; set; }

        public Delivery()
        {
        }

        public Delivery(decimal deliveryValue, DateTime deliveryDate, Company company, Employee employee, Client client, DeliveryStatus deliveryStatus,
                        PaymentMethod paymentMethod, int id, DateTime registrationDate, DateTime alterationDate, bool isActive) : base(id, registrationDate, alterationDate, isActive)
        {
            Value = deliveryValue;
            Date = deliveryDate;
            Company = company;
            Employee = employee;
            Client = client;
            Status = deliveryStatus;
            PaymentMethod = paymentMethod;
        }
    }
}
