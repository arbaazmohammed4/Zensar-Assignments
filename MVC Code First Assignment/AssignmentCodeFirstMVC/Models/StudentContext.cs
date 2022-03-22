using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace AssignmentCodeFirstMVC.Models
{
    public class StudentContext : DbContext
    {
        public StudentContext() : base("name=StudentDetails")
        {

        }

        public DbSet<Student> Students { get; set; }
    }
}