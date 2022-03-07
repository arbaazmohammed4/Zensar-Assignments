using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Case_Study_Project_Enrollment
{
    class AppEngine
    {
        public static SqlCommand cmd;
        public static SqlConnection con;
        public static SqlDataReader dr;
        public static string connections = "data source=ARBAAZ-PC ;initial catalog = case_study ;integrated security=true";

        public static void introduce(List<Course> course)
        {
            try
            {
                con = getConnection();
                int id;
                string name;
                float duration;
                float fee;
                
                Console.WriteLine("Enter Course ID : ");
                id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Course Name : ");
                name = Console.ReadLine();
                Console.WriteLine("Enter Course Duration : ");
                duration = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter Course Fees : ");
                fee = float.Parse(Console.ReadLine());
                cmd = new SqlCommand("Insert into Course_Info values(@course_id,@course_name,@course_duration,@course_fee)");
                cmd.Parameters.AddWithValue("@course_id", id);
                cmd.Parameters.AddWithValue("@course_name", name);
                cmd.Parameters.AddWithValue("@course_duration", duration);
                cmd.Parameters.AddWithValue("@course_fee", fee);
                cmd.Connection = con;
                int no_ofrows = cmd.ExecuteNonQuery();
                if (no_ofrows > 0)
                {
                    course.Add(new Course(id, name, duration, fee));
                    Console.WriteLine();
                    Console.WriteLine("Course Introduced Successfully");
                }
                else
                {
                    Console.WriteLine("OOPS !! Encounterd a Problem");
                }
                con.Close();
            }
            catch(SqlException se)
            {
                Console.WriteLine(se.Message);
            }
        }

        public static void register(List<Student> students)
        {
            try
            {
                con = getConnection();
                int id;
                string name;
                DateTime dob;
                Console.WriteLine("Enter Student ID : ");
                id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Student Name : ");
                name = Console.ReadLine();
                Console.WriteLine("Enter Date of Birth : ");
                dob = Convert.ToDateTime(Console.ReadLine());
                cmd = new SqlCommand("Insert into Student_Info values(@stud_id,@stud_name,@stud_dob)");
                cmd.Parameters.AddWithValue("@stud_id", id);
                cmd.Parameters.AddWithValue("@stud_name", name);
                cmd.Parameters.AddWithValue("@stud_dob", dob);
                cmd.Connection = con;
                int no_ofrows = cmd.ExecuteNonQuery();
                if (no_ofrows > 0)
                {
                    students.Add(new Student(id, name, dob));
                    Console.WriteLine();
                    Console.WriteLine("Student Registered Successfully");
                }
                else
                {
                    Console.WriteLine("OOPS !! Encounterd Problem");
                }
                con.Close();
            }
            catch (SqlException se)
            {
                Console.WriteLine(se.Message);
            }
        }

        public static List<Student> ListOfStudents(List<Student> students)
        {
            con = getConnection();
            cmd = new SqlCommand("select * from student_Info", con);
            dr = cmd.ExecuteReader();
            Console.WriteLine("Student Details.......");
            Console.WriteLine("----------------------------");
            while (dr.Read())
            {

                Console.WriteLine("Student ID : {0}",dr[0]);
                Console.WriteLine("Student Name : {0}", dr[1]);
                Console.WriteLine("Student Date of Birth : {0}",dr[2]);
                Console.WriteLine("----------------------------");
                // Console.WriteLine("Enrolled Course ID : {0}", dr[3]);
                students.Add(new Student((int)dr[0], (string)dr[1], (DateTime)dr[2]));
            }
            
            dr.Close();
            con.Close();
            return students;
        }

        public static List<Course> ListOfCourses(List<Course> course)
        {
            con = getConnection();
            cmd = new SqlCommand("select * from course_Info", con);
            dr = cmd.ExecuteReader();
            Console.WriteLine("Course Details : ");
            Console.WriteLine("--------------------------");
            while (dr.Read())
            {

                Console.WriteLine("Course Id : " + " " + dr[0]);
                Console.WriteLine("Course Name :" + " " + dr[1]);
                Console.WriteLine("Course Duration :" + " " + dr[2]);
                Console.WriteLine("Course Fees :" + " " + dr[3]);
                Console.WriteLine("--------------------------");

            }
            
            dr.Close();
            con.Close();
            return course;
        }
        /*
        public static void enroll(Student stud, Course cour)
        {
            try
            {

                Enroll enroll = new Enroll();
                con = getConnection();
                cmd = new SqlCommand("insert into Enrollment_Info_Data values(@stid,@courseid,@enrollDate)");
                cmd.Parameters.AddWithValue("@stid", enroll.student.Student_Id);
                cmd.Parameters.AddWithValue("@courseid", enroll.course.Course_Id);
                cmd.Parameters.AddWithValue("@enrollDate", DateTime.UtcNow);
                cmd.Connection = con;
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    enroll.EnrollList.Add(new Enroll(stud, cour, DateTime.UtcNow));
                }
                else
                {
                    Console.WriteLine("OOPS !! Encounterd Problem");
                }
                con.Close();
            }
            catch(SqlException se)
            {
                Console.WriteLine(se.Message);
            }
        }
        */

        public static void enroll()
        {
            Enroll enroll = new Enroll();
            try
            {
                int sid, cid;
                // DateTime dt;
                con = getConnection();
                Console.WriteLine("Enter your Student ID : ");
                sid = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter ID of the Course to be selected : ");
                cid = int.Parse(Console.ReadLine());
                cmd = new SqlCommand("insert into Enrollment_Info_Data values(@stid,@coid,@dt)", con);
                cmd.Parameters.AddWithValue("@stid", sid);
                cmd.Parameters.AddWithValue("@coid", cid);
                cmd.Parameters.AddWithValue("@dt", DateTime.UtcNow);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    Console.WriteLine("Student Enrolled Successfully !!!");
                }
                else
                {
                    Console.WriteLine("OOPS !! Encounterd Problem");
                }
                con.Close();
            }
            catch(SqlException se)
            {
                Console.WriteLine(se.Message);
            }
        }

        public static List<Enroll> ListOfEnrollment(List<Enroll> enrolls)
        {
            con = getConnection();
            cmd = new SqlCommand("select * from Enrollment_Info_Data", con);
            dr = cmd.ExecuteReader();
            Console.WriteLine("Student Enrollment Details.......");
            Console.WriteLine("----------------------------");
            while (dr.Read())
            {
                
                Console.WriteLine("Student ID : {0}", dr[0]);
                Console.WriteLine("Course ID : {0}", dr[1]);
                Console.WriteLine("Date of Enrollment : {0}", dr[2]);
                Console.WriteLine("----------------------------");
                // Console.WriteLine("Enrolled Course ID : {0}", dr[3]);
                enrolls.Add(new Enroll());
            }
            dr.Close();
            con.Close();
            return enrolls;
        }

        public static SqlConnection getConnection()
        {
            con = new SqlConnection(connections);
            con.Open();
            return con;
        }

        public static void GetPerStudDetails()
        {
            Console.WriteLine("Enter your Student ID : ");
            int id = int.Parse(Console.ReadLine());
            con = getConnection();
            cmd = new SqlCommand("select * from Student_Info where stud_ID = @sid");
            cmd.Parameters.AddWithValue("@sid", id);
            cmd.Connection = con;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine("Student Details.......");
                Console.WriteLine("----------------------------");
                Console.WriteLine("Student ID : {0}", dr[0]);
                Console.WriteLine("Student Name : {0}", dr[1]);
                Console.WriteLine("Student Date of Birth : {0}", dr[2]);
            }
            dr.Close();
            con.Close();
        }

        public static void GetPerCourseDetails()
        {
            Console.WriteLine("Enter your Course ID : ");
            int id = int.Parse(Console.ReadLine());
            con = getConnection();
            cmd = new SqlCommand("select * from course_Info where course_id = @cid");
            cmd.Parameters.AddWithValue("@cid", id);
            cmd.Connection = con;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine("Course Details.......");
                Console.WriteLine("----------------------------");
                Console.WriteLine("Course ID : {0}", dr[0]);
                Console.WriteLine("Course Name : {0}", dr[1]);
                Console.WriteLine("Course Duration : {0}", dr[2]);
                Console.WriteLine("Course Fee : {0}", dr[3]);
            }
            dr.Close();
            con.Close();
        }

        public static void DeleteCourse()
        {
            con = getConnection();
            Console.WriteLine("Enter the Course Id to be Deleted : ");
            int cid = int.Parse(Console.ReadLine());
            SqlCommand cmd1 = new SqlCommand("Select * from Course_Info where Course_ID = @cid", con);
            cmd1.Parameters.AddWithValue("@cid", cid);
            try
            {
                SqlDataReader dr1 = cmd1.ExecuteReader();
                while (dr1.Read())
                {
                    for (int i = 0; i < dr1.FieldCount; i++)
                    {
                        Console.WriteLine(dr1[i]);
                    }
                }
                dr1.Close();
                // con.Close();
                Console.WriteLine("Please Re-Confirm to Delete the above Data : yes or no");
                string status = Console.ReadLine();
                if ((status == "yes") || (status == "Yes") || (status == "y") || (status == "Y"))
                {
                    cmd = new SqlCommand("delete from Course_Info where Course_Id = @cid");
                    cmd.Parameters.AddWithValue("@cid", cid);
                    cmd.Connection = con;
                    int res = cmd.ExecuteNonQuery();
                    if (res > 0)
                    {
                        Console.WriteLine("Record Deleted Successfully");
                    }
                    else
                    {
                        Console.WriteLine("Something Went wrong in the Deletion Process");
                    }
                }
                con.Close();
            }
            catch (SqlException se)
            {
                Console.WriteLine(se.Message);
            }
        }

        public static void UpdateCourseInfo()
        {
            con = getConnection();
            Console.WriteLine("Enter the Course Id to be Updated : ");
            int cid = int.Parse(Console.ReadLine());
            SqlCommand cmd1 = new SqlCommand("Select * from Course_Info where Course_ID = @cid", con);
            cmd1.Parameters.AddWithValue("@cid", cid);
            try
            {
                SqlDataReader dr1 = cmd1.ExecuteReader();
                while (dr1.Read())
                {
                    for (int i = 0; i < dr1.FieldCount; i++)
                    {
                        Console.WriteLine(dr1[i]);
                    }
                }
                dr1.Close();
                // con.Close();
                Console.WriteLine("Please Re-Confirm to Update the course details : yes or no");
                string status = Console.ReadLine();
                if ((status == "yes") || (status == "Yes") || (status == "y") || (status == "Y"))
                {
                    Console.WriteLine("Enter the Course Duration and Course Fee ");
                    string cd = Console.ReadLine();
                    Console.WriteLine("Enter the Course Fee ");
                    float cf = float.Parse(Console.ReadLine());
                    cmd = new SqlCommand("update Course_Info set Course_Duration = @cdur,Course_Fee = @cfee where Course_ID = @cid");
                    cmd.Parameters.AddWithValue("@cdur", cd);
                    cmd.Parameters.AddWithValue("@cfee", cf);
                    cmd.Parameters.AddWithValue("@cid", cid);
                    cmd.Connection = con;
                    int res = cmd.ExecuteNonQuery();
                    if (res > 0)
                    {
                        Console.WriteLine("Record Updated Successfully");
                    }
                    else
                    {
                        Console.WriteLine("Something Went wrong in the Updation Procedure Process");
                    }
                }
                con.Close();
            }
            catch (SqlException se)
            {
                Console.WriteLine(se.Message);
            }
        }

        public static void UpdateStudInfo()
        {
            con = getConnection();
            Console.WriteLine("Enter the Student Id to be Updated : ");
            int sid = int.Parse(Console.ReadLine());
            SqlCommand cmd1 = new SqlCommand("Select * from Student_Info where Stud_ID = @stid", con);
            cmd1.Parameters.AddWithValue("@stid", sid);
            try
            {
                SqlDataReader dr1 = cmd1.ExecuteReader();
                while (dr1.Read())
                {
                    for (int i = 0; i < dr1.FieldCount; i++)
                    {
                        Console.WriteLine(dr1[i]);
                    }
                }
                dr1.Close();
                // con.Close();
                Console.WriteLine("Please Re-Confirm to Update the Student Birth Date : yes or no");
                string status = Console.ReadLine();
                if ((status == "yes") || (status == "Yes") || (status == "y") || (status == "Y"))
                {
                    Console.WriteLine("Enter new Date of Birth : ");
                    DateTime dt = Convert.ToDateTime(Console.ReadLine());
                    cmd = new SqlCommand("update Student_Info set stud_dob = @date where stud_ID = @stid");
                    cmd.Parameters.AddWithValue("@date", dt);
                    cmd.Parameters.AddWithValue("@stid", sid);
                    cmd.Connection = con;
                    int res = cmd.ExecuteNonQuery();
                    if (res > 0)
                    {
                        Console.WriteLine("Record Updated Successfully");
                    }
                    else
                    {
                        Console.WriteLine("Something Went wrong in the Updation Procedure Process");
                    }
                }
                con.Close();
            }
            catch (SqlException se)
            {
                Console.WriteLine(se.Message);
            }
        }

        public static void DeleteStudent()
        {
            con = getConnection();
            Console.WriteLine("Enter the Student Id to be Deleted : ");
            int sid = int.Parse(Console.ReadLine());
            SqlCommand cmd1 = new SqlCommand("Select * from Student_Info where stud_ID = @stid", con);
            cmd1.Parameters.AddWithValue("@stid", sid);
            try
            {
                SqlDataReader dr1 = cmd1.ExecuteReader();
                while (dr1.Read())
                {
                    for (int i = 0; i < dr1.FieldCount; i++)
                    {
                        Console.WriteLine(dr1[i]);
                    }
                }
                dr1.Close();
                // con.Close();
                Console.WriteLine("Please Re-Confirm to Delete the above Data : yes or no");
                string status = Console.ReadLine();
                if ((status == "yes") || (status == "Yes") || (status == "y") || (status == "Y"))
                {
                    cmd = new SqlCommand("delete from Student_Info where stud_ID = @stid");
                    cmd.Parameters.AddWithValue("@stid", sid);
                    cmd.Connection = con;
                    int res = cmd.ExecuteNonQuery();
                    if (res > 0)
                    {
                        Console.WriteLine("Record Deleted Successfully");
                    }
                    else
                    {
                        Console.WriteLine("Something Went wrong in the Deletion Process");
                    }
                }
                con.Close();
            }
            catch (SqlException se)
            {
                Console.WriteLine(se.Message);
            }
        }

    }
}
