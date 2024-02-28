using Microsoft.EntityFrameworkCore;
using Students_System.Configurations;
using Students_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Students_System.Data
{
    internal class ApplicationDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }
        public DbSet<HomeworkSubmission> HomeworkSubmissions { get; set; }
        public DbSet<Resource> Resources { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=Student_System;Integrated Security=True;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            /**** Check The Configurations Folder for the FluentAPI Code (Separation of Concerns) ****/
            new StudentEntityTypeConfiguration().Configure(modelBuilder.Entity<Student>());
            new CourseEntityTypeConfiguration().Configure(modelBuilder.Entity<Course>());
            new StudentCourseEntityTypeConfiguration().Configure(modelBuilder.Entity<StudentCourse>());
            new HomeworkEntityTypeConfiguration().Configure(modelBuilder.Entity<HomeworkSubmission>());
            new ResourceEntityTypeConfiguration().Configure(modelBuilder.Entity<Resource>());
        }
    }
}
