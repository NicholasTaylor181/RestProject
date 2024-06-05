using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Data
{
    public class YourDbContext : DbContext
    {
        public YourDbContext(DbContextOptions<YourDbContext> options) : base(options) { }

        public DbSet<Order> Orders { get; set; }
    }
}
