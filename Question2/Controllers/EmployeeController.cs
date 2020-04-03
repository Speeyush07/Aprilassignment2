using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Question2.Models;

namespace ques_two.Controllers
{
    public class employeeController : Controller
    {
        public IActionResult Index()
        {

            Employee emp = new Employee();

            var e = emp.get();

            ViewBag.title = "employeelist";
            ViewBag.emp = e;
            return View();
        }
    }
}