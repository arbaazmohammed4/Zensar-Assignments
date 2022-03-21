using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ZensarCodingTest
{
    class Program
    {
        public static SqlConnection con;
        public static SqlCommand cmd;

        static void InsertData()
        {
            try
            {
                con = getConnection();
                Console.WriteLine("Enter Employee Details : ");
                string ename, etype;
                float esal;
                Console.WriteLine("Enter Employee Name : ");
                ename = Console.ReadLine();
                Console.WriteLine("Enter Employee Salary : ");
                esal = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter Employee Type 'C' Or 'P' :");
                etype = Console.ReadLine();
                cmd = new SqlCommand("execute dbo.Add_New_Employee @ename, @esal, @etype");
                cmd.Parameters.AddWithValue("@ename", ename);
                cmd.Parameters.AddWithValue("@esal", esal);
                cmd.Parameters.AddWithValue("@etype", etype);
                cmd.Connection = con;
                int no_ofrows = cmd.ExecuteNonQuery();


                if (no_ofrows > 0)
                {
                    Console.WriteLine("No. of Rows affected are : {0} ", no_ofrows);
                }
                else
                {
                    Console.WriteLine("OOPS !! Encounterd Problem");
                }
            }
            catch (SqlException se)
            {
                Console.WriteLine(se.Message);
            }
        }

        static SqlConnection getConnection()
        {
            con = new SqlConnection(@"data source=ARBAAZ-PC ;initial catalog=EmployeeManagement ;integrated security=true");
            con.Open();
            return con;
        }


        static void Main(string[] args)
        {
            InsertData();
        }
    }

}
