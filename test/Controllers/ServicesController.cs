using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using test.Models;
namespace test.Controllers
{
    public class ServicesController : Controller
    {
        // GET: Services
        TableList lng = new TableList();
        Context c = new Context();
        [Route("ServiceList")]
        public ActionResult ServiceList()
        {
            lng.productTr = c.Products.Where(x => x.language == true).ToList();
            lng.productEn = c.Products.Where(x => x.language == false).ToList();

            lng.serviceTr = c.Services.Where(x => x.language == true).ToList();
            lng.serviceEn = c.Services.Where(x => x.language == false).ToList();
            //var service = c.Services.ToList();
            return View(lng);

        }

        public ActionResult ServiceDetails(int id)
        {
            lng.productTr = c.Products.Where(x => x.language == true).ToList();
            lng.productEn = c.Products.Where(x => x.language == false).ToList();

            lng.serviceTr = c.Services.Where(x => x.language == true).ToList();
            lng.serviceEn = c.Services.Where(x => x.language == false).ToList();

            lng.servicedtTr = c.Services.Where(x => x.language == true && x.id == id);
            lng.servicedtTr = c.Services.Where(x => x.language == false && x.id == id);
            //var findsrv = c.Services.Where(x => x.id == id).ToList();

            return View(lng);
        }



    }
}