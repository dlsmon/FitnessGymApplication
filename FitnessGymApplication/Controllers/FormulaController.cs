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
    public class FormulaController : Controller
    {
        private readonly DBContext _context;

        public FormulaController(DBContext context)
        {
            _context = context;
        }

        // GET: Formula
        public async Task<IActionResult> Index()
        {
              return _context.Formula != null ? 
                          View(await _context.Formula.ToListAsync()) :
                          Problem("Entity set 'DBContext.Formula'  is null.");
        }

        // GET: Formula/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Formula == null)
            {
                return NotFound();
            }

            var formula = await _context.Formula
                .FirstOrDefaultAsync(m => m.ID == id);
            if (formula == null)
            {
                return NotFound();
            }

            return View(formula);
        }

        // GET: Formula/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Formula/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name,Description,FormulaRank,Price,Commitement")] Formula formula)
        {
            if (ModelState.IsValid)
            {
                _context.Add(formula);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(formula);
        }

        // GET: Formula/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Formula == null)
            {
                return NotFound();
            }

            var formula = await _context.Formula.FindAsync(id);
            if (formula == null)
            {
                return NotFound();
            }
            return View(formula);
        }

        // POST: Formula/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name,Description,FormulaRank,Price,Commitement")] Formula formula)
        {
            if (id != formula.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(formula);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FormulaExists(formula.ID))
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
            return View(formula);
        }

        // GET: Formula/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Formula == null)
            {
                return NotFound();
            }

            var formula = await _context.Formula
                .FirstOrDefaultAsync(m => m.ID == id);
            if (formula == null)
            {
                return NotFound();
            }

            return View(formula);
        }

        // POST: Formula/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Formula == null)
            {
                return Problem("Entity set 'DBContext.Formula'  is null.");
            }
            var formula = await _context.Formula.FindAsync(id);
            if (formula != null)
            {
                _context.Formula.Remove(formula);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FormulaExists(int id)
        {
          return (_context.Formula?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
