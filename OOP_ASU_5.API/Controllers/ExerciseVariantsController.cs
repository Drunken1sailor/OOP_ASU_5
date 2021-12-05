using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OOP_ASU_5.Domain;
using OOP_ASU_5.Infrastructure.Data;

namespace OOP_ASU_5.API.Controllers
{
    public class ExerciseVariantsController : Controller
    {
        private readonly Context _context;

        public ExerciseVariantsController(Context context)
        {
            _context = context;
        }

        // GET: ExerciseVariants
        public async Task<IActionResult> Index()
        {
            var context = _context.ExerciseVariants.Include(e => e.Exercise);
            return View(await context.ToListAsync());
        }

        // GET: ExerciseVariants/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var exerciseVariant = await _context.ExerciseVariants
                .Include(e => e.Exercise)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (exerciseVariant == null)
            {
                return NotFound();
            }

            return View(exerciseVariant);
        }

        // GET: ExerciseVariants/Create
        public IActionResult Create()
        {
            ViewData["ExerciseId"] = new SelectList(_context.Exercises, "Id", "Id");
            return View();
        }

        // POST: ExerciseVariants/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Number,DifficultyCoefficient,ExerciseId")] ExerciseVariant exerciseVariant)
        {
            if (ModelState.IsValid)
            {
                exerciseVariant.Id = Guid.NewGuid();
                _context.Add(exerciseVariant);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ExerciseId"] = new SelectList(_context.Exercises, "Id", "Id", exerciseVariant.ExerciseId);
            return View(exerciseVariant);
        }

        // GET: ExerciseVariants/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var exerciseVariant = await _context.ExerciseVariants.FindAsync(id);
            if (exerciseVariant == null)
            {
                return NotFound();
            }
            ViewData["ExerciseId"] = new SelectList(_context.Exercises, "Id", "Id", exerciseVariant.ExerciseId);
            return View(exerciseVariant);
        }

        // POST: ExerciseVariants/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Number,DifficultyCoefficient,ExerciseId")] ExerciseVariant exerciseVariant)
        {
            if (id != exerciseVariant.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(exerciseVariant);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ExerciseVariantExists(exerciseVariant.Id))
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
            ViewData["ExerciseId"] = new SelectList(_context.Exercises, "Id", "Id", exerciseVariant.ExerciseId);
            return View(exerciseVariant);
        }

        // GET: ExerciseVariants/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var exerciseVariant = await _context.ExerciseVariants
                .Include(e => e.Exercise)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (exerciseVariant == null)
            {
                return NotFound();
            }

            return View(exerciseVariant);
        }

        // POST: ExerciseVariants/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var exerciseVariant = await _context.ExerciseVariants.FindAsync(id);
            _context.ExerciseVariants.Remove(exerciseVariant);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ExerciseVariantExists(Guid id)
        {
            return _context.ExerciseVariants.Any(e => e.Id == id);
        }
    }
}
