using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using test.Models;

namespace test.Controllers
{
    public class AdminController : Controller
    {
        Context c = new Context();
        // GET: Admin
        public ActionResult Index()
        {
            var values = c.News.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateNew()
        {

            return View();
        }
        [HttpPost]
        public ActionResult CreateNew(New n)
        {
            c.News.Add(n);
            c.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult DeleteNew(int id)
        {
            var n = c.News.Find(id);
            c.News.Remove(n);
            c.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult bringNew(int id)
        {
          var n=  c.News.Find(id);

            return View("bringNew",n);
        }

        public ActionResult UpdateNew(New ne)
        {
            var n = c.News.Find(ne.id);
            n.title = ne.title;
            n.date = ne.date;
            n.content = ne.content;
            n.fotoUrl = ne.fotoUrl;
            c.SaveChanges();


            return RedirectToAction("Index");
        }


    }
}