using HotelListing.Api.data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HotelListing.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController] 
    public class HotelsController : ControllerBase
    {
        private readonly HotelListingDbContext _context;

        public HotelsController(HotelListingDbContext context)
        {
            _context = context;
        }

        // GET: api/Hotels
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Hotel>>> Get()
        {
            return Ok(await _context.Hotels.ToListAsync());
        }

        // GET api/Hotels/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Hotel>> Get(int id)
        {
            var hotel = await _context.Hotels.FindAsync(id);
            if (hotel == null)
            {
                return NotFound();
            }
            return Ok(hotel);
        }

        // POST api/Hotels
        [HttpPost]
        public async Task<ActionResult<Hotel>> Post([FromBody] Hotel newHotel)
        {
            _context.Hotels.Add(newHotel);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(Get), new { id = newHotel.Id }, newHotel);
        }

        // PUT api/Hotels/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] Hotel updatedHotel)
        {
            if (id != updatedHotel.Id)
            {
                return BadRequest();
            }

            _context.Entry(updatedHotel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Hotels.Any(h => h.Id == id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // DELETE api/Hotels/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var hotel = await _context.Hotels.FindAsync(id);
            if (hotel == null)
            {
                return NotFound(new { message = "Hotel not found" });
            }

            _context.Hotels.Remove(hotel);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
