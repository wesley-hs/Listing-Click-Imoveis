using Microsoft.EntityFrameworkCore;

namespace Listing_ClickImoveis.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Listing> Listings { get; set; }
        public DbSet<Midia> Midias { get; set; }
    }
}
   