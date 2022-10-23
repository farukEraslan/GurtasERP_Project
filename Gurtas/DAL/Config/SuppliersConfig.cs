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
    public class SuppliersConfig : IEntityTypeConfiguration<Suppliers>
    {
        public void Configure(EntityTypeBuilder<Suppliers> builder)
        {
            builder.HasKey(e => e.SupplierId);
            builder.Property(e => e.CompanyName).HasMaxLength(255);
            builder.Property(e => e.ContactName).HasMaxLength(255);
            builder.Property(e => e.Address).HasMaxLength(1000);
            builder.Property(e => e.TaxOfficeAndNumber).HasMaxLength(255);
            builder.Property(e => e.Phone).HasMaxLength(25);
            builder.Property(e => e.CompanyRating);
            builder.Property(e => e.Goods).HasMaxLength(255);
            builder.Property(e => e.IsApproved);

            builder.HasOne(e => e.User).WithMany().HasForeignKey(e => e.UserId);

            builder.HasData(
                new Suppliers() { SupplierId = 1, CompanyName = "Gürtaş", ContactName = "Faruk Eraslan", Address = "Karadenizliler mah. Ordulu Cad.", TaxOfficeAndNumber = "1234567890", Phone = "0262 123 45 67", CompanyRating = 100, Goods = "Makine İmalatı", IsApproved = true, RecordDate = DateTime.Now, ModifiedDate = DateTime.Now, UserId = 1 }
                ) ;
        }
    }
}
