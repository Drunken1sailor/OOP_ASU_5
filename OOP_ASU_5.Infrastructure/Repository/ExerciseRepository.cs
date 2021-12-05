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
    public class ExerciseRepository
    {
        private readonly Context _context;
        public Context UnitOfWork
        {
            get
            {
                return _context;
            }
        }
        public ExerciseRepository(Context context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public async Task<List<Exercise>> GetAllAsync()
        {
            return await _context.Exercises.OrderBy(p => p.Id).ToListAsync();
        }
        public async Task<Exercise> GetByIdAsync(int id)
        {
            return await _context.Exercises.FindAsync(id);
        }
        public async Task AddAsync(Exercise person)
        {
            _context.Exercises.Add(person);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateAsync(Exercise person)
        {
            var existPerson = await _context.Exercises.FindAsync(person.Id);
            _context.Entry(existPerson).CurrentValues.SetValues(person);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(int id)
        {
            Exercise person = await _context.Exercises.FindAsync(id);
            _context.Remove(person);
            await _context.SaveChangesAsync();
        }
    }
}