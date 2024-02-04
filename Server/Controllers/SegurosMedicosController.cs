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
    public class SegurosMedicosController : ControllerBase
    {
        private readonly Contexto _context;

        public SegurosMedicosController(Contexto context)
        {
            _context = context;
        }

        // GET: api/SegurosMedicos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SegurosMedicos>>> GetSegurosMedicos()
        {
          if (_context.SegurosMedicos == null)
          {
              return NotFound();
          }
            return await _context.SegurosMedicos.ToListAsync();
        }

        // GET: api/SegurosMedicos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SegurosMedicos>> GetSegurosMedicos(int id)
        {
          if (_context.SegurosMedicos == null)
          {
              return NotFound();
          }
            var segurosMedicos = await _context.SegurosMedicos
                .Include(s => s.SegurosMedicosDetalles)
                .Where(s => s.SeguroMedicoId == id)
                .FirstOrDefaultAsync();

            if (segurosMedicos == null)
            {
                return NotFound();
            }

            return segurosMedicos;
        }

        // PUT: api/SegurosMedicos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSegurosMedicos(int id, SegurosMedicos segurosMedicos)
        {
            if (id != segurosMedicos.SeguroMedicoId)
            {
                return BadRequest();
            }

            _context.Entry(segurosMedicos).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SegurosMedicosExists(id))
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

        // POST: api/SegurosMedicos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SegurosMedicos>> PostSegurosMedicos(SegurosMedicos segurosMedicos)
        {
          if(!SegurosMedicosExists(segurosMedicos.SeguroMedicoId))
                _context.SegurosMedicos.Add(segurosMedicos);
          else
                _context.SegurosMedicos.Update(segurosMedicos);

          await _context.SaveChangesAsync();
            return Ok(segurosMedicos);
        }

        // DELETE: api/SegurosMedicos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSegurosMedicos(int id)
        {
            if (_context.SegurosMedicos == null)
            {
                return NotFound();
            }
            var segurosMedicos = await _context.SegurosMedicos.FindAsync(id);
            if (segurosMedicos == null)
            {
                return NotFound();
            }

            _context.SegurosMedicos.Remove(segurosMedicos);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("DeleteDetalles/{id}")]
        public async Task<IActionResult> DeleteDetalles(int id)
        {
            if (id <= 0)
            {
                return BadRequest();
            }
            var segurosMedicos = await _context.SegurosMedicosDetalles.FirstOrDefaultAsync(smd => smd.SeguroMedicoDetalleId == id);
            if (segurosMedicos is null)
            {
                return NotFound();
            }
            _context.SegurosMedicosDetalles.Remove(segurosMedicos);
            await _context.SaveChangesAsync();

            return Ok();
        }

        private bool SegurosMedicosExists(int id)
        {
            return (_context.SegurosMedicos?.Any(e => e.SeguroMedicoId == id)).GetValueOrDefault();
        }
    }
}
