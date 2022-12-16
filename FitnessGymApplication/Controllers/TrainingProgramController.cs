using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FitnessGymApplication.Data;
using FitnessGymApplication.Models;

namespace FitnessGymApplication.Controllers
{
    public class TrainingProgramController : Controller
    {
        private readonly DBContext _context;

        public TrainingProgramController(DBContext context)
        {
            _context = context;
        }

        // GET: TrainingProgram
        public async Task<IActionResult> Index()
        {
              return _context.TrainingProgram != null ? 
                          View(await _context.TrainingProgram.ToListAsync()) :
                          Problem("Entity set 'DBContext.TrainingProgram'  is null.");
        }

        // GET: TrainingProgram/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.TrainingProgram == null)
            {
                return NotFound();
            }

            var trainingProgram = await _context.TrainingProgram
                .FirstOrDefaultAsync(m => m.Id == id);
            if (trainingProgram == null)
            {
                return NotFound();
            }

            return View(trainingProgram);
        }

        // GET: TrainingProgram/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TrainingProgram/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Intensity,Name,Description,Duration,Calories")] TrainingProgram trainingProgram)
        {
            if (ModelState.IsValid)
            {
                _context.Add(trainingProgram);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(trainingProgram);
        }

        // GET: TrainingProgram/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.TrainingProgram == null)
            {
                return NotFound();
            }

            var trainingProgram = await _context.TrainingProgram.FindAsync(id);
            if (trainingProgram == null)
            {
                return NotFound();
            }
            return View(trainingProgram);
        }

        // POST: TrainingProgram/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Intensity,Name,Description,Duration,Calories")] TrainingProgram trainingProgram)
        {
            if (id != trainingProgram.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(trainingProgram);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TrainingProgramExists(trainingProgram.Id))
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
            return View(trainingProgram);
        }

        // GET: TrainingProgram/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.TrainingProgram == null)
            {
                return NotFound();
            }

            var trainingProgram = await _context.TrainingProgram
                .FirstOrDefaultAsync(m => m.Id == id);
            if (trainingProgram == null)
            {
                return NotFound();
            }

            return View(trainingProgram);
        }

        // POST: TrainingProgram/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.TrainingProgram == null)
            {
                return Problem("Entity set 'DBContext.TrainingProgram'  is null.");
            }
            var trainingProgram = await _context.TrainingProgram.FindAsync(id);
            if (trainingProgram != null)
            {
                _context.TrainingProgram.Remove(trainingProgram);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TrainingProgramExists(int id)
        {
          return (_context.TrainingProgram?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
