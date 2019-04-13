using System;
using System.Collections.Generic;

namespace DataAccess
{
    public class Lesson
    {
        public int LessonId { get; set; }        
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public ICollection<Question> Questions { get; set; }
    }
}
