using Microsoft.EntityFrameworkCore;
using Students_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Students_System.Configurations
{
    internal class CourseEntityTypeConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Course> builder)
        {
            builder.Property(e => e.Name).HasColumnType("nvarchar(80)").IsRequired();

            builder.Property(e => e.StartDate).IsRequired();
            builder.Property(e => e.EndDate).IsRequired();
            builder.Property(e => e.Price).IsRequired();

            // One-To-Many Relationship with Resources
            builder.HasMany(e => e.Resources)
                .WithOne(e => e.Course)
                .HasForeignKey(e => e.CourseId)
                .IsRequired();

            // One-To-Many Relationship with HomeworkSubmissions
            builder.HasMany(e => e.HomeworkSubmissions)
                .WithOne(e => e.Course)
                .HasForeignKey(e => e.CourseId)
                .IsRequired();

            builder.HasMany(e => e.StudentCources)
                .WithOne(e => e.Course)
                .HasForeignKey(e => e.CourseId)
                .IsRequired();
        }
    }
}
