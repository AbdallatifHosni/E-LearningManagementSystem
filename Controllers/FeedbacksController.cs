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
    public class FeedbacksController : ControllerBase
    {
        private readonly ApplicatioDbContext _context;

        public FeedbacksController(ApplicatioDbContext context)
        {
            _context = context;
        }

        // GET: api/Feedbacks
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Feedback>>> GetFeedbackDTO()
        {
            return await _context.Feedbacks.ToListAsync();
        }

        // GET: api/Feedbacks/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Feedback>> GetFeedbackDTO(int id)
        {
            var feedbackDTO = await _context.Feedbacks.FindAsync(id);

            if (feedbackDTO == null)
            {
                return NotFound();
            }

            return feedbackDTO;
        }

        // PUT: api/Feedbacks/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFeedbackDTO(int id, Feedback feedback)
        {
            if (id != feedback.FeedbackId)
            {
                return BadRequest();
            }

            _context.Entry(feedback).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FeedbackDTOExists(id))
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

        // POST: api/Feedbacks
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Feedback>> PostFeedbackDTO(Feedback feedbackDTO)
        {
            _context.Feedbacks.Add(feedbackDTO);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFeedbackDTO", new { id = feedbackDTO.FeedbackId }, feedbackDTO);
        }

        // DELETE: api/Feedbacks/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFeedbackDTO(int id)
        {
            var feedbackDTO = await _context.Feedbacks.FindAsync(id);
            if (feedbackDTO == null)
            {
                return NotFound();
            }

            _context.Feedbacks.Remove(feedbackDTO);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool FeedbackDTOExists(int id)
        {
            return _context.Feedbacks.Any(e => e.FeedbackId == id);
        }
    }
}
