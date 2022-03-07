using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_Study_Project_Enrollment
{

    class Course
    {
        private int Course_ID;
        public int Course_Id
        {
            get
            {
                return Course_ID;
            }
            set
            {
                Course_ID = value;
            }
        }

        private string Course_Name;
        public string Course_name
        {
            get
            {
                return Course_Name;
            }
            set
            {
                Course_Name = value;
            }
        }

        public float Course_Duration { get; set; }
        public float Course_Fees { get; set; }

        public Course()
        {

        }

        public Course(int id, string name, float duration, float fees)
        {
            Course_Id = id;
            Course_name = name;
            Course_Duration = duration;
            Course_Fees = fees;
        }
    }

    class Student
    {
        private int Stud_ID;
        public int Student_Id
        {
            get
            {
                return Stud_ID;
            }
            set
            {
                Stud_ID = value;
            }
        }

        private string Stud_Name;
        public string Student_Name
        {
            get
            {
                return Stud_Name;
            }
            set
            {
                Stud_Name = value;
            }
        }

        private DateTime Stud_DOB;

        public DateTime DOB
        {
            get
            {
                return Stud_DOB;
            }
            set
            {
                Stud_DOB = value;
            }
        }

        /*
        private int Course_ID;
        public int courid
        {
            get
            {
                return Course_ID;
            }
            set
            {
                Course_ID = value;
            }
        }
        */

        public Student()
        {

        }

        public Student(int a, string b, DateTime dob)
        {
            Student_Id = a;
            Student_Name = b;
            DOB = dob;
            // courid = cid;
        }

    }

    class Enroll
    {
        public Student student = new Student();
        public Course course = new Course();
        private DateTime enrollmentDate;
        /*
        public Student stud
        {
            get;
            set;
        }

        public Course cour
        {
            get;
            set;
        }
        */
        public List<Course> CourseList = new List<Course>();
        public List<Student> StudentList = new List<Student>();
        public List<Enroll> EnrollList = new List<Enroll>();

        public Enroll()
        {

        }

        public Enroll(Student student, Course course, DateTime enrollmentDate)
        {
            this.student = student;
            this.course = course;
            this.enrollmentDate = enrollmentDate;
        }
    }

    class Program : UserInterface
    {
        public static Enroll enroll = new Enroll();
        // public static Student stud;
        // public static Course cour;
        private string ans;

        public override void introduceNewCourseScreen()
        {
            Console.WriteLine("Welcome to Adding New Course Screen : ");
            AppEngine.introduce(enroll.CourseList);
        }

        public override void showAdminScreen()
        {
            do
            {
                Console.WriteLine("**************** Welcome to Admin Screen ********************* ");
                Console.WriteLine();
                Console.WriteLine("Please Select what you want : \n1. All Student Info List \n2. All Courses Info List \n3. New Student Registeration \n4. Update Student DateOfBirth \n5. Delete Existing Student Info \n6. Add New Course \n7. Delete Existing Course \n8. Update Existing Course \n9. Enrollment List");
                Console.WriteLine();
                Console.WriteLine("Enter your choice ( 1 or 2 or 3 or 4 or 5 or 6 or 7 or 8 or 9) : ");
                int op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        showAllStudentsScreen();
                        break;
                    case 2:
                        showAllCoursesScreen();
                        break;
                    case 3:
                        showStudentRegistrationScreen();
                        break;
                    case 4:
                        AppEngine.UpdateStudInfo();
                        break;
                    case 5:
                        AppEngine.DeleteStudent();
                        break;
                    case 6:
                        introduceNewCourseScreen();
                        break;
                    case 7:
                        AppEngine.DeleteCourse();
                        break;
                    case 8:
                        AppEngine.UpdateCourseInfo();
                        break;
                    case 9:
                        AppEngine.ListOfEnrollment(enroll.EnrollList);
                        break;
                }
                Console.WriteLine();
                Console.WriteLine("Do you want to continue in Admin Screen : Yes or No ");
                ans = Console.ReadLine();
            } while((ans=="yes") || (ans == "Yes") || (ans == "y") || (ans == "Y"));
        }

        public override void showAllCoursesScreen()
        {
            Console.WriteLine("Welcome to All Courses Information List : ");
            AppEngine.ListOfCourses(enroll.CourseList);
        }

        public override void showAllStudentsScreen()
        {
            Console.WriteLine("Welcome to All Student Information List : ");
            AppEngine.ListOfStudents(enroll.StudentList);
        }

        public override void showFirstScreen()
        {
            do
            {
                Console.WriteLine("****************** Welcome to SMS(Student Mgmt. System) v1.0 **********************");
                Console.WriteLine();
                Console.WriteLine("Please Select who You Are : \n1. Student  \n \n2. Admin");
                Console.WriteLine();
                Console.WriteLine("Enter your choice ( 1 or 2 ) : ");
                int op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        showStudentScreen();
                        break;
                    case 2:
                        showAdminScreen();
                        break;
                }
                Console.WriteLine("Do you want to continue in Main Screen : Yes or No ");
                ans = Console.ReadLine();
            } while ((ans == "yes") || (ans == "Yes") || (ans == "y") || (ans == "Y"));
        }

        public override void showStudentRegistrationScreen()
        {
            Console.WriteLine("*************** Welcome to Student Registration Screen ********************** ");
            AppEngine.register(enroll.StudentList);
        }

        public override void showStudentScreen()
        {
            do
            {
                Console.WriteLine("**************** Welcome to Student Screen ************************ ");
                Console.WriteLine();
                Console.WriteLine("Please Select What You Want  : \n1. Student Info \n2. All Courses Available \n3. Enroll in New Course");
                Console.WriteLine();
                Console.WriteLine("Enter your choice ( 1 or 2 or 3) : ");
                int op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Console.WriteLine("\t\t\t Student Screen : ");
                        AppEngine.GetPerStudDetails();
                        //AppEngine.GetPerCourseDetails();
                        break;
                    case 2:
                        showAllCoursesScreen();
                        break;
                    case 3:
                        Enrollment();
                        break;
                }
                Console.WriteLine();
                Console.WriteLine("Do you want to continue in Student Screen : Yes or No ");
                ans = Console.ReadLine();
            } while ((ans == "yes") || (ans == "Yes") || (ans == "y") || (ans == "Y"));
        }

        public void Enrollment()
        {
            AppEngine.enroll();
            // AppEngine.enroll(enroll.student, enroll.course);
        }
    }
}
