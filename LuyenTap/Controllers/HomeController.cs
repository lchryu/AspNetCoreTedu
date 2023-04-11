using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LuyenTap.Models;  
using Microsoft.AspNetCore.Mvc;

namespace LuyenTap.Controllers
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
                message = $"Product: {model.Name}\n" +
                          $"Rating: {model.Rating}\n" +
                          $"==>Created successfully";
            }
            else
            {
                message = "Failed to create the product. Please try again";
            }
            return Content(message);
        }

    }
}