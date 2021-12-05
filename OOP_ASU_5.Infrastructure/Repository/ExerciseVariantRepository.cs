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
    public class ExerciseVariantRepository
    {
        private readonly Context _context;
        public Context UnitOfWork
        {
            get
            {
                return _context;
            }
        }
        public ExerciseVariantRepository(Context context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public async Task<List<ExerciseVariant>> GetAllAsync()
        {
            return await _context.ExerciseVariants.OrderBy(p => p.Id).ToListAsync();
        }
        public async Task<ExerciseVariant> GetByIdAsync(int id)
        {
            return await _context.ExerciseVariants.FindAsync(id);
        }
        public async Task AddAsync(ExerciseVariant person)
        {
            _context.ExerciseVariants.Add(person);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateAsync(ExerciseVariant person)
        {
            var existPerson = await _context.ExerciseVariants.FindAsync(person.Id);
            _context.Entry(existPerson).CurrentValues.SetValues(person);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(int id)
        {
            ExerciseVariant person = await _context.ExerciseVariants.FindAsync(id);
            _context.Remove(person);
            await _context.SaveChangesAsync();
        }
    }
}