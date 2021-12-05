/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_ASU_5.Domain;
using OOP_ASU_5.API;
using OOP_ASU_5.Infrastructure.Repository;
using OOP_ASU_5.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace TestProject1
{
    public class TestHelper
    {
        private readonly Context _context;

        public TestHelper()
        {
            var builder = new DbContextOptionsBuilder<Context>();
            builder.UseInMemoryDatabase(databaseName: "LibraryDbInMemory");
            var dbContextOptions = builder.Options;
            _context = new Context(dbContextOptions);
            _context.Database.EnsureDeleted();
            _context.Database.EnsureCreated();
        }

        public ExerciseRepository AttendanceRepository
        {
            get
            {
                return new ExerciseRepository(_context);
            }
        }
        public ClassRepository ClassRepository
        {
            get
            {
                return new ClassRepository(_context);
            }
        }
        public GroupRepository GroupRepository
        {
            get
            {
                return new GroupRepository(_context);
            }
        }
        public StudentRepository StudentRepository
        {
            get
            {
                return new StudentRepository(_context);
            }
        }
    }
}*/