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
    public class UsersConfig : IEntityTypeConfiguration<Users>
    {
        public void Configure(EntityTypeBuilder<Users> builder)
        {
            builder.HasKey(e => e.UserId);
            builder.Property(e => e.Username).HasMaxLength(255);
            builder.Property(e => e.Name).HasMaxLength(255);
            builder.Property(e => e.Surname).HasMaxLength(255);
            builder.Property(e => e.Gender).HasMaxLength(255);
            builder.Property(e => e.Password).HasMaxLength(255);
            builder.Property(e => e.RecordDate);
            builder.Property(e => e.ModifiedDate);


            builder.HasData(
                new Users { UserId = 1, Username = "farukeraslan", Name = "Faruk", Surname = "Eraslan", Gender = "Erkek", Password = "qu4lity", RecordDate = DateTime.Now, ModifiedDate = DateTime.Now },
                new Users { UserId = 2, Username = "aykutozgur", Name = "Aykut", Surname = "Özgür", Gender = "Erkek", Password = "own3r", RecordDate = DateTime.Now, ModifiedDate = DateTime.Now },
                new Users { UserId = 3, Username = "aliyilmaz", Name = "Ali", Surname = "Yılmaz", Gender = "Erkek", Password = "pr0duction", RecordDate = DateTime.Now, ModifiedDate = DateTime.Now },
                new Users { UserId = 4, Username = "cemgulpinar", Name = "Cem", Surname = "Gülpınar", Gender = "Erkek", Password = "acc0ntting", RecordDate = DateTime.Now, ModifiedDate = DateTime.Now },
                new Users { UserId = 5, Username = "orhanozgur", Name = "Orhan", Surname = "Özgür", Gender = "Erkek", Password = "purch4sing", RecordDate = DateTime.Now, ModifiedDate = DateTime.Now },
                new Users { UserId = 6, Username = "farukkurtoglu", Name = "Faruk", Surname = "Kurtoğlu", Gender = "Erkek", Password = "log1stic", RecordDate = DateTime.Now, ModifiedDate = DateTime.Now }
                );
        }
    }
}
