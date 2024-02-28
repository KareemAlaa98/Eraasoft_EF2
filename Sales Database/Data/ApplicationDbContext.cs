using Microsoft.EntityFrameworkCore;
using Sales_Database.Configurations;
using Sales_Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Sales_Database.Data
{
    internal class ApplicationDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Sale> Sales { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=SalesDatabase;Integrated Security=True;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            /**** Check The Configurations Folder for the FluentAPI Code (Separation of Concerns) ****/
            new CustomerEntityTypeConfiguration().Configure(modelBuilder.Entity<Customer>());
            new ProductEntityTypeConfiguration().Configure(modelBuilder.Entity<Product>());
            new StoreEntityTypeConfiguration().Configure(modelBuilder.Entity<Store>());
            new SaleEntityTypeConfiguration().Configure(modelBuilder.Entity<Sale>());
        }
    }
}
