﻿using customerdetails.Models;
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
        private ILogger<HomeController> _logger;
        private int CreateRandomNumber()
        {
            Random rnd = new Random();
            int result= rnd.Next();
            return result;
        }

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View("Createpage");
        }
        public IActionResult Createpage()
        {
            return View();
        }

        public ActionResult GetcustomerData(Customerform customerData)
        {

  

            var mycustomerObject = new List<Customerform>()
            {
               new Customerform { ID = CreateRandomNumber(), Fname = customerData.Fname, Lname=customerData.Lname, Address=customerData.Address, DateTime=customerData.DateTime, Gender=customerData.Gender},
               new Customerform { ID = CreateRandomNumber(), Fname = "Sandeep",Lname = "CH",DateTime=DateTime.Now,Address="hgdfghf",Gender="m"},
               new Customerform { ID = CreateRandomNumber(), Fname = "Rushil",Lname = "E",DateTime=DateTime.Now,Address="savasdfgasg",Gender="m"},
               new Customerform { ID = CreateRandomNumber(), Fname = "Advaith",Lname = "CH",DateTime=DateTime.Now,Address="sdfbsdb",Gender="m"}
            };

             return View("index", new CustomerViewModel { Customerforms=mycustomerObject});
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
