using Microsoft.EntityFrameworkCore;
using ModelConfigurations.Models.Entities;

namespace ModelConfigurations.Models.Data
{
    public class SchoolContext : DbContext
    {
        public SchoolContext()
        {

        }

        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {

        }

        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Instructor> Instructors { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Department> Departments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("data source=output/School.db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

    }
}
