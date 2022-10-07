using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TrainingTracker.Models
{
    public class EmployeeDetailsContext : DbContext
    {
        public EmployeeDetailsContext (DbContextOptions<EmployeeDetailsContext> options)
            : base(options)
        {
        }

        public DbSet<TrainingTracker.Models.EmployeeDetails> EmployeeDetails { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().ToTable("Course");
            modelBuilder.Entity<Enrollment>().ToTable("Enrollment");
            modelBuilder.Entity<EmployeeDetails>().ToTable("EmployeeDetails");
        }
    }
}
