using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelListing.Api.Data.Configurations
{
    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.HasData(
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
        }
    }
}
