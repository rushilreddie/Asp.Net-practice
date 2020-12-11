using customerdetails.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace customerdetails.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private string lname;
        private string address;
        private string fname;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public ActionResult GetcustomerData(Customerform customerData)
        {

            var mycustomerObject = new Customerform
            {
                Fname = customerData.Fname,
                Lname = customerData.Lname,
                Address = customerData.Address,
                DateTime = customerData.DateTime,
                Gender = customerData.Gender
            };

            return View("index", mycustomerObject);

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
