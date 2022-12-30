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
    public class InputControlConfig : IEntityTypeConfiguration<InputControl>
    {
        public void Configure(EntityTypeBuilder<InputControl> builder)
        {
            builder.HasKey(e => e.FormId);
            builder.Property(e => e.ReportNo).HasMaxLength(255);
            builder.Property(e => e.ReportDate);
            builder.Property(e => e.Supplier).HasMaxLength(255);
            builder.Property(e => e.Material).HasMaxLength(255);
            builder.Property(e => e.BillNo).HasMaxLength(255);
            builder.Property(e => e.BillDate);
            builder.Property(e => e.ProjectName).HasMaxLength(255);
            builder.Property(e => e.Decision).HasMaxLength(1000);
            builder.Property(e => e.Quality);
            builder.Property(e => e.Time);
            builder.Property(e => e.Certificate);
            builder.Property(e => e.Price);
            builder.Property(e => e.Payment);
            builder.Property(e => e.RecordDate);
            builder.Property(e => e.ModifiedDate);

            builder.HasOne(e => e.User).WithMany().HasForeignKey(e => e.UserId);
        }
    }
}
