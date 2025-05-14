using Microsoft.EntityFrameworkCore;

namespace diplom.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
