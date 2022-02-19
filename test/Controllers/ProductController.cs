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
        TableList lng = new TableList();

        [Route("ProductList")]
        public ActionResult ProductList()
        {

            lng.productTr = c.Products.Where(x => x.language == true);
            lng.productEn = c.Products.Where(x => x.language == false);
            //var products = c.Products.ToList();
            return View(lng);
        }

        
        public ActionResult ProductDetails(int id)
        {
            var products = c.Products.ToList();
            products = c.Products.Where(x => x.id == id).ToList();
            return View(products);
        }






    }
}