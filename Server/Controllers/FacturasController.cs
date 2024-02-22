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
    public class FacturasController : ControllerBase
    {
        private readonly Contexto _context;

        public FacturasController(Contexto context)
        {
            _context = context;
        }

        // GET: api/Facturas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Facturas>>> GetFacturas()
        {
          if (_context.Facturas == null)
          {
              return NotFound();
          }
            return await _context.Facturas.Include(f => f.FacturasDetalles).Include(f => f.PagosCuentasPorCobrar).Where(p => p.Eliminado != true).ToListAsync();
        }

        // GET: api/Facturas/CuentasPorCobrar
        [HttpGet("CuentasPorCobrar")]
        public async Task<ActionResult<IEnumerable<Facturas>>> GetCuentasPorCobrar()
        {
            if (_context.Facturas == null)
            {
                return NotFound();
            }
            return await _context.Facturas.Include(f => f.PagosCuentasPorCobrar).Where(p => p.Eliminado != true && p.Estado == "Pendiente").ToListAsync();
        }


        // GET: api/Facturas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Facturas>> GetFacturas(int id)
        {
          if (_context.Facturas == null)
          {
              return NotFound();
          }
            var facturas = await _context.Facturas
                .Include(f => f.FacturasDetalles)
                .Include(f => f.PagosCuentasPorCobrar)
                .Where(f => f.FacturaId == id && f.Eliminado != true)
                .FirstOrDefaultAsync();

            if (facturas == null)
            {
                return NotFound();
            }

            return facturas;
        }

        // PUT: api/Facturas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFacturas(int id, Facturas facturas)
        {
            if (id != facturas.FacturaId)
            {
                return BadRequest();
            }

            _context.Entry(facturas).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FacturasExists(id))
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

        // POST: api/Facturas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Facturas>> PostFacturas(Facturas facturas)
        {
          if(!FacturasExists(facturas.FacturaId))
                _context.Facturas.Add(facturas);
          else
                _context.Facturas.Update(facturas);

          await _context.SaveChangesAsync();
          return Ok(facturas);
        }
        // POST: api/Facturas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost("Pagos")]
        public async Task<ActionResult<Facturas>> PostPagosFacturas(Facturas facturas)
        {
           
            if (!FacturasExists(facturas.FacturaId))
                _context.Facturas.Add(facturas);
            else
                _context.Facturas.Update(facturas);

            await _context.SaveChangesAsync();
            return Ok(facturas);
        }
        // DELETE: api/Facturas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFacturas(int id)
        {
            if (_context.Facturas == null)
            {
                return NotFound();
            }
            var facturas = await _context.Facturas.FindAsync(id);
            if (facturas == null)
            {
                return NotFound();
            }

            _context.Facturas.Remove(facturas);
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
            var facturas = await _context.FacturasDetalles.FirstOrDefaultAsync(fd => fd.FacturaDetalleId == id);
            if (facturas is null)
            {
                return NotFound();
            }
            _context.FacturasDetalles.Remove(facturas);
            await _context.SaveChangesAsync();

            return Ok();
        }

        private bool FacturasExists(int id)
        {
            return (_context.Facturas?.Any(e => e.FacturaId == id)).GetValueOrDefault();
        }
    }
}
