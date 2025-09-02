using Microsoft.EntityFrameworkCore;
using NuGet.DependencyResolver;
using SchoolManagementSystem.Models.Courses;
using SchoolManagementSystem.Models.Grades;
using SchoolManagementSystem.Models.People;

namespace SchoolManagementSystem.Data
{
    // For business domain
    public class SchoolDbContext : DbContext
    {
        public SchoolDbContext(DbContextOptions<SchoolDbContext> options) : base(options) { }

        public DbSet<Student> Students => Set<Student>();
        public DbSet<Teacher> Teachers => Set<Teacher>();
        public DbSet<Course> Courses => Set<Course>();
        public DbSet<Grade> Grades => Set<Grade>();
        public DbSet<Enrollment> Enrollments => Set<Enrollment>();
        public DbSet<Attendance> Attendances => Set<Attendance>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Force every FK to Restrict
            foreach (var fk in modelBuilder.Model.GetEntityTypes()
                .SelectMany(e => e.GetForeignKeys()))
            {
                fk.DeleteBehavior = DeleteBehavior.NoAction;
            }
        }
    }

}
