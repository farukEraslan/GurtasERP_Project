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
    public class ProjectsConfig : IEntityTypeConfiguration<Projects>
    {
        public void Configure(EntityTypeBuilder<Projects> builder)
        {
            builder.HasKey(e => e.ProjectId);
            builder.Property(e => e.ProjectNumber).HasMaxLength(255);
            builder.Property(e => e.ProjectName).HasMaxLength(255);
            builder.Property(e => e.IsFinished);
            builder.Property(e => e.RecordDate);
            builder.Property(e => e.ModifiedDate);

            builder.HasOne(e => e.User).WithMany().HasForeignKey(e => e.UserId);
            builder.HasOne(e => e.Customer).WithMany(e=>e.Projects).HasForeignKey(e => e.CustomerId);
        }
    }
}
