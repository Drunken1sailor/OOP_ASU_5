using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
OOP_ASU_5_Blazor.Models;

namespace OOP_ASU_5_Blazor.Models
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
        /*public Guid ContentLinkId { get; set; }*/

        // Navigation properites
        public ExercisesBlock ExercisesBlock { get; set; }
        public ContentLink ContentLink { get; set; }
        public List<ExerciseVariant> ExerciseVariants { get; set; } 
        //Ссылка на тест - добавить

    }
}
