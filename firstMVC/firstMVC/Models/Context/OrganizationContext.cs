using firstMVC.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace firstMVC.Models.Context
{
    public class OrganizationContext: DbContext
    {

        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Trainee> Trainees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Acount> Acounts { get; set; }
        public DbSet<CoursResult> CoursResult { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-4Q3BJNA;Initial Catalog=OrganizationDB;Integrated Security=True;Trust Server Certificate=True;");
        }
    }
}
