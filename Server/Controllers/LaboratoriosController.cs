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
    public class LaboratoriosController : ControllerBase
    {
        private readonly Contexto _context;

        public LaboratoriosController(Contexto context)
        {
            _context = context;
        }

        // GET: api/Laboratorios
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Laboratorios>>> GetLaboratorios()
        {
          if (_context.Laboratorios == null)
          {
              return NotFound();
          }
            return await _context.Laboratorios.ToListAsync();
        }

        // GET: api/Laboratorios/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Laboratorios>> GetLaboratorios(int id)
        {
          if (_context.Laboratorios == null)
          {
              return NotFound();
          }
            var laboratorios = await _context.Laboratorios.FindAsync(id);

            if (laboratorios == null)
            {
                return NotFound();
            }

            return laboratorios;
        }

        // PUT: api/Laboratorios/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLaboratorios(int id, Laboratorios laboratorios)
        {
            if (id != laboratorios.LaboratorioId)
            {
                return BadRequest();
            }

            _context.Entry(laboratorios).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LaboratoriosExists(id))
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

        // POST: api/Laboratorios
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Laboratorios>> PostLaboratorios(Laboratorios laboratorios)
        {
          if(!LaboratoriosExists(laboratorios.LaboratorioId))
                _context.Laboratorios.Add(laboratorios);
          else
                _context.Laboratorios.Update(laboratorios);

          await _context.SaveChangesAsync();
            return Ok(laboratorios);
        }

        // DELETE: api/Laboratorios/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLaboratorios(int id)
        {
            if (_context.Laboratorios == null)
            {
                return NotFound();
            }
            var laboratorios = await _context.Laboratorios.FindAsync(id);
            if (laboratorios == null)
            {
                return NotFound();
            }

            _context.Laboratorios.Remove(laboratorios);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool LaboratoriosExists(int id)
        {
            return (_context.Laboratorios?.Any(e => e.LaboratorioId == id)).GetValueOrDefault();
        }
    }
}
