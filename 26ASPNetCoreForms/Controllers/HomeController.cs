﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _26ASPNetCoreForms.Models;
using Microsoft.AspNetCore.Mvc;

namespace _26ASPNetCoreForms.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(ProductEditModel model)
        {
            string message = string.Empty;
            if (ModelState.IsValid)
            {
                message = "Product: " + model.Name + ".Rate: "
                    + model.Rate.ToString() + ". Rating: " + model.Rating + " created successfully";
            }
            else
            {
                message = "Failed to create the product. Please try again.";
            }
            return Content(message);
        }
    }
}