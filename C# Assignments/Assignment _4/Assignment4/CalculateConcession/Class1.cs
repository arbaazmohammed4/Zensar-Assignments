using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateConcession
{
    public class Class1
    {
        
        
        public void CalculateConcession(int fare,int age)
        {
           
            
            if(age <= 5)
            {
                Console.WriteLine("LITTLE CHAMPS - FREE TICKET");
            }  
            else if(age > 60)
            {
                double CalculateCons = 0.3 * fare;
                double ConsessionTicket = fare - CalculateCons;
                Console.WriteLine("Senior Citizen \n Ticket Price is: " + ConsessionTicket);
            }
            else
            {
                Console.WriteLine("Ticket Price Is: " +fare);   
                Console.WriteLine("Ticket Booked " );    
            }
        }
    }
}
