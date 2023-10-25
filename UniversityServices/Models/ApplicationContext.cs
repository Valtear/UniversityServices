using Microsoft.EntityFrameworkCore;

namespace UniversityServices.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<University> universities { get; set; }
        public DbSet<Faculty> faculties { get; set; }
        public DbSet<Resident> residents { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {

        }
    }
}
