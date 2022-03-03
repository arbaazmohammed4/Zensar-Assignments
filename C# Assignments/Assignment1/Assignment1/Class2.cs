using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Class2
    {
        static void Main()
        {
            Console.WriteLine("Enter the no");
            int n  =Convert.ToInt32(Console.ReadLine());
            if (n%2 == 0)
            {
                Console.WriteLine(n + " IS EVEN Number");
            }
            else
            {
                Console.WriteLine(n + " IS ODD Number");
            }
        }
    }
}
