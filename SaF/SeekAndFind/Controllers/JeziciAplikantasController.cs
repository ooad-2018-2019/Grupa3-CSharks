using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SeekAndFind.Models;

namespace SeekAndFind.Controllers
{
    public class JeziciAplikantasController : Controller
    {
        private readonly SaFContext _context;
        private static int idAplUnos = -1;
        private static int idAplEdit = -1,idJezik=-1;

        public JeziciAplikantasController(SaFContext context)
        {
            _context = context;
        }

        // GET: JeziciAplikantas
        public async Task<IActionResult> Index()
        {
            var saFContext = _context.JeziciAplikanta.Include(j => j.Aplikant).Include(j => j.Jezik);
            return View(await saFContext.ToListAsync());
        }

        // GET: JeziciAplikantas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jeziciAplikanta = await _context.JeziciAplikanta
                .Include(j => j.Aplikant)
                .Include(j => j.Jezik)
                .FirstOrDefaultAsync(m => m.JeziciAplikantaId == id);
            if (jeziciAplikanta == null)
            {
                return NotFound();
            }

            return View(jeziciAplikanta);
        }

        // GET: JeziciAplikantas/Create
        public IActionResult Create(int?apl)
        {
            //ViewData["AplikantId"] = new SelectList(_context.Aplikant, "KorisnikId", "Discriminator");

            if (apl != null)
            {
                idAplUnos = apl.Value;
            }

            ViewData["JezikId"] = new SelectList(_context.Jezik, "JezikId", "Naziv");
            return View();
        }

        // POST: JeziciAplikantas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("JeziciAplikantaId,JezikId,NivoCitanja,NivoPisanja")] JeziciAplikanta jeziciAplikanta)
        {
            if (ModelState.IsValid)
            {
                    
                if (idAplUnos != -1)
                {
                    jeziciAplikanta.AplikantId = idAplUnos;
                    _context.Add(jeziciAplikanta);
                    await _context.SaveChangesAsync();
                    int idApl = idAplUnos;
                    idAplUnos = -1;
                    return RedirectToAction("Details", "Aplikant", new { id = idApl });
                  
                }

                idAplUnos = -1;
                return RedirectToAction(nameof(Index));
            }
            idAplUnos = -1;
            //ViewData["AplikantId"] = new SelectList(_context.Aplikant, "KorisnikId", "Discriminator", jeziciAplikanta.AplikantId);
            ViewData["JezikId"] = new SelectList(_context.Jezik, "JezikId", "JezikId", jeziciAplikanta.JezikId);
            return View(jeziciAplikanta);
        }

        // GET: JeziciAplikantas/Edit/5
        public async Task<IActionResult> Edit(int? id, int?idApl )
        {
            if (id == null)
            {
                return NotFound();
            }

            var jeziciAplikanta = await _context.JeziciAplikanta.FindAsync(id);
            if (jeziciAplikanta == null)
            {
                return NotFound();
            }
            if (idApl != null)
            {
                idAplEdit = idApl.Value;
                idJezik = -jeziciAplikanta.JezikId;
            }
            //idJezik = -jeziciAplikanta.JezikId;
            //ViewData["AplikantId"] = new SelectList(_context.Aplikant, "KorisnikId", "Discriminator", jeziciAplikanta.AplikantId);
            ViewData["JezikId"] = new SelectList(_context.Jezik, "JezikId", "Naziv", jeziciAplikanta.JezikId);
            return View(jeziciAplikanta);
        }

        // POST: JeziciAplikantas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("JeziciAplikantaId,AplikantId,JezikId,NivoCitanja,NivoPisanja")] JeziciAplikanta jeziciAplikanta)
        {
            if (id != jeziciAplikanta.JeziciAplikantaId)
            {
                return NotFound();
            }
           
            if (ModelState.IsValid)
            {
                try
                {

                    if (idAplEdit != -1)
                    {
                        jeziciAplikanta.AplikantId = idAplEdit;
                        //jeziciAplikanta.JezikId = idJezik;
                        int idap = idAplEdit;
                        idAplEdit = -1;
                        _context.Update(jeziciAplikanta);
                        await _context.SaveChangesAsync();
                        //int idApl = idAplEdit;     
                        return RedirectToAction("Details", "Aplikant", new { id = idap });
                    }
                   
                }
                catch (DbUpdateConcurrencyException)
                {
                   
                    if (!JeziciAplikantaExists(jeziciAplikanta.JeziciAplikantaId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                idAplEdit = -1;
                return RedirectToAction(nameof(Index));
            }

           // idAplEdit = -1;
            //ViewData["AplikantId"] = new SelectList(_context.Aplikant, "KorisnikId", "Discriminator", jeziciAplikanta.AplikantId);
            ViewData["JezikId"] = new SelectList(_context.Jezik, "JezikId", "JezikId", jeziciAplikanta.JezikId);
             return View(jeziciAplikanta);
           // return RedirectToAction("Details", "Aplikant", new { id = idApl });

        }

        // GET: JeziciAplikantas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jeziciAplikanta = await _context.JeziciAplikanta
                .Include(j => j.Aplikant)
                .Include(j => j.Jezik)
                .FirstOrDefaultAsync(m => m.JeziciAplikantaId == id);
            if (jeziciAplikanta == null)
            {
                return NotFound();
            }

            return View(jeziciAplikanta);
        }

        // POST: JeziciAplikantas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var jeziciAplikanta = await _context.JeziciAplikanta.FindAsync(id);
            int idAplikanta = jeziciAplikanta.AplikantId;
            _context.JeziciAplikanta.Remove(jeziciAplikanta);
            await _context.SaveChangesAsync();
            return RedirectToAction("Details", "Aplikant", new { id = idAplikanta });
        }

        private bool JeziciAplikantaExists(int id)
        {
            return _context.JeziciAplikanta.Any(e => e.JeziciAplikantaId == id);
        }
    }
}
