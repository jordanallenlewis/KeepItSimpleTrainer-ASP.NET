using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KeepItSimpleTrainer.Models
{
    public class TrainingModule
    {
        public int ID { get; set; }
        public string Club { get; set; }
        //public string Club = ["Club 1", "Club 2", "Club 3"];
        public string Title { get; set; }
        public Question[] Questions { get; set; }

    }
}