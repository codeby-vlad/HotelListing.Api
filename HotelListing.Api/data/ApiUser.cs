using Microsoft.AspNetCore.Identity;

namespace HotelListing.Api.data
{
    public class ApiUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
