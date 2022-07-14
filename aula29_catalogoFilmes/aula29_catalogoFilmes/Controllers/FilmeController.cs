using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using aula29_catalogoFilmes.Models;

namespace aula29_catalogoFilmes.Controllers
{
    public class FIlmeController : Controller
    {
        private readonly CatalogoContext _context;

        public FIlmeController(CatalogoContext context)
        {
            _context = context;
        }

        // GET: FIlme
        public async Task<IActionResult> Index()
        {
              return _context.Filmes != null ? 
                          View(await _context.Filmes.ToListAsync()) :
                          Problem("Entity set 'CatalogoContext.Filmes'  is null.");
        }

        // GET: FIlme/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Filmes == null)
            {
                return NotFound();
            }

            var filmeModel = await _context.Filmes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (filmeModel == null)
            {
                return NotFound();
            }

            return View(filmeModel);
        }

        // GET: FIlme/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FIlme/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,DataLancamento,HorasDuracao")] FilmeModel filmeModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(filmeModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(filmeModel);
        }

        // GET: FIlme/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Filmes == null)
            {
                return NotFound();
            }

            var filmeModel = await _context.Filmes.FindAsync(id);
            if (filmeModel == null)
            {
                return NotFound();
            }
            return View(filmeModel);
        }

        // POST: FIlme/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,DataLancamento,HorasDuracao")] FilmeModel filmeModel)
        {
            if (id != filmeModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(filmeModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FilmeModelExists(filmeModel.Id))
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
            return View(filmeModel);
        }

        // GET: FIlme/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Filmes == null)
            {
                return NotFound();
            }

            var filmeModel = await _context.Filmes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (filmeModel == null)
            {
                return NotFound();
            }

            return View(filmeModel);
        }

        // POST: FIlme/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Filmes == null)
            {
                return Problem("Entity set 'CatalogoContext.Filmes'  is null.");
            }
            var filmeModel = await _context.Filmes.FindAsync(id);
            if (filmeModel != null)
            {
                _context.Filmes.Remove(filmeModel);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FilmeModelExists(int id)
        {
          return (_context.Filmes?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
