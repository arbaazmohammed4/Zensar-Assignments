using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Strings
    {

        /*1:Write a program in C# to accept a word from the user and display the length of it.
2.	     2:Write a program in C# to accept a word from the user and display the reverse of it. 
3.	     3:Write a program in C# to accept two words from user and find out if they are same. 
		 4:To withdraw an amount after checking the balance
		 To display name and balance.*/

        static void Main()
        {
            Console.WriteLine("Write Something");
            string s = Console.ReadLine();
            Console.WriteLine("Length of the string: " + s.Length);


            Console.WriteLine("#####################################################################");


            Console.WriteLine("REVERSE WORD");
            Console.WriteLine("write Something");
            string s2 = Console.ReadLine();
            string rev = string.Empty;
            for (int i = s2.Length - 1; i >= 0; i--)
            {
                rev += s2[i];
            }
            Console.WriteLine("Reverse of the string:" + rev);
            
           
            Console.WriteLine("#####################################################################");

            Console.WriteLine("TWO WORDs");
            Console.WriteLine("write first word");
            string s3 = Console.ReadLine();
            Console.WriteLine("write Second word");
            string s4 = Console.ReadLine();
            if (s3 == s4)
            {
                Console.WriteLine("Both Words are same");
            }
            else
            {
                Console.WriteLine("Not Same");
            }



        }


    }
}
