using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AssignmentCodeFirstMVC.Models
{
    [Table("Stud_Details")]
    public class Student
    {
        [Key]
        public int StudentID { get; set; }
        public string Stud_Branch { get; set; }
        public string Stud_City { get; set; }
        public float Stud_Percentage { get; set; }
    }
}