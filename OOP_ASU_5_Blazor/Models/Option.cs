using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ASU_5_Blazor.Models
{
    public class Option
    {
        // Properties
        public Guid Id { get; set; }
        public string OptionType { get; set; }
        public string Number { get; set; }
        public string Description { get; set; }
        public Boolean FreeFormat { get; set; }

        // Foreign keys
        public Guid ExerciseId { get; set; }

        // Navigation properites
        public Exercise Exercise { get; set; }
    }
}
