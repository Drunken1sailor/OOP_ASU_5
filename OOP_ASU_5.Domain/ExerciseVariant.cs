using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ASU_5.Domain
{
    public class ExerciseVariant
    {
        // Properties
        public Guid Id { get; set; }
        public string Number { get; set; }
        public double DifficultyCoefficient { get; set; }

        // Foreign keys
        public Guid ExerciseId { get; set; }
        /*public Guid ContentLinkId { get; set; }*/

        // Navigation properites
        public ContentLink ContentLink { get; set; }
        public Exercise Exercise { get; set; }
    }
}
