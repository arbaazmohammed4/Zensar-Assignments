using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CaseStudy1;

namespace Case_Study2
{
    class Main1
    {
        static void Main()
        {
            
            AppEngine engine = new AppEngine();


            Course c = new Course(01, "XYZ", "6 months", 9000);
            var co = new Course(c);
            engine.introduce(co);
            Console.WriteLine();
            Console.WriteLine("********************************************");
            Console.WriteLine();



            Student s1 = new Student("Arbaz", "MA65808", "18 / 12 / 1998");
            var st = new Student(s1);
            engine.register(st);
            Console.WriteLine();
            Console.WriteLine("**********************************************");
            Console.WriteLine();

            engine.enroll(st, co);
            Console.WriteLine();
            Console.WriteLine("***********************************************");

            Console.WriteLine();
            Console.WriteLine("****************************************************");
            Course[] courses = engine.listOfCourses();
            foreach (var it in courses)
            {
                Console.WriteLine($"{it.i} {it.nm} {it.du} {it.f}");
            }
            Console.WriteLine();
            Console.WriteLine("****************************************************");
            Console.WriteLine();


            Student[] students = engine.listOfStudents();
            //Console.WriteLine(students);
            foreach (var item in students)
            {
                Console.WriteLine($"{item.Name} {item.Id} {item.DateofBirth}");
            }
            Console.ReadLine();




           
        }
    }
}
