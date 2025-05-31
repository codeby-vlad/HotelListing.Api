using Microsoft.EntityFrameworkCore;

namespace HotelListing.Api.data
{
    public class HotelListingDbContext : DbContext
    {
        public HotelListingDbContext(DbContextOptions<HotelListingDbContext> options) : base (options)
        {
            
        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Hotel> Hotels { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    CountryId = 1,
                    Name = "Norway",
                    ShortName = "NO"
                },
                new Country
                {
                    CountryId = 2,
                    Name = "Bahamas",
                    ShortName = "BS"
                },
                new Country
                {
                    CountryId = 3,
                    Name = "Spain",
                    ShortName = "ESP"
                }
                );

            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Hilton",
                    Address = "Oslo",
                    CountryId = 1,
                    Rating = 4.7
                },
                new Hotel
                {
                    Id = 2,
                    Name = "Marriott International",
                    Address = "Barcelona",
                    CountryId = 3,
                    Rating = 4.8
                },
                new Hotel
                {
                    Id = 3,
                    Name = "Hyatt Hotels Corporation",
                    Address = "Nassau",
                    CountryId = 2,
                    Rating = 4.5
                }
                );
        }
    }
}
