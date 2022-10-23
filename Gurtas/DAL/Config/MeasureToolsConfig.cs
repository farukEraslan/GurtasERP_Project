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
    public class MeasureToolsConfig : IEntityTypeConfiguration<MeasureTools>
    {
        public void Configure(EntityTypeBuilder<MeasureTools> builder)
        {
            builder.HasKey(e => e.ToolId);
            builder.Property(e => e.ToolName).HasMaxLength(255);
            builder.Property(e => e.Manufacturer).HasMaxLength(255);
            builder.Property(e => e.Model).HasMaxLength(255);
            builder.Property(e => e.Type).HasMaxLength(255);
            builder.Property(e => e.MeasureRange).HasMaxLength(255);
            builder.Property(e => e.Accuracy).HasMaxLength(255);
            builder.Property(e => e.SerialNumber).HasMaxLength(255);
            builder.Property(e => e.CertificateNumber).HasMaxLength(255);
            builder.Property(e => e.CalibrationDate);
            builder.Property(e => e.NextCalibrationDate);
            builder.Property(e => e.RecordDate);
            builder.Property(e => e.ModifiedDate);

            builder.HasOne(e => e.User).WithMany().HasForeignKey(e => e.UserId);

            builder.HasData(
                new MeasureTools() { ToolId = 1, ToolName = "Kumpas", Manufacturer = "Mitutoyo", Model = "", Type = "Dijital", MeasureRange = "0-150", Accuracy = "0,01", SerialNumber = "B22084436", CertificateNumber = "22-4791", CalibrationDate = Convert.ToDateTime("2022-09-24"), NextCalibrationDate = Convert.ToDateTime("2023-09-24"), RecordDate = DateTime.Now, ModifiedDate = DateTime.Now, UserId = 1 }
                );
        }
    }
}
