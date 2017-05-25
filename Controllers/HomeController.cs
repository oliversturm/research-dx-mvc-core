using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using research_dx_mvc_core.Models;

namespace research_dx_mvc_core.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new List<Person> {
                new Person { Name = "Bob", Age = 24 },
                new Person { Name = "Anna", Age = 42 },
                new Person { Name = "Oliver", Age = 36 }
            };
            return View(model);
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
