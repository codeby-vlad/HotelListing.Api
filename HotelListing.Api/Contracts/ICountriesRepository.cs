using HotelListing.Api.data;

namespace HotelListing.Api.Contracts
{
    public interface ICountriesRepository : IGenericRepository<Country>
    {
        Task<Country> GetDetails(int id);
    }
}
