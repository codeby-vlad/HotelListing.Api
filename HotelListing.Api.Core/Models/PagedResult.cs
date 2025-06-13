namespace HotelListing.Api.Core.Models
{
    // send back to the client when someone request a paged result
    public class PagedResult<T>
    {
        public int TotalCount { get; set; } // total number of record in the table
        public int PageNumber { get; set; } // what page is the user on
        public int RecordNumber { get; set; } // how many records are coming back (25 for example)
        public List<T> Items { get; set; } // the actual items
    }
}
