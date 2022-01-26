using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using test.Models;


namespace test.Controllers
{
    public class ProjectController : Controller
    {
        Context c = new Context();    

        public ActionResult ProjectList()
        {
            //var projects = c.Projects.ToList();
           
            return View();
        }

        public ActionResult ProjectDetails(int id)
        {

            //var projects = c.Projects.Where(x => x.id == id).ToList();
            return View();


        }


    }
}