using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _13_MVCCoreApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace _13_MVCCoreApp.Controllers
{
    public class ProductController : Controller
    {
        //http://localhost:6001/product/edit
        //http://localhost:6001/product/modify
        //[ActionName("modify")]
        //[Route("Product/Modify")]
        //[NonAction]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public string Edit(string id)
        {
            return "Hello from edit method";
        }
        [HttpPost]
        public IActionResult Edit(ProductModel model)
        {
            return RedirectToAction("Index", "Product");
        }
        //POST: product/10
        [HttpPut("{id}")]
        public IActionResult Update(string id, [FromBody]ProductModel product)
        {
            //TODO: Create a product in DB
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult Update(string id)
        {
            //TODO: Create a product in DB
            return Ok();
        }
    }
}