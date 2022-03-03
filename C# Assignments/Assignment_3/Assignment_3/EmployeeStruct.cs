using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class EmployeeStruct
    {
        struct Employee
        {

            public string Name;
            public DOB DofB;

        }
        struct DOB
        {
            public int Day;
            public int Month;
            public int Year;
        }
        public static void Main()
        {
            Employee[] emp = new Employee[2];
            Console.WriteLine("       Nested Structures ");
            Console.WriteLine("-----------------------------");
            Console.WriteLine();
            for (int i = 0; i < 2; i++)
            {
                Console.Write("Name of the Employee: ");
                string n = Console.ReadLine();
                emp[i].Name = n;

                Console.Write("Day on which Born: ");
                int dd = Convert.ToInt32(Console.ReadLine());
                emp[i].DofB.Day = dd;

                Console.Write("Month IN which Born: ");
                int mm = Convert.ToInt32(Console.ReadLine());
                emp[i].DofB.Month = mm;

                Console.Write("Year IN which Born: ");
                int yy = Convert.ToInt32(Console.ReadLine());
                emp[i].DofB.Year = yy;
                Console.WriteLine();
                Console.Read();
            }

        }
    }
}
