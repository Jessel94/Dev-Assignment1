using System.Collections.Generic;
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

        public IActionResult Employee()
        {
            var employeeList = new List<Employee>
            {
                new Employee
                {
                    IdEmployee = 1,
                    Bsn = "1234",
                    Name = "Henk",
                    Surname = "Jan"
                },
                new Employee
                {
                    IdEmployee = 2,
                    Bsn = "5678",
                    Name = "Jaap",
                    Surname = "Worst"
                }
            };


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