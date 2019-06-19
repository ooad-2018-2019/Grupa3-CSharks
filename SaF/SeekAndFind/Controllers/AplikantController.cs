using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SeekAndFind.Models;
using SeekAndFind.Models.ViewModels;

namespace SeekAndFind.Controllers
{
    public class AplikantController : Controller
    {
        private readonly SaFContext _context;

        public AplikantController(SaFContext context)
        {
            _context = context;
        }

        // GET: Aplikant
        public async Task<IActionResult> Index(int? id)
        {
            if (id != null)
            {
                Oglas oglas = _context.Oglas
                  .Include(i => i.RegistrovaniAplikanti)
                    .ThenInclude(i => i.Aplikant)
                  .FirstOrDefault(m => m.OglasId == id);

                var aplikanti = oglas.RegistrovaniAplikanti.Select(s => s.Aplikant);
                return View(aplikanti);             
            }       
            return View(await _context.Aplikant.ToListAsync());
        }

        // GET: Aplikant/Details/5
        public async Task<IActionResult> Details(int? id, int? jezikId)
        {
            if (id == null)
            {
                return NotFound();
            }

            var viewModel = new AplikantData();
            viewModel.Aplikant= await _context.Aplikant
               .FirstOrDefaultAsync(m => m.KorisnikId == id);

            if (viewModel.Aplikant == null)
            {
                return NotFound();
            }
            
            ViewData["AplikantId"] = id.Value;
            viewModel.Korisnik = HomeController.prijavljenaOsoba;
               
            Aplikant instructor = viewModel.Aplikant;
            var JeziciApli = _context.JeziciAplikanta.Include(d => d.Jezik).Where(d => d.AplikantId == id);
            List<Jezik> jezici= new List<Jezik>();

            if (JeziciApli != null)
            {
                foreach (JeziciAplikanta a in JeziciApli)
                {
                    jezici.Add(a.Jezik);

                }

                if(jezici.Count>0) viewModel.Jezici = jezici;
            }

            var SrednjeSkole = _context.SrednjaSkolaAplikanta.Include(d => d.SrednjaSkola).Where(d => d.AplikantId == id);


            List<SrednjaSkola>srednjeSkole = new List<SrednjaSkola>();

            if (SrednjeSkole != null)
            {
                foreach (SrednjaSkolaAplikanta a in SrednjeSkole)
                {
                    srednjeSkole.Add(a.SrednjaSkola);

                }

                if (srednjeSkole.Count > 0) viewModel.SrednjeSkole = srednjeSkole;
            }

            var Fakulteti = _context.FakultetiAplikanta.Include(d => d.Fakultet).Where(d => d.AplikantId == id);


            List<Fakultet> fakulteti = new List<Fakultet>();

            if (fakulteti != null)
            {
                foreach (FakultetiAplikanta a in Fakulteti)
                {
                    fakulteti.Add(a.Fakultet);

                }

             if(fakulteti.Count>0)   viewModel.Fakulteti = fakulteti;
            }




            //if (instructor.SrednjaSkolaAplikanta != null) viewModel.SrednjeSkole = instructor.SrednjaSkolaAplikanta.Select(s => s.SrednjaSkola);
            //if (instructor.FakultetiAplikanta != null) viewModel.Fakulteti = instructor.FakultetiAplikanta.Select(s => s.Fakultet);

            // List<RadnoIskustvoAplikanta> iskustvoApl =  await _context.RadnoIskustvoAplikanta.Where(m => m.AplikantId == id).ToListAsync();


            var radnaIsku = _context.RadnoIskustvoAplikanta.Include(d => d.RadnoIskustvo).ThenInclude(d=>d.Zanimanje).Where(d=>d.AplikantId==id);
            List<RadnoIskustvo> iskustva = new List<RadnoIskustvo>();


            if (radnaIsku != null)
            {
                foreach (RadnoIskustvoAplikanta a in radnaIsku)
                {
                    iskustva.Add(a.RadnoIskustvo);

                }

               if(iskustva.Count>0) viewModel.RadnoIskustvo = iskustva;
            }


            var obavijestiBaza = _context.Obavijest.Include(d => d.Oglas).Where(d => d.AplikantId == id);
            List<Obavijest> obavijesti = new List<Obavijest>();


            if (obavijestiBaza != null)
            {
                foreach (Obavijest a in obavijestiBaza)
                {
                    obavijesti.Add(a);

                }

               if(obavijesti.Count>0) viewModel.Obavijesti = obavijesti;
            }

            if (jezikId != null)

            {

               viewModel.JeziciAplikanta = await _context.JeziciAplikanta.Where(m => m.AplikantId == id).ToListAsync();
               ViewData["JezikId"] = jezikId.Value;
               viewModel.JeziciAplikanta = viewModel.JeziciAplikanta.Where(m => m.JezikId == jezikId);
               foreach(JeziciAplikanta ja in viewModel.JeziciAplikanta)
                {
                    ja.JezikId = jezikId.Value;
                    ja.AplikantId = id.Value;
                }
               
               
            }

            return View(viewModel);

        }

        // GET: Aplikant/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Aplikant/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Ime,Prezime,DatumRodjenja,KorisnikId,Telefon,Email,Grad,Sifra")] Aplikant aplikant)
        {
            if (ModelState.IsValid)
            {
                _context.Add(aplikant);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(aplikant);
        }

        // GET: Aplikant/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }


            var aplikant = await _context.Aplikant
                .FirstOrDefaultAsync(m => m.KorisnikId == id);
            if (aplikant == null)
            {
                return NotFound();
            }
            ViewData["AplikantId"] = id.Value;
            return View(aplikant);
        }

        // POST: Aplikant/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Ime,Prezime,DatumRodjenja,KorisnikId,Telefon,Email,Grad,Sifra")] Aplikant aplikant)
        {
            if (id != aplikant.KorisnikId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(aplikant);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AplikantExists(aplikant.KorisnikId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Details", "Aplikant", new { id = id });
            }
            return View(aplikant);
        }

        // GET: Aplikant/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aplikant = await _context.Aplikant
                .FirstOrDefaultAsync(m => m.KorisnikId == id);
            if (aplikant == null)
            {
                return NotFound();
            }

            return View(aplikant);
        }

        // POST: Aplikant/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var aplikant = await _context.Aplikant.FindAsync(id);
            _context.Aplikant.Remove(aplikant);
            await _context.SaveChangesAsync();
            return RedirectToAction("Logout", "Home");
        }

        private bool AplikantExists(int id)
        {
            return _context.Aplikant.Any(e => e.KorisnikId == id);
        }
    }
}
