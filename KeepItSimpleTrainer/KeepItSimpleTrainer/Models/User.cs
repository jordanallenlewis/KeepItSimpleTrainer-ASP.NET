using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KeepItSimpleTrainer.Models
{
    public class User
    {
        public enum PermissionLevels { Student, Admin };
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ASURite { get; set; }
        public int StudentID { get; set; }
        public PermissionLevels PermissionLevel { get; set; }

    }
}