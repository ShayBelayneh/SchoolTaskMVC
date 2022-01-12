using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers

{
    public class StudentController : Controller
    {

        Student[] ArrayOfStudents = new Student[]
        {

            new Student(1,"shay","belyanejh",12,22),
            new Student(2,"edne","genet",11,25),
            new Student(3,"aschalew","azaga",10,24),
            new Student(4,"Liel","itzhak",9,21)

        };


        // GET: Student

        public ActionResult Index()
        {
            ViewBag.FirstName = ArrayOfStudents[0].FirstName;
            return View();
        }

        public ActionResult GetStudentName()
        {
            return View();
        }

        public ActionResult GetStudent()
        {
            return View();
        }

        public ActionResult GetAllStudents()

        {
            
            return View();

        }
    }
}