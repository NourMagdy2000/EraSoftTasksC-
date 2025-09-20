using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_system.Models
{
    public class Course
    {
        public int CourseId { get; set; }

        [MaxLength(100)]
        [Unicode(true)]
        public string Name { get; set; }
        [Unicode(true)]
        public string ?Description { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public decimal Price { get; set; }
        public List<Resourse> Resourses { get; set; }
        public List<HomeSubmisstion> homeSubmisstions { get; set; }
    }
    
}
