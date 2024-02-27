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
    public class UnidadesController : ControllerBase
    {
        private readonly Contexto _context;

        public UnidadesController(Contexto context)
        {
            _context = context;
        }

        // GET: api/Unidades
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Unidad>>> GetUnidad()
        {
          if (_context.Unidades == null)
          {
              return NotFound();
          }
            return await _context.Unidades.Where(u => u.Eliminado == false).ToListAsync();
        }

        // GET: api/Unidades/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Unidad>> GetUnidad(int id)
        {
          if (_context.Unidades == null)
          {
              return NotFound();
          }
            var unidad = await _context.Unidades.FirstOrDefaultAsync(u => u.Eliminado == false && u.UnidadId == id);

            if (unidad == null)
            {
                return NotFound();
            }

            return unidad;
        }

        // PUT: api/Unidades/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUnidad(int id, Unidad unidad)
        {
            if (id != unidad.UnidadId)
            {
                return BadRequest();
            }

            _context.Entry(unidad).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UnidadExists(id))
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

        // POST: api/Unidades
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Unidad>> PostUnidad(Unidad unidad)
        {
			if (!UnidadExists(unidad.UnidadId))
				_context.Unidades.Add(unidad);
			else
				_context.Unidades.Update(unidad);

			await _context.SaveChangesAsync();
			return Ok(unidad);
		}
         


        // DELETE: api/Unidades/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUnidad(int id)
        {
            if (_context.Unidades == null)
            {
                return NotFound();
            }
            var unidad = await _context.Unidades.FindAsync(id);
            if (unidad == null)
            {
                return NotFound();
            }
            unidad.Eliminado = true;
            _context.Unidades.Update(unidad);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UnidadExists(int id)
        {
            return (_context.Unidades?.Any(e => e.UnidadId == id)).GetValueOrDefault();
        }
    }
}
