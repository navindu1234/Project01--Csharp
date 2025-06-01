using Microsoft.EntityFrameworkCore;
using WebApplication1.Models; // Adjust based on your structure

namespace WebApplication1.Data // Must match namespace in Program.cs
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Person> People { get; set; }
    }
}
