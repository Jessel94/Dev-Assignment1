using System.Collections.Generic;
using Dev_Assignment1.Database;
using Dev_Assignment1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Dev_Assignment1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult EmployeeList()
        {
            var employeeList = GetEmployee.GetEmployeeList();

            return View(employeeList);
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}