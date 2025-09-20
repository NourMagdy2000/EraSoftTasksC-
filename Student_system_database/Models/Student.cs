using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_system.Models
{
    public class Student
    {

        public int Id { get; set; }
        [MaxLength(100)]
        [Unicode(false)]
        public string Name { get; set; }


        public string ?Birthdate { get; set; }

        [Column(TypeName = "char(10)")]
        [Unicode(false)]
        public string ?PhoneNumber { get; set; }

        [Column(TypeName = "DateTime")]
        public string RegisteredOt { get; set; }
        public List<HomeSubmisstion> homeSubmisstions { get; set; }

    }
}
