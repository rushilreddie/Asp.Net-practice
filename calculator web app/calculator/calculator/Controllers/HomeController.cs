using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using calculator.Models;
using LearningForms.Models;

namespace calculator.Controllers
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
            ViewData["DateTime"] = DateTime.Now;
            return View();
        }

        public ActionResult GetcustomerData(string name, int number)
        {

            var mycustomerObject = new Customer
            {
                Name = "updated" + name,
                Number = number + 1
            };

            return View("index",mycustomerObject);

        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }

}
