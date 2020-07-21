using KingICT.Academy.Model;
using KingICT.Academy.Repository.Configurations;
using Microsoft.EntityFrameworkCore;

namespace KingICT.Academy.Repository
{
    public class AcademyDbContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }

        public AcademyDbContext(DbContextOptions<AcademyDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CourseConfiguration());
            modelBuilder.ApplyConfiguration(new StudentConfiguration());
            modelBuilder.ApplyConfiguration(new StudentCourseConfiguration());
        }
    }
}
