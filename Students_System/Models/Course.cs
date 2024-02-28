using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students_System.Models
{
    internal class Course
    {
        public int CourseId { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
        public int Price { get; set; }
        public List<StudentCourse> StudentCources { get; } = new List<StudentCourse>();
        public List<Resource> Resources { get; } = new List<Resource>();
        public List<HomeworkSubmission> HomeworkSubmissions { get; } = new List<HomeworkSubmission>();

    }
}
