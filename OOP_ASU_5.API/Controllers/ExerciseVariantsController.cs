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
    public class ExerciseVariantsController : ControllerBase
    {
        private readonly Context _context;

        public ExerciseVariantsController(Context context)
        {
            _context = context;
        }

        // GET: api/ExerciseVariants
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ExerciseVariant>>> GetExerciseVariants()
        {
            return await _context.ExerciseVariants.ToListAsync();
        }

        // GET: api/ExerciseVariants/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ExerciseVariant>> GetExerciseVariant(Guid id)
        {
            var exerciseVariant = await _context.ExerciseVariants.FindAsync(id);

            if (exerciseVariant == null)
            {
                return NotFound();
            }

            return exerciseVariant;
        }

        // PUT: api/ExerciseVariants/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutExerciseVariant(Guid id, ExerciseVariant exerciseVariant)
        {
            if (id != exerciseVariant.Id)
            {
                return BadRequest();
            }

            _context.Entry(exerciseVariant).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ExerciseVariantExists(id))
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

        // POST: api/ExerciseVariants
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ExerciseVariant>> PostExerciseVariant(ExerciseVariant exerciseVariant)
        {
            _context.ExerciseVariants.Add(exerciseVariant);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetExerciseVariant", new { id = exerciseVariant.Id }, exerciseVariant);
        }

        // DELETE: api/ExerciseVariants/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteExerciseVariant(Guid id)
        {
            var exerciseVariant = await _context.ExerciseVariants.FindAsync(id);
            if (exerciseVariant == null)
            {
                return NotFound();
            }

            _context.ExerciseVariants.Remove(exerciseVariant);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ExerciseVariantExists(Guid id)
        {
            return _context.ExerciseVariants.Any(e => e.Id == id);
        }
    }
}
