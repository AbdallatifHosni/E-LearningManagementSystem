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
    public class ContentsController : ControllerBase
    {
        private readonly ApplicatioDbContext _context;

        public ContentsController(ApplicatioDbContext context)
        {
            _context = context;
        }

        // GET: api/ContentDTOes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Content>>> GetContentDTO()
        {
            return await _context.Content.ToListAsync();
        }

        // GET: api/ContentDTOes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Content>> GetContentDTO(int id)
        {
            var contentDTO = await _context.Content.FindAsync(id);

            if (contentDTO == null)
            {
                return NotFound();
            }

            return contentDTO;
        }

        // PUT: api/ContentDTOes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutContentDTO(int id, Content contentDTO)
        {
            if (id != contentDTO.ContentId)
            {
                return BadRequest();
            }

            _context.Entry(contentDTO).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ContentDTOExists(id))
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

        // POST: api/ContentDTOes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Content>> PostContentDTO(Content contentDTO)
        {
            _context.Content.Add(contentDTO);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetContentDTO", new { id = contentDTO.ContentId }, contentDTO);
        }

        // DELETE: api/ContentDTOes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteContentDTO(int id)
        {
            var contentDTO = await _context.Content.FindAsync(id);
            if (contentDTO == null)
            {
                return NotFound();
            }

            _context.Content.Remove(contentDTO);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ContentDTOExists(int id)
        {
            return _context.Content.Any(e => e.ContentId == id);
        }
    }
}
