using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace LinqAssignment
{
    public class Employee
    {
        public int EmployeeId;
        public string FirstName;
        public string LastName;
        public string Title;
        public DateTime DOB;
        public DateTime DOJ;
        public string City;
        //public Employee(int Eid,string FName,string Lname,string Ti,DateTime birth,DateTime joining,string loc)
        //{
        // EmployeeID = Eid;
        // FirstName = FName;
        // LastName = Lname;
        // Title = Ti;
        // DOB = birth;
        // DOJ = joining;
        // City = loc;



        //}
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> emplist = new List<Employee>() {
new Employee(){ EmployeeId=1001,FirstName="Malcolm",LastName="Daruwalla",Title="Manager",DOB=new DateTime(16/11/1984),DOJ=new DateTime(8/6/2011),City="Mumbai" },
new Employee(){ EmployeeId=1002,FirstName="Asdin",LastName="Dhalla",Title="AsstManager",DOB=new DateTime(20 /08/1984),DOJ=new DateTime(7 /7/2012),City="Mumbai"},
new Employee(){EmployeeId= 1003,FirstName="Madhavi",LastName="Oza",Title="Consultant",DOB=new DateTime(14 /11/1987),DOJ=new DateTime(12/4/2015),City="Pune"},
new Employee(){ EmployeeId=1004,FirstName="Saba",LastName="Shaikh",Title="SE",DOB=new DateTime(3 /6/1990),DOJ=new DateTime(2 /2/2016),City="Pune"},
new Employee(){ EmployeeId=1005,FirstName="Nazia",LastName="Shaikh",Title="SE",DOB=new DateTime(8 /3/1991),DOJ=new DateTime(2 /2/2016),City="Mumbai"},
new Employee(){ EmployeeId=1006,FirstName="Amit",LastName="Pathak",Title="Consultant",DOB=new DateTime(7 /11/1989),DOJ=new DateTime(8/8/2014),City="Chennai"},
new Employee(){ EmployeeId=1007,FirstName="Vijay",LastName="Natrajan",Title="Consultant",DOB=new DateTime(2 /12/1989),DOJ=new DateTime(1 /6/2015),City="Mumbai"},
new Employee(){ EmployeeId=1008,FirstName="Rahul",LastName="Dubey",Title="Associate",DOB=new DateTime(11 /11/1993),DOJ=new DateTime(6 /11/2014),City="Chennai"},
new Employee(){ EmployeeId=1009,FirstName="Suresh",LastName="Mistry",Title="Associate",DOB=new DateTime(12 /8/1992),DOJ=new DateTime(3 /12/2014),City="Chennai"},
new Employee(){ EmployeeId=1010,FirstName="Sumit",LastName="Shah",Title="Manager",DOB=new DateTime(12 /4/1991),DOJ=new DateTime(2 /1/2016),City="Pune"}};
            foreach (var f in emplist)
            {
                Console.WriteLine(f.EmployeeId + "\t" + f.FirstName + "\t" + f.LastName + "\t" + f.Title + "\t" + f.DOB + "\t" + f.DOJ + "\t" + f.City);
            }
            Console.WriteLine();
            Console.WriteLine();
            var e = emplist.Where(f => f.City != "Mumbai");
            foreach (var f in e)
            {
                Console.WriteLine(f.EmployeeId + "\t" + f.FirstName + "\t" + f.LastName + "\t" + f.Title + "\t" + f.DOB + "\t" + f.DOJ + "\t" + f.City);
            }
            Console.WriteLine();
            Console.WriteLine();
            e = emplist.Where(f => f.Title == "AsstManager");
            foreach (var f in e)
            {
                Console.WriteLine(f.EmployeeId + "\t" + f.FirstName + "\t" + f.LastName + "\t" + f.Title + "\t" + f.DOB + "\t" + f.DOJ + "\t" + f.City);
            }
            Console.WriteLine();
            Console.WriteLine();
            e = emplist.Where(f => f.LastName == "S%");
            foreach (var f in e)
            {
                Console.WriteLine(f.EmployeeId + "\t" + f.FirstName + "\t" + f.LastName + "\t" + f.Title + "\t" + f.DOB + "\t" + f.DOJ + "\t" + f.City);
            }
            Console.WriteLine();
            Console.WriteLine();
            e = emplist.Where(f => f.Title == "Consultant" && f.Title == "Associate");
            foreach (var f in e)
            {
                Console.WriteLine(f.EmployeeId + "\t" + f.FirstName + "\t" + f.LastName + "\t" + f.Title + "\t" + f.DOB + "\t" + f.DOJ + "\t" + f.City);
            }

        }
    }
}