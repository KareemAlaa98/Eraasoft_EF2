using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sales_Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales_Database.Configurations
{
    internal class CustomerEntityTypeConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.Property(e => e.Name).HasColumnType("nvarchar(100)").IsRequired();
            builder.Property(e => e.Email).HasColumnType("varchar(80)").IsRequired();
            builder.Property(e => e.CreditCardNumber).IsRequired();

            // One-To-Many Relationship with Sales
            builder.HasMany(e => e.Sales)
                .WithOne(e => e.Customer)
                .HasForeignKey(e => e.CustomerId)
                .IsRequired();
        }
    }
}
