using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tp02skito.Models;
using tp02skito.Models.Repos;

namespace tp02skito.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IOperationsModels<Employee> employees;

        public EmployeeController(IOperationsModels<Employee> employees)
        {
            this.employees = employees;
        }
        public IActionResult List()
        {
            return View(employees.List());
        }

        public IActionResult FindByAge(int id)
        {
            var x = employees.FindAge(id);
            return View("List", x);
        }
        public IActionResult FindBetweenn(int idone,int idtwo)
        {
            var x = employees.FindBetween(idone, idtwo).ToList();
            return View("List", x);
        }
        public IActionResult FindByLetterr(string letter)
        {
            var x = employees.FindByLetter(letter).ToList();
            return View("List", x);
        }
    }
}
