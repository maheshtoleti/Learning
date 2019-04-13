using System;
using System.Collections.Generic;

namespace DataAccess
{
    public class Chapter
    {
        public int ChapterId { get; set; }        
        public string Name { get; set; }
        public bool IsActive { get; set; }         
        public ICollection<Lesson> Lessons { get; set; }
        public ICollection<Question> Questions { get; set; }
    }
}
