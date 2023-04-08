using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _13_MVCCoreApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace _13_MVCCoreApp.Controllers
{
    public class HomeController : Controller
    {
        //[Route("Home/Index/{id:int}")]
        //public IActionResult Index(int id)
        //{
        //    var model = new IndexModel();
        //    model.Message = "Hello from Model, ID = " + id;
        //    return View(model);
        //}
        //public IActionResult Index(int year)
        //{
        //    var model = new IndexModel();
        //    model.Message = "Hello from Model, Year = " + year;
        //    return View(model);
        //}
        public IActionResult Index(string id)
        {
            var model = new IndexModel();
            model.Message = "Hello from Model, id = " + id;
            return View(model);
        }
    }
}