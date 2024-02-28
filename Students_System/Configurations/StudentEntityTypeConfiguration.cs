using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Students_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students_System.Configurations
{
    internal class StudentEntityTypeConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            //Up to 100 characters, unicode
            builder.Property(e => e.Name).HasColumnType("nvarchar(100)").IsRequired();

            // 10 characters, not unicode, not required
            builder.Property(e => e.Phone).HasColumnType("varchar(10)");

            builder.Property(e => e.RegisteredOn).IsRequired();

            // One-To-Many Relationship with HomeworkSubmissions
            builder.HasMany(e => e.HomeworkSubmissions)
                .WithOne(e => e.Student)
                .HasForeignKey(e => e.StudentId)
                .IsRequired();
            
            builder.HasMany(e => e.StudentCources)
                .WithOne(e => e.Student)
                .HasForeignKey(e => e.StudentId)
                .IsRequired();
        }
    }
}
