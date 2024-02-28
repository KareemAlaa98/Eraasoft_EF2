using Students_System.Data;
using Students_System.Models;

namespace Students_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InsertDataIntoStudents();
            InsertDataIntoCourses();
            InsertDataIntoResources();
            InsertDataIntoHomeworks();
            InsertDataIntoStudentCourses();
        }


        public static void InsertDataIntoStudents()
        {
            ApplicationDbContext context = new ApplicationDbContext();
            context.Database.EnsureCreated();

            var students = new List<Student>()
            {
                new Student() { Name = "Ali", Phone = "1234567890", RegisteredOn = new DateTime(2022, 1, 1), BirthDay = new DateOnly(2000, 1, 1) },
                new Student() { Name = "Ahmed", Phone = "9876543210", RegisteredOn = new DateTime(2022, 1, 15), BirthDay = new DateOnly(2001, 2, 15) },
                new Student() { Name = "Mohamed", Phone = "0101010101", RegisteredOn = new DateTime(2022, 2, 1), BirthDay = new DateOnly(1999, 5, 10) }
            };

            context.Students.AddRange(students);
            context.SaveChanges();
        }

        static void InsertDataIntoCourses()
        {
            ApplicationDbContext context = new ApplicationDbContext();
            context.Database.EnsureCreated();

            var courses = new List<Course>()
            {
                new Course() { Name = "Course 1", Description = "Description 1", StartDate = new DateOnly(2022, 1, 1), EndDate = new DateOnly(2022, 6, 30), Price = 100 },
                new Course() { Name = "Course 2", Description = "Description 2", StartDate = new DateOnly(2022, 2, 1), EndDate = new DateOnly(2022, 7, 31), Price = 150 },
                new Course() { Name = "Course 3", Description = "Description 3", StartDate = new DateOnly(2022, 3, 1), EndDate = new DateOnly(2022, 8, 31), Price = 200 }
            };

            context.Courses.AddRange(courses);
            context.SaveChanges();
        }

        static void InsertDataIntoStudentCourses()
        {
            ApplicationDbContext context = new ApplicationDbContext();
            context.Database.EnsureCreated();

            context.StudentCourses.Add(new StudentCourse { StudentId = 1, CourseId = 1 });
            context.StudentCourses.Add(new StudentCourse { StudentId = 2, CourseId = 2 });
            context.StudentCourses.Add(new StudentCourse { StudentId = 3, CourseId = 3 });

            context.SaveChanges();
        }

        static void InsertDataIntoHomeworks()
        {
            ApplicationDbContext context = new ApplicationDbContext();
            context.Database.EnsureCreated();

            var homeworks = new List<HomeworkSubmission>()
            {
               new HomeworkSubmission() { Content = "path/to/file1", ContentType = ContentType.Pdf, SubmissionTime = new DateTime(2022, 1, 5), StudentId = 1, CourseId = 1 },
               new HomeworkSubmission() { Content = "path/to/file2", ContentType = ContentType.Zip, SubmissionTime = new DateTime(2022, 1, 10), StudentId = 2, CourseId = 2 },
               new HomeworkSubmission() { Content = "path/to/file3", ContentType = ContentType.Application, SubmissionTime = new DateTime(2022, 2, 15), StudentId = 3, CourseId = 3 }
            };

            context.HomeworkSubmissions.AddRange(homeworks);
            context.SaveChanges();
        }

        static void InsertDataIntoResources()
        {
            ApplicationDbContext context = new ApplicationDbContext();
            context.Database.EnsureCreated();

            var resources = new List<Resource>()
            {
                new Resource() { Name = "Resource 1", Url = "url1", ResourceType = ResourceType.Video, CourseId = 1 },
                new Resource() { Name = "Resource 2", Url = "url2", ResourceType = ResourceType.Presentation, CourseId = 2 },
                new Resource() { Name = "Resource 3", Url = "url3", ResourceType = ResourceType.Document, CourseId = 3 }
            };

            context.Resources.AddRange(resources);
            context.SaveChanges();
        }
    }
}
