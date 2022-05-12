#nullable disable
using kunde.dira.no.Data.EF;
using kunde.dira.no.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace kunde.dira.no.KundersController
{
    [Area("Kunder")]
    public class KundersController : Controller
    {
        private readonly PostgresContext _context;

        public KundersController(PostgresContext context)
        {
            _context = context;
        }

        // GET: Kunders
        public async Task<IActionResult> Index()
        {
            return View(await _context.Kunders.ToListAsync());
        }

        // GET: Kunders/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kunder = await _context.Kunders
                .FirstOrDefaultAsync(m => m.OrgNr == id);
            if (kunder == null)
            {
                return NotFound();
            }

            return View(kunder);
        }

        // GET: Kunders/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Kunders/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("OrgNr,Adresse,PostNrSted,KontaktPTek,KontaktPØk,KontaktPLed,TripleTID")] Kunder kunder)
        {
            if (ModelState.IsValid)
            {
                _context.Add(kunder);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(kunder);
        }

        // GET: Kunders/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kunder = await _context.Kunders.FindAsync(id);
            if (kunder == null)
            {
                return NotFound();
            }
            return View(kunder);
        }

        // POST: Kunders/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("OrgNr,Adresse,PostNrSted,KontaktPTek,KontaktPØk,KontaktPLed,TripleTID")] Kunder kunder)
        {
            if (id != kunder.OrgNr)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(kunder);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KunderExists(kunder.OrgNr))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(kunder);
        }

        // GET: Kunders/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kunder = await _context.Kunders
                .FirstOrDefaultAsync(m => m.OrgNr == id);
            if (kunder == null)
            {
                return NotFound();
            }

            return View(kunder);
        }

        // POST: Kunders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var kunder = await _context.Kunders.FindAsync(id);
            _context.Kunders.Remove(kunder);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool KunderExists(long id)
        {
            return _context.Kunders.Any(e => e.OrgNr == id);
        }
    }
}
