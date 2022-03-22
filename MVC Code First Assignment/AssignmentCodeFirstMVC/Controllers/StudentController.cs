using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AssignmentCodeFirstMVC.Models;

namespace AssignmentCodeFirstMVC.Controllers
{
    public class StudentController : Controller
    {
        StudentContext sc = new StudentContext();
        // GET: Student
        public ActionResult Index()
        {
            List<Student> stud = sc.Students.ToList();
            return View(stud);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Student stud)
        {
            sc.Students.Add(stud);
            sc.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            Student stud = sc.Students.Find(id);
            return View(stud);
        }

        [HttpPost]
        public ActionResult Edit(Student stud)
        {
            Student s = sc.Students.Find(stud.StudentID);
            s.Stud_Branch = stud.Stud_Branch;
            s.Stud_City = stud.Stud_City;
            s.Stud_Percentage = stud.Stud_Percentage;
            sc.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            Student s = sc.Students.Find(id);
            return View(s);
        }

        public ActionResult Delete(int id)
        {
            Student s = sc.Students.Find(id);
            sc.Students.Remove(s);
            sc.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Search_View_By_City()
        {
            List<Student> stud = (from st in sc.Students
                                  orderby st.Stud_City
                                  select st).ToList();
            return View(stud);
        }

        public ActionResult Search_View_By_Branch()
        {
            List<Student> stud = (from st in sc.Students
                                  orderby st.Stud_Branch
                                  select st).ToList();
            return View(stud);
        }

        public ActionResult Search_View_By_Percentage()
        {
            List<Student> stud = (from st in sc.Students
                                  orderby st.Stud_Percentage
                                  select st).ToList();
            return View(stud);
        }

        public ActionResult Search_View_By_StudentID()
        {
            List<Student> stud = (from st in sc.Students
                                  orderby st.StudentID
                                  select st).ToList();
            return View(stud);
        }
    }
}