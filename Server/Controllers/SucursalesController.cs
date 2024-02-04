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
    public class SucursalesController : ControllerBase
    {
        private readonly Contexto _context;

        public SucursalesController(Contexto context)
        {
            _context = context;
        }

        // GET: api/Sucursales
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Sucursales>>> GetSucursales()
        {
          if (_context.Sucursales == null)
          {
              return NotFound();
          }
            return await _context.Sucursales.ToListAsync();
        }

        // GET: api/Sucursales/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Sucursales>> GetSucursales(int id)
        {
          if (_context.Sucursales == null)
          {
              return NotFound();
          }
            var sucursales = await _context.Sucursales.FindAsync(id);

            if (sucursales == null)
            {
                return NotFound();
            }

            return sucursales;
        }

        // PUT: api/Sucursales/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSucursales(int id, Sucursales sucursales)
        {
            if (id != sucursales.SucursalId)
            {
                return BadRequest();
            }

            _context.Entry(sucursales).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SucursalesExists(id))
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

        // POST: api/Sucursales
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Sucursales>> PostSucursales(Sucursales sucursales)
        {
          if(!SucursalesExists(sucursales.SucursalId))
            _context.Sucursales.Add(sucursales);
          else
                _context.Sucursales.Update(sucursales);

          await _context.SaveChangesAsync();

            return Ok(sucursales);
        }

        // DELETE: api/Sucursales/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSucursales(int id)
        {
            if (_context.Sucursales == null)
            {
                return NotFound();
            }
            var sucursales = await _context.Sucursales.FindAsync(id);
            if (sucursales == null)
            {
                return NotFound();
            }

            _context.Sucursales.Remove(sucursales);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SucursalesExists(int id)
        {
            return (_context.Sucursales?.Any(e => e.SucursalId == id)).GetValueOrDefault();
        }
    }
}
