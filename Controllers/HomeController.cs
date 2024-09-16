using lr1.Models;
using Microsoft.AspNetCore.Mvc;

namespace lr1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Info()
        {
            var company = new Company
            {
                Name = "Infinity St.",
                YearFounded = 2005,
                EmployeeCount = 300,
            };

            return Json(company);
        }

        public IActionResult RandomNumber()
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next(0, 101);
            return Json(new { RandomNumber = randomNumber });
        }
    }
}