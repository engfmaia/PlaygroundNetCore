using Microsoft.EntityFrameworkCore;
using Playground.Business.Domain.Models.Restaurant;

namespace Playground.Data.DbContext
{
    public class PlaygroundDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public PlaygroundDbContext(DbContextOptions<PlaygroundDbContext> options) : base(options)
        {
        }

        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<CuisineType> CuisineTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Restaurant>().ToTable("Restaurant");
            modelBuilder.Entity<CuisineType>().ToTable("CuisineType");
        }
    }
}
