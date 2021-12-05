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
    public class ExercisesBlocksController : Controller
    {
        private readonly Context _context;

        public ExercisesBlocksController(Context context)
        {
            _context = context;
        }

        // GET: ExercisesBlocks
        public async Task<IActionResult> Index()
        {
            return View(await _context.ExercisesBlocks.ToListAsync());
        }

        // GET: ExercisesBlocks/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var exercisesBlock = await _context.ExercisesBlocks
                .FirstOrDefaultAsync(m => m.Id == id);
            if (exercisesBlock == null)
            {
                return NotFound();
            }

            return View(exercisesBlock);
        }

        // GET: ExercisesBlocks/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ExercisesBlocks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ExerciseBlockType,ExerciseBlockSubType,MethodicalInstructions,Notes")] ExercisesBlock exercisesBlock)
        {
            if (ModelState.IsValid)
            {
                exercisesBlock.Id = Guid.NewGuid();
                _context.Add(exercisesBlock);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(exercisesBlock);
        }

        // GET: ExercisesBlocks/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var exercisesBlock = await _context.ExercisesBlocks.FindAsync(id);
            if (exercisesBlock == null)
            {
                return NotFound();
            }
            return View(exercisesBlock);
        }

        // POST: ExercisesBlocks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,ExerciseBlockType,ExerciseBlockSubType,MethodicalInstructions,Notes")] ExercisesBlock exercisesBlock)
        {
            if (id != exercisesBlock.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(exercisesBlock);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ExercisesBlockExists(exercisesBlock.Id))
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
            return View(exercisesBlock);
        }

        // GET: ExercisesBlocks/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var exercisesBlock = await _context.ExercisesBlocks
                .FirstOrDefaultAsync(m => m.Id == id);
            if (exercisesBlock == null)
            {
                return NotFound();
            }

            return View(exercisesBlock);
        }

        // POST: ExercisesBlocks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var exercisesBlock = await _context.ExercisesBlocks.FindAsync(id);
            _context.ExercisesBlocks.Remove(exercisesBlock);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ExercisesBlockExists(Guid id)
        {
            return _context.ExercisesBlocks.Any(e => e.Id == id);
        }
    }
}
