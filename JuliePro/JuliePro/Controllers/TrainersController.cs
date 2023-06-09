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
    public class TrainersController : Controller
    {
        private readonly JulieProDbContext _baseDonnees;

        public TrainersController(JulieProDbContext baseDonnees)
        {
           _baseDonnees = baseDonnees;
        }

        // GET: Trainers
        public async Task<IActionResult> Index()
        {
             List<Trainer>trainers = await _baseDonnees.Trainers.OrderBy(x => x.FirstName ).Include(x=>x.Speciality).ToListAsync();
            return View(trainers);
        }

        // GET: Trainers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
         Trainer trainers = await _baseDonnees.Trainers.Where(x=>x.Id==id).Include(x=>x.Speciality).FirstAsync();
            return View(trainers);
        }

        // GET: Trainers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Trainers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FirstName,LastName,Email,Photo,Id,SpecialityId")] Trainer trainer)
        {
            if (ModelState.IsValid)
            {
                _baseDonnees.Add(trainer);
                await _baseDonnees.SaveChangesAsync();
                TempData["Success"] = $"{trainer.FirstName} trainer added";
                return RedirectToAction(nameof(Index));
            }
            return View(trainer);
        }

        // GET: Trainers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _baseDonnees.Trainers == null)
            {
                return NotFound();
            }

            var trainer = await _baseDonnees.Trainers.FindAsync(id);
            if (trainer == null)
            {
                return NotFound();
            }
            return View(trainer);
        }

        // POST: Trainers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FirstName,LastName,Email,Photo,Id,SpecialityId")] Trainer trainer)
        {
            if (id != trainer.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _baseDonnees.Update(trainer);
                    await _baseDonnees.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TrainerExists(trainer.Id))
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
            return View(trainer);
        }

        // GET: Trainers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _baseDonnees.Trainers == null)
            {
                return NotFound();
            }

            var trainer = await _baseDonnees.Trainers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (trainer == null)
            {
                return NotFound();
            }

            return View(trainer);
        }

        // POST: Trainers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_baseDonnees.Trainers == null)
            {
                return Problem("Entity set 'JulieProDbContext.Trainer'  is null.");
            }
            var trainer = await _baseDonnees.Trainers.FindAsync(id);
            if (trainer != null)
            {
                _baseDonnees.Trainers.Remove(trainer);
            }
            
            await _baseDonnees  .SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TrainerExists(int id)
        {
          return (_baseDonnees.Trainers?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
