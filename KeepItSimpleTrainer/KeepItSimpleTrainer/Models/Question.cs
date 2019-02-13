using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KeepItSimpleTrainer.Models
{
    public class Question
    {
        public int ModuleID { get; set; }
        enum QuestionType { MultipleChoice, FillIn };
        public string QuestionString { get; set; }
        public Tuple<string, bool>[] Choices { get; set; }
    }
}