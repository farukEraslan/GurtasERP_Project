using Gurtas.DAL.Config;
using Gurtas.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gurtas.DAL.Context
{
    public class GurtasContext : DbContext
    {
        public DbSet<Users> Users { get; set; }
        public DbSet<MeasureTools> MeasureTools { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Suppliers> Suppliers { get; set; }
        public DbSet<Projects> Projects { get; set; }
        public DbSet<Orders> Orders { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = desktop-ufhr98h; Database = GurtasDB; uid = sa; pwd = 123;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsersConfig());
            modelBuilder.ApplyConfiguration(new MeasureToolsConfig());
            modelBuilder.ApplyConfiguration(new CustomersConfig());
            modelBuilder.ApplyConfiguration(new SuppliersConfig());
            modelBuilder.ApplyConfiguration(new ProjectsConfig());
            modelBuilder.ApplyConfiguration(new OrdersConfig());
        }
    }
}
