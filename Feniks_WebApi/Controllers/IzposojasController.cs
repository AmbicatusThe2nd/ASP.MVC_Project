using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Feniks_WebApi.Database;
using Naloga2_Tkalcic.Models;

namespace Feniks_WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IzposojasController : ControllerBase
    {
        private readonly DataContext _context;

        public IzposojasController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Izposojas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Izposoja>>> GetIzposoje()
        {
            return await _context.Izposoje.ToListAsync();
        }

        [HttpGet("{idUporabnik}")]
        public ActionResult<IEnumerable<Izposoja>> GetIzposoje(string idUporabnik)
        {
            var listRezultatov = new List<Izposoja>();

            foreach (var data in _context.Izposoje)
            {
                if (data.UporabnikID == idUporabnik)
                    listRezultatov.Add(data);
            }

            if (listRezultatov.Count < 1)
                return NotFound();

            return listRezultatov;
        }

        // GET: api/Izposojas/5
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Izposoja>> GetIzposoja(int id)
        {
            var izposoja = await _context.Izposoje.FindAsync(id);

            if (izposoja == null)
            {
                return NotFound();
            }

            return izposoja;
        }

        // PUT: api/Izposojas/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutIzposoja(int id, Izposoja izposoja)
        {
            if (id != izposoja.ID)
            {
                return BadRequest();
            }

            _context.Entry(izposoja).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!IzposojaExists(id))
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

        // POST: api/Izposojas
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Izposoja>> PostIzposoja(Izposoja izposoja)
        {
            try
            {
                _context.Izposoje.Add(izposoja);
                await _context.SaveChangesAsync();
            }
            catch(Exception ex)
            {

            }

            return CreatedAtAction("GetIzposoja", new { id = izposoja.ID }, izposoja);
        }

        // DELETE: api/Izposojas/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Izposoja>> DeleteIzposoja(int id)
        {
            var izposoja = await _context.Izposoje.FindAsync(id);
            if (izposoja == null)
            {
                return NotFound();
            }

            _context.Izposoje.Remove(izposoja);
            await _context.SaveChangesAsync();

            return izposoja;
        }

        private bool IzposojaExists(int id)
        {
            return _context.Izposoje.Any(e => e.ID == id);
        }
    }
}
