using Gurtas.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gurtas.DAL.Config
{
    public class CustomersConfig : IEntityTypeConfiguration<Customers>
    {
        public void Configure(EntityTypeBuilder<Customers> builder)
        {
            builder.HasKey(e => e.CustomerId);
            builder.Property(e => e.CustomerName).HasMaxLength(255);
            builder.Property(e => e.ContactTitle).HasMaxLength(255);
            builder.Property(e => e.Phone).HasMaxLength(25);
            builder.Property(e => e.Email).HasMaxLength(255);
            builder.Property(e => e.Address).HasMaxLength(1000);
            builder.Property(e => e.City).HasMaxLength(255);
            builder.Property(e => e.Country).HasMaxLength(255);
            builder.Property(e => e.PostalCode).HasMaxLength(255);
            builder.Property(e => e.RecordDate);
            builder.Property(e => e.ModifiedDate);

            builder.HasOne(e=>e.User).WithMany().HasForeignKey(e=>e.UserId);

            builder.HasData(
                new Customers { CustomerId= 1, CustomerName = "Amiblu", ContactTitle = "Roger Hagen", Phone = "+47 452 26 710", Email = "roger.hagen@amiblu.com", Address = "Ostre Kullerod 3 | 3241 Snaderfjord | Norway", City = "Sandefjord", Country = "Norway", PostalCode = "3241", RecordDate = DateTime.Now, ModifiedDate = DateTime.Now, UserId = 1 }
                );
        }
    }
}
