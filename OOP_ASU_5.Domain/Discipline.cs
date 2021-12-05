using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ASU_5.Domain
{
    public class Discipline
    {
        // Properties
        public Guid Id { get; set; }
        public Guid DisciplineId { get; set; }
        public string Name { get; set;}

        // Foreign keys
        public Guid LessonId { get; set; }

        // Navigation properites
        public Lesson Lesson { get; set; }
    }
}
