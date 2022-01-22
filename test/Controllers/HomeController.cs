using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using test.Models;

namespace test.Controllers
{
    

    public class HomeController : Controller
    {

        Context c = new Context();
        Home home = new Home();

        public ActionResult Index()
        {
            home.Value1 = c.News.ToList();
            home.Value2 = c.Products.ToList();

            return View(home);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        [HttpGet]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [HttpPost]
        public ActionResult Contact(Contact cont)
        {
            c.Contacts.Add(cont);
            c.SaveChanges();



            return View();
        }
    }
}