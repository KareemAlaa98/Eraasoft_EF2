using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students_System.Models
{
    internal class HomeworkSubmission
    {
        [Key]
        public int HomeworkId { get; set; }
        public string Content { get; set; }
        public ContentType ContentType { get; set; }
        public DateTime SubmissionTime { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public Student Student { get; set; }

    }
    public enum ContentType
    {
        Application,
        Pdf,
        Zip
    }
}
