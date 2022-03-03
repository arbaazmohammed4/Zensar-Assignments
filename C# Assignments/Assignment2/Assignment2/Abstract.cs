using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Assignment2
/*3.Create an Abstract class Student with  Name, StudentId, Grade as members and also an abstract method Boolean Ispassed(grade) which takes grade as an input and checks whether student passed the course or not.  

Create 2 Sub classes Undergraduate and Graduate that inherits all members of the student and overrides Ispassed() method 

For the UnderGrad class, if the grade is above 70.0, then isPassed returns true, otherwise it returns false. For the Grad class, if the grade is above 80.0, then isPassed returns true, otherwise returns false.
 * 
 * 
*/


{
    abstract class StudentDetails
    {
        public abstract bool Ispassed(float grade);
        public string Name = "Arbaz";
        public int StudentId = 051;

        

    }

    class UnderGraduate : StudentDetails
    {

        public override bool Ispassed(float grade)
        {
            Console.Write("UnderGraduate:  ");
            {
                if (grade >= 70.0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }


    }

    class Graduate : StudentDetails
    {
        public override bool Ispassed(float grade)
        {
            Console.Write("Graduate:  ");
            if (grade > 80.0f)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }

    class Abstract
    {
        public static void Main(string[] args)
        {
            bool pass;
            UnderGraduate u = new UnderGraduate();
            Console.WriteLine("Student Name is: " + u.Name);
            Console.WriteLine("Student Idno is: " + u.StudentId);
            Console.WriteLine("Enter the UnderGraduate Grade");
            float f = Convert.ToSingle(Console.ReadLine());
            pass = u.Ispassed(f);
            if (pass)
            {
                Console.WriteLine("The Student is passed in UnderGraduate");
            }
            else
                Console.WriteLine("The Student is Failed in UnderGraduate");

            Graduate g = new Graduate();
            Console.WriteLine("Enter the Graduate Grade: ");
            float g1 = Convert.ToSingle(Console.ReadLine());
            pass = g.Ispassed(g1);
            if (pass)
            {
                Console.WriteLine("The Student has Passed in Graduate");
            }
            else
                Console.WriteLine("The Student has Failed in Graduate");

        }



    }


}
