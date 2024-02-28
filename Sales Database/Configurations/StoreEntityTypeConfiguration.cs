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
    internal class StoreEntityTypeConfiguration : IEntityTypeConfiguration<Store>
    {
        public void Configure(EntityTypeBuilder<Store> builder)
        {
            builder.Property(e => e.Name).HasColumnType("nvarchar(80)").IsRequired();

            // One-To-Many Relationship with Sales
            builder.HasMany(e => e.Sales)
                .WithOne(e => e.Store)
                .HasForeignKey(e => e.StoreId)
                .IsRequired();
        }
    }
}
