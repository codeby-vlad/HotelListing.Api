using HotelListing.Api.Core.Models.Country;
using HotelListing.Api.Data;

namespace HotelListing.Api.Core.Contracts
{
    public interface ICountriesRepository : IGenericRepository<Country>
    {
        Task<CountryDto> GetDetails(int id);
    }
}
