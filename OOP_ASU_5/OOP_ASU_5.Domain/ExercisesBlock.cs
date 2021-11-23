using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ASU_5.Domain
{
    public class ExercisesBlock
    {
        // Properties
        public Guid Id { get; set; }
        public string ExerciseBlockType { get; set;}
        public string ExerciseBlockSubType { get; set; }
        public string MethodicalInstructions { get; set; }
        public string Notes { get; set; }

        // Foreign keys
        public Guid ContentLinkId { get; set; }

        // Navigation properites
        public ContentLink ContentLink { get; set; }
        public List<Exercise> Exercises { get; set; }
    }
}
