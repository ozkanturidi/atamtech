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

        Context c = new Context();

        public ActionResult ServiceList()
        {
            var service = c.Services.ToList();
            return View(service);

        }

        public ActionResult ServiceDetails(int id)
        {
            var findsrv = c.Services.Where(x => x.id == id).ToList();

            return View(findsrv);
        }



    }
}