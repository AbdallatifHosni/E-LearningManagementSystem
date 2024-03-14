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
    public class LearnersController : ControllerBase
    {
        private readonly ApplicatioDbContext _context;

        public LearnersController(ApplicatioDbContext context)
        {
            _context = context;
        }

        // GET: api/Learners
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Learner>>> GetLearner()
        {
            return await _context.Learner.ToListAsync();
        }

        // GET: api/Learners/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Learner>> GetLearner(int id)
        {
            var learner = await _context.Learner.FindAsync(id);

            if (learner == null)
            {
                return NotFound();
            }

            return learner;
        }

        // PUT: api/Learners/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLearner(int id, Learner learner)
        {
            if (id != learner.Id)
            {
                return BadRequest();
            }

            _context.Entry(learner).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LearnerExists(id))
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

        // POST: api/Learners
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Learner>> PostLearner(Learner learner)
        {
            _context.Learner.Add(learner);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (LearnerExists(learner.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetLearner", new { id = learner.Id }, learner);
        }

        // DELETE: api/Learners/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLearner(int id)
        {
            var learner = await _context.Learner.FindAsync(id);
            if (learner == null)
            {
                return NotFound();
            }

            _context.Learner.Remove(learner);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool LearnerExists(int id)
        {
            return _context.Learner.Any(e => e.Id == id);
        }
    }
}
