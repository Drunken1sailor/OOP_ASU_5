using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OOP_ASU_5.Domain;

namespace OOP_ASU_5.Infrastructure.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options)
            :base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

        // DbSet's
        public DbSet<ContentLink> ContentLinks { get; set; }
        public DbSet<Discipline> Disciplines { get; set; }
        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<ExercisesBlock> ExercisesBlocks { get; set; }
        public DbSet<ExerciseVariant> ExerciseVariants { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Option> Options { get; set;}
    }
}
