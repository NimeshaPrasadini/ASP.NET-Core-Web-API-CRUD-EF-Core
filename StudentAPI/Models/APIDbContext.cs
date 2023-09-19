using Microsoft.EntityFrameworkCore;

namespace StudentAPI.Models
{
    public class APIDbContext : DbContext
    {
        public APIDbContext(DbContextOptions options) : base(options)
        {}

        public DbSet<Student> Students { get; set; }
    }
}
