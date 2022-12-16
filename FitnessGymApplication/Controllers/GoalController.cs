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
    public class GoalController : Controller
    {
        private readonly DBContext _context;

        public GoalController(DBContext context)
        {
            _context = context;
        }

        // GET: Goal
        public async Task<IActionResult> Index()
        {
            var dBContext = _context.Goal.Include(g => g.Client);
            return View(await dBContext.ToListAsync());
        }

        // GET: Goal/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Goal == null)
            {
                return NotFound();
            }

            var goal = await _context.Goal
                .Include(g => g.Client)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (goal == null)
            {
                return NotFound();
            }

            return View(goal);
        }

        // GET: Goal/Create
        public IActionResult Create()
        {
            ViewData["IdClient"] = new SelectList(_context.Client, "Id", "Id");
            return View();
        }

        // POST: Goal/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Weight,Frequency,CaloriesBurnt,IdClient")] Goal goal)
        {
            if (ModelState.IsValid)
            {
                _context.Add(goal);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdClient"] = new SelectList(_context.Client, "Id", "Id", goal.IdClient);
            return View(goal);
        }

        // GET: Goal/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Goal == null)
            {
                return NotFound();
            }

            var goal = await _context.Goal.FindAsync(id);
            if (goal == null)
            {
                return NotFound();
            }
            ViewData["IdClient"] = new SelectList(_context.Client, "Id", "Id", goal.IdClient);
            return View(goal);
        }

        // POST: Goal/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Weight,Frequency,CaloriesBurnt,IdClient")] Goal goal)
        {
            if (id != goal.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(goal);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GoalExists(goal.Id))
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
            ViewData["IdClient"] = new SelectList(_context.Client, "Id", "Id", goal.IdClient);
            return View(goal);
        }

        // GET: Goal/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Goal == null)
            {
                return NotFound();
            }

            var goal = await _context.Goal
                .Include(g => g.Client)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (goal == null)
            {
                return NotFound();
            }

            return View(goal);
        }

        // POST: Goal/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Goal == null)
            {
                return Problem("Entity set 'DBContext.Goal'  is null.");
            }
            var goal = await _context.Goal.FindAsync(id);
            if (goal != null)
            {
                _context.Goal.Remove(goal);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GoalExists(int id)
        {
          return (_context.Goal?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
