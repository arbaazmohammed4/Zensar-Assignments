using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CaseStudy1;


namespace Case_Study2
{
    public class Enroll
    {
        private Student student;
        private Course course;
        private LocalDate enrollmentDate;

        public Course Course { get => course; set => course = value; }
    }

    //static void Main()
    //{
    //    Enroll e = new Enroll();
    //    AppEngine en = new AppEngine();
    //    en.listOfStudents();

    //}
}
