using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignement_3
{
    interface IStudent
    {

        string ID { get; set; }
        string Name { get; set; }
        void ShowDetails();
    }

    // A class that implements interface.
    class DayScholar : IStudent
    {

        public string College;
        public string Hostel;
        public string Address;
        private string id;
        public string ID

        {
            get => id;
            set => id = value;
        }
        private string name;
        public string Name
        {
            get => name;
            set => name = value;
        }

        public void ShowDetails()
        {
            College = "Poojya Doddappa College";
            Hostel = "Doddappa Hostel";
            Address = "Aiwan E Shahi,Gulbarga ";
            Console.WriteLine("College: " + College);
            Console.WriteLine("Hostel: " + Hostel);
            Console.WriteLine("Address: " + Address);
        }
    }
    class Resident : IStudent
    {
        public static string City;
        public string Locality;
        private string id2;
        public string ID

        {
            get => id2;
            set => id2 = value;
        }
        private string name2;
        public string Name
        {
            get => name2;
            set => name2 = value;
        }

        public void ShowDetails()
        {
            City = "Gulbarga";
            Locality = "Yadulla Colony";
            Console.WriteLine($"City is {City} and Locality is {Locality}");

        }

    }
    class InterfaceMain
    {
        static void Main()
        {
            IStudent d = new DayScholar();
            d.Name = "Arbaz";
            d.ID = "65808";
            Console.WriteLine("Name:" + d.Name);
            Console.WriteLine("ID:" + d.ID);
            DayScholar d1 = new DayScholar();
            d1.ShowDetails();

            IStudent r = new DayScholar();
            r.Name = "Mohammed";
            r.ID = "MA658";
            Console.WriteLine("Name: " + r.Name);
            Console.WriteLine("ID: " + r.ID);
            Resident r1 = new Resident();
            r1.ShowDetails();
            Console.WriteLine();
            Console.Read();

        }

    }
}
