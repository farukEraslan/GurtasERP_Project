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
    public class OrdersConfig : IEntityTypeConfiguration<Orders>
    {
        public void Configure(EntityTypeBuilder<Orders> builder)
        {
            builder.HasKey(e => e.OrderId);
            builder.Property(e => e.OrderNumber).HasMaxLength(255);
            builder.Property(e => e.BidNumber).HasMaxLength(255);
            builder.Property(e => e.Quantity).HasMaxLength(255);
            builder.Property(e => e.Material).HasMaxLength(255);
            builder.Property(e => e.Price);
            builder.Property(e => e.DeliveryTime).HasMaxLength(255);
            builder.Property(e => e.Discount);
            builder.Property(e => e.PackagingDetail).HasMaxLength(255);
            builder.Property(e => e.ShippingDetail).HasMaxLength(255);
            builder.Property(e => e.PaymentMethod).HasMaxLength(255);
            builder.Property(e => e.PaymentTerm).HasMaxLength(255);
            builder.Property(e => e.Description).HasMaxLength(1000);
            builder.Property(e => e.RecordDate);
            builder.Property(e => e.ModifiedDate);
            builder.Property(e => e.IsActive);
            builder.Property(e => e.Currency).HasMaxLength(255);


            builder.HasOne(e => e.User).WithMany().HasForeignKey(e => e.UserId);
        }
    }
}
