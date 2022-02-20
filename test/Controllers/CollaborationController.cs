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
        TableList lng = new TableList();
        [Route("CollaborationList")]
        public ActionResult ColList()
        {
            
            lng.collTr = c.Collaborations.Where(x => x.language == true);
            lng.collEn = c.Collaborations.Where(x => x.language == false);
            
            return View(lng);
        }


        public ActionResult ColDetails(int id)
        {
            var col = c.Collaborations.ToList();
            col = c.Collaborations.Where(x => x.id == id).ToList();
            return View(col);
        }
    }
}