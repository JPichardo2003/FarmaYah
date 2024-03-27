using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FarmaYah.Server.DAL;
using FarmaYah.Shared.Models;

namespace FarmaYah.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AveriasController : ControllerBase
    {
        private readonly Contexto _context;

        public AveriasController(Contexto context)
        {
            _context = context;
        }

        // GET: api/Averias
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Averias>>> GetAverias()
        {
          if (_context.Averias == null)
          {
              return NotFound();
          }
            return await _context.Averias.ToListAsync();
        }

        // GET: api/Averias/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Averias>> GetAverias(int id)
        {
          if (_context.Averias == null)
          {
              return NotFound();
          }
            var averias = await _context.Averias.FindAsync(id);

            if (averias == null)
            {
                return NotFound();
            }

            return averias;
        }

        // PUT: api/Averias/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAverias(int id, Averias averias)
        {
            if (id != averias.AveriaId)
            {
                return BadRequest();
            }

            _context.Entry(averias).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AveriasExists(id))
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

        // POST: api/Averias
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Averias>> PostAverias(Averias averias)
        {
            if(!AveriasExists(averias.AveriaId))
                _context.Averias.Add(averias);
            else
                _context.Averias.Update(averias);
            await _context.SaveChangesAsync();
            return Ok(averias);
        }

        // DELETE: api/Averias/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAverias(int id)
        {
            if (_context.Averias == null)
            {
                return NotFound();
            }
            var averias = await _context.Averias.FindAsync(id);
            if (averias == null)
            {
                return NotFound();
            }

            _context.Averias.Remove(averias);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AveriasExists(int id)
        {
            return (_context.Averias?.Any(e => e.AveriaId == id)).GetValueOrDefault();
        }
    }
}
