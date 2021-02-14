using ApiDeliveryDDD.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiDeliveryDDD.Infrastructure.Data.Configurations
{
    public class CompanyConfiguration : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.Property(p => p.Id).IsRequired();
            builder.Property(p => p.Cnpj).IsRequired();
            builder.Property(p => p.CompanyName).IsRequired();
            builder.Property(p => p.FantasyName).IsRequired();
            builder.Property(p => p.PhoneNumber).IsRequired();
            builder.Property(p => p.Address).IsRequired();
            builder.Property(p => p.Email);
        }
    }
}
