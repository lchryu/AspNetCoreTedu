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
        public IActionResult Index()
        {
            var model = new IndexModel();
            model.Message = "Hello from Model";
            return View(model);
        }
    }
}