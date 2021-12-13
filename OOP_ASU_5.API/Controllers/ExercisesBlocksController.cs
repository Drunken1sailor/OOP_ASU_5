using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OOP_ASU_5.Domain;
using OOP_ASU_5.Infrastructure.Data;

namespace OOP_ASU_5.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExercisesBlocksController : ControllerBase
    {
        private readonly Context _context;

        public ExercisesBlocksController(Context context)
        {
            _context = context;
        }

        // GET: api/ExercisesBlocks
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ExercisesBlock>>> GetExercisesBlocks()
        {
            return await _context.ExercisesBlocks.ToListAsync();
        }

        // GET: api/ExercisesBlocks/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ExercisesBlock>> GetExercisesBlock(Guid id)
        {
            var exercisesBlock = await _context.ExercisesBlocks.FindAsync(id);

            if (exercisesBlock == null)
            {
                return NotFound();
            }

            return exercisesBlock;
        }

        // PUT: api/ExercisesBlocks/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutExercisesBlock(Guid id, ExercisesBlock exercisesBlock)
        {
            if (id != exercisesBlock.Id)
            {
                return BadRequest();
            }

            _context.Entry(exercisesBlock).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ExercisesBlockExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/ExercisesBlocks
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ExercisesBlock>> PostExercisesBlock(ExercisesBlock exercisesBlock)
        {
            _context.ExercisesBlocks.Add(exercisesBlock);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetExercisesBlock", new { id = exercisesBlock.Id }, exercisesBlock);
        }

        // DELETE: api/ExercisesBlocks/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteExercisesBlock(Guid id)
        {
            var exercisesBlock = await _context.ExercisesBlocks.FindAsync(id);
            if (exercisesBlock == null)
            {
                return NotFound();
            }

            _context.ExercisesBlocks.Remove(exercisesBlock);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ExercisesBlockExists(Guid id)
        {
            return _context.ExercisesBlocks.Any(e => e.Id == id);
        }
    }
}
