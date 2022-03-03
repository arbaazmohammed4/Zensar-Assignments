using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Class3
    {
        static void Main()
        {
            Console.WriteLine("Enter Three Numbers");
            int n1 = Convert.ToInt32(Console.ReadLine());
            int n2 = Convert.ToInt32(Console.ReadLine());
            int n3 = Convert.ToInt32(Console.ReadLine());
            if (n1 > n2 && n1 >n3)
            {
                Console.WriteLine(n1 + " Is The Largest");
            }
            else if(n2 > n1 && n2 > n3)
            {
                Console.WriteLine(n2 + " Is The Largest");
            }
            else
            {
                Console.WriteLine(n3 + " Is The Largest");
            }
           
            if (n1<n2 && n1<n3)
            {
                Console.WriteLine(n1 + " IS the Smallest ");
            }
            else if (n2 < n1 && n2 < n3)
            {
                Console.WriteLine(n2 + " IS the SMALlest");
            }
            else 
            {
                Console.WriteLine(n3 + " IS the Smallest");
            }
        }
    }
}
