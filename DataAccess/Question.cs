using System;
using System.Collections.Generic;

namespace DataAccess
{
    public class Question
    {
        public int QuestionId { get; set; }        
        public string QuestionText { get; set; }
        public bool IsMultipleChoice { get; set; }
        public string ChoiceA { get; set; }
        public string ChoiceB { get; set; }
        public string ChoiceC { get; set; }
        public string ChoiceD { get; set; }
        public string ChoiceE { get; set; }
        public string Answer { get; set; }
        public Complexity CompexityLevel { get; set; }
        public bool IsActive { get; set; }
    }
}
