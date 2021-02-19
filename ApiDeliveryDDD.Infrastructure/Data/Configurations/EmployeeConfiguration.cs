using ApiDeliveryDDD.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiDeliveryDDD.Infrastructure.Data.Configurations
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.Property(p => p.Id).IsRequired();
            builder.Property(p => p.Name).IsRequired();
            builder.Property(p => p.CompanyId).IsRequired();
            builder.Property(p => p.LastName).IsRequired();
            builder.Property(p => p.Cpf).IsRequired();
            builder.Property(p => p.PhoneNumber).IsRequired();
            builder.Property(p => p.Address).IsRequired();
            builder.Property(p => p.Email);



            builder.HasOne(h => h.Company)
                .WithMany(w => w.Employees)
                .HasForeignKey(h => h.CompanyId);
        }
    }
}
