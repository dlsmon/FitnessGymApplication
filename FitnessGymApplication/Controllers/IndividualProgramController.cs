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
    public class IndividualProgramController : Controller
    {
        private readonly DBContext _context;

        public IndividualProgramController(DBContext context)
        {
            _context = context;
        }

        // GET: IndividualProgram
        public async Task<IActionResult> Index()
        {
            var dBContext = _context.IndividualProgram.Include(i => i.Exercise).Include(i => i.TrainingProgram);
            return View(await dBContext.ToListAsync());
        }

        // GET: IndividualProgram/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.IndividualProgram == null)
            {
                return NotFound();
            }

            var individualProgram = await _context.IndividualProgram
                .Include(i => i.Exercise)
                .Include(i => i.TrainingProgram)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (individualProgram == null)
            {
                return NotFound();
            }

            return View(individualProgram);
        }

        // GET: IndividualProgram/Create
        public IActionResult Create()
        {
            ViewData["IdExercise"] = new SelectList(_context.Exercise, "Id", "Name");
            ViewData["IdTrainingProgram"] = new SelectList(_context.TrainingProgram, "Id", "Id");
            return View();
        }

        // POST: IndividualProgram/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,IdTrainingProgram,IdExercise")] IndividualProgram individualProgram)
        {
            if (ModelState.IsValid)
            {
                _context.Add(individualProgram);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdExercise"] = new SelectList(_context.Exercise, "Id", "Name", individualProgram.IdExercise);
            ViewData["IdTrainingProgram"] = new SelectList(_context.TrainingProgram, "Id", "Id", individualProgram.IdTrainingProgram);
            return View(individualProgram);
        }

        // GET: IndividualProgram/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.IndividualProgram == null)
            {
                return NotFound();
            }

            var individualProgram = await _context.IndividualProgram.FindAsync(id);
            if (individualProgram == null)
            {
                return NotFound();
            }
            ViewData["IdExercise"] = new SelectList(_context.Exercise, "Id", "Name", individualProgram.IdExercise);
            ViewData["IdTrainingProgram"] = new SelectList(_context.TrainingProgram, "Id", "Id", individualProgram.IdTrainingProgram);
            return View(individualProgram);
        }

        // POST: IndividualProgram/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,IdTrainingProgram,IdExercise")] IndividualProgram individualProgram)
        {
            if (id != individualProgram.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(individualProgram);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!IndividualProgramExists(individualProgram.Id))
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
            ViewData["IdExercise"] = new SelectList(_context.Exercise, "Id", "Name", individualProgram.IdExercise);
            ViewData["IdTrainingProgram"] = new SelectList(_context.TrainingProgram, "Id", "Id", individualProgram.IdTrainingProgram);
            return View(individualProgram);
        }

        // GET: IndividualProgram/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.IndividualProgram == null)
            {
                return NotFound();
            }

            var individualProgram = await _context.IndividualProgram
                .Include(i => i.Exercise)
                .Include(i => i.TrainingProgram)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (individualProgram == null)
            {
                return NotFound();
            }

            return View(individualProgram);
        }

        // POST: IndividualProgram/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.IndividualProgram == null)
            {
                return Problem("Entity set 'DBContext.IndividualProgram'  is null.");
            }
            var individualProgram = await _context.IndividualProgram.FindAsync(id);
            if (individualProgram != null)
            {
                _context.IndividualProgram.Remove(individualProgram);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool IndividualProgramExists(int id)
        {
          return (_context.IndividualProgram?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
