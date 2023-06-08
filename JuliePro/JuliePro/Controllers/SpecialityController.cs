using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using JuliePro.Data;
using JuliePro.Models;

namespace JuliePro.Controllers
{
    public class SpecialityController : Controller
    {
        private  JulieProDbContext _baseDonnees { get; set; }

        public SpecialityController(JulieProDbContext baseDonnes)
        {
            _baseDonnees = baseDonnes;
            
        }

        // GET: Speciality
        public async Task<IActionResult> Index()
        {
             List<Speciality> specialities = await _baseDonnees.Specialities.OrderBy(z=>z.Name).ToListAsync();
            return View(specialities);
        }

        // GET: Speciality/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _baseDonnees.Specialities == null)
            {
                return NotFound();
            }

            var speciality = await _baseDonnees.Specialities
                .FirstOrDefaultAsync(m => m.Id == id);
            if (speciality == null)
            {
                return NotFound();
            }

            return View(speciality);
        }

        // GET: Speciality/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Speciality/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,Id")] Speciality speciality)
        {
            if (ModelState.IsValid)
            {
                _baseDonnees.Add(speciality);
                await _baseDonnees.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(speciality);
        }

        // GET: Speciality/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _baseDonnees.Specialities == null)
            {
                return NotFound();
            }

            var speciality = await _baseDonnees.Specialities.FindAsync(id);
            if (speciality == null)
            {
                return NotFound();
            }
            return View(speciality);
        }

        // POST: Speciality/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, [Bind("Name,Id")] Speciality speciality)
        {
            if (id != speciality.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _baseDonnees.Update(speciality);
                    await _baseDonnees.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SpecialityExists(speciality.Id))
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
            return View(speciality);
        }

        // GET: Speciality/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _baseDonnees.Specialities == null)
            {
                return NotFound();
            }

            var speciality = await _baseDonnees.Specialities
                .FirstOrDefaultAsync(m => m.Id == id);
            if (speciality == null)
            {
                return NotFound();
            }

            return View(speciality);
        }

        // POST: Speciality/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            if (_baseDonnees.Specialities == null)
            {
                return Problem("Entity set 'JulieProDbContext.Specialities'  is null.");
            }
            var speciality = await _baseDonnees.Specialities.FindAsync(id);
            if (speciality != null)
            {
                _baseDonnees.Specialities.Remove(speciality);
            }
            
            await _baseDonnees.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SpecialityExists(int? id)
        {
          return (_baseDonnees.Specialities?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
