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
            lng.serviceTr = c.Services.Where(x => x.language == true);
            lng.serviceEn = c.Services.Where(x => x.language == true);
            // var service = c.Services.ToList();
            return View(lng);

        }

        public ActionResult ServiceDetails(int id)
        {
            var findsrv = c.Services.Where(x => x.id == id).ToList();

            return View(findsrv);
        }



    }
}