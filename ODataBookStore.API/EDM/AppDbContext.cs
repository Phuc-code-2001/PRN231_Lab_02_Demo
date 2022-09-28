using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ODataBookStore.EDM
{
    public class AppDbContext : DbContext
    {

        private IConfiguration _configuration;
        public AppDbContext(DbContextOptions options, IConfiguration configuration) : base(options)
        {
            _configuration = configuration;
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Press> Presses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().OwnsOne(b => b.Location);
            // modelBuilder.Entity<Book>().HasData(new DataSamples.DataSources().Books);
        }


    }
}
