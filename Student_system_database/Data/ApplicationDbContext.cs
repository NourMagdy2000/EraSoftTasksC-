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
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Resourse> Resourses { get; set; }
        public DbSet<HomeSubmisstion> HomeSubmisstions { get; set; }
        public DbSet<StudentCourses> StudentCourses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured) // important so EF won't override Program.cs config
            {
                optionsBuilder.UseSqlServer(
                    "Data Source=.;Initial Catalog=School_database;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;Application Intent=ReadWrite;MultiSubnetFailover=False"
                );
            }
        }
    }
}