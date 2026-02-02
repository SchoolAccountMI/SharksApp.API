using Microsoft.EntityFrameworkCore;
using SharksApp.API.Models;

namespace SharksApp.API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        public DbSet<Shark> Sharks { get; set; }
    }
}
