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
    public class CoachController : Controller
    {
        private readonly DBContext _context;

        public CoachController(DBContext context)
        {
            _context = context;
        }

        // GET: Coach
        public async Task<IActionResult> Index()
        {
            var dBContext = _context.Coach.Include(c => c.Speciality);
            return View(await dBContext.ToListAsync());
        }

        // GET: Coach/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Coach == null)
            {
                return NotFound();
            }

            var coach = await _context.Coach
                .Include(c => c.Speciality)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (coach == null)
            {
                return NotFound();
            }

            return View(coach);
        }

        // GET: Coach/Create
        public IActionResult Create()
        {
            ViewData["IdSpeciality"] = new SelectList(_context.Set<Speciality>(), "Id", "Name");
            return View();
        }

        // POST: Coach/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,FirstName,LastName,Photo,IdSpeciality")] Coach coach)
        {
            if (ModelState.IsValid)
            {
                _context.Add(coach);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdSpeciality"] = new SelectList(_context.Set<Speciality>(), "Id", "Name", coach.IdSpeciality);
            return View(coach);
        }

        // GET: Coach/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Coach == null)
            {
                return NotFound();
            }

            var coach = await _context.Coach.FindAsync(id);
            if (coach == null)
            {
                return NotFound();
            }
            ViewData["IdSpeciality"] = new SelectList(_context.Set<Speciality>(), "Id", "Name", coach.IdSpeciality);
            return View(coach);
        }

        // POST: Coach/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,FirstName,LastName,Photo,IdSpeciality")] Coach coach)
        {
            if (id != coach.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(coach);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CoachExists(coach.ID))
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
            ViewData["IdSpeciality"] = new SelectList(_context.Set<Speciality>(), "Id", "Name", coach.IdSpeciality);
            return View(coach);
        }

        // GET: Coach/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Coach == null)
            {
                return NotFound();
            }

            var coach = await _context.Coach
                .Include(c => c.Speciality)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (coach == null)
            {
                return NotFound();
            }

            return View(coach);
        }

        // POST: Coach/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Coach == null)
            {
                return Problem("Entity set 'DBContext.Coach'  is null.");
            }
            var coach = await _context.Coach.FindAsync(id);
            if (coach != null)
            {
                _context.Coach.Remove(coach);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CoachExists(int id)
        {
          return (_context.Coach?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
