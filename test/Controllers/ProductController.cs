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

            
            lng.serviceTr = c.Services.Where(x => x.language == true).ToList();
            lng.serviceEn = c.Services.Where(x => x.language == false).ToList();
            lng.productTr = c.Products.Where(x => x.language == true).ToList();
            lng.productEn = c.Products.Where(x => x.language == false).ToList();
            //var products = c.Products.ToList();
            return View(lng);
        }


        public ActionResult ProductDetails(int id)
        {

            lng.Product = c.Products.Where(x => x.id == id).ToList();
            lng.serviceTr = c.Services.Where(x => x.language == true).ToList();
            lng.serviceEn = c.Services.Where(x => x.language == false).ToList();
            return View(lng);
        }





    }
}