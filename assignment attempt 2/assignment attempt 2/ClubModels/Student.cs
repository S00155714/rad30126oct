using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace assignment_attempt_2.ClubModels
{
    [Table("Student")]
    public class Student
    {
        public string StudentID { get; set; }

        public string Fname { get; set; }

        public string Sname { get; set; }
    }
}
 