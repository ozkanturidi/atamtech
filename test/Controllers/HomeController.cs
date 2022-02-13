using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using test.Models;
using System.Globalization;
using System.Threading;

namespace test.Controllers
{
    

    public class HomeController : Controller
    {
        public ActionResult ChangeLanguage(string selectedlanguage)
        {
            if(selectedlanguage != null)
            {
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(selectedlanguage);
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(selectedlanguage);
                var cookie = new HttpCookie("Language");
                cookie.Value = selectedlanguage;
                Response.Cookies.Add(cookie);
            }
            return RedirectToAction("Index", "Home");

        }






        Context c = new Context();

        ProductandNew pn = new ProductandNew();
        public ActionResult Index()
        {
            pn.Value1 = c.News.ToList();
            pn.Value2 = c.Products.ToList();


            return View(pn);
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