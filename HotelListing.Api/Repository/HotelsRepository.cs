using HotelListing.Api.Contracts;
using HotelListing.Api.data;

namespace HotelListing.Api.Repository
{
    public class HotelsRepository : GenericRepository<Hotel>, IHotelsRepository
    {
        public HotelsRepository(HotelListingDbContext context) : base(context)
        {
        }
    }
}
