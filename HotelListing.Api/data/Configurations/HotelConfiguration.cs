using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelListing.Api.data.Configurations
{
    public class HotelConfiguration : IEntityTypeConfiguration<Hotel>
    {
        public void Configure(EntityTypeBuilder<Hotel> builder)
        {
            builder.HasData(
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
