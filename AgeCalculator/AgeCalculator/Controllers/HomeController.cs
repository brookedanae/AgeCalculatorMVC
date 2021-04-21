using AgeCalculator.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AgeCalculator.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult GetAge()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Result(PersonViewModel model)
        {
            ViewData["Age"] = model.Age;
            ViewData["UserName"] = model.UserName;

            if (model.Age >= 21)
            {
                ViewData["DrinkResult"] = model.CanDrink = true;
                ViewData["Drink"] = "can drink (but not at the same time!)";
            }
            else
            {
                ViewData["DrinkResult"] = model.CanDrink = false;
                ViewData["Drink"] = "can't drink";
            }

            if (model.Age >= 16)
            {
                ViewData["DriveResult"] = model.CanDrive = true;
                ViewData["Drive"] = "can drive";
            }
            else
            {
                ViewData["DriveResult"] = model.CanDrive = false;
                ViewData["Drive"] = "can't drive";
            }

            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
