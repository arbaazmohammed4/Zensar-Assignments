using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{

    class Students
    {
        public int RollNo;
        public string Name;
        public string Class;
        public int SEM;
        public string Branch;
        public int[] Marks = new int[5];

        public Students(int S_rollno, string S_name, string S_class, int S_sem, string S_branch)
        {
            RollNo = S_rollno;
            Name = S_name;
            Class = S_class;
            SEM = S_sem;
            Branch = S_branch;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"The Roll Number of Student is : {RollNo} ");
            Console.WriteLine($"The Name of Student is : {Name} ");
            Console.WriteLine($"The Class of Student is : {Class} ");
            Console.WriteLine($"The Semester in which Student is in : {SEM} ");
            Console.WriteLine($"The Branch in which Student Studies is : {Branch} ");
        }

        public int GetMarks()
        {
            Console.WriteLine("Enter Marks for 5 Subjects : ");
            for (int i = 0; i < 5; i++)
            {
                Marks[i] = int.Parse(Console.ReadLine());
            }
            return 0;
        }

        public void ShowResult()
        {
            int sum = 0;
            
            for (int i = 0; i < 5; i++)
            {
                sum = sum + Marks[i];
            }

            int avg = sum / Marks.Length;

            Console.WriteLine("Average of all Marks is : {0} ", avg);

            if ((Marks[0] < 35) || (Marks[1] < 35) || (Marks[2] < 35) || (Marks[3] < 35) || (Marks[4] < 35))
            {
                Console.WriteLine("Failed");
            }
            else if (((Marks[0] >= 35) && (Marks[1] >= 35) && (Marks[2] >= 35) && (Marks[3] >= 35) && (Marks[4] >= 35)) && (avg < 50))
            {
                Console.WriteLine("Failed as Average is less than 50.");
            }
            else
            {
                Console.WriteLine("Passed");
            }
        }

    }

    class Student2
    {
        static void Main(string[] args)
        {
            Students stud = new Students(12343, "Arbaz", "A", 8, "Computer Science");
            stud.DisplayDetails();
            stud.GetMarks();
            stud.ShowResult();
        }
    }
}
