using Data.Data;
using Librari.root.user;
//using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebApplication31.api
{
    [Route("api/")]
    [ApiController]
    public class ConrolerRolles : ControllerBase
    {
        private readonly WebContext _context;

        public ConrolerRolles(WebContext context)
        {
            _context = context;
        }

        // GET: api/Answers
        [HttpGet("Rolles")]
        public async Task<ActionResult<IEnumerable<Rolles>>> GetRolles()
        {
            return await _context.Rolles.ToListAsync();
        }

        // GET: api/Answers/5
        [HttpGet("/Rolles{id}")]
        public async Task<ActionResult<Rolles>> GetRolles(int id)
        {
            var Rolles = await _context.Rolles.FindAsync(id);

            if (Rolles == null)
            {
                return NotFound();
            }

            return Rolles;
        }

        // PUT: api/Rolles/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("Rolles{id}")]
        public async Task<IActionResult> PutRolles(int id, Rolles Rolles)
        {
            if (id != Rolles.Id)
            {
                return BadRequest();
            }

            _context.Entry(Rolles).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RollesExists(id))
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

        // POST: api/Rolles
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Rolles>> PostRolles(Rolles Rolles)
        {
            _context.Rolles.Add(Rolles);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRolles", new { id = Rolles.Id }, Rolles);
        }

        // DELETE: api/Rolles/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRolles(int id)
        {
            var answer = await _context.Rolles.FindAsync(id);
            if (answer == null)
            {
                return NotFound();
            }

            _context.Rolles.Remove(answer);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RollesExists(int id)
        {
            return _context.Rolles.Any(e => e.Id == id);
        }
    }
}
