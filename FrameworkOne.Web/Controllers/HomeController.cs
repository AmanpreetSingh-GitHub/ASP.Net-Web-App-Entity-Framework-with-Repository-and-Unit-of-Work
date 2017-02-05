using FrameworkOne.Application.Interface;
using FrameworkOne.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FrameworkOne.Web.Controllers
{
    public class HomeController : Controller
    {
        private IStudentLogic studentLogic;

        public HomeController(IStudentLogic studentLogic)
        {
            this.studentLogic = studentLogic;
        }

        public ActionResult Index()
        {
            // Fetch Data
            List<StudentModel> studentModels = studentLogic.GetData();

            return View();
        }

        public ActionResult About()
        {
            // Save Data
            StudentModel student = new StudentModel() { StudentId = 100004, Name = "Student Four" };

            this.studentLogic.SaveData(student);
            this.studentLogic.Dispose();

            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}