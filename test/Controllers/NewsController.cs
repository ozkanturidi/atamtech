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

            var news = c.Newses.ToList();
            return View(news);
        }

        public ActionResult NewsDetail(int id)
        {
            var findNew = c.Newses.Where(x => x.id == id).ToList();

            return View(findNew);
        }
    }
}