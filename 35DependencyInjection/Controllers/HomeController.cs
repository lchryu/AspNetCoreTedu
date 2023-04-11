using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DISample.Services;
namespace _35DependencyInjection.Controllers
{
    public class HomeController : Controller
    {
        //private readonly IProductService _productService;
        //public HomeController(IProductService productService)
        //{
        //    _productService = productService;
        //}
        public IActionResult Index([FromServices]IProductService productService )
        {
            var products = productService.GetAll();
            return View(products);
        }
    }
}