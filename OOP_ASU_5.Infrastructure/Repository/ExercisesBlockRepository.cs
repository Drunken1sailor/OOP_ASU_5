using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_ASU_5.Domain;
using OOP_ASU_5.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace WebAPI01.Infrastructure
{
    public class ExercisesBlockRepository
    {
        private readonly Context _context;
        public Context UnitOfWork
        {
            get
            {
                return _context;
            }
        }
        public ExercisesBlockRepository(Context context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public async Task<List<ExercisesBlock>> GetAllAsync()
        {
            return await _context.ExercisesBlocks.OrderBy(p => p.Id).ToListAsync();
        }
        public async Task<ExercisesBlock> GetByIdAsync(int id)
        {
            return await _context.ExercisesBlocks.FindAsync(id);
        }
        public async Task AddAsync(ExercisesBlock person)
        {
            _context.ExercisesBlocks.Add(person);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateAsync(ExercisesBlock person)
        {
            var existPerson = await _context.ExercisesBlocks.FindAsync(person.Id);
            _context.Entry(existPerson).CurrentValues.SetValues(person);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(int id)
        {
            ExercisesBlock person = await _context.ExercisesBlocks.FindAsync(id);
            _context.Remove(person);
            await _context.SaveChangesAsync();
        }
    }
}