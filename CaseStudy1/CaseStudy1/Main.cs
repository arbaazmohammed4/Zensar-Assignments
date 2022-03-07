using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy1
{
    class MainClass
    {
        public static void Main()
        {
            Info i1 = new Info();
            Console.WriteLine("********** CaseStudy 1 ***************");
            Console.WriteLine("**********  Scenario 1 ***************");
            void Scenario1()
            {
                Student s1 = new Student("Arbaz", "MA65808", "18 / 12 / 1998");

                i1.display(s1);
                Student s2 = new Student(s1);
                i1.display(s2);
                s2.name = "XYZ";
                i1.display(s2);
            }
            Scenario1();
            Console.WriteLine();

            Console.WriteLine("************ Scenario 2 ***************");
            void Scenario2()
            {
                Student[] sArr = new Student[5];
                sArr[0] = new Student ("Mohammed", "MO808", "12/12/1999");
                sArr[1] = new Student("Pankaj", "PK687", "08/08/1998");
                sArr[2] = new Student("Prasad", "PA908", "03/11/1999");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Students List:  ");
                Console.WriteLine("Displaying Each Value");
                i1.display(sArr[0]);
                i1.display(sArr[1]);
                i1.display(sArr[2]);
                Console.WriteLine("******* Array Iterator *********");
                for (int i = 0; i <= 2; i++)
                {
                    i1.display(sArr[i]);
                }
            



            }
            Scenario2();

            Console.WriteLine();

            void Scenario3()
            {
                Console.WriteLine("Enter the number of Entries You Want to Add: ");
                int x = Convert.ToInt32(Console.ReadLine());
                Student[] arr = new Student[x];
                
                
                    for (int i = 0; i < arr.Length; i++)
                    {
                    Console.WriteLine("Enter The Student Name: ");
                    string n = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("Enter the ID: ");
                    string ide = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("Enter DOB");
                    string d = Console.ReadLine();
                    Console.WriteLine();
                    Student s3 = new Student(n, ide, d);
                        arr[i] = s3;

                    }
                Console.WriteLine();
                Console.WriteLine("*************************************");
                Console.WriteLine("**************Scenario 3 Results***********************");
                Console.WriteLine("*************************************");
                Console.WriteLine();
                foreach (Student item in arr)
               
                {
                    i1.display (item);
                }
     
            }
            Scenario3();
            Console.WriteLine();

            Console.WriteLine("Now You Create your own Class Course and Again Practice the Scenarios");
        }




    }
}
