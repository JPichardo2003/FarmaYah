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
    public class SegurosMedicosDetallesController : ControllerBase
    {
        private readonly Contexto _context;

        public SegurosMedicosDetallesController(Contexto context)
        {
            _context = context;
        }

        // GET: api/SegurosMedicosDetalles
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SegurosMedicosDetalles>>> GetSegurosMedicosDetalles()
        {
          if (_context.SegurosMedicosDetalles == null)
          {
              return NotFound();
          }
            return await _context.SegurosMedicosDetalles.ToListAsync();
        }

        // GET: api/SegurosMedicosDetalles/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SegurosMedicosDetalles>> GetSegurosMedicosDetalles(int id)
        {
          if (_context.SegurosMedicosDetalles == null)
          {
              return NotFound();
          }
            var segurosMedicosDetalles = await _context.SegurosMedicosDetalles.FindAsync(id);

            if (segurosMedicosDetalles == null)
            {
                return NotFound();
            }

            return segurosMedicosDetalles;
        }

        // PUT: api/SegurosMedicosDetalles/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSegurosMedicosDetalles(int id, SegurosMedicosDetalles segurosMedicosDetalles)
        {
            if (id != segurosMedicosDetalles.SeguroMedicoDetalleId)
            {
                return BadRequest();
            }

            _context.Entry(segurosMedicosDetalles).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SegurosMedicosDetallesExists(id))
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

        // POST: api/SegurosMedicosDetalles
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SegurosMedicosDetalles>> PostSegurosMedicosDetalles(SegurosMedicosDetalles segurosMedicosDetalles)
        {
          if (_context.SegurosMedicosDetalles == null)
          {
              return Problem("Entity set 'Contexto.SegurosMedicosDetalles'  is null.");
          }
            _context.SegurosMedicosDetalles.Add(segurosMedicosDetalles);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSegurosMedicosDetalles", new { id = segurosMedicosDetalles.SeguroMedicoDetalleId }, segurosMedicosDetalles);
        }

        // DELETE: api/SegurosMedicosDetalles/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSegurosMedicosDetalles(int id)
        {
            if (_context.SegurosMedicosDetalles == null)
            {
                return NotFound();
            }
            var segurosMedicosDetalles = await _context.SegurosMedicosDetalles.FindAsync(id);
            if (segurosMedicosDetalles == null)
            {
                return NotFound();
            }

            _context.SegurosMedicosDetalles.Remove(segurosMedicosDetalles);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SegurosMedicosDetallesExists(int id)
        {
            return (_context.SegurosMedicosDetalles?.Any(e => e.SeguroMedicoDetalleId == id)).GetValueOrDefault();
        }
    }
}
