using AutoMapper;
using HotelListing.Api.Core.Contracts;
using HotelListing.Api.Data;

namespace HotelListing.Api.Core.Repository
{
    public class HotelsRepository : GenericRepository<Hotel>, IHotelsRepository
    {
        public HotelsRepository(HotelListingDbContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
 