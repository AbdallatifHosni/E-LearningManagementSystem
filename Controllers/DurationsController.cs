using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using E_Learning_Management_System.Data;
using E_Learning_Management_System.Model;

namespace E_LearningManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DurationsController : ControllerBase
    {
        private readonly ApplicatioDbContext _context;

        public DurationsController(ApplicatioDbContext context)
        {
            _context = context;
        }

        // GET: api/Durations
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Duration>>> GetDuration()
        {
            return await _context.Duration.ToListAsync();
        }

        // GET: api/Durations/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Duration>> GetDuration(int id)
        {
            var duration = await _context.Duration.FindAsync(id);

            if (duration == null)
            {
                return NotFound();
            }

            return duration;
        }

        // PUT: api/Durations/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDuration(int id, Duration duration)
        {
            if (id != duration.Id)
            {
                return BadRequest();
            }

            _context.Entry(duration).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DurationExists(id))
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

        // POST: api/Durations
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Duration>> PostDuration(Duration duration)
        {
            _context.Duration.Add(duration);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDuration", new { id = duration.Id }, duration);
        }

        // DELETE: api/Durations/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDuration(int id)
        {
            var duration = await _context.Duration.FindAsync(id);
            if (duration == null)
            {
                return NotFound();
            }

            _context.Duration.Remove(duration);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DurationExists(int id)
        {
            return _context.Duration.Any(e => e.Id == id);
        }
    }
}
