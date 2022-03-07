using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy1
{
    public class Student
    {
        public string Name;
        public string Id;
        public string DateofBirth;

        public Student(Student s)
        {
            this.Name = s.Name;
            Id = s.Id;
            DateofBirth = s.DateofBirth;
        }
        public Student(string nm, string id, string dob)
        {
            this.Name = nm;
            this.Id = id;
            this.DateofBirth = dob;
        }

        public string name 
        {
            get
            {
                return Name;
            }
               

          set { Name = value; } 
        }
    }


}
