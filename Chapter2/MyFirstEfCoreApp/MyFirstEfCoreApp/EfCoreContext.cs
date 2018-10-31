using Microsoft.EntityFrameworkCore;
using MyFirstEfCoreApp.Models;

namespace MyFirstEfCoreApp
{
    public class EfCoreContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<PriceOffer> PriceOffers { get; set; }

        public EfCoreContext (DbContextOptions<EfCoreContext> options)
            : base (options) { }

        protected override void OnModelCreating (ModelBuilder model) { }
    }
}
