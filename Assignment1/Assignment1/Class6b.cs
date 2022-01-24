using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Class6b
    {
       

        static void Main()
        {
            Console.WriteLine("Enter the marks");
            int[] marks = new int[10];
            int sum = 0;
           
            for (int i = 0; i < 10; i++)
            {
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < marks.Length; i++)
            {

                sum = sum + marks[i];
            }
            Console.WriteLine(" TOTAL MARKS " + sum);
            int avg = sum / 10;
            Console.WriteLine("AVERAGE MARKS " + avg);
            Console.WriteLine("MINIMUM MARKS SCORED " + marks.Min());
            Console.WriteLine("MAXIMUM MARKS SCORED "  + marks.Max());
            

            Array.Sort(marks);
            Console.WriteLine("MARKS in Asc order");
            for (int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine(marks[i]);
            }
            Array.Reverse(marks);
            Console.WriteLine("MARKS IN Desc Order");
            for (int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine(marks[i]);
            }
        }
       
    }
}
