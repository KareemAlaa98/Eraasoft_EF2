using Microsoft.EntityFrameworkCore;
using Sales_Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales_Database.Configurations
{
    internal class ProductEntityTypeConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Product> builder)
        {
            builder.Property(e => e.Name).HasColumnType("nvarchar(50)").IsRequired();
            builder.Property(e => e.Quantity).IsRequired();
            builder.Property(e => e.Price).IsRequired();

            // One-To-Many Relationship with Sales
            builder.HasMany(e => e.Sales)
                .WithOne(e => e.Product)
                .HasForeignKey(e => e.ProductId)
                .IsRequired();

            builder.Property(e => e.Description).HasColumnType("nvarchar(250)").HasDefaultValue("No Description");
        }
    }
}
