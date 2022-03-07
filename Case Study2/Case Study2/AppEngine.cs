using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CaseStudy1;

namespace Case_Study2
{
    class AppEngine
    {
        public void introduce(Course course)
        {
            course.i = 121;
            course.nm = "C++ Full Stack Developer";
            course.du = "6 Months";
            course.f = 25000;
            Console.WriteLine($"{course.i} {course.nm} {course.du} {course.f}");
        }

        public void register(Student student)
        {
            student.Name = "Bill";
            student.Id = "12";
            student.DateofBirth = "12/02/1999";
            Console.WriteLine($"{student.Name} {student.Id} {student.DateofBirth}");

        }

        public Student[] listOfStudents()
        {
            var student = new Student[]
            {
                new Student("Alex","102","02/01/2022"),
                new Student("Ferguson","221","03/01/2022"),
                new Student("Ron","876","03/01/2022")
            };
            
            return student;

        }

        public Course[] listOfCourses()
        {
            var course = new Course[]
            {
                new Course(01,"C# Full Stack Developer","3 Months",28000),
                new Course(02,"JAVA Full Stack Developer","4 Months",30000),
                new Course(03, "Python", "2 Months", 25000)
            };

            return course;

        }

        public void enroll(Student student, Course course)
        {
            Console.WriteLine();
            Console.WriteLine("**************************************");
            Console.WriteLine();
            Console.WriteLine("The Following Student Has enrolled to: ");
            var Course_Enrolled =  student.Name   +   course.nm;
            Console.WriteLine(Course_Enrolled);
            Console.WriteLine();
            Console.WriteLine("**************************************");
            Console.WriteLine();


        }

     

    }
}
