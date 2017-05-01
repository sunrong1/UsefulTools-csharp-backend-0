using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebRong.Models;

namespace WebRong.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        //public ActionResult Index()
        //{
        //    return View();
        //}
        [NonAction]
        public string GetString()
        {
            return "Hello World is old now. It's time for wassup bro ;)";
        }
        public ActionResult GetView()
        {
            Employee emp = new Employee();
            emp.FirstName = "Sukesh";
            emp.LastName = "Marla";
            emp.Salary = 20000;
            ViewBag.Employee = emp;
            //ViewData["Employee"] = emp;
            return View("MyView");
            //return Content("Hi Welcome");
            //return View("MyView");
        }
    }
}