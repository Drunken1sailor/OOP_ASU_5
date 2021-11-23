using System;
using System.Collections.Generic;

namespace OOP_ASU_5.Domain
{
    public class Lesson
    {
        // Properties
        public Guid Id { get; set; }
        public string LessonType { get; set;}
        public string Name { get; set; }
        public int Laboriousness { get; set; }
        public string Notes { get; set; }

        // Foreign Keys
        public Guid DisciplineId { get; set; }
        public Guid ContentLinkId { get; set; }
        // Navigation properites
        public List<ExercisesBlock> ExercisesBlocks { get; set; }
        public Discipline Discipline { set; get; }
        public ContentLink ContentLink { get; set; }
        // Тест объект
        //public List<ExerciseVariant> ExerciseVariants { get; set; }

    }
}
