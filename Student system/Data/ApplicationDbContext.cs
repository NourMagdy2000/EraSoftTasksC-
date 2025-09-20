using Microsoft.EntityFrameworkCore;
using Student_system.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_system.Data
{
    public class ApplicationDbContext : DbContext

    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Resourse> Resourses { get; set; }
        public DbSet<HomeSubmisstion> HomeSubmisstions { get; set; }
        public DbSet<StudentCourses> StudentCourses { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Data Source=.;initial Catalog = School_database ;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;");

        }


    }

}
