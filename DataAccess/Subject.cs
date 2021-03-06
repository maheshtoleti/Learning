﻿using System;
using System.Collections.Generic;

namespace DataAccess
{
    public class Subject
    {
        public int SubjectId { get; set; }        
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public ICollection<Chapter> Chapters { get; set; }
        public ICollection<Lesson> Lessons { get; set; }
        public ICollection<Question> Questions { get; set; }
    }
}
