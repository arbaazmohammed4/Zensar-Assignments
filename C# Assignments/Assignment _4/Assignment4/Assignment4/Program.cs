using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculateConcession;

namespace Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Class1 cc = new Class1();
            int TotalFare = 500;
            Console.WriteLine("Enter the Name: ");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter the Age ");
            int Age = Convert.ToInt32(Console.ReadLine());
            cc.CalculateConcession(TotalFare, Age);
        }
    }
}
