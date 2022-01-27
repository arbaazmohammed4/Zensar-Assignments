using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Account2
    {
        long Account_no;
        string Customer_name;
        string Account_Type;
        public string Trans_Type;
        public long Amount;

        public Account2(long Acc_no, string cust_nm, string acc_typ)
        {
            Account_no = Acc_no;
            Customer_name = cust_nm;
            Account_Type = acc_typ;
        }

        public void credit()
        {
            Console.WriteLine("Available: " +Amount);
            Console.WriteLine("Enter Amount to be Deposited");
            long c = Convert.ToInt64(Console.ReadLine());
            Amount = c + Amount;
            
            Console.WriteLine("New Balance: " + Amount);
        }
        public void debit()
        {
            Console.WriteLine("Available: " + Amount);
            Console.WriteLine("Enter Amount to be Withdrawn");
            long d = Convert.ToInt64(Console.ReadLine());
            Amount =  d - Amount;
            Console.WriteLine("New Balance: " + Amount);
        }

        public void Display()
        {
            Console.WriteLine("Account number: " + Account_no);
            Console.WriteLine("Customer Number: " + Customer_name);
            Console.WriteLine("Account Type: " + Account_Type);

        }



    }

    class Bank
    {
        public static void Main()
        {
            Account2 acc = new Account2(68754789, "Arbaz", "SAVINGS");
            acc.Display();
            acc.Amount = 3000;
            Console.WriteLine("Enter The Transaction Type");
            Console.WriteLine("For Deposit Press: 1 \nfor Withdrawal Press: 2");
            int Trans_Type = Convert.ToInt32(Console.ReadLine());
            if(Trans_Type == 1)
            {
                acc.credit();

            }
            else if(Trans_Type == 2)    
            {
                acc.debit();
            }
            else
            {
                Console.WriteLine("Entered a Wrong Choice");
            }

            Console.WriteLine("Thank you Visit Again");


        }
    }
}
