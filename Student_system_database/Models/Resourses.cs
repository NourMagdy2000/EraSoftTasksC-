using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_system.Models
{
    public enum ResourceType
    {
        Video,
        Presentation,
        Document,
        Other
    }
    public class Resourse
    {
         
        public int ResourseId { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
        [MaxLength(50)]
        [Unicode(true)]    
        public string Name { get; set; }
        [Unicode(false)]
        public string Url { get; set; }
        public ResourceType ResourceType { get; set; }

    }
}
