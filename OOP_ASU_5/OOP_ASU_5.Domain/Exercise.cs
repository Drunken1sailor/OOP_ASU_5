using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ASU_5.Domain
{
    public class Exercise
    {

        // Properties
        public Guid Id { get; set; }
        public string ExerciseType { get; set; }
        public string Number { get; set; }
        public double DifficultyCoefficient { get; set;}

        // Foreign keys
        public Guid ExercisesBlockId { get; set; }
        public Guid ContentLinkId { get; set; }

        // Navigation properites
        public ExercisesBlock ExercisesBlock { get; set; }
        public ContentLink ContentLink { get; set; }
        //Ссылка на тест - добавить
        public List<ExerciseVariant> ExercisesVariants { get; set; }

    }
}
