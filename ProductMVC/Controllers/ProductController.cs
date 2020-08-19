using ProductMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProductMVC.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            var prod = GetProduct();
            
            return View(prod);
        }
        public IEnumerable<Product> GetProduct()
        {
            return new List<Product>
            {
                 new Product{Pid=101,PName="AC",Rate=45000},
                  new Product{Pid=102,PName="Mobile",Rate=38000},
                    new Product{Pid=103,PName="Bike",Rate=94000},


            };
        }

            public ActionResult Details(int id)
        {
            var product = GetProduct().SingleOrDefault(p => p.Pid == id);
            if (product == null)
                return HttpNotFound();
            else
                return View(product);
        }
    }
}