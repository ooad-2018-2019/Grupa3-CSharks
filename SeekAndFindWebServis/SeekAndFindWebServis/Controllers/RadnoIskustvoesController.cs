using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SeekAndFindWebServis;

namespace SeekAndFindWebServis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RadnoIskustvoesController : ControllerBase
    {
        private readonly SeekAndFindContext _context;

        public RadnoIskustvoesController(SeekAndFindContext context)
        {
            _context = context;
        }

        // GET: api/RadnoIskustvoes
        [HttpGet]
        public IEnumerable<RadnoIskustvo> GetRadnoIskustvo()
        {
            return _context.RadnoIskustvo;
        }

        // GET: api/RadnoIskustvoes/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetRadnoIskustvo([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var radnoIskustvo = await _context.RadnoIskustvo.FindAsync(id);

            if (radnoIskustvo == null)
            {
                return NotFound();
            }

            return Ok(radnoIskustvo);
        }

        // PUT: api/RadnoIskustvoes/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRadnoIskustvo([FromRoute] int id, [FromBody] RadnoIskustvo radnoIskustvo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != radnoIskustvo.RadnoIskustvoId)
            {
                return BadRequest();
            }

            _context.Entry(radnoIskustvo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RadnoIskustvoExists(id))
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

        // POST: api/RadnoIskustvoes
        [HttpPost]
        public async Task<IActionResult> PostRadnoIskustvo([FromBody] RadnoIskustvo radnoIskustvo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.RadnoIskustvo.Add(radnoIskustvo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRadnoIskustvo", new { id = radnoIskustvo.RadnoIskustvoId }, radnoIskustvo);
        }

        // DELETE: api/RadnoIskustvoes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRadnoIskustvo([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var radnoIskustvo = await _context.RadnoIskustvo.FindAsync(id);
            if (radnoIskustvo == null)
            {
                return NotFound();
            }

            _context.RadnoIskustvo.Remove(radnoIskustvo);
            await _context.SaveChangesAsync();

            return Ok(radnoIskustvo);
        }

        private bool RadnoIskustvoExists(int id)
        {
            return _context.RadnoIskustvo.Any(e => e.RadnoIskustvoId == id);
        }
    }
}