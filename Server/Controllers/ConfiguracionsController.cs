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
    public class ConfiguracionsController : ControllerBase
    {
        private readonly Contexto _context;

        public ConfiguracionsController(Contexto context)
        {
            _context = context;
        }

        // GET: api/Configuracions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Configuracion>>> GetConfiguracion()
        {
          if (_context.Configuracion == null)
          {
              return NotFound();
          }
            return await _context.Configuracion.ToListAsync();
        }

        // GET: api/Configuracions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Configuracion>> GetConfiguracion(int id)
        {
          if (_context.Configuracion == null)
          {
              return NotFound();
          }
            var configuracion = await _context.Configuracion.FindAsync(id);

            if (configuracion == null)
            {
                return NotFound();
            }

            return configuracion;
        }

        // PUT: api/Configuracions/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutConfiguracion(int id, Configuracion configuracion)
        {
            if (id != configuracion.ConfiguracionId)
            {
                return BadRequest();
            }

            _context.Entry(configuracion).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ConfiguracionExists(id))
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

        // POST: api/Configuracions
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Configuracion>> PostConfiguracion(Configuracion configuracion)
        {
          if(!ConfiguracionExists(configuracion.ConfiguracionId))
            _context.Configuracion.Add(configuracion);          
          else
            _context.Configuracion.Update(configuracion);

          await _context.SaveChangesAsync();

            return Ok(configuracion);
        }

        // DELETE: api/Configuracions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteConfiguracion(int id)
        {
            if (_context.Configuracion == null)
            {
                return NotFound();
            }
            var configuracion = await _context.Configuracion.FindAsync(id);
            if (configuracion == null)
            {
                return NotFound();
            }

            _context.Configuracion.Remove(configuracion);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ConfiguracionExists(int id)
        {
            return (_context.Configuracion?.Any(e => e.ConfiguracionId == id)).GetValueOrDefault();
        }
    }
}
