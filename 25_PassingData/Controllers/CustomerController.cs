﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _25_PassingData.Models;
using Microsoft.AspNetCore.Mvc;

namespace _25_PassingData.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            //ViewBag.Customer = new Customer();
            //ViewData.Model = new Customer();
            var customer = new Customer();
            return View(customer);
        }
    }
}