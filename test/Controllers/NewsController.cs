using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using test.Models;
namespace test.Controllers
{
    public class NewsController : Controller
    {
        Context c = new Context();
        public ActionResult NewsList()
        {

            var news = c.News.ToList();
            return View(news);
        }
        NewComment nc = new NewComment();

        public ActionResult NewsDetail(int id)
        {
            //var findNew = c.News.Where(x => x.id == id).ToList();
            nc.Value1 = c.News.Where(x => x.id == id).ToList();
            nc.Value2 = c.Comments.Where(x => x.NewId == id).ToList();
            return View(nc);
        }

        [HttpGet]
        public PartialViewResult MakeComment(int id)
        {

            @ViewBag.deger = id;
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult MakeComment(Comment com )
        {

            c.Comments.Add(com);
            c.SaveChanges();


            return PartialView();
        }

    }
}