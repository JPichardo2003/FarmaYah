﻿using System;
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
    public class ProveedoresController : ControllerBase
    {
        private readonly Contexto _context;

        public ProveedoresController(Contexto context)
        {
            _context = context;
        }

        // GET: api/Proveedores
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Proveedores>>> GetProveedores()
        {
          if (_context.Proveedores == null)
          {
              return NotFound();
          }
            return await _context.Proveedores
                .Where(p => p.Eliminado != true)
                .ToListAsync();
        }

        // GET: api/Proveedores/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Proveedores>> GetProveedores(int id)
        {
          if (_context.Proveedores == null)
          {
              return NotFound();
          }
            var proveedores = await _context.Proveedores
                .Include(p => p.ProveedorProducto)
                .Where(p => p.ProveedorId == id && p.Eliminado != true)
                .FirstOrDefaultAsync();
         
            if (proveedores == null)
            {
                return NotFound();
            }

            return proveedores;
        }

        // PUT: api/Proveedores/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProveedores(int id, Proveedores proveedores)
        {
            if (id != proveedores.ProveedorId)
            {
                return BadRequest();
            }

            _context.Entry(proveedores).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProveedoresExists(id))
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

        // POST: api/Proveedores
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Proveedores>> PostProveedores(Proveedores proveedores)
        {
            if (!ProveedoresExists(proveedores.ProveedorId))
                _context.Proveedores.Add(proveedores);
            else
                _context.Proveedores.Update(proveedores);

            await _context.SaveChangesAsync();
            return Ok(proveedores);
        }

        // DELETE: api/Proveedores/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProveedores(int id)
        {
            if (_context.Proveedores == null)
            {
                return NotFound();
            }
            var proveedores = await _context.Proveedores.FindAsync(id);
            if (proveedores == null)
            {
                return NotFound();
            }

            _context.Proveedores.Remove(proveedores);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProveedoresExists(int id)
        {
            return (_context.Proveedores?.Any(e => e.ProveedorId == id)).GetValueOrDefault();
        }
    }
}
