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
    public class OptionRepository
    {
        private readonly Context _context;
        public Context UnitOfWork
        {
            get
            {
                return _context;
            }
        }
        public OptionRepository(Context context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public async Task<List<Option>> GetAllAsync()
        {
            return await _context.Options.OrderBy(p => p.Id).ToListAsync();
        }
        public async Task<Option> GetByIdAsync(int id)
        {
            return await _context.Options.FindAsync(id);
        }
        public async Task AddAsync(Option person)
        {
            _context.Options.Add(person);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateAsync(Option person)
        {
            var existPerson = await _context.Options.FindAsync(person.Id);
            _context.Entry(existPerson).CurrentValues.SetValues(person);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(int id)
        {
            Option person = await _context.Options.FindAsync(id);
            _context.Remove(person);
            await _context.SaveChangesAsync();
        }
    }
}