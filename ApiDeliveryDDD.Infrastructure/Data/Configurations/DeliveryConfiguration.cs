using ApiDeliveryDDD.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiDeliveryDDD.Infrastructure.Data.Configurations
{
    public class DeliveryConfiguration : IEntityTypeConfiguration<Delivery>
    {
        public void Configure(EntityTypeBuilder<Delivery> builder)
        {
            builder.Property(p => p.Id).IsRequired();
            builder.Property(p => p.PaymentMethod).IsRequired();
            builder.Property(p => p.Value).IsRequired();
            builder.Property(p => p.Status).IsRequired();

            builder.HasOne(h => h.Client)
                   .WithMany(w => w.Deliveries)
                   .HasForeignKey(h => h.ClientId);

            builder.HasOne(h => h.Employee)
                   .WithMany()
                   .HasForeignKey(h => h.EmployeeId);

            builder.HasOne(h => h.Company)
                .WithMany()
                .HasForeignKey(h => h.CompanyId);
        }
    }
}
