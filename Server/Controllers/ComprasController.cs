using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FarmaYah.Server.DAL;
using FarmaYah.Shared.Models;
using FarmaYah.Client.Pages.Registros;

namespace FarmaYah.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComprasController : ControllerBase
    {
        private readonly Contexto _context;

        public ComprasController(Contexto context)
        {
            _context = context;
        }

        // GET: api/Compras
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Compras>>> GetCompras()
        {
          if (_context.Compras == null)
          {
              return NotFound();
          }
            return await _context.Compras.Include(f => f.d_Compra).Include(c => c.CuentasPorPagar).ToListAsync();
        }

        // GET: api/Compras/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Compras>> GetCompras(int id)
        {
          if (_context.Compras == null)
          {
              return NotFound();
          }
            var compras = await _context.Compras
                        .Include(f => f.d_Compra)
                        .Include(c => c.CuentasPorPagar)
                        .Where(f => f.CompraId == id)
                        .FirstOrDefaultAsync();


            if (compras == null)
            {
                return NotFound();
            }

            return compras;
        }

        // PUT: api/Compras/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCompras(int id, Compras compras)
        {
            if (id != compras.CompraId)
            {
                return BadRequest();
            }

            _context.Entry(compras).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ComprasExists(id))
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

        // POST: api/Compras
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Compras>> PostCompras(Compras compras)
        {
            if (!ComprasExists(compras.CompraId))
                _context.Compras.Add(compras);
            else
                _context.Compras.Update(compras);

            await _context.SaveChangesAsync();
            return Ok(compras);
        }

        // DELETE: api/Compras/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCompras(int id)
        {
            if (_context.Compras == null)
            {
                return NotFound();
            }
            var compras = await _context.Compras.FindAsync(id);
            if (compras == null)
            {
                return NotFound();
            }

            _context.Compras.Remove(compras);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ComprasExists(int id)
        {
            return (_context.Compras?.Any(e => e.CompraId == id)).GetValueOrDefault();
        }

        [HttpDelete("DeleteDetalles/{id}")]
        public async Task<IActionResult> DeleteDetalles(int id)
        {
            if (id <= 0)
            {
                return BadRequest();
            }
            var compras = await _context.d_Compra.FirstOrDefaultAsync(fd => fd.CompraId == id);
            if (compras is null)
            {
                return NotFound();
            }
            _context.d_Compra.Remove(compras);
            await _context.SaveChangesAsync();

            return Ok();
        }

        [HttpDelete("DeleteDetallesCxP/{id}")]
        public async Task<IActionResult> DeleteDetallesCxP(int id)
        {
            if (id <= 0)
            {
                return BadRequest();
            }
            var compras = await _context.CuentasPorPagar.FirstOrDefaultAsync(fd => fd.CompraId == id);
            if (compras is null)
            {
                return NotFound();
            }
            _context.CuentasPorPagar.Remove(compras);
            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}
