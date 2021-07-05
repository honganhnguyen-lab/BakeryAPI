using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BakeryWeb.Models;

namespace BakeryWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BakeryController : ControllerBase
    {
        private readonly BakeryContext _context;

        public BakeryController(BakeryContext context)
        {
            _context = context;
        }

        // GET: api/Bakery
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Bakery>>> GetBakerys()
        {
            return await _context.Bakerys.ToListAsync();
        }

        // GET: api/Bakery/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Bakery>> GetBakery(int id)
        {
            var bakery = await _context.Bakerys.FindAsync(id);

            if (bakery == null)
            {
                return NotFound();
            }

            return bakery;
        }

        // PUT: api/Bakery/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBakery(int id, Bakery bakery)
        {
            if (id != bakery.BakeryID)
            {
                return BadRequest();
            }

            _context.Entry(bakery).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BakeryExists(id))
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

        // POST: api/Bakery
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Bakery>> PostBakery(Bakery bakery)
        {
            _context.Bakerys.Add(bakery);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBakery", new { id = bakery.BakeryID }, bakery);
        }

        // DELETE: api/Bakery/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBakery(int id)
        {
            var bakery = await _context.Bakerys.FindAsync(id);
            if (bakery == null)
            {
                return NotFound();
            }

            _context.Bakerys.Remove(bakery);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BakeryExists(int id)
        {
            return _context.Bakerys.Any(e => e.BakeryID == id);
        }
    }
}
