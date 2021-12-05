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
    public class LessonRepository
    {
        private readonly Context _context;
        public Context UnitOfWork
        {
            get
            {
                return _context;
            }
        }
        public LessonRepository(Context context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public async Task<List<Lesson>> GetAllAsync()
        {
            return await _context.Lessons.OrderBy(p => p.Id).ToListAsync();
        }
        public async Task<Lesson> GetByIdAsync(int id)
        {
            return await _context.Lessons.FindAsync(id);
        }
        public async Task AddAsync(Lesson person)
        {
            _context.Lessons.Add(person);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateAsync(Lesson person)
        {
            var existPerson = await _context.Lessons.FindAsync(person.Id);
            _context.Entry(existPerson).CurrentValues.SetValues(person);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(int id)
        {
            Lesson person = await _context.Lessons.FindAsync(id);
            _context.Remove(person);
            await _context.SaveChangesAsync();
        }
    }
}