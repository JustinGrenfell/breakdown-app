using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BreakdownAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BreakdownAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BreakdownsController : ControllerBase
    {
        private readonly BreakdownContext _context;

        public BreakdownsController(BreakdownContext context)
        {
            _context = context;
        }

        // Get all breakdowns
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Breakdown>>> GetBreakdowns()
        {
            return await _context.Breakdowns.ToListAsync();
        }

        //Get a specific breakdown
        [HttpGet("{id}")]
        public async Task<ActionResult<Breakdown>> GetBreakdown(int id)
        {
            var breakdown = await _context.Breakdowns.FindAsync(id);

            if (breakdown == null)
            {
                return NotFound();
            }

            return breakdown;
        }

        // Make new breakdown
        [HttpPost]
        public async Task<ActionResult<Breakdown>> PostBreakdown(Breakdown breakdown)
        {
            _context.Breakdowns.Add(breakdown);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetBreakdown), new { id = breakdown.Id }, breakdown);
        }

        // Update Breakdown
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBreakdown(int id, Breakdown breakdown)
        {
            if (id != breakdown.Id)
            {
                return BadRequest();
            }

            _context.Entry(breakdown).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BreakdownExists(id))
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

        private bool BreakdownExists(int id)
        {
            return _context.Breakdowns.Any(e => e.Id == id);
        }
    }
}
