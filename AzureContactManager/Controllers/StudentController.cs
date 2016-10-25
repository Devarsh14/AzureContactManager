using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AzureContactManager.Models;
using System.Web.Mvc;

namespace AzureContactManager.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            var stud = new Student();
            stud.FirstName = "Devarsh";
            stud.LastName = "shukla";
            stud.StudentNo = 12;

            return View(stud);
        }
    }
}