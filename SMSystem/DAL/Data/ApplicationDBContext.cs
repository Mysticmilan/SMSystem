using Microsoft.EntityFrameworkCore;
using Domin.Models;

namespace Domin.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
            : base(options)
        {
        }

        // Define your DbSets here. For example:
        public DbSet<Student> Students { get; set; }
        public DbSet<Classes> Classes { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Course> Courses { get; set; }

    }
}
