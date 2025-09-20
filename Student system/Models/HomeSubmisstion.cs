using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_system.Models
{
    public enum ContentType
    {
        Application,
        Pdf,
        Zip
    }
    public class HomeSubmisstion
    {
        public int HomeSubmisstionId { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public ContentType Content { get; set; }
        public string ContentType { get; set; }
        public string SubmissionTime { get; set; }
    }
}
