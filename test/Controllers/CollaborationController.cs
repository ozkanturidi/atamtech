using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using test.Models;

namespace test.Controllers
{
    

    public class CollaborationController : Controller
    {

        Context c = new Context();
        
        public ActionResult ColList()
        {
            var col = c.Collaborations.ToList();
            return View(col);
        }
    }
}