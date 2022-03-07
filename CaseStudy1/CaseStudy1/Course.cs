using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy1
{
    public class Course
    {
        int id;
        string name;
        string duration;
        float fees;

        public Course(Course c)
        {
            this.id = c.id;
            this.name = c.name;
            this.duration = c.duration;
        }

       
        public Course(int i, string n, string du, float f)
        {
            this.id = i;
            this.name = n;
            this.duration = du;
            this.fees = f;
        }

        public int i{ get { return id; } set { id = value; } }

        public string nm { get { return name; }set { name = value; } } 
        public string du { get { return duration; } set { duration = value; } }

        public float f { get { return fees; }set { fees = value; } }

    }
}
