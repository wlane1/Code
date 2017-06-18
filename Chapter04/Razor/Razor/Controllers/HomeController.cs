using Razor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Razor.Controllers
{
    public class HomeController : Controller
    {
        Product myproduct = new Product
        {
            ProductID = 1,
            Name = "kayake",
            Description = "A boat for one person",
            Category = "Watersports",
            Price = 275M
        };


        // GET: Home
        public ActionResult Index()
        {
            return View(myproduct);
        }

        public ActionResult NameAndPrice()
        {
            return View(myproduct);
        }

        public ActionResult DemoExpression()
        {
            ViewBag.ProductCount = 1;
            ViewBag.ExpressShip = true;
            ViewBag.ApplyDiscount = false;
            ViewBag.Supplier = null;

            return View(myproduct);
        }

        public ActionResult DemoArray()
        {
            Product[] array =
            {
                new Product { Name = "Kayak", Price = 275M },
                new Product { Name = "LifeJacket", Price = 48.95M },
                new Product { Name = "Soccer Ball", Price = 19.50M },
                new Product { Name = "Corner Flag", Price = 34.95M }
            };
            return View(array);
        }
    }
}