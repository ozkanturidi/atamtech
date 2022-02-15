using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using test.Models;

namespace test.Controllers
{
    public class ProductController : Controller
    {
        Context c = new Context();

        [Route("ProductList")]
        public ActionResult ProductList()
        {

            var products = c.Products.ToList();
            return View(products);
        }

        
        public ActionResult ProductDetails(int id)
        {
            var products = c.Products.ToList();
            products = c.Products.Where(x => x.id == id).ToList();
            return View(products);
        }






    }
}