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
    public class MermasController : ControllerBase
    {
        private readonly Contexto _context;

        public MermasController(Contexto context)
        {
            _context = context;
        }

        // GET: api/Mermas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Mermas>>> GetMermas()
        {
          if (_context.Mermas == null)
          {
              return NotFound();
          }
            return await _context.Mermas.ToListAsync();
        }

        // GET: api/Mermas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Mermas>> GetMermas(int id)
        {
          if (_context.Mermas == null)
          {
              return NotFound();
          }
            var mermas = await _context.Mermas.FindAsync(id);

            if (mermas == null)
            {
                return NotFound();
            }

            return mermas;
        }

        // PUT: api/Mermas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMermas(int id, Mermas mermas)
        {
            if (id != mermas.MermaId)
            {
                return BadRequest();
            }

            _context.Entry(mermas).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MermasExists(id))
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

        // POST: api/Mermas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Mermas>> PostMermas(Mermas mermas)
        {
			if (!MermasExists(mermas.MermaId))
				_context.Mermas.Add(mermas);
			else
				_context.Mermas.Update(mermas);

			await _context.SaveChangesAsync();
			return Ok(mermas);
		}

        // DELETE: api/Mermas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMermas(int id)
        {
            if (_context.Mermas == null)
            {
                return NotFound();
            }
            var mermas = await _context.Mermas.FindAsync(id);
            if (mermas == null)
            {
                return NotFound();
            }

            _context.Mermas.Remove(mermas);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MermasExists(int id)
        {
            return (_context.Mermas?.Any(e => e.MermaId == id)).GetValueOrDefault();
        }
    }
}
