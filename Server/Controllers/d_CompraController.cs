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
    public class d_CompraController : ControllerBase
    {
        private readonly Contexto _context;

        public d_CompraController(Contexto context)
        {
            _context = context;
        }

        // GET: api/d_Compra
        [HttpGet]
        public async Task<ActionResult<IEnumerable<d_Compra>>> Getd_Compra()
        {
          if (_context.d_Compra == null)
          {
              return NotFound();
          }
            return await _context.d_Compra.ToListAsync();
        }

        // GET: api/d_Compra/5
        [HttpGet("{id}")]
        public async Task<ActionResult<d_Compra>> Getd_Compra(int id)
        {
          if (_context.d_Compra == null)
          {
              return NotFound();
          }
            var d_Compra = await _context.d_Compra.FindAsync(id);

            if (d_Compra == null)
            {
                return NotFound();
            }

            return d_Compra;
        }

        // PUT: api/d_Compra/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> Putd_Compra(int id, d_Compra d_Compra)
        {
            if (id != d_Compra.d_CompraId)
            {
                return BadRequest();
            }

            _context.Entry(d_Compra).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!d_CompraExists(id))
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

        // POST: api/d_Compra
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<d_Compra>> Postd_Compra(d_Compra d_Compra)
        {
          if (_context.d_Compra == null)
          {
              return Problem("Entity set 'Contexto.d_Compra'  is null.");
          }
            _context.d_Compra.Add(d_Compra);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Getd_Compra", new { id = d_Compra.d_CompraId }, d_Compra);
        }

        // DELETE: api/d_Compra/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Deleted_Compra(int id)
        {
            if (_context.d_Compra == null)
            {
                return NotFound();
            }
            var d_Compra = await _context.d_Compra.FindAsync(id);
            if (d_Compra == null)
            {
                return NotFound();
            }

            _context.d_Compra.Remove(d_Compra);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool d_CompraExists(int id)
        {
            return (_context.d_Compra?.Any(e => e.d_CompraId == id)).GetValueOrDefault();
        }
    }
}
