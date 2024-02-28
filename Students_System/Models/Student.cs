using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students_System.Models
{
    internal class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string? Phone { get; set; }
        public DateTime RegisteredOn { get; set; }
        public DateOnly? BirthDay { get; set; }
        public List<StudentCourse> StudentCources { get; } = new List<StudentCourse>();
        public List<HomeworkSubmission> HomeworkSubmissions { get; } = new List<HomeworkSubmission>();

    }
}
