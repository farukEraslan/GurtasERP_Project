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

            builder.HasData(
                new Projects { ProjectId = 1, ProjectNumber = "PO 77684-1", ProjectName = "545-AR Catalyst System", IsFinished = true, RecordDate = DateTime.Now, ModifiedDate = DateTime.Now, UserId = 1, CustomerId = 1 },
                new Projects { ProjectId = 2, ProjectNumber = "PO 77704-1", ProjectName = "545-AR Machine Saw Carriage and Feeder", IsFinished = true, RecordDate = DateTime.Now, ModifiedDate = DateTime.Now, UserId = 1, CustomerId = 1 },
                new Projects { ProjectId = 3, ProjectNumber = "PO 77736-1", ProjectName = "545-AR Chopper 500 - 1500", IsFinished = true, RecordDate = DateTime.Now, ModifiedDate = DateTime.Now, UserId = 1, CustomerId = 1 },
                new Projects { ProjectId = 4, ProjectNumber = "PO 77793-1", ProjectName = "545-AR Steel Band Tensioner", IsFinished = true, RecordDate = DateTime.Now, ModifiedDate = DateTime.Now, UserId = 1, CustomerId = 1 },
                new Projects { ProjectId = 5, ProjectNumber = "PO 77810-1", ProjectName = "545-AR Sandbox 100", IsFinished = true, RecordDate = DateTime.Now, ModifiedDate = DateTime.Now, UserId = 1, CustomerId = 1 },
                new Projects { ProjectId = 6, ProjectNumber = "PO 77912-1", ProjectName = "545-AR Platform Spindle Lifting", IsFinished = true, RecordDate = DateTime.Now, ModifiedDate = DateTime.Now, UserId = 1, CustomerId = 1 },
                new Projects { ProjectId = 7, ProjectNumber = "PO 77923-1", ProjectName = "545-AR Resin Mix Small Parts", IsFinished = true, RecordDate = DateTime.Now, ModifiedDate = DateTime.Now, UserId = 1, CustomerId = 1 },
                new Projects { ProjectId = 8, ProjectNumber = "PO 77924-1", ProjectName = "545-AR Netting Tensioner E1 Upgrade", IsFinished = true, RecordDate = DateTime.Now, ModifiedDate = DateTime.Now, UserId = 1, CustomerId = 1 },
                new Projects { ProjectId = 9, ProjectNumber = "PO 77938-1", ProjectName = "545-AR Gear Drive System", IsFinished = true, RecordDate = DateTime.Now, ModifiedDate = DateTime.Now, UserId = 1, CustomerId = 1 }
                );
        }
    }
}
