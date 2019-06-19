using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SeekAndFind.Models;
using SeekAndFind.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeekAndFind.Controllers
{
    public class OglasController : Controller
    {
        private readonly SaFContext _context;
        public static Oglas oglasZaPrijavu = null;
        private static bool pretraga = false;

        public OglasController(SaFContext context)
        {
            _context = context;

        }

        // GET: Oglas
        public async Task<IActionResult> Index(int? id)
        {
            var viewModel = new OglasData();

            var oglas = new Oglas();
            oglas.JeziciOglasa = new List<JeziciOglasa>();
            oglas.FakultetiOglasa = new List<FakultetiOglasa>();
            oglas.SrednjaSkolaOglasa = new List<SrednjaSkolaOglasa>();
            oglas.RegistrovaniAplikanti = new List<RegistrovaniAplikanti>();
            SkoleDropDownList(oglas);
            FakultetDropDownList(oglas);
            JeziciDropDownList(oglas);
            ZanimanjeDropDownList(oglas);

            if (HomeController.prijavljenaOsoba is Poslodavac)
            {
                viewModel.Oglasi = await _context.Oglas
                 .Include(i => i.Poslodavac)
                 .Include(i => i.RegistrovaniAplikanti)
                   .ThenInclude(i => i.Aplikant)
                 .Include(i => i.Zanimanje)
                 .Include(i => i.JeziciOglasa)
                   .ThenInclude(i => i.Jezik)
                 .Include(i => i.FakultetiOglasa)
                   .ThenInclude(i => i.Fakultet)
                 .Include(i => i.SrednjaSkolaOglasa)
                   .ThenInclude(i => i.SrednjaSkola)
                    .Where(i => i.PoslodavacId == HomeController.prijavljenaOsoba.KorisnikId)
                 .AsNoTracking()
                 .OrderByDescending(i => i.DatumObjavljivanja)
                 .ToListAsync();
            }

            else
            {
                viewModel.Oglasi = await _context.Oglas
                 .Include(i => i.Poslodavac)
                 .Include(i => i.RegistrovaniAplikanti)
                   .ThenInclude(i => i.Aplikant)
                 .Include(i => i.Zanimanje)
                 .Include(i => i.JeziciOglasa)
                   .ThenInclude(i => i.Jezik)
                 .Include(i => i.FakultetiOglasa)
                   .ThenInclude(i => i.Fakultet)
                 .Include(i => i.SrednjaSkolaOglasa)
                   .ThenInclude(i => i.SrednjaSkola)
                 .AsNoTracking()
                 .OrderByDescending(i => i.DatumObjavljivanja)
                 .ToListAsync();
            }

            if (id != null)
            {
                ViewData["OglasId"] = id.Value;
                Oglas oglass = viewModel.Oglasi.Where(
                    i => i.OglasId == id.Value).Single();
                viewModel.Jezici = oglass.JeziciOglasa.Select(s => s.Jezik);
                viewModel.Fakulteti = oglass.FakultetiOglasa.Select(s => s.Fakultet);
                viewModel.SrednjeSkole = oglass.SrednjaSkolaOglasa.Select(s => s.SrednjaSkola);
            }
            return View(viewModel);
        }



        // GET: Oglas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            oglasZaPrijavu = await _context.Oglas
                  .Include(i => i.Poslodavac)
                  .Include(i => i.Zanimanje)
                  .Include(i => i.JeziciOglasa)
                    .ThenInclude(i => i.Jezik)
                  .Include(i => i.FakultetiOglasa)
                    .ThenInclude(i => i.Fakultet)
                  .Include(i => i.SrednjaSkolaOglasa)
                    .ThenInclude(i => i.SrednjaSkola)
                  .Include(i => i.RegistrovaniAplikanti)
                    .ThenInclude(i => i.Aplikant)
                  .FirstOrDefaultAsync(m => m.OglasId == id);


            if (oglasZaPrijavu == null)
            {
                return NotFound();
            }

            return View(oglasZaPrijavu);
        }



        public IActionResult Prijava()
        {

            var novaRegistracija = new RegistrovaniAplikanti { OglasId = oglasZaPrijavu.OglasId, KorisnikId = HomeController.prijavljenaOsoba.KorisnikId };
            _context.RegistrovaniAplikanti.Add(novaRegistracija);
            oglasZaPrijavu = null;
            _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Pretrazi()
        {
            return RedirectToAction(nameof(Index));
        }



        public IActionResult Odjava()
        {
            RegistrovaniAplikanti ra = oglasZaPrijavu.RegistrovaniAplikanti.FirstOrDefault(i => i.KorisnikId == HomeController.prijavljenaOsoba.KorisnikId);
            _context.Remove(ra);
            oglasZaPrijavu = null;
            _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // GET: Oglas/Create
        public IActionResult Create()
        {
            var oglas = new Oglas();
            oglas.JeziciOglasa = new List<JeziciOglasa>();
            oglas.FakultetiOglasa = new List<FakultetiOglasa>();
            oglas.SrednjaSkolaOglasa = new List<SrednjaSkolaOglasa>();
            oglas.RegistrovaniAplikanti = new List<RegistrovaniAplikanti>();
            SkoleDropDownList(oglas);
            FakultetDropDownList(oglas);
            JeziciDropDownList(oglas);
            ZanimanjeDropDownList(oglas);
            return View();
        }

        // POST: Oglas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("OglasId,ZanimanjeId,Naziv,Opis,DatumIsteka,Grad")] Oglas oglas, string[] selectedJezici, int[] nivoiCitanja, int[] nivoiPisanja, string[] selectedSkole, string[] selectedFakulteti)
        {
            oglas.DatumObjavljivanja = DateTime.Today;
            oglas.Aktuelan = true;
            oglas.Poslodavac = _context.Poslodavac.Where(i => i.KorisnikId == HomeController.prijavljenaOsoba.KorisnikId).Single();
            if (selectedJezici != null)
            {
                oglas.JeziciOglasa = new List<JeziciOglasa>();
                int brojac = 0;
                foreach (var jezik in selectedJezici)
                {
                    var noviJezik = new JeziciOglasa { OglasId = oglas.OglasId, JezikId = int.Parse(jezik), NivoCitanja = nivoiCitanja[brojac], NivoPisanja = nivoiPisanja[brojac] };
                    oglas.JeziciOglasa.Add(noviJezik);
                    brojac++;
                }
            }

            if (selectedSkole != null)
            {
                oglas.SrednjaSkolaOglasa = new List<SrednjaSkolaOglasa>();
                foreach (var skola in selectedSkole)
                {
                    var novaSkola = new SrednjaSkolaOglasa { OglasId = oglas.OglasId, SrednjaSkolaId = int.Parse(skola) };
                    oglas.SrednjaSkolaOglasa.Add(novaSkola);
                }
            }

            if (selectedFakulteti != null)
            {
                oglas.FakultetiOglasa = new List<FakultetiOglasa>();
                foreach (var fakultet in selectedFakulteti)
                {
                    var noviFakultet = new FakultetiOglasa { OglasId = oglas.OglasId, FakultetId = int.Parse(fakultet) };
                    oglas.FakultetiOglasa.Add(noviFakultet);
                }
            }

            if (ModelState.IsValid)
            {
                _context.Add(oglas);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            SkoleDropDownList(oglas);
            FakultetDropDownList(oglas);
            JeziciDropDownList(oglas);
            ZanimanjeDropDownList();
            return View(oglas);
        }

        private void JeziciDropDownList(Oglas oglas)
        {
            var sviJezici = _context.Jezik;
            var jeziciOglasa = new HashSet<int>(oglas.JeziciOglasa.Select(c => c.JezikId));
            var viewModel = new List<DodijeljeniJeziciOglasu>();
            foreach (var jezik in sviJezici)
            {
                int nivoCitanja = 0, nivoPisanja = 0;
                if (jeziciOglasa.Contains(jezik.JezikId))
                {
                    JeziciOglasa j = oglas.JeziciOglasa.Where(c => c.Jezik.JezikId == jezik.JezikId).Single();
                    nivoCitanja = j.NivoCitanja;
                    nivoPisanja = j.NivoPisanja;
                }

                viewModel.Add(new DodijeljeniJeziciOglasu
                {
                    JezikId = jezik.JezikId,
                    Naziv = jezik.Naziv,
                    Assigned = jeziciOglasa.Contains(jezik.JezikId),
                    NivoPisanja = nivoPisanja,
                    NivoCitanja = nivoCitanja
                });

            }
            ViewData["Jezici"] = viewModel;
        }

        private void SkoleDropDownList(Oglas oglas)
        {
            var sveSkole = _context.SrednjaSkola;
            var skoleOglasa = new HashSet<int>(oglas.SrednjaSkolaOglasa.Select(c => c.SrednjaSkolaId));
            var viewModel = new List<DodijeljeneSkoleOglasu>();
            foreach (var skola in sveSkole)
            {

                viewModel.Add(new DodijeljeneSkoleOglasu
                {
                    SrednjaSkolaId = skola.SrednjaSkolaId,
                    Naziv = skola.Naziv,
                    Assigned = skoleOglasa.Contains(skola.SrednjaSkolaId),
                });

            }
            ViewData["SrednjeSkole"] = viewModel;
        }

        private void FakultetDropDownList(Oglas oglas)
        {
            var sviFakulteti = _context.Fakultet;
            var fakultetiOglasa = new HashSet<int>(oglas.FakultetiOglasa.Select(c => c.FakultetId));
            var viewModel = new List<DodjieljeniFakultetiOglasu>();
            foreach (var fakultet in sviFakulteti)
            {

                viewModel.Add(new DodjieljeniFakultetiOglasu
                {
                    FakultetId = fakultet.FakultetId,
                    Naziv = fakultet.Naziv,
                    Assigned = fakultetiOglasa.Contains(fakultet.FakultetId),
                });

            }
            ViewData["Fakulteti"] = viewModel;
        }

        // GET: Oglas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var oglas = await _context.Oglas
                .Include(i => i.JeziciOglasa).ThenInclude(i => i.Jezik)
                .Include(i => i.FakultetiOglasa).ThenInclude(i => i.Fakultet)
                .Include(i => i.SrednjaSkolaOglasa).ThenInclude(i => i.SrednjaSkola)
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.OglasId == id);
            if (oglas == null)
            {
                return NotFound();
            }
            SkoleDropDownList(oglas);
            FakultetDropDownList(oglas);
            JeziciDropDownList(oglas);
            ZanimanjeDropDownList(oglas.ZanimanjeId);
            return View(oglas);
        }

        // POST: Oglas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditPost(int? id, string[] selectedJezici, int[] nivoiCitanja, int[] nivoiPisanja, string[] selectedSkole, string[] selectedFakulteti)
        {
            if (id == null)
            {
                return NotFound();
            }

            var oglasUpdate = await _context.Oglas
                .Include(i => i.JeziciOglasa).ThenInclude(i => i.Jezik)
                .Include(i => i.SrednjaSkolaOglasa).ThenInclude(i => i.SrednjaSkola)
                .Include(i => i.FakultetiOglasa).ThenInclude(i => i.Fakultet)
                .FirstOrDefaultAsync(s => s.OglasId == id);

            if (await TryUpdateModelAsync<Oglas>(oglasUpdate, "", s => s.Naziv, s => s.DatumIsteka, s => s.ZanimanjeId
            , s => s.Opis, s => s.Grad))
            {
                UpdateJeziciOglasa(selectedJezici, nivoiCitanja, nivoiPisanja, oglasUpdate);
                UpdateSkoleOglasa(selectedSkole, oglasUpdate);
                UpdateFakultetiOglasa(selectedFakulteti, oglasUpdate);
                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateException /* ex */)
                {
                    //Log the error (uncomment ex variable name and write a log.)
                    ModelState.AddModelError("", "Unable to save changes. " +
                        "Try again, and if the problem persists, " +
                        "see your system administrator.");
                }
                return RedirectToAction("Details", "Oglas", new { id = id });
            }
            FakultetDropDownList(oglasUpdate);
            SkoleDropDownList(oglasUpdate);
            JeziciDropDownList(oglasUpdate);
            UpdateJeziciOglasa(selectedJezici, nivoiCitanja, nivoiPisanja, oglasUpdate);
            UpdateSkoleOglasa(selectedSkole, oglasUpdate);
            UpdateFakultetiOglasa(selectedFakulteti, oglasUpdate);
            ZanimanjeDropDownList(oglasUpdate.ZanimanjeId);
            return View(oglasUpdate);
        }

        private void UpdateJeziciOglasa(string[] selectedJezici, int[] nivoiCitanja, int[] nivoiPisanja, Oglas oglasUpdate)
        {
            if (selectedJezici == null)
            {
                oglasUpdate.JeziciOglasa = new List<JeziciOglasa>();
                return;
            }

            var selectedJeziciHS = new HashSet<string>(selectedJezici);
            var jeziciOglasa = new HashSet<int>
                (oglasUpdate.JeziciOglasa.Select(c => c.Jezik.JezikId));
            int brojac = 0;
            foreach (var jezik in _context.Jezik)
            {
                if (selectedJeziciHS.Contains(jezik.JezikId.ToString()))
                {
                    if (!jeziciOglasa.Contains(jezik.JezikId))
                    {
                        oglasUpdate.JeziciOglasa.Add(new JeziciOglasa { OglasId = oglasUpdate.OglasId, JezikId = jezik.JezikId, NivoCitanja = nivoiCitanja[brojac], NivoPisanja = nivoiPisanja[brojac] });
                    }
                    else
                    {
                        JeziciOglasa jezikToRemove = oglasUpdate.JeziciOglasa.FirstOrDefault(i => i.JezikId == jezik.JezikId);
                        _context.Remove(jezikToRemove);
                        oglasUpdate.JeziciOglasa.Add(new JeziciOglasa { OglasId = oglasUpdate.OglasId, JezikId = jezik.JezikId, NivoCitanja = nivoiCitanja[brojac], NivoPisanja = nivoiPisanja[brojac] });

                    }
                }
                else
                {

                    if (jeziciOglasa.Contains(jezik.JezikId))
                    {
                        JeziciOglasa jezikToRemove = oglasUpdate.JeziciOglasa.FirstOrDefault(i => i.JezikId == jezik.JezikId);
                        _context.Remove(jezikToRemove);
                    }
                }
                brojac++;
            }
        }

        private void UpdateSkoleOglasa(string[] selectedSkole, Oglas oglasUpdate)
        {
            if (selectedSkole == null)
            {
                oglasUpdate.SrednjaSkolaOglasa = new List<SrednjaSkolaOglasa>();
                return;
            }

            var selectedSkoleHS = new HashSet<string>(selectedSkole);
            var skoleOglasa = new HashSet<int>
                (oglasUpdate.SrednjaSkolaOglasa.Select(c => c.SrednjaSkola.SrednjaSkolaId));
            foreach (var skola in _context.SrednjaSkola)
            {
                if (selectedSkoleHS.Contains(skola.SrednjaSkolaId.ToString()))
                {
                    if (!skoleOglasa.Contains(skola.SrednjaSkolaId))
                    {
                        oglasUpdate.SrednjaSkolaOglasa.Add(new SrednjaSkolaOglasa { OglasId = oglasUpdate.OglasId, SrednjaSkolaId = skola.SrednjaSkolaId });
                    }

                }
                else
                {

                    if (skoleOglasa.Contains(skola.SrednjaSkolaId))
                    {
                        SrednjaSkolaOglasa skolaToRemove = oglasUpdate.SrednjaSkolaOglasa.FirstOrDefault(i => i.SrednjaSkolaId == skola.SrednjaSkolaId);
                        _context.Remove(skolaToRemove);
                    }
                }
            }
        }

        private void UpdateFakultetiOglasa(string[] selectedFakulteti, Oglas oglasUpdate)
        {
            if (selectedFakulteti == null)
            {
                oglasUpdate.FakultetiOglasa = new List<FakultetiOglasa>();
                return;
            }

            var selectedFakultetaHS = new HashSet<string>(selectedFakulteti);
            var fakultetiOglasa = new HashSet<int>
                (oglasUpdate.FakultetiOglasa.Select(c => c.Fakultet.FakultetId));
            foreach (var fakultet in _context.Fakultet)
            {
                if (selectedFakultetaHS.Contains(fakultet.FakultetId.ToString()))
                {
                    if (!fakultetiOglasa.Contains(fakultet.FakultetId))
                    {
                        oglasUpdate.FakultetiOglasa.Add(new FakultetiOglasa { OglasId = oglasUpdate.OglasId, FakultetId = fakultet.FakultetId });
                    }

                }
                else
                {

                    if (fakultetiOglasa.Contains(fakultet.FakultetId))
                    {
                        FakultetiOglasa fakultetToRemove = oglasUpdate.FakultetiOglasa.FirstOrDefault(i => i.FakultetId == fakultet.FakultetId);
                        _context.Remove(fakultetToRemove);
                    }
                }
            }
        }

        private void ZanimanjeDropDownList(object selectedZanimanje = null)
        {
            var zanimanjaQuery = from d in _context.Zanimanje
                                 orderby d.Naziv
                                 select d;
            ViewBag.ZanimanjeId = new SelectList(zanimanjaQuery.AsNoTracking(), "ZanimanjeId", "Naziv", selectedZanimanje);
        }



        // GET: Oglas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var oglas = await _context.Oglas
                  .Include(i => i.Poslodavac)
                  .Include(i => i.Zanimanje)
                  .Include(i => i.JeziciOglasa)
                    .ThenInclude(i => i.Jezik)
                  .Include(i => i.FakultetiOglasa)
                    .ThenInclude(i => i.Fakultet)
                  .Include(i => i.SrednjaSkolaOglasa)
                    .ThenInclude(i => i.SrednjaSkola)
                  .FirstOrDefaultAsync(m => m.OglasId == id);

            if (oglas == null)
            {
                return NotFound();
            }

            return View(oglas);
        }

        // POST: Oglas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            Oglas oglas = await _context.Oglas
                .SingleAsync(i => i.OglasId == id);


            _context.Oglas.Remove(oglas);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OglasExists(int id)
        {
            return _context.Oglas.Any(e => e.OglasId == id);
        }
    }
}
